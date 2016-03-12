using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KazimProxy
{
    public partial class FMain : Form
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        private int remainingSeconds = 0;
        private List<ProxyListItemData> myList = new List<ProxyListItemData>();
        private string SettingsFile;
        private Ping pingSender;
        private ProxyListItemData RunningProxy;

        public FMain()
        {
            InitializeComponent();
            Application.DoEvents();

            SettingsFile = Application.StartupPath + "\\KazimProxy.bin";
            LoadSettings();
            LoadTableData();
            UpdateRemainingSeconds();

            pingSender = new Ping();
            ResetRunningTimes();
            if (chStartTimer.Checked)
                AutoSwitchToNextProxy();
            PingAll();
            myTimer.Enabled = true;
        }

        private void setProxy(string proxyhost, bool proxyEnabled)
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            const string keyName = userRoot + "\\" + subkey;

            Registry.SetValue(keyName, "ProxyServer", proxyhost);
            Registry.SetValue(keyName, "ProxyEnable", proxyEnabled ? 1 : 0);//"1" : "0");

            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        private void AutoSwitchToNextProxy()
        {
            if (myList.Count == 0)
                return;
            if (RunningProxy != null)
                RunningProxy.isRunning = false;

            RunningProxy = myList[0];
            if (RunningProxy == null)
                return;

            for (int i = 1; i < myList.Count; i++)
            {
                ProxyListItemData pli = myList[i];
                if (pli != null)
                {
                    if (pli.isActive)
                    { 
                        if (pli.Runtime < RunningProxy.Runtime)
                        {
                            RunningProxy = pli;
                        }
                    }
                }
            }
            RunningProxy.isRunning = true;
            setProxy(RunningProxy.IPAddress + ":" + RunningProxy.PortNumber.ToString(), true);
            myGrid.Refresh();
        }

        private void SendPing(string IP)
        {
            if (IP == null)
                return;

            string data = "This is KazimProxy, how far a u?";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            int timeout = 3000;
            PingOptions options = new PingOptions(64, true);
            PingReply reply = pingSender.Send(IP, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            { 
                for (int i = 0; i < myGrid.Rows.Count; i++)
                {
                    if (!myGrid.Rows[i].IsNewRow)
                    {
                        if (myGrid[colServerAddress.Index, i].Value != null)
                        { 
                            if (myGrid[colServerAddress.Index, i].Value.ToString() == reply.Address.ToString())
                            {
                                myGrid[colLatency.Index, i].Value = reply.RoundtripTime.ToString() + " ms";
                            }
                        }
                    }
                }
            }
        }
        

        private void LoadSettings()
        {
            txtSwitchInterval.Value = Properties.Settings.Default.NextProxyInterval;
            chStartTimer.Checked = Properties.Settings.Default.AutoSwitch;
        }

        private void LoadTableData()
        {
            if (File.Exists(SettingsFile))
            { 
                using (Stream stream = File.Open(SettingsFile, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    myList = (List<ProxyListItemData>)bin.Deserialize(stream);
                }
            }
            ApplyDataToGrid();
        }

        private void ApplyDataToGrid()
        {
            myGrid.Rows.Clear();
            for (int i = 0; i < myList.Count; i++)
            {
                ProxyListItemData pli = myList[i];
                if (pli != null)
                {
                    int n = myGrid.Rows.Add();
                    myGrid[colServerName.Index, n].Value = pli.ServerName;
                    myGrid[colActive.Index, n].Value = pli.isActive;
                    myGrid[colServerAddress.Index, n].Value = pli.IPAddress;
                    myGrid[colPort.Index, n].Value = pli.PortNumber;
                    myGrid[colSocks.Index, n].Value = pli.useSocks;
                    myGrid[colLatency.Index, n].Value = "0 ms";
                    myGrid.Rows[n].Tag = i;
                }
            }
            myGrid.Refresh();
        }

        private void SaveGridToDataList()
        {
            myList.Clear();
            for (int i = 0; i < myGrid.Rows.Count; i++)
            {
                DataGridViewRow r = myGrid.Rows[i];
                if (!r.IsNewRow)
                {
                    ProxyListItemData pli = new ProxyListItemData();
                    pli.ServerName = r.Cells[colServerName.Index].Value != null ?
                        r.Cells[colServerName.Index].Value.ToString() : "";
                    pli.isActive = r.Cells[colActive.Index].Value != null ? (bool)r.Cells[colActive.Index].Value : false;
                    pli.IPAddress = (string)r.Cells[colServerAddress.Index].Value;
                    try
                    {
                        pli.PortNumber = Convert.ToInt32(r.Cells[colPort.Index].Value);
                    }
                    catch
                    {
                        pli.PortNumber = 8080;
                    }
                    pli.useSocks = r.Cells[colSocks.Index].Value != null ? (bool)r.Cells[colSocks.Index].Value : false;
                    myList.Add(pli);
                }
            }
        }

        private void SaveTableData()
        {
            try
            {
                using (Stream stream = File.Open("KazimProxy.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    myList.TrimExcess();
                    bin.Serialize(stream, myList);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Proxy listesi kayit edilirken hata olustu.");
            }
        }

        private void UpdateRemainingSeconds()
        {
            remainingSeconds = (int)(txtSwitchInterval.Value * 60);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chStartTimer_CheckedChanged(object sender, EventArgs e)
        {
            // myTimer.Enabled = chStartTimer.Checked;
            Properties.Settings.Default.AutoSwitch = chStartTimer.Checked;
            Properties.Settings.Default.Save();
            UpdateRemainingSeconds();
            if (RunningProxy == null && chStartTimer.Checked)
                AutoSwitchToNextProxy();
        }

        private void txtSwitchInterval_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NextProxyInterval = txtSwitchInterval.Value;
            Properties.Settings.Default.Save();
            UpdateRemainingSeconds();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (chStartTimer.Checked)
            { 
            remainingSeconds -= 1;
            int rem = 0;
            int res = Math.DivRem(remainingSeconds, 60, out rem);

            if (res > 0)
                lbRemainingTime.Text = res.ToString() + "dk. " + rem.ToString() + "sn.";
            if (res <= 0)
                lbRemainingTime.Text = rem.ToString() + "sn.";
            }
            else
            {
                lbRemainingTime.Text = "(Elle kontrol)";
            }

            if (RunningProxy != null)
            {
                RunningProxy.Runtime++;
                for (int i = 0; i < myGrid.Rows.Count; i++)
                {
                    DataGridViewRow r = myGrid.Rows[i];
                    if (r.Cells[colServerAddress.Index].Value.ToString() ==
                        RunningProxy.IPAddress)
                    {
                        int minutes, seconds;
                        minutes = Math.DivRem((int)RunningProxy.Runtime, 60, out seconds);
                        
                        r.Cells[colRunningTime.Index].Value = 
                            minutes.ToString() + "dk " + seconds.ToString() + "sn";
                        break;
                    }
                }
            }

            if (remainingSeconds <= 0)
            {
                ChangeToNextProxy();
            }
        }

        private void ChangeToNextProxy()
        {
            AutoSwitchToNextProxy();
            UpdateRemainingSeconds();
        }

        private void btnSwitchToNextProxy_Click(object sender, EventArgs e)
        {
            ChangeToNextProxy();
            
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            myTimer.Enabled = false;
            setProxy("", false);
            SaveGridToDataList();
            SaveTableData();
        }

        private void PingAll()
        {
            if (!myThread.IsBusy)
                myThread.RunWorkerAsync();
        }

        private void mnuRefreshLatencies_Click(object sender, EventArgs e)
        {
            PingAll();
        }

        private void myThread_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] != null)
                {
                    SendPing(myList[i].IPAddress);
                }
            }
        }

        private void myGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (RunningProxy == null)
                return;
            
            for (int i = 0; i < myGrid.Rows.Count; i++)
            {
                if (myGrid[colServerAddress.Index, i].Value.ToString() ==
                    RunningProxy.IPAddress)
                {
                    if (e.RowIndex == i)
                    {
                        e.CellStyle.BackColor = Color.DarkRed;
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.SelectionBackColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.White;
                    }
                }
            }
        }

        private void mnuAddNewProxy_Click(object sender, EventArgs e)
        {
            ProxyListItemData pli = new ProxyListItemData();
            FProxyEditor pe = new FProxyEditor(pli, true);
            if (pe.ShowDialog(this) == DialogResult.OK)
            {
                myList.TrimExcess();
                myList.Add(pli);
                int n = myGrid.Rows.Add();
                myGrid[colServerName.Index, n].Value = pli.ServerName;
                myGrid[colActive.Index, n].Value = pli.isActive;
                myGrid[colServerAddress.Index, n].Value = pli.IPAddress;
                myGrid[colPort.Index, n].Value = pli.PortNumber;
                myGrid[colSocks.Index, n].Value = pli.useSocks;
                myGrid[colLatency.Index, n].Value = "0 ms";
                myGrid.Rows[n].Tag = myList.Count - 1;
                ResetRunningTimes();
                SendPing(pli.IPAddress);
            }
        }

        private void mnuResetRunningTimes_Click(object sender, EventArgs e)
        {
            ResetRunningTimes();
        }

        private void ResetRunningTimes()
        {
            for (int i = 0; i < myGrid.Rows.Count; i++)
            {
                myGrid.Rows[i].Cells[colRunningTime.Index].Value = "0dk 0sn";
            }
            for (int i = 0; i < myList.Count; i++)
            {
                ProxyListItemData pli = myList[i];
                if (pli != null)
                    pli.Runtime = 0;
            }
        }

        private void mnuEditProxy_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rc = myGrid.SelectedRows;
            if (rc.Count < 1)
                return;
            string ipaddr = rc[0].Cells[colServerAddress.Index].Value.ToString();
            for (int i = 0; i < myList.Count; i++)
            {
                ProxyListItemData pli = myList[i];
                if (pli != null)
                {
                    if (pli.IPAddress == ipaddr)
                    {
                        FProxyEditor pe = new FProxyEditor(pli, false);
                        if (pe.ShowDialog(this) == DialogResult.OK)
                        {
                                pli.isRunning = false;
                                ResetRunningTimes();
                                ApplyDataToGrid();
                                AutoSwitchToNextProxy();
                        }
                        break;
                    }
                }
            }    
        }

        private void mnuDeleteProxy_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rc = myGrid.SelectedRows;
            if (rc.Count < 1)
                return;
            string ipaddr = rc[0].Cells[colServerAddress.Index].Value.ToString();
            for (int i = 0; i < myList.Count; i++)
            {
                ProxyListItemData pli = myList[i];
                if (pli != null)
                {
                    if (pli.IPAddress == ipaddr)
                    {
                        DialogResult r = MessageBox.Show(this, "Bu kayıdı silmek istediğinizden emin misiniz?",
                            "Sil: " + pli.IPAddress, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (r == DialogResult.Yes)
                        {
                            if (pli.isRunning)
                            { 
                                pli.isRunning = false;
                                pli.isActive = false;
                            }
                            myList.Remove(pli);
                            ApplyDataToGrid();
                            ResetRunningTimes();
                            AutoSwitchToNextProxy();
                        }
                        break;
                    }
                }
            }
        }

        private void chStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (chStartWithWindows.Checked)
            {
                StartUpManager.AddApplicationToCurrentUserStartup();
            }
            else
            {
                StartUpManager.RemoveApplicationFromCurrentUserStartup();
            }
        }

        private void myGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (myGrid.SelectedRows.Count == 0)
                return;

            string NewProxyIP = myGrid.SelectedRows[0].Cells[colServerAddress.Index].Value.ToString();

            if (RunningProxy != null)
            { 
                if (NewProxyIP == RunningProxy.IPAddress)
                    return;

                RunningProxy.isRunning = false;
            }

            for (int i = 0; i < myList.Count; i++)
            {
                ProxyListItemData pli = myList[i];
                if (pli != null)
                {
                    if (pli.IPAddress == NewProxyIP)
                    {
                        pli.isRunning = true;
                        RunningProxy = pli;
                        setProxy(RunningProxy.IPAddress + ":" + RunningProxy.PortNumber.ToString(), true);
                        myGrid.Refresh();
                        UpdateRemainingSeconds();
                        return;
                    }
                }
            }
        }

        private void mnuSwitchToSelectedProxy_Click(object sender, EventArgs e)
        {
            myGrid_CellDoubleClick(this, null);
        }

        private void myGrid_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                myContextMenu.Show(MousePosition);
            }
        }

        private void mnuRefreshSelectedProxy_Click(object sender, EventArgs e)
        {
            if (myGrid.SelectedRows.Count == 0)
                return;

            string proxyIP = myGrid.SelectedRows[0].Cells[colServerAddress.Index].Value.ToString();
            SendPing(proxyIP);
        }
    }
}
