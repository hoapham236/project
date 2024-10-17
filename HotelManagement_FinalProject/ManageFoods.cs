using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{

    public partial class ManageFoods : Form
    {
        Kho kho = new Kho();
        List<NumericUpDown> numericUps = new List<NumericUpDown>();
        MyDatabase mydb = new MyDatabase();
        int check = 0;
        public ManageFoods()
        {
            InitializeComponent();
        }

        private void guna2ButtonNhapKho_Click(object sender, EventArgs e)
        {
            guna2DataGridViewKhoHienTai.Visible = false;
            panelStore.Visible = true;
        }

        private void guna2ButtonShowKho_Click(object sender, EventArgs e)
        {
            check = 0;
            SqlCommand command = new SqlCommand("Select TenNL as 'Ingredient Name',SL as 'Count' from NguyenLieu join KHOHIENTAI on KHOHIENTAI.IdNL = NguyenLieu.IdNL", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            guna2DataGridViewKhoHienTai.DataSource = tb;
            guna2DataGridViewKhoHienTai.Visible = true;
            guna2DataGridViewKhoHienTai.Click -= guna2DataGridViewKhoHienTai_Click;
            panelStore.Visible = false;
        }

        private void guna2ButtonShowHistory_Click(object sender, EventArgs e)
        {
            check = 1;
            SqlCommand command = new SqlCommand("Select IdPhieuThu as 'Bill ID',Ngay as Date, HoTen as 'Manager Name',GiaTien as 'Price' From PhieuThu join NHANVIEN on PhieuThu.NguoiThucHien = NHANVIEN.ID", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            guna2DataGridViewKhoHienTai.DataSource = tb;
            guna2DataGridViewKhoHienTai.Visible = true;
            guna2DataGridViewKhoHienTai.Click += guna2DataGridViewKhoHienTai_Click;
            panelStore.Visible = false;
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (NumericUpDown num in numericUps)
            {
                panelStore.Controls.Remove(num);
            }
            numericUps.Clear();
            checkedListBoxName.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenNL from NguyenLieu", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            int vitri = 94;
            int i = 0;
            foreach (DataRow dataRow in tb.Rows)
            {
                checkedListBoxName.Items.Add(dataRow["TenNL"].ToString());
                numericUps.Add(new NumericUpDown());
                numericUps[i].Minimum = 1;
                numericUps[i].Size = new Size(46, 32);
                numericUps[i].Location = new Point(457, vitri);
                vitri += 25;
                panelStore.Controls.Add(numericUps[i]);
                i++;

            }
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (NumericUpDown num in numericUps)
            {
                panelStore.Controls.Remove(num);
            }
            numericUps.Clear();
            checkedListBoxName.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenNL from NguyenLieu join KHOHIENTAI on NguyenLieu.IdNL = KHOHIENTAI.IdNL where SL = @sl", mydb.getConnection);
            cmd.Parameters.AddWithValue("@sl", 0);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            int vitri = 94;
            int i = 0;
            foreach (DataRow dataRow in tb.Rows)
            {

                checkedListBoxName.Items.Add(dataRow["TenNL"].ToString());
                numericUps.Add(new NumericUpDown());
                numericUps[i].Minimum = 1;
                numericUps[i].Size = new Size(46, 32);
                numericUps[i].Location = new Point(457, vitri);
                panelStore.Controls.Add(numericUps[i]);
                vitri += 25;
                i++;
            }
        }

        private void guna2ButtonStore_Click(object sender, EventArgs e)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("Select * from NhapKho", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int Idphieuthu = dt.Rows.Count + 1;
            int tongtien = 0;
            // Buoc 1 chen vao NhapKho va KHOHIENTAI
            for (int i = 0; i < checkedListBoxName.Items.Count; i++)
            {
                if (checkedListBoxName.GetItemChecked(i))
                {
                    int tien = kho.getGiaTien(checkedListBoxName.Items[i].ToString()) * (int)numericUps[i].Value;
                    SqlCommand command2 = new SqlCommand("Insert into NhapKho(IdPhieuThu,IdNL,SL,GiaTien) values (@id,@idnl,@sl,@giatien)", mydb.getConnection);
                    command2.Parameters.AddWithValue("@id", Idphieuthu);
                    command2.Parameters.AddWithValue("@idnl", kho.getIdNL(checkedListBoxName.Items[i].ToString()));
                    command2.Parameters.AddWithValue("@sl", numericUps[i].Value);
                    command2.Parameters.AddWithValue("@giatien", tien);
                    tongtien += tien;


                    SqlCommand command4 = new SqlCommand("Update KHOHIENTAI set SL += @sl where IdNL = @id", mydb.getConnection);
                    command4.Parameters.AddWithValue("@sl", numericUps[i].Value);
                    command4.Parameters.AddWithValue("@id", kho.getIdNL(checkedListBoxName.Items[i].ToString()));

                    if (command2.ExecuteNonQuery() == 1 && command4.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("1");
                    }


                }
            }
            // Buoc 2 chen vao PhieuThu

            SqlCommand command3 = new SqlCommand("Insert into PhieuThu(IdPhieuThu,Ngay,NguoiThucHien,GiaTien) values (@id,@ngay,@nguoi,@giatien)", mydb.getConnection);
            command3.Parameters.AddWithValue("@id", Idphieuthu);
            command3.Parameters.AddWithValue("@ngay", DateTime.Now);
            command3.Parameters.AddWithValue("@nguoi", LoginForm.idlogin);
            command3.Parameters.AddWithValue("@giatien", tongtien);

            if (command3.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("2");
            }



            MessageBox.Show("Store succussfully!", "Store", MessageBoxButtons.OK);
            // Thanhcong 

        }

        private void ManageFoods_Load(object sender, EventArgs e)
        {
            guna2DataGridViewKhoHienTai.ColumnHeadersHeight = 30;
        }
        
        private void guna2DataGridViewKhoHienTai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridViewKhoHienTai_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                FormShowDetail fshowD = new FormShowDetail();
                fshowD.Idbill = (int)guna2DataGridViewKhoHienTai.CurrentRow.Cells[0].Value;
                //MessageBox.Show((fshowD.Idbill).ToString());
                fshowD.Show();
            }
        }
    }
}

