namespace FIT_WMI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.queryCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wmiCB = new System.Windows.Forms.ComboBox();
            this.qAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qCB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rqtext = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TransactiondataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AlarmDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rResult = new System.Windows.Forms.Label();
            this.rCheck = new System.Windows.Forms.Button();
            this.rQuery = new System.Windows.Forms.ComboBox();
            this.rProtocol = new System.Windows.Forms.Label();
            this.ProtocolLabel = new System.Windows.Forms.Label();
            this.rIP = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.rName = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rConnect = new System.Windows.Forms.Button();
            this.rpasslabel = new System.Windows.Forms.Label();
            this.ridlabel = new System.Windows.Forms.Label();
            this.rPASS = new System.Windows.Forms.TextBox();
            this.rID = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactiondataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUERY:\\_";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.queryCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.wmiCB);
            this.groupBox1.Controls.Add(this.qAnswer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.qCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MY COMPUTER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // queryCB
            // 
            this.queryCB.FormattingEnabled = true;
            this.queryCB.Location = new System.Drawing.Point(589, 86);
            this.queryCB.Name = "queryCB";
            this.queryCB.Size = new System.Drawing.Size(164, 21);
            this.queryCB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "WIN32 CLASS:";
            // 
            // wmiCB
            // 
            this.wmiCB.FormattingEnabled = true;
            this.wmiCB.Items.AddRange(new object[] {
            "Win32_OperatingSystem",
            "Win32_Account",
            "Win32_AllocatedResource",
            "Win32_BaseService",
            "Win32_BootConfiguration",
            "Win32_ClassicCOMApplicationClasses",
            "Win32_ClassicCOMClass",
            "Win32_ClassicCOMClassSetting",
            "Win32_ClassicCOMClassSettings",
            "Win32_ClusterShare",
            "Win32_CodecFile",
            "Win32_ComputerSystem",
            "Win32_DCOMApplicationSetting",
            "Win32_Directory",
            "Win32_ClientApplicationSetting",
            "Win32_COMApplication",
            "Win32_COMApplicationClasses",
            "Win32_COMApplicationSettings",
            "Win32_COMClass",
            "Win32_ComClassAutoEmulator",
            "Win32_ComClassEmulator",
            "Win32_ComponentCategory",
            "Win32_COMSetting",
            "Win32_DCOMApplication",
            "Win32_DependentService",
            "Win32_Desktop",
            "Win32_ComputerSystemProduct",
            "Win32_Environment",
            "Win32_Group",
            "Win32_GroupUser",
            "Win32_ImplementedCategory",
            "Win32_LoadOrderGroup",
            "Win32_LoadOrderGroupServiceDependencies",
            "Win32_LoadOrderGroupServiceMembers",
            "Win32_LogonSessionMappedDisk",
            "Win32_LoggedOnUser",
            "Win32_LogonSession",
            "Win32_OperatingSystemAutochkSetting",
            "Win32_OperatingSystemQFE",
            "Win32_OptionalFeature",
            "Win32_OSRecoveryConfiguration",
            "Win32_PageFile",
            "Win32_PageFileElementSetting",
            "Win32_PageFileSetting",
            "Win32_PageFileUsage",
            "Win32_PrivilegesStatus",
            "Win32_ProcessStartup",
            "Win32_ProgramGroupContents",
            "Win32_ProgramGroupOrItem",
            "Win32_ProtocolBinding",
            "Win32_Process",
            "Win32_QuickFixEngineering",
            "Win32_Registry",
            "Win32_ScheduledJob",
            "Win32_Service",
            "Win32_Session",
            "Win32_SessionProcess",
            "Win32_SessionResource",
            "Win32_Share",
            "Win32_ShortcutFile",
            "Win32_ShareToDirectory",
            "Win32_StartupCommand",
            "Win32_SubDirectory",
            "Win32_SubSession",
            "Win32_SystemAccount",
            "Win32_SystemBIOS",
            "Win32_SystemBootConfiguration",
            "Win32_SystemConfigurationChangeEvent",
            "Win32_SystemDesktop",
            "Win32_SystemDevices",
            "Win32_SystemDriver",
            "Win32_SystemDriverPNPEntity",
            "Win32_SystemEnclosure",
            "Win32_SystemLoadOrderGroups",
            "Win32_SystemMemoryResource",
            "Win32_SystemNetworkConnections",
            "Win32_SystemOperatingSystem",
            "Win32_SystemPartitions",
            "Win32_SystemProcesses",
            "Win32_SystemProgramGroups",
            "Win32_SystemResources",
            "Win32_SystemServices",
            "Win32_SystemSetting",
            "Win32_SystemSlot",
            "Win32_SystemSystemDriver",
            "Win32_SystemTimeZone",
            "Win32_SystemUsers",
            "Win32_Thread",
            "Win32_TimeZone",
            "Win32_UserAccount",
            "Win32_UserDesktop",
            "Win32_VideoConfiguration",
            "Win32_VolumeChangeEvent"});
            this.wmiCB.Location = new System.Drawing.Point(589, 59);
            this.wmiCB.Name = "wmiCB";
            this.wmiCB.Size = new System.Drawing.Size(245, 21);
            this.wmiCB.TabIndex = 7;
            this.wmiCB.SelectedIndexChanged += new System.EventHandler(this.wmiCB_SelectedIndexChanged);
            // 
            // qAnswer
            // 
            this.qAnswer.AutoSize = true;
            this.qAnswer.Location = new System.Drawing.Point(6, 50);
            this.qAnswer.Name = "qAnswer";
            this.qAnswer.Size = new System.Drawing.Size(10, 13);
            this.qAnswer.TabIndex = 6;
            this.qAnswer.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESULT:";
            // 
            // qCB
            // 
            this.qCB.Location = new System.Drawing.Point(759, 84);
            this.qCB.Name = "qCB";
            this.qCB.Size = new System.Drawing.Size(75, 23);
            this.qCB.TabIndex = 4;
            this.qCB.Text = "Check";
            this.qCB.UseVisualStyleBackColor = true;
            this.qCB.Click += new System.EventHandler(this.qCB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.disconnectButton);
            this.groupBox2.Controls.Add(this.rqtext);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.rCheck);
            this.groupBox2.Controls.Add(this.rQuery);
            this.groupBox2.Controls.Add(this.rProtocol);
            this.groupBox2.Controls.Add(this.ProtocolLabel);
            this.groupBox2.Controls.Add(this.rIP);
            this.groupBox2.Controls.Add(this.IPLabel);
            this.groupBox2.Controls.Add(this.rName);
            this.groupBox2.Controls.Add(this.nameLabel);
            this.groupBox2.Controls.Add(this.rConnect);
            this.groupBox2.Controls.Add(this.rpasslabel);
            this.groupBox2.Controls.Add(this.ridlabel);
            this.groupBox2.Controls.Add(this.rPASS);
            this.groupBox2.Controls.Add(this.rID);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 347);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REMOTE ACCESS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rqtext
            // 
            this.rqtext.AutoSize = true;
            this.rqtext.Location = new System.Drawing.Point(495, 110);
            this.rqtext.Name = "rqtext";
            this.rqtext.Size = new System.Drawing.Size(59, 13);
            this.rqtext.TabIndex = 10;
            this.rqtext.Text = "QUERY:\\_";
            this.rqtext.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TransactiondataGridView);
            this.groupBox5.Location = new System.Drawing.Point(361, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 176);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TRANSACTION HISTORY";
            // 
            // TransactiondataGridView
            // 
            this.TransactiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactiondataGridView.Location = new System.Drawing.Point(6, 19);
            this.TransactiondataGridView.Name = "TransactiondataGridView";
            this.TransactiondataGridView.Size = new System.Drawing.Size(467, 150);
            this.TransactiondataGridView.TabIndex = 29;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AlarmDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(9, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 176);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ALARM HISTORY";
            // 
            // AlarmDataGridView
            // 
            this.AlarmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmDataGridView.Location = new System.Drawing.Point(6, 19);
            this.AlarmDataGridView.Name = "AlarmDataGridView";
            this.AlarmDataGridView.Size = new System.Drawing.Size(287, 150);
            this.AlarmDataGridView.TabIndex = 29;
            this.AlarmDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rResult);
            this.groupBox3.Location = new System.Drawing.Point(560, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 77);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESULT";
            // 
            // rResult
            // 
            this.rResult.AutoSize = true;
            this.rResult.Location = new System.Drawing.Point(6, 28);
            this.rResult.Name = "rResult";
            this.rResult.Size = new System.Drawing.Size(10, 13);
            this.rResult.TabIndex = 24;
            this.rResult.Text = "-";
            // 
            // rCheck
            // 
            this.rCheck.Location = new System.Drawing.Point(766, 105);
            this.rCheck.Name = "rCheck";
            this.rCheck.Size = new System.Drawing.Size(75, 23);
            this.rCheck.TabIndex = 10;
            this.rCheck.Text = "Check";
            this.rCheck.UseVisualStyleBackColor = true;
            this.rCheck.Visible = false;
            this.rCheck.Click += new System.EventHandler(this.rCheck_Click);
            // 
            // rQuery
            // 
            this.rQuery.FormattingEnabled = true;
            this.rQuery.Items.AddRange(new object[] {
            "CPU",
            "MEMORY",
            "DISK",
            "DISK_USAGE"});
            this.rQuery.Location = new System.Drawing.Point(560, 105);
            this.rQuery.Name = "rQuery";
            this.rQuery.Size = new System.Drawing.Size(193, 21);
            this.rQuery.TabIndex = 10;
            this.rQuery.Visible = false;
            this.rQuery.SelectedIndexChanged += new System.EventHandler(this.rQuery_SelectedIndexChanged);
            // 
            // rProtocol
            // 
            this.rProtocol.AutoSize = true;
            this.rProtocol.Location = new System.Drawing.Point(60, 70);
            this.rProtocol.Name = "rProtocol";
            this.rProtocol.Size = new System.Drawing.Size(10, 13);
            this.rProtocol.TabIndex = 16;
            this.rProtocol.Text = "-";
            this.rProtocol.Visible = false;
            // 
            // ProtocolLabel
            // 
            this.ProtocolLabel.AutoSize = true;
            this.ProtocolLabel.Location = new System.Drawing.Point(5, 70);
            this.ProtocolLabel.Name = "ProtocolLabel";
            this.ProtocolLabel.Size = new System.Drawing.Size(49, 13);
            this.ProtocolLabel.TabIndex = 15;
            this.ProtocolLabel.Text = "Protocol:";
            this.ProtocolLabel.Visible = false;
            // 
            // rIP
            // 
            this.rIP.AutoSize = true;
            this.rIP.Location = new System.Drawing.Point(60, 49);
            this.rIP.Name = "rIP";
            this.rIP.Size = new System.Drawing.Size(10, 13);
            this.rIP.TabIndex = 14;
            this.rIP.Text = "-";
            this.rIP.Visible = false;
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(5, 47);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(20, 13);
            this.IPLabel.TabIndex = 13;
            this.IPLabel.Text = "IP:";
            this.IPLabel.Visible = false;
            // 
            // rName
            // 
            this.rName.AutoSize = true;
            this.rName.Location = new System.Drawing.Point(60, 25);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(10, 13);
            this.rName.TabIndex = 12;
            this.rName.Text = "-";
            this.rName.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(5, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Visible = false;
            // 
            // rConnect
            // 
            this.rConnect.Location = new System.Drawing.Point(361, 39);
            this.rConnect.Name = "rConnect";
            this.rConnect.Size = new System.Drawing.Size(75, 23);
            this.rConnect.TabIndex = 4;
            this.rConnect.Text = "Connect";
            this.rConnect.UseVisualStyleBackColor = true;
            this.rConnect.Click += new System.EventHandler(this.rConnect_Click);
            // 
            // rpasslabel
            // 
            this.rpasslabel.AutoSize = true;
            this.rpasslabel.Location = new System.Drawing.Point(166, 44);
            this.rpasslabel.Name = "rpasslabel";
            this.rpasslabel.Size = new System.Drawing.Size(73, 13);
            this.rpasslabel.TabIndex = 3;
            this.rpasslabel.Text = "PASSWORD:";
            // 
            // ridlabel
            // 
            this.ridlabel.AutoSize = true;
            this.ridlabel.Location = new System.Drawing.Point(6, 44);
            this.ridlabel.Name = "ridlabel";
            this.ridlabel.Size = new System.Drawing.Size(21, 13);
            this.ridlabel.TabIndex = 2;
            this.ridlabel.Text = "ID:";
            // 
            // rPASS
            // 
            this.rPASS.Location = new System.Drawing.Point(245, 41);
            this.rPASS.Name = "rPASS";
            this.rPASS.Size = new System.Drawing.Size(100, 20);
            this.rPASS.TabIndex = 1;
            // 
            // rID
            // 
            this.rID.Location = new System.Drawing.Point(33, 41);
            this.rID.Name = "rID";
            this.rID.Size = new System.Drawing.Size(100, 20);
            this.rID.TabIndex = 0;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(6, 100);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 31;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Visible = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FIT - WMI TECHNOLOGY v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactiondataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label qAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button qCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label rpasslabel;
        private System.Windows.Forms.Label ridlabel;
        private System.Windows.Forms.TextBox rPASS;
        private System.Windows.Forms.TextBox rID;
        private System.Windows.Forms.Button rConnect;
        private System.Windows.Forms.ComboBox wmiCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox queryCB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label rName;
        private System.Windows.Forms.Label rProtocol;
        private System.Windows.Forms.Label ProtocolLabel;
        private System.Windows.Forms.Label rIP;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label rResult;
        private System.Windows.Forms.Button rCheck;
        private System.Windows.Forms.ComboBox rQuery;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView AlarmDataGridView;
        private System.Windows.Forms.Label rqtext;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView TransactiondataGridView;
        private System.Windows.Forms.Button disconnectButton;
    }
}

