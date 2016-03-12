namespace KazimProxy
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chStartWithWindows = new System.Windows.Forms.CheckBox();
            this.btnSwitchToNextProxy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chStartTimer = new System.Windows.Forms.CheckBox();
            this.txtSwitchInterval = new System.Windows.Forms.NumericUpDown();
            this.myMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProxyList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddNewProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRefreshLatencies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetRunningTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbRemainingTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.myThread = new System.ComponentModel.BackgroundWorker();
            this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSocks = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLatency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRunningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSwitchToSelectedProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.myContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kullanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshSelectedProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwitchInterval)).BeginInit();
            this.myMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.myContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.myGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proxy Sunucular";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myGrid
            // 
            this.myGrid.AllowUserToAddRows = false;
            this.myGrid.AllowUserToDeleteRows = false;
            this.myGrid.AllowUserToResizeRows = false;
            this.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActive,
            this.colServerName,
            this.colServerAddress,
            this.colPort,
            this.colSocks,
            this.colLatency,
            this.colRunningTime});
            this.myGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.myGrid.Location = new System.Drawing.Point(3, 3);
            this.myGrid.MultiSelect = false;
            this.myGrid.Name = "myGrid";
            this.myGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myGrid.Size = new System.Drawing.Size(737, 343);
            this.myGrid.TabIndex = 0;
            this.myGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myGrid_CellDoubleClick);
            this.myGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.myGrid_CellFormatting);
            this.myGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myGrid_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chStartWithWindows);
            this.tabPage2.Controls.Add(this.btnSwitchToNextProxy);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.chStartTimer);
            this.tabPage2.Controls.Add(this.txtSwitchInterval);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ayarlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chStartWithWindows
            // 
            this.chStartWithWindows.AutoSize = true;
            this.chStartWithWindows.Location = new System.Drawing.Point(26, 177);
            this.chStartWithWindows.Name = "chStartWithWindows";
            this.chStartWithWindows.Size = new System.Drawing.Size(252, 17);
            this.chStartWithWindows.TabIndex = 6;
            this.chStartWithWindows.Text = "Windows başlatıldığında KazımProxy\'yi de çalıştır";
            this.chStartWithWindows.UseVisualStyleBackColor = true;
            this.chStartWithWindows.CheckedChanged += new System.EventHandler(this.chStartWithWindows_CheckedChanged);
            // 
            // btnSwitchToNextProxy
            // 
            this.btnSwitchToNextProxy.Location = new System.Drawing.Point(26, 112);
            this.btnSwitchToNextProxy.Name = "btnSwitchToNextProxy";
            this.btnSwitchToNextProxy.Size = new System.Drawing.Size(127, 23);
            this.btnSwitchToNextProxy.TabIndex = 5;
            this.btnSwitchToNextProxy.Text = "Şimdi Değiştir";
            this.btnSwitchToNextProxy.UseVisualStyleBackColor = true;
            this.btnSwitchToNextProxy.Click += new System.EventHandler(this.btnSwitchToNextProxy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "dakikada bir";
            // 
            // chStartTimer
            // 
            this.chStartTimer.AutoSize = true;
            this.chStartTimer.Location = new System.Drawing.Point(26, 33);
            this.chStartTimer.Name = "chStartTimer";
            this.chStartTimer.Size = new System.Drawing.Size(214, 17);
            this.chStartTimer.TabIndex = 3;
            this.chStartTimer.Text = "Proxy sunucuları otomatik olarak değiştir";
            this.chStartTimer.UseVisualStyleBackColor = true;
            this.chStartTimer.CheckedChanged += new System.EventHandler(this.chStartTimer_CheckedChanged);
            // 
            // txtSwitchInterval
            // 
            this.txtSwitchInterval.Location = new System.Drawing.Point(65, 58);
            this.txtSwitchInterval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.txtSwitchInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSwitchInterval.Name = "txtSwitchInterval";
            this.txtSwitchInterval.Size = new System.Drawing.Size(56, 20);
            this.txtSwitchInterval.TabIndex = 2;
            this.txtSwitchInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSwitchInterval.ValueChanged += new System.EventHandler(this.txtSwitchInterval_ValueChanged);
            // 
            // myMenu
            // 
            this.myMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuProxyList});
            this.myMenu.Location = new System.Drawing.Point(0, 0);
            this.myMenu.Name = "myMenu";
            this.myMenu.Size = new System.Drawing.Size(751, 24);
            this.myMenu.TabIndex = 1;
            this.myMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(51, 20);
            this.mnuFile.Text = "&Dosya";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Çıkış";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuProxyList
            // 
            this.mnuProxyList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddNewProxy,
            this.mnuEditProxy,
            this.mnuDeleteProxy,
            this.toolStripSeparator1,
            this.mnuRefreshLatencies,
            this.mnuResetRunningTimes,
            this.toolStripMenuItem2,
            this.mnuSwitchToSelectedProxy});
            this.mnuProxyList.Name = "mnuProxyList";
            this.mnuProxyList.Size = new System.Drawing.Size(94, 20);
            this.mnuProxyList.Text = "Sunucu Listesi";
            // 
            // mnuAddNewProxy
            // 
            this.mnuAddNewProxy.Name = "mnuAddNewProxy";
            this.mnuAddNewProxy.Size = new System.Drawing.Size(215, 22);
            this.mnuAddNewProxy.Text = "&Yeni Sunucu Ekle...";
            this.mnuAddNewProxy.Click += new System.EventHandler(this.mnuAddNewProxy_Click);
            // 
            // mnuEditProxy
            // 
            this.mnuEditProxy.Name = "mnuEditProxy";
            this.mnuEditProxy.Size = new System.Drawing.Size(215, 22);
            this.mnuEditProxy.Text = "&Düzenle...";
            this.mnuEditProxy.Click += new System.EventHandler(this.mnuEditProxy_Click);
            // 
            // mnuDeleteProxy
            // 
            this.mnuDeleteProxy.Name = "mnuDeleteProxy";
            this.mnuDeleteProxy.Size = new System.Drawing.Size(215, 22);
            this.mnuDeleteProxy.Text = "Sil...";
            this.mnuDeleteProxy.Click += new System.EventHandler(this.mnuDeleteProxy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // mnuRefreshLatencies
            // 
            this.mnuRefreshLatencies.Name = "mnuRefreshLatencies";
            this.mnuRefreshLatencies.Size = new System.Drawing.Size(215, 22);
            this.mnuRefreshLatencies.Text = "&Sunucu Uzaklıklarını Tazele";
            this.mnuRefreshLatencies.Click += new System.EventHandler(this.mnuRefreshLatencies_Click);
            // 
            // mnuResetRunningTimes
            // 
            this.mnuResetRunningTimes.Name = "mnuResetRunningTimes";
            this.mnuResetRunningTimes.Size = new System.Drawing.Size(215, 22);
            this.mnuResetRunningTimes.Text = "&Kullanım Sürelerini Sıfırla";
            this.mnuResetRunningTimes.Click += new System.EventHandler(this.mnuResetRunningTimes_Click);
            // 
            // myTimer
            // 
            this.myTimer.Interval = 1000;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbRemainingTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(751, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(149, 17);
            this.toolStripStatusLabel1.Text = "(c) Ozan Yasin Doğan, 2016";
            // 
            // lbRemainingTime
            // 
            this.lbRemainingTime.Name = "lbRemainingTime";
            this.lbRemainingTime.Size = new System.Drawing.Size(587, 17);
            this.lbRemainingTime.Spring = true;
            this.lbRemainingTime.Text = "0 sn.";
            this.lbRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myThread
            // 
            this.myThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.myThread_DoWork);
            // 
            // colActive
            // 
            this.colActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colActive.HeaderText = "Aktif";
            this.colActive.Name = "colActive";
            this.colActive.Width = 34;
            // 
            // colServerName
            // 
            this.colServerName.HeaderText = "Sunucu Adı";
            this.colServerName.Name = "colServerName";
            this.colServerName.ReadOnly = true;
            this.colServerName.Width = 120;
            // 
            // colServerAddress
            // 
            this.colServerAddress.HeaderText = "Proxy Sunucusu";
            this.colServerAddress.Name = "colServerAddress";
            this.colServerAddress.Width = 120;
            // 
            // colPort
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = "0";
            this.colPort.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPort.HeaderText = "Port";
            this.colPort.MaxInputLength = 5;
            this.colPort.Name = "colPort";
            // 
            // colSocks
            // 
            this.colSocks.HeaderText = "Socks Kullan";
            this.colSocks.Name = "colSocks";
            // 
            // colLatency
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLatency.DefaultCellStyle = dataGridViewCellStyle2;
            this.colLatency.HeaderText = "Uzaklik (ms)";
            this.colLatency.Name = "colLatency";
            this.colLatency.ReadOnly = true;
            // 
            // colRunningTime
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRunningTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRunningTime.HeaderText = "Kullanım Süresi";
            this.colRunningTime.Name = "colRunningTime";
            this.colRunningTime.ReadOnly = true;
            this.colRunningTime.Width = 120;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 6);
            // 
            // mnuSwitchToSelectedProxy
            // 
            this.mnuSwitchToSelectedProxy.Name = "mnuSwitchToSelectedProxy";
            this.mnuSwitchToSelectedProxy.Size = new System.Drawing.Size(215, 22);
            this.mnuSwitchToSelectedProxy.Text = "Seçili Sunucuya Geç";
            this.mnuSwitchToSelectedProxy.Click += new System.EventHandler(this.mnuSwitchToSelectedProxy_Click);
            // 
            // myContextMenu
            // 
            this.myContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.toolStripMenuItem3,
            this.mnuRefreshSelectedProxy});
            this.myContextMenu.Name = "myContextMenu";
            this.myContextMenu.Size = new System.Drawing.Size(191, 120);
            // 
            // kullanToolStripMenuItem
            // 
            this.kullanToolStripMenuItem.Name = "kullanToolStripMenuItem";
            this.kullanToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.kullanToolStripMenuItem.Text = "&Kullan";
            this.kullanToolStripMenuItem.Click += new System.EventHandler(this.mnuSwitchToSelectedProxy_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.düzenleToolStripMenuItem.Text = "&Düzenle...";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.mnuEditProxy_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.silToolStripMenuItem.Text = "&Sil...";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.mnuDeleteProxy_Click);
            // 
            // mnuRefreshSelectedProxy
            // 
            this.mnuRefreshSelectedProxy.Name = "mnuRefreshSelectedProxy";
            this.mnuRefreshSelectedProxy.Size = new System.Drawing.Size(190, 22);
            this.mnuRefreshSelectedProxy.Text = "&Uzaklık Bilgisini Tazele";
            this.mnuRefreshSelectedProxy.Click += new System.EventHandler(this.mnuRefreshSelectedProxy_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 6);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 419);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.myMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.myMenu;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KazımProxy - Otomatik Proxy Sunucusu Değiştirici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwitchInterval)).EndInit();
            this.myMenu.ResumeLayout(false);
            this.myMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.myContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip myMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chStartTimer;
        private System.Windows.Forms.NumericUpDown txtSwitchInterval;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbRemainingTime;
        private System.Windows.Forms.Button btnSwitchToNextProxy;
        private System.Windows.Forms.DataGridView myGrid;
        private System.ComponentModel.BackgroundWorker myThread;
        private System.Windows.Forms.CheckBox chStartWithWindows;
        private System.Windows.Forms.ToolStripMenuItem mnuProxyList;
        private System.Windows.Forms.ToolStripMenuItem mnuAddNewProxy;
        private System.Windows.Forms.ToolStripMenuItem mnuEditProxy;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteProxy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshLatencies;
        private System.Windows.Forms.ToolStripMenuItem mnuResetRunningTimes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPort;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRunningTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuSwitchToSelectedProxy;
        private System.Windows.Forms.ContextMenuStrip myContextMenu;
        private System.Windows.Forms.ToolStripMenuItem kullanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshSelectedProxy;
    }
}

