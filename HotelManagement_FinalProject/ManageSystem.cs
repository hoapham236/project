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
using System.Xml.Linq;

namespace HotelManagement_FinalProject
{
    public partial class ManageSystem : Form
    {
        public ManageSystem()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();
        int check = 0;
        Worksession checkchar = new Worksession();
        private void ManageSystem_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Name,Price as 'Price(VND)' from Price where Type = @type", mydb.getConnection);
            command.Parameters.AddWithValue("@type", "Salary");
            SqlDataAdapter adaptee = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adaptee.Fill(tb);

            guna2DataGridView1.ColumnHeadersHeight = 20;
            guna2DataGridView1.DataSource = tb;
            guna2ComboBox1.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBoxPrice.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            check = 1;

        }

        private void guna2ButtonRoom_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Name,Price as 'Price(VND)' from Price where Type = @type", mydb.getConnection);
            command.Parameters.AddWithValue("@type", "Room Price");
            SqlDataAdapter adaptee = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adaptee.Fill(tb);

            guna2DataGridView1.ColumnHeadersHeight = 20;
            guna2DataGridView1.DataSource = tb;
            check = 2;
            guna2ButtonFood.FillColor = Color.FromArgb(192, 192, 255);
            guna2ButtonRoom.FillColor = Color.LightSkyBlue;
            guna2ButtonSalary.FillColor = Color.FromArgb(192, 192, 255);
        }

        private void guna2ButtonSalary_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Name,Price as 'Price(VND)' from Price where Type = @type", mydb.getConnection);
            command.Parameters.AddWithValue("@type", "Salary");
            SqlDataAdapter adaptee = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adaptee.Fill(tb);

            guna2DataGridView1.ColumnHeadersHeight = 20;
            guna2DataGridView1.DataSource = tb;
            check = 1;
            guna2ButtonFood.FillColor = Color.FromArgb(192, 192, 255);
            guna2ButtonSalary.FillColor = Color.LightSkyBlue;
            guna2ButtonRoom.FillColor = Color.FromArgb(192, 192, 255);

        }

        private void guna2ButtonFood_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Name,Price as 'Price(VND)' from Price where Type = @type", mydb.getConnection);
            command.Parameters.AddWithValue("@type", "Food Price");
            SqlDataAdapter adaptee = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adaptee.Fill(tb);

            guna2DataGridView1.ColumnHeadersHeight = 20;
            guna2DataGridView1.DataSource = tb;
            check = 3;
            guna2ButtonSalary.FillColor = Color.FromArgb(192, 192, 255);
            guna2ButtonFood.FillColor = Color.LightSkyBlue;
            guna2ButtonRoom.FillColor = Color.FromArgb(192, 192, 255);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2ComboBox1.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBoxPrice.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        public bool checkPrice(string p)
        {
            foreach (var x in p)
            {
                if (!char.IsDigit(x))
                    return false;
            }
            return true;
        }
        public bool updateMon(string ten, int price)
        {
            SqlCommand command = new SqlCommand("Update Mon set GiaMon = @price where TenMon = @name", mydb.getConnection);
            command.Parameters.AddWithValue("@name", ten);
            command.Parameters.AddWithValue("@price", price);
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox1.Text == "")
            {
                MessageBox.Show("Empty Valid", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (guna2TextBoxPrice.Text == "")
            {
                MessageBox.Show("Empty Valid", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (!checkchar.hasChar(guna2TextBoxPrice.Text))
            {
                MessageBox.Show("Price must be integer number", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            string name = guna2ComboBox1.Text;
            string p = guna2TextBoxPrice.Text.ToString();
            if (!checkPrice(p) || p.Trim() == "")
            {
                MessageBox.Show("Error type of Price", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (Convert.ToInt32(p) == 0)
            {
                MessageBox.Show("Price must not be 0", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            SqlCommand command = new SqlCommand("Update Price set Price = @price where Name = @name", mydb.getConnection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", Convert.ToInt32(p));
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update successfully!", "Update", MessageBoxButtons.OK);
                if (check == 1)
                {
                    SqlCommand command1 = new SqlCommand("Select Name,Price as 'Price(VND)' from Price where Type = @type", mydb.getConnection);
                    command1.Parameters.AddWithValue("@type", "Salary");
                    SqlDataAdapter adaptee = new SqlDataAdapter(command1);
                    DataTable tb = new DataTable();
                    adaptee.Fill(tb);

                    guna2DataGridView1.ColumnHeadersHeight = 20;
                    guna2DataGridView1.DataSource = tb;
                }
                else if (check == 2)
                {
                    SqlCommand command1 = new SqlCommand("Select Name,Price as 'Price(VND)' from Price where Type = @type", mydb.getConnection);
                    command1.Parameters.AddWithValue("@type", "Room Price");
                    SqlDataAdapter adaptee = new SqlDataAdapter(command1);
                    DataTable tb = new DataTable();
                    adaptee.Fill(tb);

                    guna2DataGridView1.ColumnHeadersHeight = 20;
                    guna2DataGridView1.DataSource = tb;
                }
                else if (check == 3)
                {
                    if (updateMon(name, Convert.ToInt32(p)))
                    {
                        SqlCommand command1 = new SqlCommand("Select Name,Price as 'Price(VND)' from Price where Type = @type", mydb.getConnection);
                        command1.Parameters.AddWithValue("@type", "Food Price");
                        SqlDataAdapter adaptee = new SqlDataAdapter(command1);
                        DataTable tb = new DataTable();
                        adaptee.Fill(tb);

                        guna2DataGridView1.ColumnHeadersHeight = 20;
                        guna2DataGridView1.DataSource = tb;
                    }
                }
            }
            else
                MessageBox.Show("Update unsuccessfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBoxPrice.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
