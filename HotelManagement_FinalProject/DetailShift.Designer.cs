using System;

namespace HotelManagement_FinalProject
{
    partial class DetailShift
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
            this.listBoxManager = new System.Windows.Forms.ListBox();
            this.listBoxCleaner = new System.Windows.Forms.ListBox();
            this.listBoxRecept = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalMana = new System.Windows.Forms.Label();
            this.labelTotalCleaner = new System.Windows.Forms.Label();
            this.labelTotalRecep = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ImageButtonFind = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // listBoxManager
            // 
            this.listBoxManager.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxManager.FormattingEnabled = true;
            this.listBoxManager.ItemHeight = 21;
            this.listBoxManager.Location = new System.Drawing.Point(39, 161);
            this.listBoxManager.Name = "listBoxManager";
            this.listBoxManager.Size = new System.Drawing.Size(245, 172);
            this.listBoxManager.TabIndex = 0;
            // 
            // listBoxCleaner
            // 
            this.listBoxCleaner.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxCleaner.FormattingEnabled = true;
            this.listBoxCleaner.ItemHeight = 21;
            this.listBoxCleaner.Location = new System.Drawing.Point(593, 161);
            this.listBoxCleaner.Name = "listBoxCleaner";
            this.listBoxCleaner.Size = new System.Drawing.Size(245, 172);
            this.listBoxCleaner.TabIndex = 1;
            // 
            // listBoxRecept
            // 
            this.listBoxRecept.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxRecept.FormattingEnabled = true;
            this.listBoxRecept.ItemHeight = 21;
            this.listBoxRecept.Location = new System.Drawing.Point(317, 161);
            this.listBoxRecept.Name = "listBoxRecept";
            this.listBoxRecept.Size = new System.Drawing.Size(245, 172);
            this.listBoxRecept.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(98, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(666, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cleaner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(378, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receptionist";
            // 
            // labelTotalMana
            // 
            this.labelTotalMana.AutoSize = true;
            this.labelTotalMana.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTotalMana.Location = new System.Drawing.Point(98, 356);
            this.labelTotalMana.Name = "labelTotalMana";
            this.labelTotalMana.Size = new System.Drawing.Size(56, 21);
            this.labelTotalMana.TabIndex = 6;
            this.labelTotalMana.Text = "Total:";
            // 
            // labelTotalCleaner
            // 
            this.labelTotalCleaner.AutoSize = true;
            this.labelTotalCleaner.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTotalCleaner.Location = new System.Drawing.Point(666, 356);
            this.labelTotalCleaner.Name = "labelTotalCleaner";
            this.labelTotalCleaner.Size = new System.Drawing.Size(56, 21);
            this.labelTotalCleaner.TabIndex = 7;
            this.labelTotalCleaner.Text = "Total:";
            // 
            // labelTotalRecep
            // 
            this.labelTotalRecep.AutoSize = true;
            this.labelTotalRecep.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTotalRecep.Location = new System.Drawing.Point(378, 356);
            this.labelTotalRecep.Name = "labelTotalRecep";
            this.labelTotalRecep.Size = new System.Drawing.Size(56, 21);
            this.labelTotalRecep.TabIndex = 8;
            this.labelTotalRecep.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shift:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Day:";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Enabled = false;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(165, 23);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker1.TabIndex = 11;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 5, 13, 4, 2, 56, 181);
            // 
            // guna2ImageButtonFind
            // 
            this.guna2ImageButtonFind.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButtonFind.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButtonFind.Image = global::HotelManagement_FinalProject.Properties.Resources.view_more;
            this.guna2ImageButtonFind.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButtonFind.ImageRotate = 0F;
            this.guna2ImageButtonFind.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButtonFind.Location = new System.Drawing.Point(670, 16);
            this.guna2ImageButtonFind.Name = "guna2ImageButtonFind";
            this.guna2ImageButtonFind.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButtonFind.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButtonFind.TabIndex = 13;
            this.guna2ImageButtonFind.Click += new System.EventHandler(this.guna2ImageButtonFind_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(72, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(727, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Transparent;
            this.comboBox1.BorderRadius = 15;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.comboBox1.Location = new System.Drawing.Point(488, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 36);
            this.comboBox1.TabIndex = 15;
            // 
            // DetailShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 462);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2ImageButtonFind);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalRecep);
            this.Controls.Add(this.labelTotalCleaner);
            this.Controls.Add(this.labelTotalMana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRecept);
            this.Controls.Add(this.listBoxCleaner);
            this.Controls.Add(this.listBoxManager);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailShift";
            this.Text = "DetailShift";
            this.Load += new System.EventHandler(this.DetailShift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxManager;
        private System.Windows.Forms.ListBox listBoxCleaner;
        private System.Windows.Forms.ListBox listBoxRecept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalMana;
        private System.Windows.Forms.Label labelTotalCleaner;
        private System.Windows.Forms.Label labelTotalRecep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButtonFind;
        private System.Windows.Forms.Label label6;
        public DateTime date;
        public string ca;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox1;
    }
}