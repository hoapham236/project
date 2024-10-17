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
    public partial class CleanerList : Form
    {
        MyDatabase mydb = new MyDatabase();
        private int _check;
        public CleanerList(int check)
        {
            InitializeComponent();
            _check = check;
        }

        public int Check
        {
            get { return _check; }
            set { _check = value; }
        }

        Clean clean = new Clean();
        private void CleanerList_Load(object sender, EventArgs e)
        {
            this.guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SqlCommand command = new SqlCommand("Select ID,HoTen as 'Name',NgaySinh as 'BirthDate',DiaChi as 'Address',Sdt as 'Phone',Anh as 'Picture' from NHANVIEN Where NghiepVu = @nv", mydb.getConnection);
            command.Parameters.AddWithValue("@nv", "Cleaner");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.ColumnHeadersHeight = 27;
        }

        private void guna2GradientButtonShowFullList_Click(object sender, EventArgs e)
        {
            CleanerList_Load(sender, e);
        }

        private void guna2GradientButtonShowThisShift_Click(object sender, EventArgs e)
        {
            DateTime day = DateTime.Now.Date;
            TimeSpan time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            SqlCommand command = new SqlCommand("Select NHANVIEN.ID,HoTen as 'Name',NgaySinh as 'BirthDate',DiaChi as 'Address',Sdt as 'Phone',Anh as 'Picture' from NHANVIEN join CALAM on NHANVIEN.ID = CALAM.ID Where NghiepVu = @nv and [Ngay] = @day and ([GioVao] <= @time and [GioRa] is NULL) ", mydb.getConnection);
            command.Parameters.AddWithValue("@nv", "Cleaner");
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@time", time);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }
        string idCleaner;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCleaner = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void guna2GradientButtonCleanR_Click(object sender, EventArgs e)
        {
            try
            {
                if (clean.insertClean(idCleaner, this.idRoom))// idRoom là biến toàn cục truyền từ form Room
                {
                    MessageBox.Show("Select succussfully", "", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;

                }
            } catch { }
        }
    }
}