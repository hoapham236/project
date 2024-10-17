using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{
    public partial class ManageRoom : Form
    {
        public ManageRoom()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();
        Room room = new Room();
        private void ManageRoom_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Room", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.Columns[0].HeaderText = "ID Room";
            guna2DataGridView1.Columns[1].HeaderText = "Floor";
            guna2DataGridView1.Columns[2].HeaderText = "Status";
            guna2DataGridView1.Columns[3].HeaderText = "Type";
        }

        private void guna2ImageButtonRemove_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Select Room to delete", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            if ((string)guna2DataGridView1.CurrentRow.Cells[2].Value != "Blank")
            {
                MessageBox.Show("Only Delete Room when Room Status is blank", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            int id = (int)guna2DataGridView1.CurrentRow.Cells[0].Value;
            if (room.deleteRoom(id))
            {
                MessageBox.Show("Delete Room " + id + " successfully", "Delete Room", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Delete Room " + id + " unsuccessfully", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand command = new SqlCommand("Select * from Room", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            guna2DataGridView1.DataSource = dt;

        }

        private void guna2ImageButtonReload_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Room", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            panelEnter.Visible = true;
            panelDataGridView.Visible = false;
            labelTitle.Text = "Add new room";
            guna2ImageButtonUpdate.Visible = false;
            guna2ImageButtonAdde.Visible = true;
            guna2TextBoxID.Enabled = true;

        }

        private void guna2ImageButtonCancel_Click(object sender, EventArgs e)
        {
            guna2TextBoxID.Text = "";
            comboBoxFloor.Text = "1";
            comboBox1Type.Text = "Single Bedroom";
        }

        private void guna2ImageButtonBack_Click(object sender, EventArgs e)
        {
            panelEnter.Visible = false;
            panelDataGridView.Visible = true;
            SqlCommand command = new SqlCommand("Select * from Room", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            guna2DataGridView1.DataSource = dt;

        }

        public bool checkNumber(string id)
        {
            foreach (char x in id)
            {
                if (!Char.IsDigit(x))
                    return false;
            }
            return true;
        }
        private void guna2ImageButtonAdde_Click(object sender, EventArgs e)
        {
            if (!checkNumber(guna2TextBoxID.Text))
            {
                MessageBox.Show("Enter the number of Room ID", "Add room", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            int id = Convert.ToInt32(guna2TextBoxID.Text.Trim().ToString());
            int floor = Convert.ToInt32(comboBoxFloor.Text.Trim().ToString());
            string type = comboBox1Type.Text;
            string status = guna2TextBoxStatus.Text;
            if (room.checkExistidRoom(id))
            {
                MessageBox.Show("Id Room existed", "Add room", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (room.addRoom(id, floor, status, type))
                MessageBox.Show("Add new room successfully", "Add room", MessageBoxButtons.OK);
            else
                MessageBox.Show("Add new room unsuccessfully", "Add room", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void guna2ImageButtonEdit_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Select Room to Edit", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            if ((string)guna2DataGridView1.CurrentRow.Cells[2].Value != "Blank")
            {
                MessageBox.Show("Only Edit Room when Room Status is blank", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            panelEnter.Visible = true;
            panelDataGridView.Visible = false;
            labelTitle.Text = "Edit room";
            guna2ImageButtonAdde.Visible = false;
            guna2ImageButtonUpdate.Visible = true;
            guna2TextBoxID.Enabled = false;
            guna2TextBoxID.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1Type.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxFloor.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            guna2TextBoxStatus.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void guna2ImageButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!checkNumber(guna2TextBoxID.Text))
            {
                MessageBox.Show("Enter the number of Room ID", "Edit room", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            int id = Convert.ToInt32(guna2TextBoxID.Text.Trim().ToString());
            int floor = Convert.ToInt32(comboBoxFloor.Text.Trim().ToString());
            string type = comboBox1Type.Text;
            string status = guna2TextBoxStatus.Text;
            if (room.updateRoom(id, floor, status, type))
                MessageBox.Show("Edit room successfully", "Edit room", MessageBoxButtons.OK);
            else
                MessageBox.Show("Edit room unsuccessfully", "Edit room", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
