namespace ToDoTasks
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Today", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Tomorrow", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("The day after tomorrow", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Upcoming...", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.panMenu = new System.Windows.Forms.Panel();
            this.radTabLogin = new System.Windows.Forms.RadioButton();
            this.radTabSettings = new System.Windows.Forms.RadioButton();
            this.radTabSchedule = new System.Windows.Forms.RadioButton();
            this.rabTabStatus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panControl = new System.Windows.Forms.Panel();
            this.tabsFun = new ToDoTasks.TabPagesControl();
            this.tpFunStatus = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMinimizeToSystemTray = new System.Windows.Forms.Button();
            this.tpFunSchedule = new System.Windows.Forms.TabPage();
            this.radScheduleMonth = new System.Windows.Forms.RadioButton();
            this.radScheduleWeek = new System.Windows.Forms.RadioButton();
            this.radScheduleList = new System.Windows.Forms.RadioButton();
            this.tpFunScheduleNewTask = new System.Windows.Forms.TabPage();
            this.btnCancelAddNewTask = new System.Windows.Forms.Button();
            this.btnOKAddNewTask = new System.Windows.Forms.Button();
            this.tpFunScheduleEditTask = new System.Windows.Forms.TabPage();
            this.btnCancelEditTask = new System.Windows.Forms.Button();
            this.btnOKEditTask = new System.Windows.Forms.Button();
            this.tpFunSettings = new System.Windows.Forms.TabPage();
            this.tpFunSettingsSync = new System.Windows.Forms.TabPage();
            this.btnSyncCancel = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.tpFunLogin = new System.Windows.Forms.TabPage();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tpFunLoginNewAccount = new System.Windows.Forms.TabPage();
            this.btnAccountCancel = new System.Windows.Forms.Button();
            this.btnAccountOK = new System.Windows.Forms.Button();
            this.tpFunLogout = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timSys = new System.Windows.Forms.Timer(this.components);
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShowToDoTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.lblVersionTop = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabs = new ToDoTasks.TabPagesControl();
            this.tpStatus = new System.Windows.Forms.TabPage();
            this.lvStatus = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sbtnFinishTask = new System.Windows.Forms.ToolStripButton();
            this.sbtnDeleteTask = new System.Windows.Forms.ToolStripButton();
            this.sbtnEditTask = new System.Windows.Forms.ToolStripButton();
            this.sbtnAddTask = new System.Windows.Forms.ToolStripButton();
            this.calSchedule = new System.Windows.Forms.Calendar.Calendar();
            this.tpSchedule_List = new System.Windows.Forms.TabPage();
            this.lvScheduleList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnScheduleList_Finish = new System.Windows.Forms.ToolStripButton();
            this.btnScheduleList_Delete = new System.Windows.Forms.ToolStripButton();
            this.btnScheduleList_Edit = new System.Windows.Forms.ToolStripButton();
            this.btnScheduleList_Add = new System.Windows.Forms.ToolStripButton();
            this.tpEditTask = new System.Windows.Forms.TabPage();
            this.txtIndexTaskEdit = new System.Windows.Forms.TextBox();
            this.numTaskRepeatTimes = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.btnTaskRemoveRemindTime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaskAddRemindTime = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.numTaskAddRemindTime = new System.Windows.Forms.NumericUpDown();
            this.lstTaskRemindTime = new System.Windows.Forms.ListBox();
            this.label25 = new System.Windows.Forms.Label();
            this.chkTaskRemindType_Email = new System.Windows.Forms.CheckBox();
            this.chkTaskRemindType_Sound = new System.Windows.Forms.CheckBox();
            this.chkTaskRemindType_Notification = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.numTaskRepeatUnit = new System.Windows.Forms.NumericUpDown();
            this.cmbTaskRepeatType = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpTaskEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpTaskStartTime = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.picTaskColor = new System.Windows.Forms.PictureBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskPlace = new System.Windows.Forms.TextBox();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.lnkStartSync = new System.Windows.Forms.LinkLabel();
            this.lblLastSync = new System.Windows.Forms.Label();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            this.btnSoundBrowse = new System.Windows.Forms.Button();
            this.txtSoundFile = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkHideOnMinimizing = new System.Windows.Forms.CheckBox();
            this.chkHideOnStarting = new System.Windows.Forms.CheckBox();
            this.chkStartWithOS = new System.Windows.Forms.CheckBox();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tpSync = new System.Windows.Forms.TabPage();
            this.dtSyncEnd = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtSyncStart = new System.Windows.Forms.DateTimePicker();
            this.radCustomSync = new System.Windows.Forms.RadioButton();
            this.radCompleteSync = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogInEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpRegisterNewAccount = new System.Windows.Forms.TabPage();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccountConfirmPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panControl.SuspendLayout();
            this.tabsFun.SuspendLayout();
            this.tpFunStatus.SuspendLayout();
            this.tpFunSchedule.SuspendLayout();
            this.tpFunScheduleNewTask.SuspendLayout();
            this.tpFunScheduleEditTask.SuspendLayout();
            this.tpFunSettingsSync.SuspendLayout();
            this.tpFunLogin.SuspendLayout();
            this.tpFunLoginNewAccount.SuspendLayout();
            this.tpFunLogout.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.tabs.SuspendLayout();
            this.tpStatus.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tpSchedule_List.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tpEditTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskRepeatTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskAddRemindTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskRepeatUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaskColor)).BeginInit();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            this.tpSync.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tpRegisterNewAccount.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.White;
            this.panMenu.Controls.Add(this.radTabLogin);
            this.panMenu.Controls.Add(this.radTabSettings);
            this.panMenu.Controls.Add(this.radTabSchedule);
            this.panMenu.Controls.Add(this.rabTabStatus);
            this.panMenu.Controls.Add(this.label1);
            this.panMenu.Controls.Add(this.picLogo);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(903, 70);
            this.panMenu.TabIndex = 0;
            // 
            // radTabLogin
            // 
            this.radTabLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radTabLogin.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTabLogin.BackColor = System.Drawing.Color.White;
            this.radTabLogin.FlatAppearance.BorderSize = 0;
            this.radTabLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.radTabLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTabLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTabLogin.Location = new System.Drawing.Point(783, 0);
            this.radTabLogin.Name = "radTabLogin";
            this.radTabLogin.Size = new System.Drawing.Size(120, 70);
            this.radTabLogin.TabIndex = 11;
            this.radTabLogin.TabStop = true;
            this.radTabLogin.Text = "Log in";
            this.radTabLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabLogin.UseVisualStyleBackColor = false;
            this.radTabLogin.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
            // 
            // radTabSettings
            // 
            this.radTabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radTabSettings.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTabSettings.BackColor = System.Drawing.Color.White;
            this.radTabSettings.FlatAppearance.BorderSize = 0;
            this.radTabSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.radTabSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTabSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTabSettings.Location = new System.Drawing.Point(662, 0);
            this.radTabSettings.Name = "radTabSettings";
            this.radTabSettings.Size = new System.Drawing.Size(120, 70);
            this.radTabSettings.TabIndex = 10;
            this.radTabSettings.TabStop = true;
            this.radTabSettings.Text = "Settings";
            this.radTabSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabSettings.UseVisualStyleBackColor = false;
            this.radTabSettings.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
            // 
            // radTabSchedule
            // 
            this.radTabSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radTabSchedule.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTabSchedule.BackColor = System.Drawing.Color.White;
            this.radTabSchedule.FlatAppearance.BorderSize = 0;
            this.radTabSchedule.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.radTabSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTabSchedule.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTabSchedule.Location = new System.Drawing.Point(541, 0);
            this.radTabSchedule.Name = "radTabSchedule";
            this.radTabSchedule.Size = new System.Drawing.Size(120, 70);
            this.radTabSchedule.TabIndex = 9;
            this.radTabSchedule.TabStop = true;
            this.radTabSchedule.Text = "Schedule";
            this.radTabSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabSchedule.UseVisualStyleBackColor = false;
            this.radTabSchedule.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
            // 
            // rabTabStatus
            // 
            this.rabTabStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabTabStatus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rabTabStatus.BackColor = System.Drawing.Color.White;
            this.rabTabStatus.Checked = true;
            this.rabTabStatus.FlatAppearance.BorderSize = 0;
            this.rabTabStatus.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.rabTabStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.rabTabStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.rabTabStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rabTabStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rabTabStatus.Location = new System.Drawing.Point(420, 0);
            this.rabTabStatus.Name = "rabTabStatus";
            this.rabTabStatus.Size = new System.Drawing.Size(120, 70);
            this.rabTabStatus.TabIndex = 2;
            this.rabTabStatus.TabStop = true;
            this.rabTabStatus.Text = "Status";
            this.rabTabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rabTabStatus.UseVisualStyleBackColor = false;
            this.rabTabStatus.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(161)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Do Tasks";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(46, 46);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panControl
            // 
            this.panControl.BackColor = System.Drawing.Color.White;
            this.panControl.Controls.Add(this.tabsFun);
            this.panControl.Controls.Add(this.lblDate);
            this.panControl.Controls.Add(this.lblTime);
            this.panControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panControl.Location = new System.Drawing.Point(0, 406);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(903, 80);
            this.panControl.TabIndex = 1;
            // 
            // tabsFun
            // 
            this.tabsFun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsFun.Controls.Add(this.tpFunStatus);
            this.tabsFun.Controls.Add(this.tpFunSchedule);
            this.tabsFun.Controls.Add(this.tpFunScheduleNewTask);
            this.tabsFun.Controls.Add(this.tpFunScheduleEditTask);
            this.tabsFun.Controls.Add(this.tpFunSettings);
            this.tabsFun.Controls.Add(this.tpFunSettingsSync);
            this.tabsFun.Controls.Add(this.tpFunLogin);
            this.tabsFun.Controls.Add(this.tpFunLoginNewAccount);
            this.tabsFun.Controls.Add(this.tpFunLogout);
            this.tabsFun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsFun.Location = new System.Drawing.Point(375, 8);
            this.tabsFun.Name = "tabsFun";
            this.tabsFun.SelectedIndex = 0;
            this.tabsFun.Size = new System.Drawing.Size(494, 83);
            this.tabsFun.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabsFun.TabIndex = 32;
            this.tabsFun.TabStop = false;
            // 
            // tpFunStatus
            // 
            this.tpFunStatus.Controls.Add(this.btnAbout);
            this.tpFunStatus.Controls.Add(this.btnMinimizeToSystemTray);
            this.tpFunStatus.Location = new System.Drawing.Point(4, 24);
            this.tpFunStatus.Name = "tpFunStatus";
            this.tpFunStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpFunStatus.Size = new System.Drawing.Size(486, 55);
            this.tpFunStatus.TabIndex = 0;
            this.tpFunStatus.Text = "tpFunStatus";
            this.tpFunStatus.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(435, 11);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10);
            this.btnAbout.Size = new System.Drawing.Size(45, 45);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMinimizeToSystemTray
            // 
            this.btnMinimizeToSystemTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeToSystemTray.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeToSystemTray.Image")));
            this.btnMinimizeToSystemTray.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizeToSystemTray.Location = new System.Drawing.Point(226, 11);
            this.btnMinimizeToSystemTray.Name = "btnMinimizeToSystemTray";
            this.btnMinimizeToSystemTray.Padding = new System.Windows.Forms.Padding(10);
            this.btnMinimizeToSystemTray.Size = new System.Drawing.Size(203, 45);
            this.btnMinimizeToSystemTray.TabIndex = 4;
            this.btnMinimizeToSystemTray.Text = "Minimize to system tray";
            this.btnMinimizeToSystemTray.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizeToSystemTray.UseVisualStyleBackColor = true;
            this.btnMinimizeToSystemTray.Click += new System.EventHandler(this.btnMinimizeToSystemTray_Click);
            // 
            // tpFunSchedule
            // 
            this.tpFunSchedule.Controls.Add(this.radScheduleMonth);
            this.tpFunSchedule.Controls.Add(this.radScheduleWeek);
            this.tpFunSchedule.Controls.Add(this.radScheduleList);
            this.tpFunSchedule.Location = new System.Drawing.Point(4, 24);
            this.tpFunSchedule.Name = "tpFunSchedule";
            this.tpFunSchedule.Padding = new System.Windows.Forms.Padding(10);
            this.tpFunSchedule.Size = new System.Drawing.Size(486, 55);
            this.tpFunSchedule.TabIndex = 2;
            this.tpFunSchedule.Text = "tpFunSchedule";
            this.tpFunSchedule.UseVisualStyleBackColor = true;
            // 
            // radScheduleMonth
            // 
            this.radScheduleMonth.Appearance = System.Windows.Forms.Appearance.Button;
            this.radScheduleMonth.Image = ((System.Drawing.Image)(resources.GetObject("radScheduleMonth.Image")));
            this.radScheduleMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radScheduleMonth.Location = new System.Drawing.Point(382, 11);
            this.radScheduleMonth.Name = "radScheduleMonth";
            this.radScheduleMonth.Padding = new System.Windows.Forms.Padding(10);
            this.radScheduleMonth.Size = new System.Drawing.Size(106, 45);
            this.radScheduleMonth.TabIndex = 25;
            this.radScheduleMonth.Text = "Month";
            this.radScheduleMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radScheduleMonth.UseVisualStyleBackColor = true;
            this.radScheduleMonth.CheckedChanged += new System.EventHandler(this.radScheduleMonth_CheckedChanged);
            // 
            // radScheduleWeek
            // 
            this.radScheduleWeek.Appearance = System.Windows.Forms.Appearance.Button;
            this.radScheduleWeek.Checked = true;
            this.radScheduleWeek.Image = ((System.Drawing.Image)(resources.GetObject("radScheduleWeek.Image")));
            this.radScheduleWeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radScheduleWeek.Location = new System.Drawing.Point(277, 11);
            this.radScheduleWeek.Name = "radScheduleWeek";
            this.radScheduleWeek.Padding = new System.Windows.Forms.Padding(10);
            this.radScheduleWeek.Size = new System.Drawing.Size(99, 45);
            this.radScheduleWeek.TabIndex = 24;
            this.radScheduleWeek.TabStop = true;
            this.radScheduleWeek.Text = "Week";
            this.radScheduleWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radScheduleWeek.UseVisualStyleBackColor = true;
            this.radScheduleWeek.CheckedChanged += new System.EventHandler(this.radScheduleWeek_CheckedChanged);
            // 
            // radScheduleList
            // 
            this.radScheduleList.Appearance = System.Windows.Forms.Appearance.Button;
            this.radScheduleList.Image = ((System.Drawing.Image)(resources.GetObject("radScheduleList.Image")));
            this.radScheduleList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radScheduleList.Location = new System.Drawing.Point(182, 11);
            this.radScheduleList.Name = "radScheduleList";
            this.radScheduleList.Padding = new System.Windows.Forms.Padding(10);
            this.radScheduleList.Size = new System.Drawing.Size(89, 45);
            this.radScheduleList.TabIndex = 23;
            this.radScheduleList.Text = "List";
            this.radScheduleList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radScheduleList.UseVisualStyleBackColor = true;
            this.radScheduleList.CheckedChanged += new System.EventHandler(this.radScheduleList_CheckedChanged);
            // 
            // tpFunScheduleNewTask
            // 
            this.tpFunScheduleNewTask.Controls.Add(this.btnCancelAddNewTask);
            this.tpFunScheduleNewTask.Controls.Add(this.btnOKAddNewTask);
            this.tpFunScheduleNewTask.Location = new System.Drawing.Point(4, 24);
            this.tpFunScheduleNewTask.Name = "tpFunScheduleNewTask";
            this.tpFunScheduleNewTask.Size = new System.Drawing.Size(486, 55);
            this.tpFunScheduleNewTask.TabIndex = 6;
            this.tpFunScheduleNewTask.Text = "tpFunScheduleNewTask";
            this.tpFunScheduleNewTask.UseVisualStyleBackColor = true;
            // 
            // btnCancelAddNewTask
            // 
            this.btnCancelAddNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAddNewTask.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelAddNewTask.Image")));
            this.btnCancelAddNewTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAddNewTask.Location = new System.Drawing.Point(372, 11);
            this.btnCancelAddNewTask.Name = "btnCancelAddNewTask";
            this.btnCancelAddNewTask.Padding = new System.Windows.Forms.Padding(10);
            this.btnCancelAddNewTask.Size = new System.Drawing.Size(108, 45);
            this.btnCancelAddNewTask.TabIndex = 23;
            this.btnCancelAddNewTask.Text = "Cancel";
            this.btnCancelAddNewTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelAddNewTask.UseVisualStyleBackColor = true;
            this.btnCancelAddNewTask.Click += new System.EventHandler(this.btnCancelAddNewTask_Click);
            // 
            // btnOKAddNewTask
            // 
            this.btnOKAddNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOKAddNewTask.Image = ((System.Drawing.Image)(resources.GetObject("btnOKAddNewTask.Image")));
            this.btnOKAddNewTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOKAddNewTask.Location = new System.Drawing.Point(278, 11);
            this.btnOKAddNewTask.Name = "btnOKAddNewTask";
            this.btnOKAddNewTask.Padding = new System.Windows.Forms.Padding(10);
            this.btnOKAddNewTask.Size = new System.Drawing.Size(88, 45);
            this.btnOKAddNewTask.TabIndex = 22;
            this.btnOKAddNewTask.Text = "Add";
            this.btnOKAddNewTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOKAddNewTask.UseVisualStyleBackColor = true;
            this.btnOKAddNewTask.Click += new System.EventHandler(this.btnOKAddNewTask_Click);
            // 
            // tpFunScheduleEditTask
            // 
            this.tpFunScheduleEditTask.Controls.Add(this.btnCancelEditTask);
            this.tpFunScheduleEditTask.Controls.Add(this.btnOKEditTask);
            this.tpFunScheduleEditTask.Location = new System.Drawing.Point(4, 24);
            this.tpFunScheduleEditTask.Name = "tpFunScheduleEditTask";
            this.tpFunScheduleEditTask.Size = new System.Drawing.Size(486, 55);
            this.tpFunScheduleEditTask.TabIndex = 7;
            this.tpFunScheduleEditTask.Text = "tpFunScheduleEditTask";
            this.tpFunScheduleEditTask.UseVisualStyleBackColor = true;
            // 
            // btnCancelEditTask
            // 
            this.btnCancelEditTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelEditTask.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelEditTask.Image")));
            this.btnCancelEditTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelEditTask.Location = new System.Drawing.Point(372, 11);
            this.btnCancelEditTask.Name = "btnCancelEditTask";
            this.btnCancelEditTask.Padding = new System.Windows.Forms.Padding(10);
            this.btnCancelEditTask.Size = new System.Drawing.Size(108, 45);
            this.btnCancelEditTask.TabIndex = 25;
            this.btnCancelEditTask.Text = "Cancel";
            this.btnCancelEditTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelEditTask.UseVisualStyleBackColor = true;
            this.btnCancelEditTask.Click += new System.EventHandler(this.btnCancelEditTask_Click);
            // 
            // btnOKEditTask
            // 
            this.btnOKEditTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOKEditTask.Image = ((System.Drawing.Image)(resources.GetObject("btnOKEditTask.Image")));
            this.btnOKEditTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOKEditTask.Location = new System.Drawing.Point(278, 11);
            this.btnOKEditTask.Name = "btnOKEditTask";
            this.btnOKEditTask.Padding = new System.Windows.Forms.Padding(10);
            this.btnOKEditTask.Size = new System.Drawing.Size(88, 45);
            this.btnOKEditTask.TabIndex = 24;
            this.btnOKEditTask.Text = "Edit";
            this.btnOKEditTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOKEditTask.UseVisualStyleBackColor = true;
            this.btnOKEditTask.Click += new System.EventHandler(this.btnOKEditTask_Click);
            // 
            // tpFunSettings
            // 
            this.tpFunSettings.Location = new System.Drawing.Point(4, 24);
            this.tpFunSettings.Name = "tpFunSettings";
            this.tpFunSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpFunSettings.Size = new System.Drawing.Size(486, 55);
            this.tpFunSettings.TabIndex = 9;
            this.tpFunSettings.Text = "tpFunSettings";
            this.tpFunSettings.UseVisualStyleBackColor = true;
            // 
            // tpFunSettingsSync
            // 
            this.tpFunSettingsSync.Controls.Add(this.btnSyncCancel);
            this.tpFunSettingsSync.Controls.Add(this.btnSync);
            this.tpFunSettingsSync.Location = new System.Drawing.Point(4, 24);
            this.tpFunSettingsSync.Name = "tpFunSettingsSync";
            this.tpFunSettingsSync.Size = new System.Drawing.Size(486, 55);
            this.tpFunSettingsSync.TabIndex = 4;
            this.tpFunSettingsSync.Text = "tpFunSettingsSync";
            this.tpFunSettingsSync.UseVisualStyleBackColor = true;
            // 
            // btnSyncCancel
            // 
            this.btnSyncCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSyncCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnSyncCancel.Image")));
            this.btnSyncCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyncCancel.Location = new System.Drawing.Point(372, 11);
            this.btnSyncCancel.Name = "btnSyncCancel";
            this.btnSyncCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btnSyncCancel.Size = new System.Drawing.Size(108, 45);
            this.btnSyncCancel.TabIndex = 24;
            this.btnSyncCancel.Text = "Cancel";
            this.btnSyncCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSyncCancel.UseVisualStyleBackColor = true;
            this.btnSyncCancel.Click += new System.EventHandler(this.btnSyncCancel_Click);
            // 
            // btnSync
            // 
            this.btnSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(272, 11);
            this.btnSync.Name = "btnSync";
            this.btnSync.Padding = new System.Windows.Forms.Padding(10);
            this.btnSync.Size = new System.Drawing.Size(94, 45);
            this.btnSync.TabIndex = 23;
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // tpFunLogin
            // 
            this.tpFunLogin.Controls.Add(this.btnNewAccount);
            this.tpFunLogin.Controls.Add(this.btnLogIn);
            this.tpFunLogin.Location = new System.Drawing.Point(4, 24);
            this.tpFunLogin.Name = "tpFunLogin";
            this.tpFunLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpFunLogin.Size = new System.Drawing.Size(486, 55);
            this.tpFunLogin.TabIndex = 1;
            this.tpFunLogin.Text = "tpFunLogin";
            this.tpFunLogin.UseVisualStyleBackColor = true;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAccount.Image")));
            this.btnNewAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAccount.Location = new System.Drawing.Point(233, 11);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Padding = new System.Windows.Forms.Padding(10);
            this.btnNewAccount.Size = new System.Drawing.Size(140, 45);
            this.btnNewAccount.TabIndex = 27;
            this.btnNewAccount.Text = "New account";
            this.btnNewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.Location = new System.Drawing.Point(379, 11);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogIn.Size = new System.Drawing.Size(101, 45);
            this.btnLogIn.TabIndex = 26;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tpFunLoginNewAccount
            // 
            this.tpFunLoginNewAccount.Controls.Add(this.btnAccountCancel);
            this.tpFunLoginNewAccount.Controls.Add(this.btnAccountOK);
            this.tpFunLoginNewAccount.Location = new System.Drawing.Point(4, 24);
            this.tpFunLoginNewAccount.Name = "tpFunLoginNewAccount";
            this.tpFunLoginNewAccount.Size = new System.Drawing.Size(486, 55);
            this.tpFunLoginNewAccount.TabIndex = 5;
            this.tpFunLoginNewAccount.Text = "tpFunLoginNewAccount";
            this.tpFunLoginNewAccount.UseVisualStyleBackColor = true;
            // 
            // btnAccountCancel
            // 
            this.btnAccountCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountCancel.Image")));
            this.btnAccountCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountCancel.Location = new System.Drawing.Point(372, 11);
            this.btnAccountCancel.Name = "btnAccountCancel";
            this.btnAccountCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btnAccountCancel.Size = new System.Drawing.Size(108, 45);
            this.btnAccountCancel.TabIndex = 21;
            this.btnAccountCancel.Text = "Cancel";
            this.btnAccountCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountCancel.UseVisualStyleBackColor = true;
            this.btnAccountCancel.Click += new System.EventHandler(this.btnAccountCancel_Click);
            // 
            // btnAccountOK
            // 
            this.btnAccountOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountOK.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountOK.Image")));
            this.btnAccountOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountOK.Location = new System.Drawing.Point(278, 11);
            this.btnAccountOK.Name = "btnAccountOK";
            this.btnAccountOK.Padding = new System.Windows.Forms.Padding(10);
            this.btnAccountOK.Size = new System.Drawing.Size(88, 45);
            this.btnAccountOK.TabIndex = 20;
            this.btnAccountOK.Text = "OK";
            this.btnAccountOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountOK.UseVisualStyleBackColor = true;
            this.btnAccountOK.Click += new System.EventHandler(this.btnAccountOK_Click);
            // 
            // tpFunLogout
            // 
            this.tpFunLogout.Controls.Add(this.btnLogOut);
            this.tpFunLogout.Location = new System.Drawing.Point(4, 24);
            this.tpFunLogout.Name = "tpFunLogout";
            this.tpFunLogout.Size = new System.Drawing.Size(486, 55);
            this.tpFunLogout.TabIndex = 8;
            this.tpFunLogout.Text = "tpFunLogout";
            this.tpFunLogout.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(370, 11);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogOut.Size = new System.Drawing.Size(110, 45);
            this.btnLogOut.TabIndex = 21;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDate.Location = new System.Drawing.Point(12, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(121, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Jan 8th, 2014";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(103, 32);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "20:21:03";
            // 
            // timSys
            // 
            this.timSys.Enabled = true;
            this.timSys.Interval = 1000;
            this.timSys.Tick += new System.EventHandler(this.timSys_Tick);
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.BalloonTipTitle = "To Do Tasks";
            this.tray.ContextMenuStrip = this.contextMenuStrip1;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "To do tasks";
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowToDoTasks,
            this.toolStripMenuItem1,
            this.mnuQuit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 54);
            // 
            // mnuShowToDoTasks
            // 
            this.mnuShowToDoTasks.Name = "mnuShowToDoTasks";
            this.mnuShowToDoTasks.Size = new System.Drawing.Size(170, 22);
            this.mnuShowToDoTasks.Text = "Show To Do Tasks";
            this.mnuShowToDoTasks.Click += new System.EventHandler(this.mnuShowToDoTasks_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(170, 22);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(352, 116);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(202, 51);
            this.label27.TabIndex = 4;
            this.label27.Text = "To Do Tasks";
            // 
            // lblVersionTop
            // 
            this.lblVersionTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVersionTop.AutoSize = true;
            this.lblVersionTop.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionTop.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lblVersionTop.ForeColor = System.Drawing.Color.White;
            this.lblVersionTop.Location = new System.Drawing.Point(545, 116);
            this.lblVersionTop.Name = "lblVersionTop";
            this.lblVersionTop.Size = new System.Drawing.Size(41, 32);
            this.lblVersionTop.TabIndex = 5;
            this.lblVersionTop.Text = "1.0";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(312, 196);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(142, 25);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version:    1.2.3.4";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(312, 236);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 21);
            this.label30.TabIndex = 7;
            this.label30.Text = "Authors:";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(396, 236);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 42);
            this.label31.TabIndex = 8;
            this.label31.Text = "Dương Diệu Pháp\r\nBùi Bá Lộc";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(313, 325);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(227, 21);
            this.label32.TabIndex = 9;
            this.label32.Text = "Contact:      d2phap@gmail.com";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(396, 289);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(258, 21);
            this.label33.TabIndex = 10;
            this.label33.Text = "Copyright © 2014. All rights reserved.";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tpStatus);
            this.tabs.Controls.Add(this.tpSchedule);
            this.tabs.Controls.Add(this.tpSchedule_List);
            this.tabs.Controls.Add(this.tpEditTask);
            this.tabs.Controls.Add(this.tpSettings);
            this.tabs.Controls.Add(this.tpSync);
            this.tabs.Controls.Add(this.tpLogin);
            this.tabs.Controls.Add(this.tpRegisterNewAccount);
            this.tabs.Controls.Add(this.tpAccount);
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(40, 95);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(821, 288);
            this.tabs.TabIndex = 3;
            this.tabs.TabStop = false;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tpStatus
            // 
            this.tpStatus.Controls.Add(this.lvStatus);
            this.tpStatus.Location = new System.Drawing.Point(4, 24);
            this.tpStatus.Name = "tpStatus";
            this.tpStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatus.Size = new System.Drawing.Size(813, 260);
            this.tpStatus.TabIndex = 0;
            this.tpStatus.Text = "Status";
            this.tpStatus.UseVisualStyleBackColor = true;
            // 
            // lvStatus
            // 
            this.lvStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStatus.FullRowSelect = true;
            listViewGroup1.Header = "Today";
            listViewGroup1.Name = "Today";
            listViewGroup2.Header = "Tomorrow";
            listViewGroup2.Name = "Tomorrow";
            listViewGroup3.Header = "The day after tomorrow";
            listViewGroup3.Name = "The day after tomorrow";
            listViewGroup4.Header = "Upcoming...";
            listViewGroup4.Name = "Upcoming...";
            this.lvStatus.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.lvStatus.Location = new System.Drawing.Point(3, 3);
            this.lvStatus.MultiSelect = false;
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.ShowItemToolTips = true;
            this.lvStatus.Size = new System.Drawing.Size(807, 254);
            this.lvStatus.TabIndex = 13;
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            this.lvStatus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Title";
            this.columnHeader7.Width = 340;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Start time";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "End time";
            this.columnHeader10.Width = 150;
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.tableLayoutPanel1);
            this.tpSchedule.Location = new System.Drawing.Point(4, 24);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedule.Size = new System.Drawing.Size(813, 260);
            this.tpSchedule.TabIndex = 1;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.calSchedule, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 254);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbtnFinishTask,
            this.sbtnDeleteTask,
            this.sbtnEditTask,
            this.sbtnAddTask});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(807, 40);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sbtnFinishTask
            // 
            this.sbtnFinishTask.AutoSize = false;
            this.sbtnFinishTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbtnFinishTask.Image = ((System.Drawing.Image)(resources.GetObject("sbtnFinishTask.Image")));
            this.sbtnFinishTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnFinishTask.Name = "sbtnFinishTask";
            this.sbtnFinishTask.Size = new System.Drawing.Size(32, 32);
            this.sbtnFinishTask.Text = "Finish task";
            this.sbtnFinishTask.Click += new System.EventHandler(this.sbtnFinishTask_Click);
            // 
            // sbtnDeleteTask
            // 
            this.sbtnDeleteTask.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sbtnDeleteTask.AutoSize = false;
            this.sbtnDeleteTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbtnDeleteTask.Image = ((System.Drawing.Image)(resources.GetObject("sbtnDeleteTask.Image")));
            this.sbtnDeleteTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnDeleteTask.Name = "sbtnDeleteTask";
            this.sbtnDeleteTask.Size = new System.Drawing.Size(32, 32);
            this.sbtnDeleteTask.Text = "Delete selected task";
            this.sbtnDeleteTask.Click += new System.EventHandler(this.sbtnDeleteTask_Click);
            // 
            // sbtnEditTask
            // 
            this.sbtnEditTask.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sbtnEditTask.AutoSize = false;
            this.sbtnEditTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbtnEditTask.Image = ((System.Drawing.Image)(resources.GetObject("sbtnEditTask.Image")));
            this.sbtnEditTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnEditTask.Name = "sbtnEditTask";
            this.sbtnEditTask.Size = new System.Drawing.Size(32, 32);
            this.sbtnEditTask.Text = "Edit selected task";
            this.sbtnEditTask.Click += new System.EventHandler(this.sbtnEditTask_Click);
            // 
            // sbtnAddTask
            // 
            this.sbtnAddTask.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sbtnAddTask.AutoSize = false;
            this.sbtnAddTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbtnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("sbtnAddTask.Image")));
            this.sbtnAddTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnAddTask.Name = "sbtnAddTask";
            this.sbtnAddTask.Size = new System.Drawing.Size(32, 32);
            this.sbtnAddTask.Text = "Add new task";
            this.sbtnAddTask.Click += new System.EventHandler(this.sbtnAddTask_Click);
            // 
            // calSchedule
            // 
            this.calSchedule.AllowItemEdit = false;
            this.calSchedule.AllowItemResize = false;
            this.calSchedule.AllowNew = false;
            this.calSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calSchedule.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calSchedule.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calSchedule.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calSchedule.Location = new System.Drawing.Point(3, 43);
            this.calSchedule.Name = "calSchedule";
            this.calSchedule.Size = new System.Drawing.Size(801, 208);
            this.calSchedule.TabIndex = 12;
            this.calSchedule.ItemClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calSchedule_ItemClick);
            this.calSchedule.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calSchedule_ItemDoubleClick);
            this.calSchedule.Paint += new System.Windows.Forms.PaintEventHandler(this.calSchedule_Paint);
            // 
            // tpSchedule_List
            // 
            this.tpSchedule_List.Controls.Add(this.lvScheduleList);
            this.tpSchedule_List.Controls.Add(this.toolStrip2);
            this.tpSchedule_List.Location = new System.Drawing.Point(4, 24);
            this.tpSchedule_List.Name = "tpSchedule_List";
            this.tpSchedule_List.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedule_List.Size = new System.Drawing.Size(813, 260);
            this.tpSchedule_List.TabIndex = 8;
            this.tpSchedule_List.Text = "Schedule_List";
            this.tpSchedule_List.UseVisualStyleBackColor = true;
            // 
            // lvScheduleList
            // 
            this.lvScheduleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvScheduleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvScheduleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvScheduleList.FullRowSelect = true;
            this.lvScheduleList.Location = new System.Drawing.Point(3, 43);
            this.lvScheduleList.MultiSelect = false;
            this.lvScheduleList.Name = "lvScheduleList";
            this.lvScheduleList.Size = new System.Drawing.Size(807, 214);
            this.lvScheduleList.TabIndex = 12;
            this.lvScheduleList.UseCompatibleStateImageBehavior = false;
            this.lvScheduleList.View = System.Windows.Forms.View.Details;
            this.lvScheduleList.DoubleClick += new System.EventHandler(this.lvScheduleList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 340;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Start time";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "End time";
            this.columnHeader5.Width = 150;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnScheduleList_Finish,
            this.btnScheduleList_Delete,
            this.btnScheduleList_Edit,
            this.btnScheduleList_Add});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(807, 40);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnScheduleList_Finish
            // 
            this.btnScheduleList_Finish.AutoSize = false;
            this.btnScheduleList_Finish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScheduleList_Finish.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleList_Finish.Image")));
            this.btnScheduleList_Finish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScheduleList_Finish.Name = "btnScheduleList_Finish";
            this.btnScheduleList_Finish.Size = new System.Drawing.Size(32, 32);
            this.btnScheduleList_Finish.Text = "Finish task";
            this.btnScheduleList_Finish.Click += new System.EventHandler(this.btnScheduleList_Finish_Click);
            // 
            // btnScheduleList_Delete
            // 
            this.btnScheduleList_Delete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnScheduleList_Delete.AutoSize = false;
            this.btnScheduleList_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScheduleList_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleList_Delete.Image")));
            this.btnScheduleList_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScheduleList_Delete.Name = "btnScheduleList_Delete";
            this.btnScheduleList_Delete.Size = new System.Drawing.Size(32, 32);
            this.btnScheduleList_Delete.Text = "Delete selected task";
            this.btnScheduleList_Delete.Click += new System.EventHandler(this.btnScheduleList_Delete_Click);
            // 
            // btnScheduleList_Edit
            // 
            this.btnScheduleList_Edit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnScheduleList_Edit.AutoSize = false;
            this.btnScheduleList_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScheduleList_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleList_Edit.Image")));
            this.btnScheduleList_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScheduleList_Edit.Name = "btnScheduleList_Edit";
            this.btnScheduleList_Edit.Size = new System.Drawing.Size(32, 32);
            this.btnScheduleList_Edit.Text = "Edit selected task";
            this.btnScheduleList_Edit.Click += new System.EventHandler(this.btnScheduleList_Edit_Click);
            // 
            // btnScheduleList_Add
            // 
            this.btnScheduleList_Add.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnScheduleList_Add.AutoSize = false;
            this.btnScheduleList_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScheduleList_Add.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleList_Add.Image")));
            this.btnScheduleList_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScheduleList_Add.Name = "btnScheduleList_Add";
            this.btnScheduleList_Add.Size = new System.Drawing.Size(32, 32);
            this.btnScheduleList_Add.Text = "Add new task";
            this.btnScheduleList_Add.Click += new System.EventHandler(this.btnScheduleList_Add_Click);
            // 
            // tpEditTask
            // 
            this.tpEditTask.AutoScroll = true;
            this.tpEditTask.Controls.Add(this.txtIndexTaskEdit);
            this.tpEditTask.Controls.Add(this.numTaskRepeatTimes);
            this.tpEditTask.Controls.Add(this.label28);
            this.tpEditTask.Controls.Add(this.btnTaskRemoveRemindTime);
            this.tpEditTask.Controls.Add(this.panel1);
            this.tpEditTask.Controls.Add(this.btnTaskAddRemindTime);
            this.tpEditTask.Controls.Add(this.label26);
            this.tpEditTask.Controls.Add(this.numTaskAddRemindTime);
            this.tpEditTask.Controls.Add(this.lstTaskRemindTime);
            this.tpEditTask.Controls.Add(this.label25);
            this.tpEditTask.Controls.Add(this.chkTaskRemindType_Email);
            this.tpEditTask.Controls.Add(this.chkTaskRemindType_Sound);
            this.tpEditTask.Controls.Add(this.chkTaskRemindType_Notification);
            this.tpEditTask.Controls.Add(this.label24);
            this.tpEditTask.Controls.Add(this.numTaskRepeatUnit);
            this.tpEditTask.Controls.Add(this.cmbTaskRepeatType);
            this.tpEditTask.Controls.Add(this.label23);
            this.tpEditTask.Controls.Add(this.label22);
            this.tpEditTask.Controls.Add(this.dtpTaskEndTime);
            this.tpEditTask.Controls.Add(this.dtpTaskStartTime);
            this.tpEditTask.Controls.Add(this.label21);
            this.tpEditTask.Controls.Add(this.label20);
            this.tpEditTask.Controls.Add(this.picTaskColor);
            this.tpEditTask.Controls.Add(this.txtTaskDescription);
            this.tpEditTask.Controls.Add(this.txtTaskPlace);
            this.tpEditTask.Controls.Add(this.txtTaskTitle);
            this.tpEditTask.Controls.Add(this.label19);
            this.tpEditTask.Controls.Add(this.label18);
            this.tpEditTask.Controls.Add(this.label17);
            this.tpEditTask.Controls.Add(this.label16);
            this.tpEditTask.Location = new System.Drawing.Point(4, 24);
            this.tpEditTask.Name = "tpEditTask";
            this.tpEditTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditTask.Size = new System.Drawing.Size(813, 260);
            this.tpEditTask.TabIndex = 2;
            this.tpEditTask.Text = "Edit task";
            this.tpEditTask.UseVisualStyleBackColor = true;
            // 
            // txtIndexTaskEdit
            // 
            this.txtIndexTaskEdit.Location = new System.Drawing.Point(420, 154);
            this.txtIndexTaskEdit.Name = "txtIndexTaskEdit";
            this.txtIndexTaskEdit.Size = new System.Drawing.Size(76, 23);
            this.txtIndexTaskEdit.TabIndex = 30;
            this.txtIndexTaskEdit.Visible = false;
            // 
            // numTaskRepeatTimes
            // 
            this.numTaskRepeatTimes.Location = new System.Drawing.Point(157, 299);
            this.numTaskRepeatTimes.Name = "numTaskRepeatTimes";
            this.numTaskRepeatTimes.Size = new System.Drawing.Size(159, 23);
            this.numTaskRepeatTimes.TabIndex = 29;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(38, 301);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 15);
            this.label28.TabIndex = 28;
            this.label28.Text = "Repeat time(s):";
            // 
            // btnTaskRemoveRemindTime
            // 
            this.btnTaskRemoveRemindTime.Location = new System.Drawing.Point(354, 420);
            this.btnTaskRemoveRemindTime.Name = "btnTaskRemoveRemindTime";
            this.btnTaskRemoveRemindTime.Size = new System.Drawing.Size(69, 23);
            this.btnTaskRemoveRemindTime.TabIndex = 27;
            this.btnTaskRemoveRemindTime.Text = "Remove";
            this.btnTaskRemoveRemindTime.UseVisualStyleBackColor = true;
            this.btnTaskRemoveRemindTime.Click += new System.EventHandler(this.btnTaskRemoveRemindTime_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 90);
            this.panel1.TabIndex = 26;
            // 
            // btnTaskAddRemindTime
            // 
            this.btnTaskAddRemindTime.Location = new System.Drawing.Point(298, 420);
            this.btnTaskAddRemindTime.Name = "btnTaskAddRemindTime";
            this.btnTaskAddRemindTime.Size = new System.Drawing.Size(50, 23);
            this.btnTaskAddRemindTime.TabIndex = 25;
            this.btnTaskAddRemindTime.Text = "Add";
            this.btnTaskAddRemindTime.UseVisualStyleBackColor = true;
            this.btnTaskAddRemindTime.Click += new System.EventHandler(this.btnTaskAddRemindTime_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(224, 424);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 15);
            this.label26.TabIndex = 24;
            this.label26.Text = "minute(s)";
            // 
            // numTaskAddRemindTime
            // 
            this.numTaskAddRemindTime.Location = new System.Drawing.Point(157, 422);
            this.numTaskAddRemindTime.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numTaskAddRemindTime.Name = "numTaskAddRemindTime";
            this.numTaskAddRemindTime.Size = new System.Drawing.Size(61, 23);
            this.numTaskAddRemindTime.TabIndex = 23;
            this.numTaskAddRemindTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lstTaskRemindTime
            // 
            this.lstTaskRemindTime.FormattingEnabled = true;
            this.lstTaskRemindTime.ItemHeight = 15;
            this.lstTaskRemindTime.Location = new System.Drawing.Point(157, 352);
            this.lstTaskRemindTime.Name = "lstTaskRemindTime";
            this.lstTaskRemindTime.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTaskRemindTime.Size = new System.Drawing.Size(266, 64);
            this.lstTaskRemindTime.Sorted = true;
            this.lstTaskRemindTime.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(38, 352);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 15);
            this.label25.TabIndex = 21;
            this.label25.Text = "Remind time:";
            // 
            // chkTaskRemindType_Email
            // 
            this.chkTaskRemindType_Email.AutoSize = true;
            this.chkTaskRemindType_Email.Location = new System.Drawing.Point(318, 327);
            this.chkTaskRemindType_Email.Name = "chkTaskRemindType_Email";
            this.chkTaskRemindType_Email.Size = new System.Drawing.Size(55, 19);
            this.chkTaskRemindType_Email.TabIndex = 20;
            this.chkTaskRemindType_Email.Text = "Email";
            this.chkTaskRemindType_Email.UseVisualStyleBackColor = true;
            // 
            // chkTaskRemindType_Sound
            // 
            this.chkTaskRemindType_Sound.AutoSize = true;
            this.chkTaskRemindType_Sound.Checked = true;
            this.chkTaskRemindType_Sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTaskRemindType_Sound.Location = new System.Drawing.Point(252, 327);
            this.chkTaskRemindType_Sound.Name = "chkTaskRemindType_Sound";
            this.chkTaskRemindType_Sound.Size = new System.Drawing.Size(60, 19);
            this.chkTaskRemindType_Sound.TabIndex = 19;
            this.chkTaskRemindType_Sound.Text = "Sound";
            this.chkTaskRemindType_Sound.UseVisualStyleBackColor = true;
            // 
            // chkTaskRemindType_Notification
            // 
            this.chkTaskRemindType_Notification.AutoSize = true;
            this.chkTaskRemindType_Notification.Checked = true;
            this.chkTaskRemindType_Notification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTaskRemindType_Notification.Location = new System.Drawing.Point(157, 327);
            this.chkTaskRemindType_Notification.Name = "chkTaskRemindType_Notification";
            this.chkTaskRemindType_Notification.Size = new System.Drawing.Size(89, 19);
            this.chkTaskRemindType_Notification.TabIndex = 18;
            this.chkTaskRemindType_Notification.Text = "Notification";
            this.chkTaskRemindType_Notification.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(38, 328);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 15);
            this.label24.TabIndex = 17;
            this.label24.Text = "Remind types:";
            // 
            // numTaskRepeatUnit
            // 
            this.numTaskRepeatUnit.Location = new System.Drawing.Point(157, 270);
            this.numTaskRepeatUnit.Name = "numTaskRepeatUnit";
            this.numTaskRepeatUnit.Size = new System.Drawing.Size(159, 23);
            this.numTaskRepeatUnit.TabIndex = 16;
            // 
            // cmbTaskRepeatType
            // 
            this.cmbTaskRepeatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskRepeatType.FormattingEnabled = true;
            this.cmbTaskRepeatType.Items.AddRange(new object[] {
            "Unique",
            "Repeated"});
            this.cmbTaskRepeatType.Location = new System.Drawing.Point(157, 241);
            this.cmbTaskRepeatType.Name = "cmbTaskRepeatType";
            this.cmbTaskRepeatType.Size = new System.Drawing.Size(159, 23);
            this.cmbTaskRepeatType.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(38, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 15);
            this.label23.TabIndex = 14;
            this.label23.Text = "Repeated unit (day):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(38, 244);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 15);
            this.label22.TabIndex = 12;
            this.label22.Text = "Repeat type:";
            // 
            // dtpTaskEndTime
            // 
            this.dtpTaskEndTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpTaskEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskEndTime.Location = new System.Drawing.Point(157, 212);
            this.dtpTaskEndTime.Name = "dtpTaskEndTime";
            this.dtpTaskEndTime.Size = new System.Drawing.Size(159, 23);
            this.dtpTaskEndTime.TabIndex = 11;
            // 
            // dtpTaskStartTime
            // 
            this.dtpTaskStartTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpTaskStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskStartTime.Location = new System.Drawing.Point(157, 183);
            this.dtpTaskStartTime.Name = "dtpTaskStartTime";
            this.dtpTaskStartTime.Size = new System.Drawing.Size(159, 23);
            this.dtpTaskStartTime.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 218);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 15);
            this.label21.TabIndex = 9;
            this.label21.Text = "End time:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(38, 189);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 15);
            this.label20.TabIndex = 8;
            this.label20.Text = "Start time:";
            // 
            // picTaskColor
            // 
            this.picTaskColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.picTaskColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTaskColor.Location = new System.Drawing.Point(157, 154);
            this.picTaskColor.Name = "picTaskColor";
            this.picTaskColor.Size = new System.Drawing.Size(61, 23);
            this.picTaskColor.TabIndex = 7;
            this.picTaskColor.TabStop = false;
            this.picTaskColor.Click += new System.EventHandler(this.picTaskColor_Click);
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(157, 84);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(339, 64);
            this.txtTaskDescription.TabIndex = 6;
            // 
            // txtTaskPlace
            // 
            this.txtTaskPlace.Location = new System.Drawing.Point(157, 56);
            this.txtTaskPlace.Name = "txtTaskPlace";
            this.txtTaskPlace.Size = new System.Drawing.Size(339, 23);
            this.txtTaskPlace.TabIndex = 5;
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(157, 27);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(339, 23);
            this.txtTaskTitle.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "Color:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Description:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Place:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Title:";
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.lnkStartSync);
            this.tpSettings.Controls.Add(this.lblLastSync);
            this.tpSettings.Controls.Add(this.lblVolumeValue);
            this.tpSettings.Controls.Add(this.btnSoundBrowse);
            this.tpSettings.Controls.Add(this.txtSoundFile);
            this.tpSettings.Controls.Add(this.label15);
            this.tpSettings.Controls.Add(this.chkHideOnMinimizing);
            this.tpSettings.Controls.Add(this.chkHideOnStarting);
            this.tpSettings.Controls.Add(this.chkStartWithOS);
            this.tpSettings.Controls.Add(this.trbVolume);
            this.tpSettings.Controls.Add(this.label14);
            this.tpSettings.Controls.Add(this.label13);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(813, 260);
            this.tpSettings.TabIndex = 3;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // lnkStartSync
            // 
            this.lnkStartSync.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(161)))), ((int)(((byte)(204)))));
            this.lnkStartSync.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkStartSync.AutoSize = true;
            this.lnkStartSync.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(161)))), ((int)(((byte)(204)))));
            this.lnkStartSync.Location = new System.Drawing.Point(335, 225);
            this.lnkStartSync.Name = "lnkStartSync";
            this.lnkStartSync.Size = new System.Drawing.Size(84, 15);
            this.lnkStartSync.TabIndex = 20;
            this.lnkStartSync.TabStop = true;
            this.lnkStartSync.Text = "Start sync now";
            this.lnkStartSync.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(161)))), ((int)(((byte)(204)))));
            this.lnkStartSync.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStartSync_LinkClicked);
            // 
            // lblLastSync
            // 
            this.lblLastSync.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastSync.AutoSize = true;
            this.lblLastSync.Location = new System.Drawing.Point(281, 205);
            this.lblLastSync.Name = "lblLastSync";
            this.lblLastSync.Size = new System.Drawing.Size(58, 15);
            this.lblLastSync.TabIndex = 19;
            this.lblLastSync.Text = "Last sync:";
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVolumeValue.AutoSize = true;
            this.lblVolumeValue.Location = new System.Drawing.Point(500, 69);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(25, 15);
            this.lblVolumeValue.TabIndex = 18;
            this.lblVolumeValue.Text = "800";
            // 
            // btnSoundBrowse
            // 
            this.btnSoundBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSoundBrowse.Location = new System.Drawing.Point(500, 174);
            this.btnSoundBrowse.Name = "btnSoundBrowse";
            this.btnSoundBrowse.Size = new System.Drawing.Size(42, 25);
            this.btnSoundBrowse.TabIndex = 17;
            this.btnSoundBrowse.Text = "...";
            this.btnSoundBrowse.UseVisualStyleBackColor = true;
            this.btnSoundBrowse.Click += new System.EventHandler(this.btnSoundBrowse_Click);
            // 
            // txtSoundFile
            // 
            this.txtSoundFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoundFile.Location = new System.Drawing.Point(331, 175);
            this.txtSoundFile.Name = "txtSoundFile";
            this.txtSoundFile.Size = new System.Drawing.Size(163, 23);
            this.txtSoundFile.TabIndex = 16;
            this.txtSoundFile.TextChanged += new System.EventHandler(this.txtSoundFile_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Sound:";
            // 
            // chkHideOnMinimizing
            // 
            this.chkHideOnMinimizing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkHideOnMinimizing.AutoSize = true;
            this.chkHideOnMinimizing.Location = new System.Drawing.Point(284, 145);
            this.chkHideOnMinimizing.Name = "chkHideOnMinimizing";
            this.chkHideOnMinimizing.Size = new System.Drawing.Size(176, 19);
            this.chkHideOnMinimizing.TabIndex = 14;
            this.chkHideOnMinimizing.Text = "Hide window on minimizing";
            this.chkHideOnMinimizing.UseVisualStyleBackColor = true;
            this.chkHideOnMinimizing.CheckedChanged += new System.EventHandler(this.chkHideOnMinimizing_CheckedChanged);
            // 
            // chkHideOnStarting
            // 
            this.chkHideOnStarting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkHideOnStarting.AutoSize = true;
            this.chkHideOnStarting.Location = new System.Drawing.Point(284, 120);
            this.chkHideOnStarting.Name = "chkHideOnStarting";
            this.chkHideOnStarting.Size = new System.Drawing.Size(156, 19);
            this.chkHideOnStarting.TabIndex = 13;
            this.chkHideOnStarting.Text = "Hide window on starting";
            this.chkHideOnStarting.UseVisualStyleBackColor = true;
            this.chkHideOnStarting.CheckedChanged += new System.EventHandler(this.chkHideOnStarting_CheckedChanged);
            // 
            // chkStartWithOS
            // 
            this.chkStartWithOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkStartWithOS.AutoSize = true;
            this.chkStartWithOS.Location = new System.Drawing.Point(284, 96);
            this.chkStartWithOS.Name = "chkStartWithOS";
            this.chkStartWithOS.Size = new System.Drawing.Size(128, 19);
            this.chkStartWithOS.TabIndex = 12;
            this.chkStartWithOS.Text = "Start with Windows";
            this.chkStartWithOS.UseVisualStyleBackColor = true;
            this.chkStartWithOS.CheckedChanged += new System.EventHandler(this.chkStartWithOS_CheckedChanged);
            // 
            // trbVolume
            // 
            this.trbVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trbVolume.BackColor = System.Drawing.Color.White;
            this.trbVolume.Location = new System.Drawing.Point(338, 69);
            this.trbVolume.Maximum = 1000;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(156, 45);
            this.trbVolume.TabIndex = 11;
            this.trbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbVolume.Value = 800;
            this.trbVolume.Scroll += new System.EventHandler(this.trbVolume_Scroll);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label14.Location = new System.Drawing.Point(344, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 37);
            this.label14.TabIndex = 10;
            this.label14.Text = "Settings";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Volume:";
            // 
            // tpSync
            // 
            this.tpSync.Controls.Add(this.dtSyncEnd);
            this.tpSync.Controls.Add(this.label12);
            this.tpSync.Controls.Add(this.label11);
            this.tpSync.Controls.Add(this.dtSyncStart);
            this.tpSync.Controls.Add(this.radCustomSync);
            this.tpSync.Controls.Add(this.radCompleteSync);
            this.tpSync.Controls.Add(this.label10);
            this.tpSync.Location = new System.Drawing.Point(4, 24);
            this.tpSync.Name = "tpSync";
            this.tpSync.Padding = new System.Windows.Forms.Padding(3);
            this.tpSync.Size = new System.Drawing.Size(813, 260);
            this.tpSync.TabIndex = 4;
            this.tpSync.Text = "Sync";
            this.tpSync.UseVisualStyleBackColor = true;
            // 
            // dtSyncEnd
            // 
            this.dtSyncEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtSyncEnd.Enabled = false;
            this.dtSyncEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSyncEnd.Location = new System.Drawing.Point(364, 176);
            this.dtSyncEnd.Name = "dtSyncEnd";
            this.dtSyncEnd.Size = new System.Drawing.Size(155, 23);
            this.dtSyncEnd.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "End";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Start";
            // 
            // dtSyncStart
            // 
            this.dtSyncStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtSyncStart.Enabled = false;
            this.dtSyncStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSyncStart.Location = new System.Drawing.Point(364, 147);
            this.dtSyncStart.Name = "dtSyncStart";
            this.dtSyncStart.Size = new System.Drawing.Size(155, 23);
            this.dtSyncStart.TabIndex = 12;
            // 
            // radCustomSync
            // 
            this.radCustomSync.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCustomSync.AutoSize = true;
            this.radCustomSync.Location = new System.Drawing.Point(312, 122);
            this.radCustomSync.Name = "radCustomSync";
            this.radCustomSync.Size = new System.Drawing.Size(94, 19);
            this.radCustomSync.TabIndex = 11;
            this.radCustomSync.Text = "Custom sync";
            this.radCustomSync.UseVisualStyleBackColor = true;
            this.radCustomSync.CheckedChanged += new System.EventHandler(this.radCustomSync_CheckedChanged);
            // 
            // radCompleteSync
            // 
            this.radCompleteSync.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCompleteSync.AutoSize = true;
            this.radCompleteSync.Checked = true;
            this.radCompleteSync.Location = new System.Drawing.Point(312, 97);
            this.radCompleteSync.Name = "radCompleteSync";
            this.radCompleteSync.Size = new System.Drawing.Size(104, 19);
            this.radCompleteSync.TabIndex = 10;
            this.radCompleteSync.TabStop = true;
            this.radCompleteSync.Text = "Complete sync";
            this.radCompleteSync.UseVisualStyleBackColor = true;
            this.radCompleteSync.CheckedChanged += new System.EventHandler(this.radCompleteSync_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label10.Location = new System.Drawing.Point(391, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 37);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sync";
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.label4);
            this.tpLogin.Controls.Add(this.txtLogInPassword);
            this.tpLogin.Controls.Add(this.label3);
            this.tpLogin.Controls.Add(this.txtLogInEmail);
            this.tpLogin.Controls.Add(this.label2);
            this.tpLogin.Location = new System.Drawing.Point(4, 24);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(813, 260);
            this.tpLogin.TabIndex = 5;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label4.Location = new System.Drawing.Point(378, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Log in";
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogInPassword.Location = new System.Drawing.Point(320, 130);
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.Size = new System.Drawing.Size(222, 23);
            this.txtLogInPassword.TabIndex = 3;
            this.txtLogInPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(244, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtLogInEmail
            // 
            this.txtLogInEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogInEmail.Location = new System.Drawing.Point(320, 101);
            this.txtLogInEmail.Name = "txtLogInEmail";
            this.txtLogInEmail.Size = new System.Drawing.Size(222, 23);
            this.txtLogInEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(244, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // tpRegisterNewAccount
            // 
            this.tpRegisterNewAccount.Controls.Add(this.txtAccountName);
            this.tpRegisterNewAccount.Controls.Add(this.label9);
            this.tpRegisterNewAccount.Controls.Add(this.txtAccountConfirmPassword);
            this.tpRegisterNewAccount.Controls.Add(this.label8);
            this.tpRegisterNewAccount.Controls.Add(this.label5);
            this.tpRegisterNewAccount.Controls.Add(this.txtAccountPassword);
            this.tpRegisterNewAccount.Controls.Add(this.label6);
            this.tpRegisterNewAccount.Controls.Add(this.txtAccountEmail);
            this.tpRegisterNewAccount.Controls.Add(this.label7);
            this.tpRegisterNewAccount.Location = new System.Drawing.Point(4, 24);
            this.tpRegisterNewAccount.Name = "tpRegisterNewAccount";
            this.tpRegisterNewAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegisterNewAccount.Size = new System.Drawing.Size(813, 260);
            this.tpRegisterNewAccount.TabIndex = 6;
            this.tpRegisterNewAccount.Text = "Register";
            this.tpRegisterNewAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountName.Location = new System.Drawing.Point(355, 94);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(209, 23);
            this.txtAccountName.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(227, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Name:";
            // 
            // txtAccountConfirmPassword
            // 
            this.txtAccountConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountConfirmPassword.Location = new System.Drawing.Point(355, 181);
            this.txtAccountConfirmPassword.Name = "txtAccountConfirmPassword";
            this.txtAccountConfirmPassword.Size = new System.Drawing.Size(209, 23);
            this.txtAccountConfirmPassword.TabIndex = 11;
            this.txtAccountConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(227, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Re-type password:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label5.Location = new System.Drawing.Point(35, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(742, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Register new account";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountPassword.Location = new System.Drawing.Point(355, 152);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(209, 23);
            this.txtAccountPassword.TabIndex = 8;
            this.txtAccountPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(227, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            // 
            // txtAccountEmail
            // 
            this.txtAccountEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountEmail.Location = new System.Drawing.Point(355, 123);
            this.txtAccountEmail.Name = "txtAccountEmail";
            this.txtAccountEmail.Size = new System.Drawing.Size(209, 23);
            this.txtAccountEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(227, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email:";
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.lblAccountName);
            this.tpAccount.Location = new System.Drawing.Point(4, 24);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(813, 260);
            this.tpAccount.TabIndex = 7;
            this.tpAccount.Text = "Account";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(93, 102);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(628, 37);
            this.lblAccountName.TabIndex = 5;
            this.lblAccountName.Text = "Welcome #";
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(903, 486);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblVersionTop);
            this.Controls.Add(this.label27);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 510);
            this.Name = "frmMain";
            this.Text = "To Do Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panControl.ResumeLayout(false);
            this.panControl.PerformLayout();
            this.tabsFun.ResumeLayout(false);
            this.tpFunStatus.ResumeLayout(false);
            this.tpFunSchedule.ResumeLayout(false);
            this.tpFunScheduleNewTask.ResumeLayout(false);
            this.tpFunScheduleEditTask.ResumeLayout(false);
            this.tpFunSettingsSync.ResumeLayout(false);
            this.tpFunLogin.ResumeLayout(false);
            this.tpFunLoginNewAccount.ResumeLayout(false);
            this.tpFunLogout.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tpStatus.ResumeLayout(false);
            this.tpSchedule.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tpSchedule_List.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tpEditTask.ResumeLayout(false);
            this.tpEditTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskRepeatTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskAddRemindTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskRepeatUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaskColor)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            this.tpSync.ResumeLayout(false);
            this.tpSync.PerformLayout();
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.tpRegisterNewAccount.ResumeLayout(false);
            this.tpRegisterNewAccount.PerformLayout();
            this.tpAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panControl;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rabTabStatus;
        private System.Windows.Forms.RadioButton radTabLogin;
        private System.Windows.Forms.RadioButton radTabSettings;
        private System.Windows.Forms.RadioButton radTabSchedule;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timSys;
        private TabPagesControl tabs;
        private System.Windows.Forms.TabPage tpStatus;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.TabPage tpEditTask;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpSync;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TabPage tpRegisterNewAccount;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.TabPage tpAccount;
        private TabPagesControl tabsFun;
        private System.Windows.Forms.TabPage tpFunStatus;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMinimizeToSystemTray;
        private System.Windows.Forms.TabPage tpFunLogin;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TabPage tpFunSchedule;
        private System.Windows.Forms.TabPage tpFunScheduleNewTask;
        private System.Windows.Forms.TabPage tpFunScheduleEditTask;
        private System.Windows.Forms.TabPage tpFunSettingsSync;
        private System.Windows.Forms.TabPage tpFunLoginNewAccount;
        private System.Windows.Forms.Button btnAccountOK;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogInEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TabPage tpFunLogout;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccountEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAccountConfirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSyncCancel;
        private System.Windows.Forms.Button btnAccountCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radCustomSync;
        private System.Windows.Forms.RadioButton radCompleteSync;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtSyncStart;
        private System.Windows.Forms.DateTimePicker dtSyncEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.CheckBox chkHideOnStarting;
        private System.Windows.Forms.CheckBox chkStartWithOS;
        private System.Windows.Forms.CheckBox chkHideOnMinimizing;
        private System.Windows.Forms.Button btnSoundBrowse;
        private System.Windows.Forms.TextBox txtSoundFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLastSync;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.LinkLabel lnkStartSync;
        private System.Windows.Forms.RadioButton radScheduleList;
        private System.Windows.Forms.RadioButton radScheduleMonth;
        private System.Windows.Forms.RadioButton radScheduleWeek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton sbtnFinishTask;
        private System.Windows.Forms.ToolStripButton sbtnDeleteTask;
        private System.Windows.Forms.ToolStripButton sbtnEditTask;
        private System.Windows.Forms.ToolStripButton sbtnAddTask;
        private System.Windows.Forms.TabPage tpFunSettings;
        private System.Windows.Forms.Calendar.Calendar calSchedule;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picTaskColor;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskPlace;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpTaskStartTime;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpTaskEndTime;
        private System.Windows.Forms.NumericUpDown numTaskRepeatUnit;
        private System.Windows.Forms.ComboBox cmbTaskRepeatType;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkTaskRemindType_Email;
        private System.Windows.Forms.CheckBox chkTaskRemindType_Sound;
        private System.Windows.Forms.CheckBox chkTaskRemindType_Notification;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnTaskAddRemindTime;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown numTaskAddRemindTime;
        private System.Windows.Forms.ListBox lstTaskRemindTime;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelAddNewTask;
        private System.Windows.Forms.Button btnOKAddNewTask;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblVersionTop;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuShowToDoTasks;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.Button btnTaskRemoveRemindTime;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.NumericUpDown numTaskRepeatTimes;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnCancelEditTask;
        private System.Windows.Forms.Button btnOKEditTask;
        private System.Windows.Forms.TextBox txtIndexTaskEdit;
        private System.Windows.Forms.TabPage tpSchedule_List;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnScheduleList_Finish;
        private System.Windows.Forms.ToolStripButton btnScheduleList_Delete;
        private System.Windows.Forms.ToolStripButton btnScheduleList_Edit;
        private System.Windows.Forms.ToolStripButton btnScheduleList_Add;
        private System.Windows.Forms.ListView lvScheduleList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvStatus;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;



    }
}

