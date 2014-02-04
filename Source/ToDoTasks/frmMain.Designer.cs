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
            this.panMenu = new System.Windows.Forms.Panel();
            this.radTabLogin = new System.Windows.Forms.RadioButton();
            this.radTabSettings = new System.Windows.Forms.RadioButton();
            this.radTabSchedule = new System.Windows.Forms.RadioButton();
            this.rabTabStatus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panControl = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timSys = new System.Windows.Forms.Timer(this.components);
            this.panStatus = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panControl.SuspendLayout();
            this.panStatus.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "To do tasks";
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
            this.panControl.Controls.Add(this.button3);
            this.panControl.Controls.Add(this.button2);
            this.panControl.Controls.Add(this.lblDate);
            this.panControl.Controls.Add(this.lblTime);
            this.panControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panControl.Location = new System.Drawing.Point(0, 406);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(903, 80);
            this.panControl.TabIndex = 1;
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
            // panStatus
            // 
            this.panStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panStatus.BackColor = System.Drawing.Color.White;
            this.panStatus.Controls.Add(this.button16);
            this.panStatus.Controls.Add(this.button17);
            this.panStatus.Controls.Add(this.button15);
            this.panStatus.Controls.Add(this.button14);
            this.panStatus.Controls.Add(this.button12);
            this.panStatus.Controls.Add(this.button13);
            this.panStatus.Controls.Add(this.button11);
            this.panStatus.Controls.Add(this.button10);
            this.panStatus.Controls.Add(this.button9);
            this.panStatus.Controls.Add(this.button8);
            this.panStatus.Controls.Add(this.button7);
            this.panStatus.Controls.Add(this.button6);
            this.panStatus.Controls.Add(this.button5);
            this.panStatus.Controls.Add(this.button4);
            this.panStatus.Controls.Add(this.button1);
            this.panStatus.Location = new System.Drawing.Point(55, 105);
            this.panStatus.Name = "panStatus";
            this.panStatus.Size = new System.Drawing.Size(792, 265);
            this.panStatus.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(622, 21);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(203, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Minimize to system tray";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(831, 21);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10);
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 3;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(17, 201);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(88, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "OK";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(111, 201);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10);
            this.button5.Size = new System.Drawing.Size(108, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cancel";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(423, 19);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10);
            this.button6.Size = new System.Drawing.Size(110, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Normal";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(539, 19);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10);
            this.button7.Size = new System.Drawing.Size(110, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Week";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(655, 19);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10);
            this.button8.Size = new System.Drawing.Size(110, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Month";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(423, 84);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10);
            this.button9.Size = new System.Drawing.Size(94, 45);
            this.button9.TabIndex = 8;
            this.button9.Text = "Sync";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(523, 84);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(10);
            this.button10.Size = new System.Drawing.Size(101, 45);
            this.button10.TabIndex = 9;
            this.button10.Text = "Log in";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(630, 84);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(10);
            this.button11.Size = new System.Drawing.Size(140, 45);
            this.button11.TabIndex = 10;
            this.button11.Text = "New account";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(674, 201);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(10);
            this.button12.Size = new System.Drawing.Size(45, 45);
            this.button12.TabIndex = 12;
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(623, 201);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(10);
            this.button13.Size = new System.Drawing.Size(45, 45);
            this.button13.TabIndex = 11;
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(572, 201);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(10);
            this.button14.Size = new System.Drawing.Size(45, 45);
            this.button14.TabIndex = 13;
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(725, 201);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(10);
            this.button15.Size = new System.Drawing.Size(45, 45);
            this.button15.TabIndex = 14;
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(423, 201);
            this.button16.Name = "button16";
            this.button16.Padding = new System.Windows.Forms.Padding(10);
            this.button16.Size = new System.Drawing.Size(45, 45);
            this.button16.TabIndex = 16;
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(474, 201);
            this.button17.Name = "button17";
            this.button17.Padding = new System.Windows.Forms.Padding(10);
            this.button17.Size = new System.Drawing.Size(45, 45);
            this.button17.TabIndex = 15;
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(903, 486);
            this.Controls.Add(this.panStatus);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.panMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 510);
            this.Name = "frmMain";
            this.Text = "To do tasks";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panControl.ResumeLayout(false);
            this.panControl.PerformLayout();
            this.panStatus.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;



    }
}

