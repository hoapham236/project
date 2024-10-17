using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{

    public partial class CheckInOutCleaner : Form
    {
        MyDatabase mydb = new MyDatabase();
        string id = LoginForm.idlogin;
        Clean clean = new Clean();
        
        public CheckInOutCleaner()
        {
            InitializeComponent();
        }
        private void CheckInOutCleaner_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBoxCheckin.Visible = false;
            pictureBoxCheckout.Visible = false;
            string ca = Worksession.calam;
            if (ca == "no")
            {
                guna2ButtonCheckin.Enabled = false;
                guna2ButtonCheckout.Enabled = false;
            }
            else
            {
                if (clean.checkLC(id, DateTime.Now.ToString("MM/dd/yyyy")) == "checkin")
                {
                    pictureBoxCheckin.Visible=true;
                    guna2ButtonCheckin.Enabled = false;
                    guna2ButtonCheckout.Enabled = true;
                }
                else if (clean.checkLC(id, DateTime.Now.ToString("MM/dd/yyyy")) == "check")
                {
                    pictureBoxCheckin.Visible = true;
                    pictureBoxCheckout.Visible=true;
                    guna2ButtonCheckin.Enabled = false;
                    guna2ButtonCheckout.Enabled = false;
                }   
                else
                {
                    guna2ButtonCheckin.Enabled = true;
                    guna2ButtonCheckout.Enabled = false;
                }    
            }    
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ButtonCheckin.Text = "Check in\n" + DateTime.Now.ToString("hh:mm tt");
            guna2ButtonCheckout.Text = "Check out\n" + DateTime.Now.ToString("hh:mm tt");
        }
        private void guna2ButtonCheckin_Click(object sender, EventArgs e)
        {
            string ca = Worksession.calam;
            if (DialogResult.Yes == MessageBox.Show("Are you sure to check in?", "Check in", MessageBoxButtons.YesNo))
            {
                SqlCommand command = new SqlCommand("Insert into CALAM(ID,Ngay,GioVao,Ca) Values (@id,@day,@timein,@ca)", mydb.getConnection);
                command.Parameters.AddWithValue("@timein", DateTime.Now.ToString("hh:mm tt"));
                command.Parameters.AddWithValue("day", DateTime.Now.ToString("MM/dd/yyyy") );
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("@ca", ca);
                mydb.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Check in succussfully!", "Check in", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Check in unsuccussfully!", "Check in", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                mydb.closeConnection();
                guna2ButtonCheckin.Enabled = false;
                pictureBoxCheckin.Visible = true;
                guna2ButtonCheckout.Enabled = true;
            }
        }

        private void guna2ButtonCheckout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to check out?", "Check out", MessageBoxButtons.YesNo))
            {
                SqlCommand command = new SqlCommand("Update CALAM set GioRa = @timeout where ID = @id", mydb.getConnection);
                command.Parameters.AddWithValue("@timeout", DateTime.Now.ToString("hh:mm tt"));
                command.Parameters.AddWithValue("id", id);
                mydb.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Check out succussfully!", "Check out", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Check out unsuccussfully!", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mydb.closeConnection();
                guna2ButtonCheckout.Enabled = false;
                pictureBoxCheckout.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
