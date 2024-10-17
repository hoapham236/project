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
    public partial class ResetPasswordF : Form
    {
        MyDatabase mydb = new MyDatabase();
        public ResetPasswordF()
        {
            InitializeComponent();
        }

        private void ResetPasswordF_Load(object sender, EventArgs e)
        {
            textBoxNewPass.Text = "Password";
            textBoxConfirmPass.Text = "Confirm password";
            errorProvider1.Clear();
        }

        private void textBoxNewPass_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPass.Text == "Password")
            {
                textBoxNewPass.Text = "";
                textBoxNewPass.PasswordChar = '*';
            }
        }

        private void textBoxNewPass_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPass.Text == "")
            {
                textBoxNewPass.Text = "Password";
                textBoxNewPass.PasswordChar = '\0';
            }
        }

        private void textBoxConfirmPass_Enter(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text == "Confirm password")
            {
                textBoxConfirmPass.Text = "";
                textBoxConfirmPass.PasswordChar = '*';
            }
        }

        private void textBoxConfirmPass_Leave(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text == "")
            {
                textBoxConfirmPass.Text = "Confirm password";
                textBoxConfirmPass.PasswordChar = '\0';
            }
        }

        private void checkBoxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpass.Checked)
            {
                textBoxNewPass.PasswordChar = '\0';
                textBoxConfirmPass.PasswordChar = '\0';

            }
            else
            {
                textBoxNewPass.PasswordChar = '*';
                textBoxConfirmPass.PasswordChar = '*';
            }
        }

        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update LOGIN set Password = @pas,Status = @sta where Username = @user", mydb.getConnection);
            command.Parameters.AddWithValue("@pas", textBoxConfirmPass.Text.ToString().Trim());
            command.Parameters.AddWithValue("@user", LoginForm.idlogin);
            command.Parameters.AddWithValue("@sta", "old");
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                MessageBox.Show("Reset password succussfully!", "Reset", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Reset unsuccussfully!", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mydb.closeConnection();
        }

        private void textBoxConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text != textBoxNewPass.Text)
            {
                errorProvider1.SetError(textBoxConfirmPass, "Password doesn't match");
            }
            else
            {
                errorProvider1.SetError(textBoxConfirmPass, ""); // Xóa thông báo lỗi nếu giá trị khớp
            }
            
        }
    }
}
