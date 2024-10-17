using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{
    public partial class CustomerList : Form
    {
        Worksession check = new Worksession();
        public CustomerList()
        {
            InitializeComponent();
        }
        MyDatabase db = new MyDatabase();
        Room room = new Room();
        DataTable tbstatic = new DataTable();
        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            if (guna2TextBoxIDB.Text == "" || guna2TextBoxRoom.Text == "" || guna2TextBoxName.Text == "" || guna2TextBoxCMND.Text == "" || guna2TextBoxAdd.Text == "" || guna2TextBoxPhone.Text == "" || guna2TextBoxNote.Text == "")
            {
                MessageBox.Show("Empty Valid", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!check.hasChar(guna2TextBoxIDB.Text))
            {
                MessageBox.Show("Id Bill must be number", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (!check.hasChar(guna2TextBoxRoom.Text))
            {
                MessageBox.Show("Room must be number", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (!check.checkname(guna2TextBoxName.Text))
            {
                MessageBox.Show("Name cannot have number and special char", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!check.hasChar(guna2TextBoxPhone.Text) || guna2TextBoxPhone.Text.Trim().Length != 10)
            {
                MessageBox.Show("Phone cannot char and enough 10 number", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!check.hasChar(guna2TextBoxCMND.Text) || guna2TextBoxCMND.Text.Trim().Length != 12)
            {
                MessageBox.Show("CMND cannot char and enough 12 number", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idb = Convert.ToInt32(guna2TextBoxIDB.Text);
            int idr = Convert.ToInt32(guna2TextBoxRoom.Text);
            string name = guna2TextBoxName.Text;
            string cmnd = guna2TextBoxCMND.Text;
            string add = guna2TextBoxAdd.Text;
            string phone = guna2TextBoxPhone.Text;
            string note = guna2TextBoxNote.Text;
            string status = guna2ComboBoxsta.Text;
            if (room.updateRoomBooked(idb,idr,name,cmnd,add,phone,note,status))
            {
                MessageBox.Show("Edit Success", "Edit Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                MessageBox.Show("Edit Not Success", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            guna2ComboBoxStatus.Text = "None";

            Button buttonAll = new Button();
            buttonAll.Text = "All Room";
            buttonAll.Size = new Size(132, 50);
            buttonAll.Click += (buttonSender, buttonEvent) =>
            {
                guna2ComboBoxStatus.Text = "None";
                SqlCommand cmd0 = new SqlCommand("Select IdBil as 'ID Bill', IdRoom as 'Room', name as 'Name', cmnd as 'CMND', address as 'Address', phone as 'Phone', note as 'Note', status as 'Status' from BookRoom", db.getConnection);
                SqlDataAdapter adapter0 = new SqlDataAdapter(cmd0);
                DataTable table0 = new DataTable();
                adapter0.Fill(table0);
                guna2DataGridView1.DataSource = table0;
                tbstatic = table0;
            };
            flowLayoutPanel1.Controls.Add(buttonAll);

            SqlCommand cmd = new SqlCommand("Select * from Room", db.getConnection);
            db.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int roomNumber = (Int32)reader[0];
                Button button = new Button();
                button.Text = "Room " + roomNumber;
                button.Size = new Size(132, 50);
                button.Click += (buttonSender, buttonEvent) =>
                {
                    guna2ComboBoxStatus.Text = "None";
                    SqlCommand cmd2 = new SqlCommand("Select IdBil as 'ID Bill', IdRoom as 'Room', name as 'Name', cmnd as 'CMND',address as 'Address', phone as 'Phone', note as 'Note', status as 'Status' from BookRoom where IdRoom = @idr", db.getConnection);
                    cmd2.Parameters.Add("@idr",SqlDbType.Int).Value = roomNumber;
                    SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    guna2DataGridView1.DataSource = table1;
                    tbstatic = table1;
                };
                flowLayoutPanel1.Controls.Add(button);
            }



            reader.Close();

            SqlCommand cmd1 = new SqlCommand("Select IdBil as 'ID Bill', IdRoom as 'Room', name as 'Name', cmnd as 'CMND',address as 'Address', phone as 'Phone', note as 'Note', status as 'Status' from BookRoom", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable table = new DataTable();
            adapter.Fill(table);
            guna2DataGridView1.DataSource = table;
            tbstatic = table;

            guna2DataGridView1.ColumnHeadersHeight = 50;
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                guna2TextBoxIDB.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                guna2TextBoxRoom.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                guna2TextBoxName.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                guna2TextBoxCMND.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                guna2TextBoxAdd.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                guna2TextBoxPhone.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                guna2TextBoxNote.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                guna2ComboBoxsta.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch { }
        }



        private void guna2ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = tbstatic.Copy();
                int i = dataTable.Rows.Count - 1;

                if (guna2ComboBoxStatus.Text != "None")
                {
                    while (i >= 0)
                    {
                        if (dataTable.Rows[i][6].ToString() != guna2ComboBoxStatus.Text)
                        {
                            dataTable.Rows.RemoveAt(i);
                        }
                        i--;
                    }
                }
                guna2DataGridView1.DataSource = dataTable;
            }
            catch { }
        }

        private void guna2ImageButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBoxId.Text == "")
                {
                    return;
                }
                if (!check.hasChar(guna2TextBoxId.Text))
                {
                    MessageBox.Show("Cannot has char", "Find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = Convert.ToInt32(guna2TextBoxId.Text);
                guna2ComboBoxStatus.Text = "None";
                SqlCommand cmd2 = new SqlCommand("Select IdBil as 'ID Bill', IdRoom as 'Room', name as 'Name', cmnd as 'CMND',address as 'Address', phone as 'Phone', note as 'Note', status as 'Status' from BookRoom where IdBil = @idb", db.getConnection);
                cmd2.Parameters.Add("@idb", SqlDbType.Int).Value = id;
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
                guna2DataGridView1.DataSource = table1;
                tbstatic = table1;
            }
            catch { }
        }
        private void guna2TextBoxIDB_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxIDB.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxIDB, "Id is missing");
            }
            else if (!checkNumber(text))
            {
                errorProvider1.SetError(guna2TextBoxIDB, "Id Bill must be a number");
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxIDB, "");
            }
        }

        private void guna2TextBoxRoom_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxRoom.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxRoom, "Id room is missing");
            }
            else if (!checkNumber(text))
            {
                errorProvider1.SetError(guna2TextBoxRoom, "Id room must be a number");
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxRoom, "");
            }
        }


        private void guna2TextBoxName_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxName.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxName, "Name is missing");
            }
            else if (!checkName(text))
            {
                errorProvider1.SetError(guna2TextBoxName, "Name must contain only letters");
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxName, "");
            }
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
        public bool checkName(string id)
        {
            foreach (char x in id)
            {
                if (Char.IsDigit(x))
                    return false;
            }
            return true;
        }

        private void guna2TextBoxCMND_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxCMND.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxCMND, "ID Card is missing");
            }
            else if (!checkNumber(text))
            {
                errorProvider1.SetError(guna2TextBoxCMND, "ID Card must contain only numbers");
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxCMND, "");
            }
        }

        private void guna2TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxPhone, "Phone number is missing");
            }
            else if (!checkNumber(text))
            {
                errorProvider1.SetError(guna2TextBoxPhone, "Phone number must contain only numbers");
            }
            else if (text.Length != 10)
            {
                errorProvider1.SetError(guna2TextBoxPhone, "Phone number must have 10 digits");
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxPhone, "");
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = guna2ComboBoxsta.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2ComboBoxsta, "Status is missing");
            }
            else
            {
                errorProvider1.SetError(guna2ComboBoxsta, "");
            }
        }

        private void guna2TextBoxId_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxId.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxId, "ID Bill is missing");
            }
            else if (!checkNumber(text))
            {
                errorProvider1.SetError(guna2TextBoxId, "ID Bill must contain only numbers");
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxId, "");
            }
        }
    }
}
