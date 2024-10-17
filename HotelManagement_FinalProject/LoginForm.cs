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
    public partial class LoginForm : Form
    {
        MyDatabase db = new MyDatabase();
        public LoginForm()
        {
            InitializeComponent();

        }
        public static string idlogin;

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                guna2ButtonLogin_Click(sender , e);
            }
        }
        

        public bool checkStatus(string username) 
        {
            SqlCommand command = new SqlCommand("Select Status from LOGIN where Username = @us", db.getConnection);
            command.Parameters.AddWithValue("@us", idlogin);
            DataTable tb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(tb);
            string status = (string)tb.Rows[0][0];
            if (status == "old")
                return true; // cu 
            else 
                return false; // moi 
        }
        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            if (guna2TextBoxid.Text == "")
            {
                errorProvider1.SetError(guna2TextBoxid, "Username error!!!");

            }
            else
            {

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT NghiepVu FROM LOGIN JOIN NHANVIEN ON LOGIN.Username = NHANVIEN.ID WHERE Username = @User AND Password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = guna2TextBoxid.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = guna2TextBoxpass.Text;

                adapter.SelectCommand = command;
                db.openConnection();

                adapter.Fill(table);
                string radio;
                if (radioButtonCleaner.Checked)
                {
                    radio = radioButtonCleaner.Text;
                }
                else if (radioButtonReceptionist.Checked)
                {
                    radio = radioButtonReceptionist.Text;
                }
                else
                {
                    radio = radioButtonManager.Text;
                }
                if ((table.Rows.Count > 0) && table.Rows[0][0].ToString() == radio)
                {
                    this.DialogResult = DialogResult.OK;
                    idlogin = guna2TextBoxid.Text;
                    db.closeConnection();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
