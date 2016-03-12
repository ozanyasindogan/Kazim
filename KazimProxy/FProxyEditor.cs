using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KazimProxy
{
    public partial class FProxyEditor : Form
    {
        private ProxyListItemData pli;

        public FProxyEditor(ProxyListItemData item, bool isNew)
        {
            InitializeComponent();
            pli = item;
            if (isNew)
            {
                Text = "Yeni Proxy Sunucusu";
            }
            else
            {
                txtServerName.Text = pli.ServerName;
                Text = "Proxy Sunucusu: " + pli.IPAddress;
                txtServerIP.Text = pli.IPAddress;
                txtServerPort.Text = pli.PortNumber.ToString();
                chUseSocks.Checked = pli.useSocks;
                chIsActive.Checked = pli.isActive;
            }
        }

        private void txtServerIP_Validating(object sender, CancelEventArgs e)
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(txtServerIP.Text, out ipAddress))
            {
                lbIPAddressError.Visible = false;
                e.Cancel = false;
            }
            else
            {
                lbIPAddressError.Visible = true;
                e.Cancel = true;
            }
        }

        private void txtServerPort_Validating(object sender, CancelEventArgs e)
        {
            int port;
            
            try
            {
                port = Convert.ToInt32(txtServerPort.Text);
                if (port < 1 || port > 65535)
                {
                    lbIncorrectPort.Visible = true;
                    e.Cancel = true;
                    return;
                }
            }
            catch
            {
                lbIncorrectPort.Visible = true;
                e.Cancel = true;
                return;
            }

            lbIncorrectPort.Visible = false;
            e.Cancel = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pli.ServerName = txtServerName.Text;
            pli.IPAddress = txtServerIP.Text;
            pli.PortNumber = Convert.ToInt32(txtServerPort.Text);
            pli.useSocks = chUseSocks.Checked;
            pli.isActive = chIsActive.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
