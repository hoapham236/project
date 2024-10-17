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
    public partial class FormShowDetail : Form
    {
        public FormShowDetail()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();
        Kho kho = new Kho();
        private void FormShowDetail_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select IdNL,SL,GiaTien from NhapKho where IdPhieuThu = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", this.Idbill);
            mydb.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            int vitri = 10;
            while (reader.Read())
            {
                string ten = kho.getTenNL(reader[0].ToString());
                string sol = reader[1].ToString();
                string giatien = reader[2].ToString();

                Label tenNL = new Label();
                tenNL.Text = ten;
                tenNL.Location = new Point(10, vitri);
                tenNL.AutoSize = true;

                Label soLuong = new Label();
                soLuong.Text = sol;
                soLuong.Location = new Point(170, vitri);
                soLuong.AutoSize = true;

                Label giaTien = new Label();
                giaTien.Text = giatien;
                giaTien.Location = new Point(315, vitri);
                giaTien.AutoSize = true;

                panelShow.Controls.Add(tenNL);
                panelShow.Controls.Add(soLuong);
                panelShow.Controls.Add(giaTien);
                vitri += 25;

            }
        }

        private void FormShowDetail_MouseEnter(object sender, EventArgs e)
        {

        }

        private void FormShowDetail_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            BillNhap billNhap = new BillNhap(this.Idbill);
            billNhap.Show();
        }
    }
}
