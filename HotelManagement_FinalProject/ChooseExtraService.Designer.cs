using System.Collections.Generic;
using System;

namespace HotelManagement_FinalProject
{
    partial class ChooseExtraService
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
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.guna2ButtonDone = new Guna.UI2.WinForms.Guna2Button();
            this.listBoxMon = new System.Windows.Forms.ListBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxService
            // 
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.ItemHeight = 23;
            this.listBoxService.Location = new System.Drawing.Point(60, 10);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(292, 257);
            this.listBoxService.TabIndex = 0;
            this.listBoxService.Click += new System.EventHandler(this.listBoxService_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(551, 306);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 3;
            // 
            // guna2ButtonDone
            // 
            this.guna2ButtonDone.BorderRadius = 8;
            this.guna2ButtonDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(172)))), ((int)(((byte)(147)))));
            this.guna2ButtonDone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDone.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2ButtonDone.Image = global::HotelManagement_FinalProject.Properties.Resources._71919511;
            this.guna2ButtonDone.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonDone.Location = new System.Drawing.Point(197, 563);
            this.guna2ButtonDone.Name = "guna2ButtonDone";
            this.guna2ButtonDone.PressedColor = System.Drawing.Color.White;
            this.guna2ButtonDone.Size = new System.Drawing.Size(202, 52);
            this.guna2ButtonDone.TabIndex = 5;
            this.guna2ButtonDone.Text = "Done";
            this.guna2ButtonDone.Click += new System.EventHandler(this.guna2ButtonDone_Click);
            // 
            // listBoxMon
            // 
            this.listBoxMon.FormattingEnabled = true;
            this.listBoxMon.ItemHeight = 23;
            this.listBoxMon.Location = new System.Drawing.Point(490, 10);
            this.listBoxMon.Name = "listBoxMon";
            this.listBoxMon.Size = new System.Drawing.Size(292, 257);
            this.listBoxMon.TabIndex = 0;
            this.listBoxMon.Click += new System.EventHandler(this.listBoxMon_Click);
            this.listBoxMon.SelectedIndexChanged += new System.EventHandler(this.listBoxMon_SelectedIndexChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::HotelManagement_FinalProject.Properties.Resources._1004733;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(696, 286);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(68, 69);
            this.guna2ImageButton1.TabIndex = 6;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount:";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(171, 305);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(239, 32);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.guna2ButtonCancel);
            this.panel1.Controls.Add(this.panelShow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Controls.Add(this.listBoxMon);
            this.panel1.Controls.Add(this.guna2ButtonDone);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.listBoxService);
            this.panel1.Location = new System.Drawing.Point(41, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 633);
            this.panel1.TabIndex = 13;
            // 
            // guna2ButtonCancel
            // 
            this.guna2ButtonCancel.BorderRadius = 8;
            this.guna2ButtonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCancel.FillColor = System.Drawing.Color.Tomato;
            this.guna2ButtonCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonCancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2ButtonCancel.Image = global::HotelManagement_FinalProject.Properties.Resources._71919511;
            this.guna2ButtonCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonCancel.Location = new System.Drawing.Point(456, 563);
            this.guna2ButtonCancel.Name = "guna2ButtonCancel";
            this.guna2ButtonCancel.PressedColor = System.Drawing.Color.White;
            this.guna2ButtonCancel.Size = new System.Drawing.Size(202, 52);
            this.guna2ButtonCancel.TabIndex = 8;
            this.guna2ButtonCancel.Text = "Cancel";
            this.guna2ButtonCancel.Click += new System.EventHandler(this.guna2ButtonCancel_Click);
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.label3);
            this.panelShow.Location = new System.Drawing.Point(60, 361);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(704, 196);
            this.panelShow.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choice: ";
            // 
            // ChooseExtraService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 697);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChooseExtraService";
            this.Text = "ChooseExtraService";
            this.Load += new System.EventHandler(this.ChooseExtraService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxService;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDone;
        private System.Windows.Forms.ListBox listBoxMon;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCancel;
        public List<Tuple<string, string, int>> tuples = new List<Tuple<string, string, int>>();
    }
}