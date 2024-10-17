using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{
    public partial class MainFormReceptionist : Form
    {
        Clean clean = new Clean();
        MyDatabase mydb = new MyDatabase();
        int check = 0;
        private List<System.Drawing.Image> images = new List<System.Drawing.Image>();
        private int currentIndex = 0;
        public MainFormReceptionist()
        {
            InitializeComponent();
            images.Add(Properties.Resources.cropped_Artboard_111BE_HA);
            images.Add(Properties.Resources._230918777);
            images.Add(Properties.Resources._28719181);
            ShowImage(currentIndex);
            timer = new Timer();
            timer.Interval = 5000; // Thời gian giữa các chuyển đổi ảnh (5 giây)
            timer.Tick += Timer_Tick;
            timer.Start();
            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;
        }
        private void ShowImage(int index)
        {
            if (index >= 0 && index < images.Count)
            {
                imagePanel.BackgroundImage = images[index];
                imagePanel.Show();
                if (currentIndex == 0)
                    guna2CustomRadioButton1.Checked = true;
                if (currentIndex == 1)
                    guna2CustomRadioButton2.Checked = true;
                if (currentIndex == 2)
                    guna2CustomRadioButton3.Checked = true;
            }
        }

        private void ShowNextImage()
        {
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            ShowImage(currentIndex);
        }

        private void ShowPreviousImage()
        {
            currentIndex = (currentIndex + 1) % images.Count;
            ShowImage(currentIndex);
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowPreviousImage();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            ShowPreviousImage();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            ShowNextImage();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select Ca from LichLam where ID=@id and Ngay=@ngay", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id.Trim();
            cmd.Parameters.Add("@ngay", SqlDbType.DateTime).Value = DateTime.Today;
            DataTable table1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                string ca = table1.Rows[0][0].ToString();
                if (DateTime.Now.Hour >= 7 && DateTime.Now.Hour <= 19)
                {
                    if (ca == "1")
                    {
                        labelCa.Text = "Shift ToDay: Day (7h-19h)";
                        Worksession.calam = "Day";
                    }
                    else
                    {
                        labelCa.Text = "Currently no working shifts";
                        Worksession.calam = "no";
                    }
                }
                else
                {
                    if (ca == "2")
                    {
                        labelCa.Text = "Shift ToDay: Night (19h-7h)";
                        Worksession.calam = "Night";
                    }
                    else
                    {
                        labelCa.Text = "Currently no working shifts";
                        Worksession.calam = "no";
                    }
                }
            }
            else
            {
                labelCa.Text = "Currently no working shifts";
                Worksession.calam = "no";
            }

            timer1.Start();
            DateTime d = DateTime.Now;

            labelDate.Text = d.DayOfWeek + " " + d.ToString("dd/MM/yyyy");
            try
            {
                linkLabelID.Text += id.ToUpper();

                using (SqlConnection connection = mydb.getConnection)
                {

                    SqlCommand command = new SqlCommand("SELECT HoTen,Anh FROM NHANVIEN WHERE ID = @ID", mydb.getConnection);

                    command.Parameters.AddWithValue("@ID", id.Trim());

                    connection.Open();
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    string ten = (string)table.Rows[0]["HoTen"];
                    linkLabelName.Text += ten;
                    Worksession.tentn = ten;

                    mydb.openConnection();
                    SqlCommand command1 = new SqlCommand("Select Anh from NHANVIEN Where ID = @una", mydb.getConnection);
                    command1.Parameters.AddWithValue("@una", id);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command1);
                    DataTable dt = new DataTable();
                    adapter2.Fill(dt);
                    byte[] pic = (byte[])dt.Rows[0]["Anh"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxImage.Image = System.Drawing.Image.FromStream(picture);
                    pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately, e.g., logging or displaying error message.
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void guna2ButtonHome_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(panelHomePage);
            guna2ButtonHome.FillColor = Color.Teal;
            guna2ButtonCheckInOut.FillColor = Color.White;
            guna2ButtonHistory.FillColor = Color.White;
            guna2ButtonExit.FillColor = Color.White;
            guna2ButtonRoom.FillColor = Color.White;
            guna2ButtonBill.FillColor = Color.White;
            guna2ButtonCleaner.FillColor = Color.White;
            guna2ButtonCustomer.FillColor = Color.White;
        }

        private void guna2ButtonCheckInOut_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            CheckInOutCleaner checkInOut = new CheckInOutCleaner();
            checkInOut.TopLevel = false;
            panelShow.Controls.Add(checkInOut);
            checkInOut.Show();
            guna2ButtonHome.FillColor = Color.White;
            guna2ButtonCheckInOut.FillColor = Color.Teal;
            guna2ButtonHistory.FillColor = Color.White;
            guna2ButtonExit.FillColor = Color.White;
            guna2ButtonRoom.FillColor = Color.White;
            guna2ButtonBill.FillColor = Color.White;
            guna2ButtonCleaner.FillColor = Color.White;
            guna2ButtonCustomer.FillColor = Color.White;
            checkInOut.FormClosed += (fsender, fe) =>
            {
                if (checkInOut.DialogResult == DialogResult.OK)
                {
                    guna2ButtonHistory.PerformClick();
                }
            };
        }

        private void guna2ButtonHistory_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            HistoryFormCleaner historyF = new HistoryFormCleaner();
            historyF.id = id;
            historyF.TopLevel = false;
            panelShow.Controls.Add(historyF);
            historyF.Show();
            guna2ButtonHome.FillColor = Color.White;
            guna2ButtonCheckInOut.FillColor = Color.White;
            guna2ButtonHistory.FillColor = Color.Teal;
            guna2ButtonExit.FillColor = Color.White;
            guna2ButtonRoom.FillColor = Color.White;
            guna2ButtonBill.FillColor = Color.White;
            guna2ButtonCleaner.FillColor = Color.White;
            guna2ButtonCustomer.FillColor = Color.White;
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            guna2ButtonHome.FillColor = Color.White;
            guna2ButtonCheckInOut.FillColor = Color.White;
            guna2ButtonHistory.FillColor = Color.White;
            guna2ButtonExit.FillColor = Color.Teal;
            guna2ButtonRoom.FillColor = Color.White;
            guna2ButtonBill.FillColor = Color.White;
            guna2ButtonCleaner.FillColor = Color.White;
            guna2ButtonCustomer.FillColor = Color.White;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void guna2ButtonCleaner_Click(object sender, EventArgs e)
        {
            CleanerList room = new CleanerList(0);
            panelShow.Controls.Clear();
            room.TopLevel = false;
            panelShow.Controls.Add(room);
            room.Show();
            guna2ButtonHome.FillColor = Color.White;
            guna2ButtonCheckInOut.FillColor = Color.White;
            guna2ButtonHistory.FillColor = Color.White;
            guna2ButtonExit.FillColor = Color.White;
            guna2ButtonRoom.FillColor = Color.White;
            guna2ButtonBill.FillColor = Color.White;
            guna2ButtonCleaner.FillColor = Color.Teal;
            guna2ButtonCustomer.FillColor = Color.White;
        }

        private void guna2ButtonRoom_Click(object sender, EventArgs e)
        {
            RoomList room = new RoomList();
            panelShow.Controls.Clear();
            room.TopLevel = false;
            panelShow.Controls.Add(room);
            room.Show();
            guna2ButtonHome.FillColor = Color.White;
            guna2ButtonCheckInOut.FillColor = Color.White;
            guna2ButtonHistory.FillColor = Color.White;
            guna2ButtonExit.FillColor = Color.White;
            guna2ButtonRoom.FillColor = Color.Teal;
            guna2ButtonBill.FillColor = Color.White;
            guna2ButtonCleaner.FillColor = Color.White;
            guna2ButtonCustomer.FillColor = Color.White;
            room.FormClosed += (fsender, fe) =>
            {

                if (room.DialogResult == DialogResult.OK)
                {
                    guna2ButtonRoom.PerformClick();

                }
            };
        }

        private void guna2ButtonCustomer_Click(object sender, EventArgs e)
        {
            CustomerList room = new CustomerList();
            panelShow.Controls.Clear();
            room.TopLevel = false;
            panelShow.Controls.Add(room);
            room.Show();
            guna2ButtonHome.FillColor = Color.White;
            guna2ButtonCheckInOut.FillColor = Color.White;
            guna2ButtonHistory.FillColor = Color.White;
            guna2ButtonExit.FillColor = Color.White;
            guna2ButtonRoom.FillColor = Color.White;
            guna2ButtonBill.FillColor = Color.White;
            guna2ButtonCleaner.FillColor = Color.White;
            guna2ButtonCustomer.FillColor = Color.Teal;
        }

        private void guna2ButtonBill_Click(object sender, EventArgs e)
        {
            BillList room = new BillList();
            panelShow.Controls.Clear();
            room.TopLevel = false;
            panelShow.Controls.Add(room);
            room.Show();
            guna2ButtonHome.FillColor = Color.White;
            guna2ButtonCheckInOut.FillColor = Color.White;
            guna2ButtonHistory.FillColor = Color.White;
            guna2ButtonExit.FillColor = Color.White;
            guna2ButtonRoom.FillColor = Color.White;
            guna2ButtonBill.FillColor = Color.Teal;
            guna2ButtonCleaner.FillColor = Color.White;
            guna2ButtonCustomer.FillColor = Color.White;
        }

        private void linkLabelID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InFormationForm room = new InFormationForm();
            panelShow.Controls.Clear();
            room.TopLevel = false;
            panelShow.Controls.Add(room);
            room.Show();
            room.FormClosed += (fsender, fe) =>
            {

                if (room.DialogResult == DialogResult.OK)
                {
                    guna2ButtonHome.PerformClick();
                    linkLabelName.Text = room.HoTen;
                }
            };
        }

        private void linkLabelName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InFormationForm room = new InFormationForm();
            panelShow.Controls.Clear();
            room.TopLevel = false;
            panelShow.Controls.Add(room);
            room.Show();
            room.FormClosed += (fsender, fe) =>
            {

                if (room.DialogResult == DialogResult.OK)
                {
                    guna2ButtonHome.PerformClick();
                    linkLabelName.Text = room.HoTen;
                }
            };
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            InFormationForm room = new InFormationForm();
            panelShow.Controls.Clear();
            room.TopLevel = false;
            panelShow.Controls.Add(room);
            room.Show();
            room.FormClosed += (fsender, fe) =>
            {

                if (room.DialogResult == DialogResult.OK)
                {
                    guna2ButtonHome.PerformClick();
                    linkLabelName.Text = room.HoTen;
                }
            };
        }

        private void guna2ButtonShowWorkShift_Click(object sender, EventArgs e)
        {
            ShowShift room = new ShowShift();
            panelShow.Controls.Clear();
            room.TopLevel = false;
            panelShow.Controls.Add(room);
            room.Show();
        }
    }
}
