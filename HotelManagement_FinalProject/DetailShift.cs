using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{
    public partial class DetailShift : Form
    {
        int shift = 1;
        MyDatabase mydb = new MyDatabase();
        public DetailShift()
        {
            InitializeComponent();
        }

        private void DetailShift_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = this.date;
            comboBox1.Text = this.ca;
            if (ca == "Day")
                shift = 1;
            else
                shift = 2;

            // Manager 
            SqlCommand command = new SqlCommand("Select NHANVIEN.ID as Id,HoTen from NHANVIEN join LichLam on LichLam.ID = NHANVIEN.ID where Ca = @ca and [Ngay] = @ngay and NghiepVu = @nv", mydb.getConnection);
            command.Parameters.AddWithValue("@ca", shift);
            command.Parameters.Add("@ngay", SqlDbType.Date).Value = this.date;
            command.Parameters.AddWithValue("@nv", "Manager");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            listBoxManager.DataSource = dt;
            listBoxManager.DisplayMember = "HoTen";
            listBoxManager.ValueMember = "Id";
            listBoxManager.SelectedItem = null;
            labelTotalMana.Text = "Total: " + dt.Rows.Count;

            // Receptionist
            SqlCommand command1 = new SqlCommand("Select NHANVIEN.ID as Id,HoTen from NHANVIEN join LichLam on LichLam.ID = NHANVIEN.ID where Ca = @ca and [Ngay] = @ngay and NghiepVu = @nv", mydb.getConnection);
            command1.Parameters.AddWithValue("@ca", shift);
            command1.Parameters.Add("@ngay", SqlDbType.Date).Value = this.date;
            command1.Parameters.AddWithValue("@nv", "Receptionist");
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            listBoxRecept.DataSource = dt1;
            listBoxRecept.DisplayMember = "HoTen";
            listBoxRecept.ValueMember = "Id";
            listBoxRecept.SelectedItem = null;
            labelTotalRecep.Text = "Total: " + dt1.Rows.Count;


            // Cleaner
            SqlCommand command2 = new SqlCommand("Select NHANVIEN.ID as Id,HoTen from NHANVIEN join LichLam on LichLam.ID = NHANVIEN.ID where Ca = @ca and [Ngay] = @ngay and NghiepVu = @nv", mydb.getConnection);
            command2.Parameters.AddWithValue("@ca", shift);
            command2.Parameters.Add("@ngay", SqlDbType.Date).Value = this.date;
            command2.Parameters.AddWithValue("@nv", "Cleaner");
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            listBoxCleaner.DataSource = dt2;
            listBoxCleaner.DisplayMember = "HoTen";
            listBoxCleaner.ValueMember = "Id";
            listBoxCleaner.SelectedItem = null;
            labelTotalCleaner.Text = "Total: " + dt2.Rows.Count;
        }

        private void guna2ImageButtonFind_Click(object sender, EventArgs e)
        {
            int calam = 0;
            if (comboBox1.Text == "Day")
                calam = 1;
            else
                calam = 2;
            // Manager 
            SqlCommand command = new SqlCommand("Select NHANVIEN.ID as Id,HoTen from NHANVIEN join LichLam on LichLam.ID = NHANVIEN.ID where Ca = @ca and [Ngay] = @ngay and NghiepVu = @nv", mydb.getConnection);
            command.Parameters.AddWithValue("@ca",calam );
            command.Parameters.Add("@ngay", SqlDbType.Date).Value = guna2DateTimePicker1.Value;
            command.Parameters.AddWithValue("@nv", "Manager");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            listBoxManager.DataSource = dt;
            listBoxManager.DisplayMember = "HoTen";
            listBoxManager.ValueMember = "Id";
            listBoxManager.SelectedItem = null;
            labelTotalMana.Text = "Total: " + dt.Rows.Count;

            // Receptionist
            SqlCommand command1 = new SqlCommand("Select NHANVIEN.ID as Id,HoTen from NHANVIEN join LichLam on LichLam.ID = NHANVIEN.ID where Ca = @ca and [Ngay] = @ngay and NghiepVu = @nv", mydb.getConnection);
            command1.Parameters.AddWithValue("@ca", calam);
            command1.Parameters.Add("@ngay", SqlDbType.Date).Value = guna2DateTimePicker1.Value;
            command1.Parameters.AddWithValue("@nv", "Receptionist");
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            listBoxRecept.DataSource = dt1;
            listBoxRecept.DisplayMember = "HoTen";
            listBoxRecept.ValueMember = "Id";
            listBoxRecept.SelectedItem = null;
            labelTotalRecep.Text = "Total: " + dt1.Rows.Count;


            // Cleaner
            SqlCommand command2 = new SqlCommand("Select NHANVIEN.ID as Id,HoTen from NHANVIEN join LichLam on LichLam.ID = NHANVIEN.ID where Ca = @ca and [Ngay] = @ngay and NghiepVu = @nv", mydb.getConnection);
            command2.Parameters.AddWithValue("@ca", calam);
            command2.Parameters.Add("@ngay", SqlDbType.Date).Value = guna2DateTimePicker1.Value;
            command2.Parameters.AddWithValue("@nv", "Cleaner");
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            listBoxCleaner.DataSource = dt2;
            listBoxCleaner.DisplayMember = "HoTen";
            listBoxCleaner.ValueMember = "Id";
            listBoxCleaner.SelectedItem = null;
            labelTotalCleaner.Text = "Total: " + dt2.Rows.Count;
        }
    }
}
