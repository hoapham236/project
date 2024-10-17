using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace HotelManagement_FinalProject
{
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }
        public static string to;
        Employee employee = new Employee();
        int time = 60;
        bool t = true;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            panelDataGridView.Show(); // Hiển thị panelShow
            panelEnter.Visible = false;
            guna2DataGridView1.DataSource = employee.getAllExcepEmployee("Manager");
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            guna2DataGridView1.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)guna2DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            guna2DataGridView1.AllowUserToAddRows = false;
            labelTotal.Text = "Total : " + guna2DataGridView1.Rows.Count;
            guna2DataGridView1.ColumnHeadersHeight = 30;

        }

        private void radioButtonRecep_CheckedChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = employee.getEmByNghiepVu("Receptionist");
            labelTotal.Text = "Total : " + guna2DataGridView1.Rows.Count;
        }

        private void radioButtonCleaner_CheckedChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = employee.getEmByNghiepVu("Cleaner");
            labelTotal.Text = "Total : " + guna2DataGridView1.Rows.Count;
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            ManageEmployees_Load(sender, e);
        }

        private void guna2ImageButtonReload_Click(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked == true)
            {
                guna2DataGridView1.DataSource = employee.getAllExcepEmployee("Manager");
            }
            if (radioButtonCleaner.Checked == true)
            {
                guna2DataGridView1.DataSource = employee.getEmByNghiepVu("Cleaner");
            }
            if (radioButtonRecep.Checked == true)
            {
                guna2DataGridView1.DataSource = employee.getEmByNghiepVu("Receptionist");
            }
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            guna2DataGridView1.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)guna2DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            guna2DataGridView1.AllowUserToAddRows = false;
            labelTotal.Text = "Total : " + guna2DataGridView1.Rows.Count;
        }

        private void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            panelEnter.Visible = true;
            panelDataGridView.Visible = false;
            guna2ImageButtonUpdate.Visible = false;
            guna2ImageButtonAdde.Visible = true;
            guna2TextBoxID.Enabled = true;
        }

        private void guna2ImageButtonRemove_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Choose employee want to delete", "Detele Employee", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;
            }
            else
            {
                string id = (string)guna2DataGridView1.CurrentRow.Cells[0].Value;
                if (DialogResult.Yes == MessageBox.Show("Delete this employee?", "Approval", MessageBoxButtons.YesNo))
                {
                    if (employee.deleteEmployee(id) && employee.deleteAccount(id))
                    {
                        MessageBox.Show("Deleted", "Delete Employee", MessageBoxButtons.OK);
                        guna2DataGridView1.DataSource = employee.getAllExcepEmployee("Manager");

                    }
                    else
                    {
                        MessageBox.Show("Not Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void guna2ImageButtonEdit_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Choose employee want to edit", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;
            }
            panelEnter.Show(); // Hiển thị panelShow
            panelEnter.Visible = true;
            panelDataGridView.Visible = false;
            guna2ImageButtonAdde.Visible = false;
            guna2ImageButtonUpdate.Visible = true;
            guna2TextBoxID.Enabled = false;
            guna2TextBoxID.Text = (string)guna2DataGridView1.CurrentRow.Cells[0].Value;
            guna2TextBoxFullName.Text = (string)guna2DataGridView1.CurrentRow.Cells[1].Value;
            guna2DateTimePicker1.Value = (DateTime)guna2DataGridView1.CurrentRow.Cells[2].Value;
            if ((string)guna2DataGridView1.CurrentRow.Cells[3].Value == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else if ((string)guna2DataGridView1.CurrentRow.Cells[3].Value == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            guna2TextBoxAddress.Text = (string)guna2DataGridView1.CurrentRow.Cells[4].Value;
            guna2TextBoxPhone.Text = (string)guna2DataGridView1.CurrentRow.Cells[5].Value;
            if ((string)guna2DataGridView1.CurrentRow.Cells[6].Value == "Cleaner")
            {
                guna2RadioButtonClea.Checked = true;
            }
            else if ((string)guna2DataGridView1.CurrentRow.Cells[6].Value == "Receptionist")
            {
                guna2RadioButtonRecept.Checked = true;
            }
            byte[] pic = guna2DataGridView1.CurrentRow.Cells[7].Value as byte[];

            if (pic != null)
            {
                using (MemoryStream picture = new MemoryStream(pic))
                {
                    guna2PictureBox1.Image = Image.FromStream(picture);
                }
            }
            else
            {

                guna2PictureBox1.Image = null;
            }
            guna2TextBoxemail.Text = guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();


        }

        private void guna2ImageButtonBack_Click(object sender, EventArgs e)
        {
            panelDataGridView.Show(); // Hiển thị panelShow
            panelEnter.Visible = false;
            guna2TextBoxID.Text = "";
            guna2TextBoxFullName.Text = "";
            guna2DateTimePicker1.Value = DateTime.Now;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            guna2TextBoxAddress.Text = "";
            guna2TextBoxPhone.Text = "";
            radioButtonCleaner.Checked = false;
            guna2RadioButtonRecept.Checked = false;
            guna2RadioButtonClea.Checked = false;
            guna2PictureBox1.Image = null;
            guna2TextBoxemail.Text = "";
        }

        private void guna2ImageButtonUpdate_Click(object sender, EventArgs e)
        {
            string id = guna2TextBoxID.Text;
            string name = guna2TextBoxFullName.Text;
            DateTime day = guna2DateTimePicker1.Value;
            string gender = "";
            if (radioButtonMale.Checked)
                gender = "Male";
            else if (radioButtonFemale.Checked)
                gender = "Female";
            string address = guna2TextBoxAddress.Text;
            string phone = guna2TextBoxPhone.Text;
            string nghiepvu = "";
            if (guna2RadioButtonClea.Checked && guna2RadioButtonRecept.Checked)
            {
                MessageBox.Show("Choose only one role!", "Update employee", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            if (guna2RadioButtonClea.Checked)
                nghiepvu = "Cleaner";
            if (guna2RadioButtonRecept.Checked)
                nghiepvu = "Receptionist";
            MemoryStream pic = new MemoryStream();
            if (guna2PictureBox1.Image is null)
            {
                MessageBox.Show("Please choose picture", "Update employee", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            guna2PictureBox1.Image.Save(pic, guna2PictureBox1.Image.RawFormat);

            string email = guna2TextBoxemail.Text;
            if (employee.updateEmployee(id, name, day, address, phone, nghiepvu, pic, email, gender))
            {
                MessageBox.Show("Update informaton succussfully!", "Edit Employee", MessageBoxButtons.OK);
                guna2DataGridView1.DataSource = employee.getAllExcepEmployee("Manager");


            }
            else
            {
                MessageBox.Show("Update informaton unsuccussfully!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (Char.IsLetter(x) || x == ' ')
                    continue;
                else
                    return false;
            }
            return true;
        }
        private void guna2ImageButtonAdde_Click(object sender, EventArgs e)
        {
            if (t == true)
            {
                string id = guna2TextBoxID.Text;
                string name = guna2TextBoxFullName.Text;
                DateTime day = guna2DateTimePicker1.Value;
                string gender = "";
                if (radioButtonMale.Checked)
                    gender = "Male";
                if (radioButtonFemale.Checked)
                    gender = "Female";
                string address = guna2TextBoxAddress.Text;
                string phone = guna2TextBoxPhone.Text;
                string nghiepvu = "";
                if (guna2RadioButtonClea.Checked)
                    nghiepvu = "Cleaner";
                if (guna2RadioButtonRecept.Checked)
                    nghiepvu = "Receptionist";
                MemoryStream pic = new MemoryStream();
                if (guna2RadioButtonClea.Checked && guna2RadioButtonRecept.Checked)
                {
                    MessageBox.Show("Choose only one role!", "Add employee", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                if (guna2PictureBox1.Image is null)
                {
                    MessageBox.Show("Please choose picture", "Add employee", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                if (!employee.checkID(id))
                {
                    MessageBox.Show("ID has been used!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                guna2PictureBox1.Image.Save(pic, guna2PictureBox1.Image.RawFormat);

                string email = guna2TextBoxemail.Text;
                string username = id;
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < 8; i++)
                {
                    stringBuilder.Append(chars[random.Next(chars.Length)]);
                }
                string randomPass = stringBuilder.ToString();

                string status = "new";


                if (employee.addEmployee(id, name, day, address, phone, nghiepvu, pic, email, gender) && employee.addAccount(username, randomPass, status))
                {
                    MessageBox.Show("Add employee succussfully!", "Edit Employee", MessageBoxButtons.OK);
                    guna2DataGridView1.DataSource = employee.getAllExcepEmployee("Manager");
                    string from, messageBody, pass;
                    MailMessage message = new MailMessage();
                    to = guna2TextBoxemail.Text.Trim();
                    from = "nhunguyetpy206@gmail.com"; //email của bạn
                    pass = "ubgbulcemteotbxd"; // pass email

                    message.IsBodyHtml = true; // Thiết lập cho phép sử dụng HTML trong nội dung email

                    messageBody = "<b>We are MoonLight Hotel!</b><br />" +
                                  "<b>Congratulation for becoming a part of us.<br />" +
                                  "Here is your account!<br />" +
                                  "Username: <span style='color:blue;'>" + id + "</span><br />" +
                                  "Pass: <span style='color:red;'>" + randomPass + "</span>";
                    try
                    {
                        message.To.Add(to);
                        message.From = new MailAddress(from, "MoonLight Hotel", System.Text.Encoding.UTF8);
                        message.Body = messageBody;
                        message.Subject = "Password for your new account";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Port = 587;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        try
                        {
                            smtp.Send(message);
                            MessageBox.Show("Send information account to employee successfully", "Send Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Add employee unsuccussfully!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error","Add Employee",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void guna2ImageButtonCancel_Click(object sender, EventArgs e)
        {
            guna2TextBoxID.Text = "";
            guna2TextBoxFullName.Text = "";
            guna2DateTimePicker1.Value = DateTime.Now;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            guna2TextBoxAddress.Text = "";
            guna2TextBoxPhone.Text = "";
            radioButtonCleaner.Checked = false;
            guna2RadioButtonRecept.Checked = false;
            guna2RadioButtonClea.Checked = false;
            guna2PictureBox1.Image = null;
            guna2TextBoxemail.Text = "";
            errorProvider1.Clear();
        }

        private void guna2ImageButtonUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Sellect Image(*.jpg;*png;*.gif)| *.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                guna2PictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }


        private void guna2TextBoxID_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxID.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxID, "Id is missing");
                t = false;
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxID, "");
                t = true;
            }
        }

        private void guna2TextBoxFullName_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxFullName.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxFullName, "Name is missing");
                t = false;
            }
            else if (!checkName(text))
            {
                errorProvider1.SetError(guna2TextBoxFullName, "Name must not contain number");
                t = false;
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxFullName, "");
                t = true;
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int year = guna2DateTimePicker1.Value.Year;
            if (DateTime.Now.Year - year < 18 || year < 1964)
            {
                errorProvider1.SetError(guna2DateTimePicker1, "Age must be between 18 and 60");
                t = false;
            }
            else
            {
                errorProvider1.SetError(guna2DateTimePicker1, "");
                t = true;
            }
        }

        private void guna2TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxAddress, "Address is missing");
                t = false;
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxAddress, "");
                t = true;
            }
        }

        private void guna2TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxPhone, "Phone is missing");
                t=false;
            }
            else if (!checkNumber(text))
            {
                errorProvider1.SetError(guna2TextBoxPhone, "Phone must be a number");
                t = false;
            }
            else if (text.Length != 10)
            {
                errorProvider1.SetError(guna2TextBoxPhone, "Phone must be have 10 numbers");
                t = false;
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxPhone, "");
                t = true;
            }
        }

        private void guna2RadioButtonRecept_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButtonRecept.Checked && guna2RadioButtonClea.Checked)
            {
                errorProvider1.SetError(guna2RadioButtonRecept, "Choose only one role");
                t = false;
            }
            else if (!guna2RadioButtonRecept.Checked && !guna2RadioButtonClea.Checked)
            {
                errorProvider1.SetError(guna2RadioButtonRecept, "Chooseone role");
                t = false;
            }
            else
            {
                errorProvider1.SetError(guna2RadioButtonRecept, "");
                errorProvider1.SetError(guna2RadioButtonClea, "");
                t = true;
            }

        }

        private void guna2RadioButtonClea_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButtonRecept.Checked && guna2RadioButtonClea.Checked)
            {
                errorProvider1.SetError(guna2RadioButtonClea, "Choose only one role");
                t = false;
            }
            else if (!guna2RadioButtonRecept.Checked && !guna2RadioButtonClea.Checked)
            {
                errorProvider1.SetError(guna2RadioButtonClea, "Choose one role");
                t = false;
            }
            else
            {
                errorProvider1.SetError(guna2RadioButtonRecept, "");
                errorProvider1.SetError(guna2RadioButtonClea, "");
                t = true;
            }

        }

        private void guna2TextBoxemail_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBoxemail.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(guna2TextBoxemail, "Email is missing");
                t = false;
            }
            else
            {
                errorProvider1.SetError(guna2TextBoxemail, "");
                t = true;
            }
        }


    }
}
