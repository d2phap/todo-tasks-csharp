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
            this.panControl = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rabTabStatus = new System.Windows.Forms.RadioButton();
            this.radTabSchedule = new System.Windows.Forms.RadioButton();
            this.radTabSettings = new System.Windows.Forms.RadioButton();
            this.radTabLogin = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timSys = new System.Windows.Forms.Timer(this.components);
            this.panMenu.SuspendLayout();
            this.panControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.panMenu.Size = new System.Drawing.Size(919, 70);
            this.panMenu.TabIndex = 0;
            // 
            // panControl
            // 
            this.panControl.BackColor = System.Drawing.Color.White;
            this.panControl.Controls.Add(this.lblDate);
            this.panControl.Controls.Add(this.lblTime);
            this.panControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panControl.Location = new System.Drawing.Point(0, 406);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(919, 80);
            this.panControl.TabIndex = 1;
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
            this.rabTabStatus.Location = new System.Drawing.Point(436, 0);
            this.rabTabStatus.Name = "rabTabStatus";
            this.rabTabStatus.Size = new System.Drawing.Size(120, 70);
            this.rabTabStatus.TabIndex = 2;
            this.rabTabStatus.TabStop = true;
            this.rabTabStatus.Text = "Status";
            this.rabTabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rabTabStatus.UseVisualStyleBackColor = false;
            this.rabTabStatus.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
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
            this.radTabSchedule.Location = new System.Drawing.Point(557, 0);
            this.radTabSchedule.Name = "radTabSchedule";
            this.radTabSchedule.Size = new System.Drawing.Size(120, 70);
            this.radTabSchedule.TabIndex = 9;
            this.radTabSchedule.TabStop = true;
            this.radTabSchedule.Text = "Schedule";
            this.radTabSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabSchedule.UseVisualStyleBackColor = false;
            this.radTabSchedule.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
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
            this.radTabSettings.Location = new System.Drawing.Point(678, 0);
            this.radTabSettings.Name = "radTabSettings";
            this.radTabSettings.Size = new System.Drawing.Size(120, 70);
            this.radTabSettings.TabIndex = 10;
            this.radTabSettings.TabStop = true;
            this.radTabSettings.Text = "Settings";
            this.radTabSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabSettings.UseVisualStyleBackColor = false;
            this.radTabSettings.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
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
            this.radTabLogin.Location = new System.Drawing.Point(799, 0);
            this.radTabLogin.Name = "radTabLogin";
            this.radTabLogin.Size = new System.Drawing.Size(120, 70);
            this.radTabLogin.TabIndex = 11;
            this.radTabLogin.TabStop = true;
            this.radTabLogin.Text = "Log in";
            this.radTabLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabLogin.UseVisualStyleBackColor = false;
            this.radTabLogin.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
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
            // timSys
            // 
            this.timSys.Enabled = true;
            this.timSys.Interval = 1000;
            this.timSys.Tick += new System.EventHandler(this.timSys_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(919, 486);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.panMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 510);
            this.Name = "frmMain";
            this.Text = "To do tasks";
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panControl.ResumeLayout(false);
            this.panControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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



    }
}

