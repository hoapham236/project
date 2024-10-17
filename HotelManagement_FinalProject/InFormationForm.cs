using Guna.UI2.WinForms;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace HotelManagement_FinalProject
{
    public partial class InFormationForm : Form
    {
        public InFormationForm()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();

        string hoten;
        DateTime Ngaysinh;
        string gioitinh;
        string nghiepvu;
        string sdt;
        string diachi;
        string email;
        MemoryStream picture;
        private void InFormationForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select HoTen,NgaySinh,GioiTinh,NghiepVu,Sdt,DiaChi,Email,Anh from NHANVIEN where ID = @id", mydb.getConnection);
            command.Parameters.AddWithValue("@id", LoginForm.idlogin);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adap.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                hoten = tb.Rows[0]["HoTen"].ToString();
                Ngaysinh = (DateTime)tb.Rows[0]["NgaySinh"];
                gioitinh = tb.Rows[0]["GioiTinh"].ToString();
                nghiepvu = tb.Rows[0]["NghiepVu"].ToString();
                sdt = tb.Rows[0]["Sdt"].ToString();
                diachi = tb.Rows[0]["DiaChi"].ToString();
                email = tb.Rows[0]["Email"].ToString();
                byte[] pic;
                pic = (byte[])tb.Rows[0]["Anh"];
                picture = new MemoryStream(pic);

                this.HoTen = hoten;

                labelname.Text = "Name: " + hoten;
                labelbirthdate.Text = "Birthdate: " + Ngaysinh.Date.ToString();
                label1gender.Text = "Gender: " + gioitinh;
                label1Role.Text = "Role: " + nghiepvu;
                labelPhone.Text = "Phone: " + sdt;
                labelAddress.Text = "Address: " + diachi;
                labelEmail.Text = "Email: " + email;
                pictureBox1.Image = Image.FromStream(picture);
            }
            else
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelEnter.Show();
            panelMain.Visible = false;
            guna2TextBoxFullName.Text = hoten;
            guna2DateTimePicker1.Value = Ngaysinh;
            if (gioitinh == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else if (gioitinh == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            guna2TextBoxAddress.Text = diachi;
            guna2TextBoxPhone.Text = sdt;

            guna2PictureBox1.Image = Image.FromStream(picture);
            guna2TextBoxemail.Text = email;

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void guna2ImageButtonBack_Click(object sender, EventArgs e)
        {
            panelMain.Show();
            panelEnter.Visible = false;
        }
        Employee employee = new Employee();
        private void guna2ImageButtonUpdate_Click(object sender, EventArgs e)
        {
            string id = LoginForm.idlogin;
            string name = guna2TextBoxFullName.Text;
            DateTime day = guna2DateTimePicker1.Value;
            string gender = "";
            if (radioButtonMale.Checked)
                gender = "Male";
            else if (radioButtonFemale.Checked)
                gender = "Female";
            string address = guna2TextBoxAddress.Text;
            string phone = guna2TextBoxPhone.Text;

            MemoryStream pic = new MemoryStream();
            guna2PictureBox1.Image.Save(pic, guna2PictureBox1.Image.RawFormat);
            string temail = guna2TextBoxemail.Text;
            if (updateInfo(id, name, day, address, phone, gender, pic, temail))
            {
                MessageBox.Show("Update informaton succussfully!", "Edit Employee", MessageBoxButtons.OK);
                hoten = name;
                Ngaysinh = day;
                gioitinh = gender;
                sdt = phone;
                diachi = address;
                email = temail;
                picture = pic;


                labelname.Text = "Name: " + hoten;
                labelbirthdate.Text = "Birthdate: " + Ngaysinh.Date.ToString();
                label1gender.Text = "Gender: " + gioitinh;
                label1Role.Text = "Role: " + nghiepvu;
                labelPhone.Text = "Phone: " + sdt;
                labelAddress.Text = "Address: " + diachi;
                labelEmail.Text = "Email: " + email;
                pictureBox1.Image = Image.FromStream(picture);

                this.HoTen = hoten;

            }
            else
            {
                MessageBox.Show("Update informaton unsuccussfully!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool updateInfo(string id, string name, DateTime bdate, string address, string phone, string gender, MemoryStream picture, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET HoTen=@name,NgaySinh=@bdt, DiaChi = @dc,sdt=@phn, Anh=@pic,Email =@email,GioiTinh = @gt WHERE ID=@ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.AddWithValue("@dc", address);
            command.Parameters.AddWithValue("@phn", phone);
            command.Parameters.AddWithValue("@gt", gender);
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}