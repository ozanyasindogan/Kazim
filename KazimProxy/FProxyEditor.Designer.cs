namespace KazimProxy
{
    partial class FProxyEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIncorrectPort = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.MaskedTextBox();
            this.lbIPAddressError = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.MaskedTextBox();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.chUseSocks = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbIncorrectPort);
            this.groupBox1.Controls.Add(this.txtServerPort);
            this.groupBox1.Controls.Add(this.lbIPAddressError);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Controls.Add(this.chIsActive);
            this.groupBox1.Controls.Add(this.chUseSocks);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbIncorrectPort
            // 
            this.lbIncorrectPort.AutoSize = true;
            this.lbIncorrectPort.ForeColor = System.Drawing.Color.Red;
            this.lbIncorrectPort.Location = new System.Drawing.Point(256, 73);
            this.lbIncorrectPort.Name = "lbIncorrectPort";
            this.lbIncorrectPort.Size = new System.Drawing.Size(62, 13);
            this.lbIncorrectPort.TabIndex = 7;
            this.lbIncorrectPort.Text = "* Hatalı port";
            this.lbIncorrectPort.Visible = false;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(134, 70);
            this.txtServerPort.Mask = "00000";
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(116, 20);
            this.txtServerPort.TabIndex = 6;
            this.txtServerPort.ValidatingType = typeof(int);
            this.txtServerPort.Validating += new System.ComponentModel.CancelEventHandler(this.txtServerPort_Validating);
            // 
            // lbIPAddressError
            // 
            this.lbIPAddressError.AutoSize = true;
            this.lbIPAddressError.ForeColor = System.Drawing.Color.Red;
            this.lbIPAddressError.Location = new System.Drawing.Point(256, 47);
            this.lbIPAddressError.Name = "lbIPAddressError";
            this.lbIPAddressError.Size = new System.Drawing.Size(70, 13);
            this.lbIPAddressError.TabIndex = 4;
            this.lbIPAddressError.Text = "* Hatalı adres";
            this.lbIPAddressError.Visible = false;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(134, 44);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(116, 20);
            this.txtServerIP.TabIndex = 3;
            this.txtServerIP.Validating += new System.ComponentModel.CancelEventHandler(this.txtServerIP_Validating);
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Location = new System.Drawing.Point(134, 125);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(47, 17);
            this.chIsActive.TabIndex = 9;
            this.chIsActive.Text = "Aktif";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // chUseSocks
            // 
            this.chUseSocks.AutoSize = true;
            this.chUseSocks.Location = new System.Drawing.Point(134, 102);
            this.chUseSocks.Name = "chUseSocks";
            this.chUseSocks.Size = new System.Drawing.Size(87, 17);
            this.chUseSocks.TabIndex = 8;
            this.chUseSocks.Text = "Socks kullan";
            this.chUseSocks.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proxy Sunucu IP Adresi:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(190, 179);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&Kaydet";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(271, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(134, 19);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(116, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Proxy Adı:";
            // 
            // FProxyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 213);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FProxyEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proxy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtServerIP;
        private System.Windows.Forms.CheckBox chIsActive;
        private System.Windows.Forms.CheckBox chUseSocks;
        private System.Windows.Forms.Label lbIPAddressError;
        private System.Windows.Forms.MaskedTextBox txtServerPort;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbIncorrectPort;
        private System.Windows.Forms.MaskedTextBox txtServerName;
        private System.Windows.Forms.Label label3;
    }
}