using System;
using System.Collections;
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
    public partial class BillList : Form
    {
        public BillList()
        {
            InitializeComponent();
        }
        Room room = new Room();
        MyDatabase db = new MyDatabase();
        private DateTimePicker timePicker;
        private void BillList_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select IdBil as 'ID Bill', IdRoom as 'ID Room', TimeCin as 'Check-in', TimeCout as 'Check-out', price as 'Price', status as 'Status' from BookRoom", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;

            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.guna2DateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            this.guna2DateTimePickerTo.Format = DateTimePickerFormat.Custom;
            guna2DateTimePickerFrom.CustomFormat = "dd/MM/yyyy HH:mm";
            guna2DateTimePickerTo.CustomFormat = "dd/MM/yyyy HH:mm";
            this.guna2DateTimePickerFrom.ShowUpDown = true;
            this.guna2DateTimePickerTo.ShowUpDown = true;

            this.guna2DateTimePickerFrominf.Format = DateTimePickerFormat.Custom;
            this.guna2DateTimePickerToinf.Format = DateTimePickerFormat.Custom;
            guna2DateTimePickerFrominf.CustomFormat = "dd/MM/yyyy HH:mm";
            guna2DateTimePickerToinf.CustomFormat = "dd/MM/yyyy HH:mm";
            this.guna2DateTimePickerFrominf.ShowUpDown = true;
            this.guna2DateTimePickerToinf.ShowUpDown = true;

            guna2DateTimePickerFrom.Value = DateTime.Today;
            guna2DateTimePickerTo.Value = DateTime.Today;
            guna2DateTimePickerFrominf.Value = DateTime.Today;
            guna2DateTimePickerToinf.Value = DateTime.Today;

            guna2ComboBoxRoom.DataSource = room.getAllRoom();
            guna2ComboBoxRoom.DisplayMember = "Id";
            guna2ComboBoxRoom.ValueMember = "Id";

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy giá trị từ ô trong hàng hiện tại và gán vào các điều khiển khác
                comboBoxRoom.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBoxStatus.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();

                guna2DateTimePickerFrominf.Value = (DateTime)guna2DataGridView1.CurrentRow.Cells[2].Value;
                guna2DateTimePickerToinf.Value = (DateTime)guna2DataGridView1.CurrentRow.Cells[3].Value;
            }

        }

        private void guna2ImageButtonFind_Click(object sender, EventArgs e)
        {
            string query = "";
            if (guna2CheckBoxDay.Checked)
            {
                if (guna2CheckBoxRoom.Checked && guna2CheckBoxStatus.Checked)
                {
                    query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom where IdRoom = @room and status = @status and [TimeCin] >= @timein and [TimeCout] <= @timeout";
                }
                else if (guna2CheckBoxRoom.Checked)
                {
                    query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom where IdRoom = @room and [TimeCin] >= @timein and [TimeCout] <= @timeout";
                }
                else if (guna2CheckBoxStatus.Checked)
                {
                    query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom where status = @status and [TimeCin] >= @timein and [TimeCout] <= @timeout";
                }
                else
                {
                    query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom where [TimeCin] >= @timein and [TimeCout] <= @timeout";
                }
            }
            else
            {
                if (guna2CheckBoxRoom.Checked && guna2CheckBoxStatus.Checked)
                {
                    query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom where IdRoom = @room and status = @status";
                }
                else if (guna2CheckBoxRoom.Checked)
                {
                    query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom where IdRoom = @room";
                }
                else if (guna2CheckBoxStatus.Checked)
                {
                    query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom where status = @status";
                }
                else
                {
                    query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom";
                }
            }
            SqlCommand command = new SqlCommand(query, db.getConnection);

            command.Parameters.AddWithValue("@timein",guna2DateTimePickerFrom.Value);
            command.Parameters.AddWithValue("@timeout", guna2DateTimePickerTo.Value);
            command.Parameters.Add("@room",SqlDbType.Int).Value = Convert.ToInt32(guna2ComboBoxRoom.Text);
            command.Parameters.AddWithValue("@status", guna2ComboBoxStatus.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            guna2DataGridView1.DataSource = table;

            guna2DataGridView1.Columns[0].HeaderText = "ID Bill";
            guna2DataGridView1.Columns[1].HeaderText = "ID Room";
            guna2DataGridView1.Columns[2].HeaderText = "Check-in";
            guna2DataGridView1.Columns[3].HeaderText = "Check-out";
            guna2DataGridView1.Columns[4].HeaderText = "Price";
            guna2DataGridView1.Columns[5].HeaderText = "Status";
        }

        private void guna2ImageButtonReload_Click(object sender, EventArgs e)
        {
            guna2CheckBoxDay.Checked = false;
            guna2CheckBoxRoom.Checked = false;
            guna2CheckBoxStatus.Checked = false;
            guna2ComboBoxRoom.SelectedItem = null;
            guna2ComboBoxStatus.SelectedItem = null;
            comboBoxRoom.SelectedItem= null;
            comboBoxStatus.SelectedItem = null;
            guna2DateTimePickerFrom.Value = DateTime.Today;
            guna2DateTimePickerTo.Value = DateTime.Today;
            guna2DateTimePickerFrominf.Value = DateTime.Today;
            guna2DateTimePickerToinf.Value = DateTime.Today;
            string query = "Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom";
            SqlCommand command = new SqlCommand(query, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            guna2DataGridView1.DataSource = table;
        }

        private void guna2ImageButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text == "")
                {
                    MessageBox.Show("Enter something to find", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlCommand command = new SqlCommand("Select IdBil,IdRoom,TimeCin,TimeCout,price,status from BookRoom WHERE CONCAT(IdBil,IdRoom,status) LIKE '%" + textBoxSearch.Text + "%'", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                guna2DataGridView1.DataSource = table;
                guna2DataGridView1.Columns[0].HeaderText = "ID Bill";
                guna2DataGridView1.Columns[1].HeaderText = "ID Room";
                guna2DataGridView1.Columns[2].HeaderText = "Check-in";
                guna2DataGridView1.Columns[3].HeaderText = "Check-out";
                guna2DataGridView1.Columns[4].HeaderText = "Price";
                guna2DataGridView1.Columns[5].HeaderText = "Status";
            }
            catch { }
        }
    }
}
