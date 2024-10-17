namespace HotelManagement_FinalProject
{
    partial class LoginForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelmain = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBoxpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.radioButtonCleaner = new System.Windows.Forms.RadioButton();
            this.radioButtonReceptionist = new System.Windows.Forms.RadioButton();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelmain.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonLogin.Location = new System.Drawing.Point(237, 291);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(121, 39);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(149)))), ((int)(((byte)(139)))));
            this.panelmain.BackgroundImage = global::HotelManagement_FinalProject.Properties.Resources.hills_and_mountains_blue_background_illustration_ai_generative_free_photo;
            this.panelmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelmain.Controls.Add(this.panelLogin);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1040, 660);
            this.panelmain.TabIndex = 0;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.guna2TextBoxpass);
            this.panelLogin.Controls.Add(this.guna2TextBoxid);
            this.panelLogin.Controls.Add(this.guna2ButtonLogin);
            this.panelLogin.Controls.Add(this.radioButtonCleaner);
            this.panelLogin.Controls.Add(this.radioButtonReceptionist);
            this.panelLogin.Controls.Add(this.radioButtonManager);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.Location = new System.Drawing.Point(273, 113);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(457, 433);
            this.panelLogin.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "MoonLight Hotel";
            // 
            // guna2TextBoxpass
            // 
            this.guna2TextBoxpass.BorderRadius = 15;
            this.guna2TextBoxpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxpass.DefaultText = "";
            this.guna2TextBoxpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBoxpass.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxpass.IconLeft = global::HotelManagement_FinalProject.Properties.Resources.check;
            this.guna2TextBoxpass.IconLeftSize = new System.Drawing.Size(25, 25);
            this.guna2TextBoxpass.Location = new System.Drawing.Point(162, 177);
            this.guna2TextBoxpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxpass.Name = "guna2TextBoxpass";
            this.guna2TextBoxpass.PasswordChar = '\0';
            this.guna2TextBoxpass.PlaceholderText = "";
            this.guna2TextBoxpass.SelectedText = "";
            this.guna2TextBoxpass.Size = new System.Drawing.Size(229, 35);
            this.guna2TextBoxpass.TabIndex = 13;
            // 
            // guna2TextBoxid
            // 
            this.guna2TextBoxid.BorderRadius = 15;
            this.guna2TextBoxid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxid.DefaultText = "";
            this.guna2TextBoxid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBoxid.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxid.IconLeft = global::HotelManagement_FinalProject.Properties.Resources.user;
            this.guna2TextBoxid.Location = new System.Drawing.Point(162, 112);
            this.guna2TextBoxid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxid.Name = "guna2TextBoxid";
            this.guna2TextBoxid.PasswordChar = '\0';
            this.guna2TextBoxid.PlaceholderText = "";
            this.guna2TextBoxid.SelectedText = "";
            this.guna2TextBoxid.Size = new System.Drawing.Size(229, 35);
            this.guna2TextBoxid.TabIndex = 12;
            // 
            // guna2ButtonLogin
            // 
            this.guna2ButtonLogin.BackColor = System.Drawing.Color.White;
            this.guna2ButtonLogin.BorderRadius = 15;
            this.guna2ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2ButtonLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonLogin.Image = global::HotelManagement_FinalProject.Properties.Resources._71919512;
            this.guna2ButtonLogin.Location = new System.Drawing.Point(176, 320);
            this.guna2ButtonLogin.Name = "guna2ButtonLogin";
            this.guna2ButtonLogin.Size = new System.Drawing.Size(134, 39);
            this.guna2ButtonLogin.TabIndex = 11;
            this.guna2ButtonLogin.Text = "Login";
            this.guna2ButtonLogin.Click += new System.EventHandler(this.guna2ButtonLogin_Click);
            // 
            // radioButtonCleaner
            // 
            this.radioButtonCleaner.AutoSize = true;
            this.radioButtonCleaner.Checked = true;
            this.radioButtonCleaner.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCleaner.Location = new System.Drawing.Point(325, 237);
            this.radioButtonCleaner.Name = "radioButtonCleaner";
            this.radioButtonCleaner.Size = new System.Drawing.Size(80, 21);
            this.radioButtonCleaner.TabIndex = 7;
            this.radioButtonCleaner.TabStop = true;
            this.radioButtonCleaner.Text = "Cleaner";
            this.radioButtonCleaner.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceptionist
            // 
            this.radioButtonReceptionist.AutoSize = true;
            this.radioButtonReceptionist.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonReceptionist.Location = new System.Drawing.Point(178, 237);
            this.radioButtonReceptionist.Name = "radioButtonReceptionist";
            this.radioButtonReceptionist.Size = new System.Drawing.Size(108, 21);
            this.radioButtonReceptionist.TabIndex = 6;
            this.radioButtonReceptionist.Text = "Receptionist";
            this.radioButtonReceptionist.UseVisualStyleBackColor = true;
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManager.Location = new System.Drawing.Point(62, 237);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(87, 21);
            this.radioButtonManager.TabIndex = 5;
            this.radioButtonManager.Text = "Manager";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "User name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Account";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1040, 660);
            this.Controls.Add(this.panelmain);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelmain.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton radioButtonCleaner;
        public System.Windows.Forms.RadioButton radioButtonReceptionist;
        public System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        public string id;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLogin;

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelLogin;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBoxid;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxpass;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Label label4;
    }
}

