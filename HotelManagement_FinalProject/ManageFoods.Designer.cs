namespace HotelManagement_FinalProject
{
    partial class ManageFoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelStore = new System.Windows.Forms.Panel();
            this.checkedListBoxName = new System.Windows.Forms.CheckedListBox();
            this.guna2ButtonStore = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2DataGridViewKhoHienTai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ButtonShowKho = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonShowHistory = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonNhapKho = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.panelStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewKhoHienTai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(72, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 2);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.panelStore);
            this.guna2Panel1.Controls.Add(this.guna2DataGridViewKhoHienTai);
            this.guna2Panel1.Controls.Add(this.guna2ButtonShowKho);
            this.guna2Panel1.Controls.Add(this.guna2ButtonShowHistory);
            this.guna2Panel1.Controls.Add(this.guna2ButtonNhapKho);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(67, 52);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(909, 561);
            this.guna2Panel1.TabIndex = 15;
            // 
            // panelStore
            // 
            this.panelStore.Controls.Add(this.checkedListBoxName);
            this.panelStore.Controls.Add(this.guna2ButtonStore);
            this.panelStore.Controls.Add(this.label2);
            this.panelStore.Controls.Add(this.label1);
            this.panelStore.Controls.Add(this.guna2RadioButton2);
            this.panelStore.Controls.Add(this.guna2RadioButton1);
            this.panelStore.Location = new System.Drawing.Point(84, 107);
            this.panelStore.Name = "panelStore";
            this.panelStore.Size = new System.Drawing.Size(738, 392);
            this.panelStore.TabIndex = 7;
            // 
            // checkedListBoxName
            // 
            this.checkedListBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxName.ForeColor = System.Drawing.Color.LightCoral;
            this.checkedListBoxName.FormattingEnabled = true;
            this.checkedListBoxName.Location = new System.Drawing.Point(114, 103);
            this.checkedListBoxName.Name = "checkedListBoxName";
            this.checkedListBoxName.Size = new System.Drawing.Size(176, 189);
            this.checkedListBoxName.TabIndex = 0;
            // 
            // guna2ButtonStore
            // 
            this.guna2ButtonStore.BorderRadius = 15;
            this.guna2ButtonStore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonStore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2ButtonStore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonStore.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonStore.Location = new System.Drawing.Point(309, 331);
            this.guna2ButtonStore.Name = "guna2ButtonStore";
            this.guna2ButtonStore.Size = new System.Drawing.Size(133, 45);
            this.guna2ButtonStore.TabIndex = 9;
            this.guna2ButtonStore.Text = "Store";
            this.guna2ButtonStore.Click += new System.EventHandler(this.guna2ButtonStore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Count (kg)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingredients name";
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.Location = new System.Drawing.Point(372, 7);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(205, 27);
            this.guna2RadioButton2.TabIndex = 4;
            this.guna2RadioButton2.Text = "Missing ingredients";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.CheckedChanged += new System.EventHandler(this.guna2RadioButton2_CheckedChanged);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Location = new System.Drawing.Point(207, 7);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(56, 27);
            this.guna2RadioButton1.TabIndex = 3;
            this.guna2RadioButton1.Text = "All";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // guna2DataGridViewKhoHienTai
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewKhoHienTai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewKhoHienTai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewKhoHienTai.ColumnHeadersHeight = 4;
            this.guna2DataGridViewKhoHienTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewKhoHienTai.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewKhoHienTai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewKhoHienTai.Location = new System.Drawing.Point(84, 107);
            this.guna2DataGridViewKhoHienTai.Name = "guna2DataGridViewKhoHienTai";
            this.guna2DataGridViewKhoHienTai.RowHeadersVisible = false;
            this.guna2DataGridViewKhoHienTai.RowHeadersWidth = 51;
            this.guna2DataGridViewKhoHienTai.RowTemplate.Height = 24;
            this.guna2DataGridViewKhoHienTai.Size = new System.Drawing.Size(749, 426);
            this.guna2DataGridViewKhoHienTai.TabIndex = 0;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewKhoHienTai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewKhoHienTai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewKhoHienTai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.ReadOnly = false;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewKhoHienTai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewKhoHienTai.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridViewKhoHienTai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewKhoHienTai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewKhoHienTai.Click += new System.EventHandler(this.guna2DataGridViewKhoHienTai_Click);
            // 
            // guna2ButtonShowKho
            // 
            this.guna2ButtonShowKho.BorderRadius = 20;
            this.guna2ButtonShowKho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonShowKho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonShowKho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonShowKho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonShowKho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ButtonShowKho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonShowKho.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2ButtonShowKho.Image = global::HotelManagement_FinalProject.Properties.Resources._9096015;
            this.guna2ButtonShowKho.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ButtonShowKho.Location = new System.Drawing.Point(355, 15);
            this.guna2ButtonShowKho.Name = "guna2ButtonShowKho";
            this.guna2ButtonShowKho.PressedColor = System.Drawing.Color.White;
            this.guna2ButtonShowKho.Size = new System.Drawing.Size(171, 59);
            this.guna2ButtonShowKho.TabIndex = 6;
            this.guna2ButtonShowKho.Text = "In storage";
            this.guna2ButtonShowKho.Click += new System.EventHandler(this.guna2ButtonShowKho_Click);
            // 
            // guna2ButtonShowHistory
            // 
            this.guna2ButtonShowHistory.BorderRadius = 20;
            this.guna2ButtonShowHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonShowHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonShowHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonShowHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonShowHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(150)))));
            this.guna2ButtonShowHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonShowHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ButtonShowHistory.Image = global::HotelManagement_FinalProject.Properties.Resources._11181369;
            this.guna2ButtonShowHistory.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ButtonShowHistory.Location = new System.Drawing.Point(547, 15);
            this.guna2ButtonShowHistory.Name = "guna2ButtonShowHistory";
            this.guna2ButtonShowHistory.Size = new System.Drawing.Size(176, 61);
            this.guna2ButtonShowHistory.TabIndex = 5;
            this.guna2ButtonShowHistory.Text = "Store History ";
            this.guna2ButtonShowHistory.Click += new System.EventHandler(this.guna2ButtonShowHistory_Click);
            // 
            // guna2ButtonNhapKho
            // 
            this.guna2ButtonNhapKho.BorderRadius = 20;
            this.guna2ButtonNhapKho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonNhapKho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonNhapKho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonNhapKho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonNhapKho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(172)))), ((int)(((byte)(147)))));
            this.guna2ButtonNhapKho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonNhapKho.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2ButtonNhapKho.Image = global::HotelManagement_FinalProject.Properties.Resources.add_inventory;
            this.guna2ButtonNhapKho.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonNhapKho.Location = new System.Drawing.Point(163, 17);
            this.guna2ButtonNhapKho.Name = "guna2ButtonNhapKho";
            this.guna2ButtonNhapKho.PressedColor = System.Drawing.Color.White;
            this.guna2ButtonNhapKho.Size = new System.Drawing.Size(171, 59);
            this.guna2ButtonNhapKho.TabIndex = 4;
            this.guna2ButtonNhapKho.Text = "Store";
            this.guna2ButtonNhapKho.Click += new System.EventHandler(this.guna2ButtonNhapKho_Click);
            // 
            // ManageFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 656);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageFoods";
            this.Text = "ManageFoods";
            this.Load += new System.EventHandler(this.ManageFoods_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelStore.ResumeLayout(false);
            this.panelStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewKhoHienTai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonNhapKho;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonShowHistory;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonShowKho;
        private System.Windows.Forms.Panel panelStore;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewKhoHienTai;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxName;
    }
}