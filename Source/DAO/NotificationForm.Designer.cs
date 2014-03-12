namespace DAO
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panBot = new System.Windows.Forms.Panel();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.chkClose = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(161)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notification";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(46, 46);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panBot
            // 
            this.panBot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panBot.BackColor = System.Drawing.Color.White;
            this.panBot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panBot.BackgroundImage")));
            this.panBot.Controls.Add(this.lblNoiDung);
            this.panBot.Location = new System.Drawing.Point(0, 69);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(904, 260);
            this.panBot.TabIndex = 2;
            this.panBot.Paint += new System.Windows.Forms.PaintEventHandler(this.panBot_Paint);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNoiDung.ForeColor = System.Drawing.Color.White;
            this.lblNoiDung.Location = new System.Drawing.Point(42, 19);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(821, 219);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkClose
            // 
            this.chkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkClose.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkClose.AutoCheck = false;
            this.chkClose.FlatAppearance.BorderSize = 0;
            this.chkClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(161)))), ((int)(((byte)(204)))));
            this.chkClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(231)))), ((int)(((byte)(249)))));
            this.chkClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkClose.Location = new System.Drawing.Point(855, 2);
            this.chkClose.Name = "chkClose";
            this.chkClose.Size = new System.Drawing.Size(47, 29);
            this.chkClose.TabIndex = 1;
            this.chkClose.Text = "X";
            this.chkClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkClose.UseVisualStyleBackColor = true;
            this.chkClose.CheckedChanged += new System.EventHandler(this.chkClose_CheckedChanged);
            this.chkClose.Click += new System.EventHandler(this.chkClose_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(904, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkClose);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.picLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NotificationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NotificationForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panBot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panBot;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.CheckBox chkClose;
    }
}