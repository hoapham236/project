namespace HotelManagement_FinalProject
{
    partial class CheckInOutCleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInOutCleaner));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxCheckout = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckin = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ButtonCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonCheckin = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2HtmlLabelNameCa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.pictureBoxCheckout);
            this.guna2Panel1.Controls.Add(this.pictureBoxCheckin);
            this.guna2Panel1.Controls.Add(this.panel3);
            this.guna2Panel1.Controls.Add(this.guna2ButtonCheckout);
            this.guna2Panel1.Controls.Add(this.guna2ButtonCheckin);
            this.guna2Panel1.Controls.Add(this.linkLabel1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabelNameCa);
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(111, 51);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(815, 497);
            this.guna2Panel1.TabIndex = 14;
            // 
            // pictureBoxCheckout
            // 
            this.pictureBoxCheckout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckout.Image")));
            this.pictureBoxCheckout.Location = new System.Drawing.Point(602, 327);
            this.pictureBoxCheckout.Name = "pictureBoxCheckout";
            this.pictureBoxCheckout.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckout.TabIndex = 28;
            this.pictureBoxCheckout.TabStop = false;
            this.pictureBoxCheckout.Visible = false;
            // 
            // pictureBoxCheckin
            // 
            this.pictureBoxCheckin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckin.Image")));
            this.pictureBoxCheckin.Location = new System.Drawing.Point(205, 327);
            this.pictureBoxCheckin.Name = "pictureBoxCheckin";
            this.pictureBoxCheckin.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckin.TabIndex = 27;
            this.pictureBoxCheckin.TabStop = false;
            this.pictureBoxCheckin.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(419, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 259);
            this.panel3.TabIndex = 6;
            // 
            // guna2ButtonCheckout
            // 
            this.guna2ButtonCheckout.BorderRadius = 20;
            this.guna2ButtonCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(150)))));
            this.guna2ButtonCheckout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ButtonCheckout.Image = global::HotelManagement_FinalProject.Properties.Resources.export_16;
            this.guna2ButtonCheckout.Location = new System.Drawing.Point(521, 130);
            this.guna2ButtonCheckout.Name = "guna2ButtonCheckout";
            this.guna2ButtonCheckout.Size = new System.Drawing.Size(176, 170);
            this.guna2ButtonCheckout.TabIndex = 5;
            this.guna2ButtonCheckout.Text = "Check out";
            this.guna2ButtonCheckout.Click += new System.EventHandler(this.guna2ButtonCheckout_Click);
            // 
            // guna2ButtonCheckin
            // 
            this.guna2ButtonCheckin.BorderRadius = 20;
            this.guna2ButtonCheckin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCheckin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCheckin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCheckin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCheckin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(172)))), ((int)(((byte)(147)))));
            this.guna2ButtonCheckin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonCheckin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2ButtonCheckin.Image = global::HotelManagement_FinalProject.Properties.Resources._71919511;
            this.guna2ButtonCheckin.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonCheckin.Location = new System.Drawing.Point(128, 130);
            this.guna2ButtonCheckin.Name = "guna2ButtonCheckin";
            this.guna2ButtonCheckin.PressedColor = System.Drawing.Color.White;
            this.guna2ButtonCheckin.Size = new System.Drawing.Size(176, 170);
            this.guna2ButtonCheckin.TabIndex = 4;
            this.guna2ButtonCheckin.Text = "Check in";
            this.guna2ButtonCheckin.Click += new System.EventHandler(this.guna2ButtonCheckin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
            this.linkLabel1.Location = new System.Drawing.Point(47, 440);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 23);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = ">Show History";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2HtmlLabelNameCa
            // 
            this.guna2HtmlLabelNameCa.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelNameCa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelNameCa.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabelNameCa.Location = new System.Drawing.Point(51, 16);
            this.guna2HtmlLabelNameCa.Name = "guna2HtmlLabelNameCa";
            this.guna2HtmlLabelNameCa.Size = new System.Drawing.Size(54, 25);
            this.guna2HtmlLabelNameCa.TabIndex = 2;
            this.guna2HtmlLabelNameCa.Text = "Shift : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(25, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(25, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 2);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CheckInOutCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1046, 608);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckInOutCleaner";
            this.Text = "CheckInOut";
            this.Load += new System.EventHandler(this.CheckInOutCleaner_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCheckin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelNameCa;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCheckout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxCheckout;
        private System.Windows.Forms.PictureBox pictureBoxCheckin;
    }
}