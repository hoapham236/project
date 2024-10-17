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
    public partial class RoomList : Form
    {
        public static int idroom;
        public RoomList()
        {
            InitializeComponent();
        }
        MyDatabase db = new MyDatabase();
        Room room = new Room();
        public void Room_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Room", db.getConnection);
            db.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            int panelCount = 0;
            while (reader.Read())
            {
                string roomNumber = reader[0].ToString();
                string roomFloor = reader[1].ToString();
                string roomType = reader[3].ToString();
                string roomStatus = reader[2].ToString();

                Panel roomPanel = new Panel();
                roomPanel.Size = new Size(200, 150);
                roomPanel.BorderStyle = BorderStyle.FixedSingle;

                Label roomNumberLabel = new Label();
                roomNumberLabel.Text = "Room: " + roomNumber + "    F" + roomFloor;
                roomNumberLabel.Location = new Point(10, 10);
                roomNumberLabel.AutoSize = true;

                Label roomTypeLabel = new Label();
                roomTypeLabel.Text = "Type:" + roomType;
                roomTypeLabel.Location = new Point(2, 40);
                roomTypeLabel.AutoSize = true;

                Label roomStatusLabel = new Label();
                roomStatusLabel.Text = "Status: " + roomStatus;
                roomStatusLabel.Location = new Point(10, 70);
                roomStatusLabel.AutoSize = true;

                if (roomStatus == "Blank")
                {
                    Button btnBook = new Button();
                    btnBook.Text = "Book";
                    btnBook.Size = new Size(80, 30);
                    btnBook.Location = new Point(50, 100);
                    btnBook.AutoSize = true;
                    btnBook.Click += (bookSender, bookEvent) =>
                    {

                        BookRoom bookRoom = new BookRoom(roomNumber);
                        bookRoom.Show();
                        bookRoom.FormClosed += (fsender, fe) =>
                        {
                            // Kiểm tra khi form CleanerList đã đóng
                            if (bookRoom.DialogResult == DialogResult.OK)
                            {
                                btnBook.Dispose();
                                roomPanel.BackColor = Color.IndianRed;
                                roomStatusLabel.Text = "Status: " + "Booking";

                                Button btnCheckout = new Button();
                                btnCheckout.Text = "Check-out";
                                btnCheckout.Size = new Size(80, 30);
                                btnCheckout.Location = new Point(30, 100);
                                btnCheckout.AutoSize = true;
                                btnCheckout.Click += (CheckoutSender, CheckoutEvent) =>
                                {
                                    idroom = Convert.ToInt32(roomNumber);
                                    CheckOutRoom check = new CheckOutRoom();
                                    check.Show();
                                };

                                roomPanel.Controls.Add(btnBook);
                                roomPanel.Controls.Add(btnCheckout);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        };
                    };

                    roomPanel.Controls.Add(btnBook);

                }
                else if (roomStatus == "Not Cleaned")
                {
                    Button btnClean = new Button();
                    btnClean.Text = "Clean";
                    btnClean.Size = new Size(80, 30);
                    btnClean.Location = new Point(50, 100);
                    btnClean.AutoSize = true;

                    roomPanel.Controls.Add(btnClean);
                    int check = 0;
                    btnClean.Click += (CleanSender, CleanEvent) =>
                    {
                        CleanerList FormCleaner = new CleanerList(check);
                        FormCleaner.idRoom = Convert.ToInt32(roomNumber);
                        FormCleaner.FormBorderStyle = FormBorderStyle.Sizable;
                        FormCleaner.guna2GradientButtonCleanR.Visible = true;
                        FormCleaner.Show();
                        FormCleaner.FormClosed += (fsender, fe) =>
                        {
                            // Kiểm tra khi form CleanerList đã đóng
                            if (FormCleaner.DialogResult == DialogResult.OK)
                            {
                                roomPanel.BackColor = Color.Yellow;
                                // Nếu form CleanerList được đóng lại với DialogResult là OK, cập nhật trạng thái của phòng và vô hiệu hóa nút Clean
                                roomStatusLabel.Text = "Status: " + "Cleaning";
                                SqlCommand cmd1 = new SqlCommand("update Room set status=@sta where Id=@id", db.getConnection);
                                cmd1.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(roomNumber);
                                cmd1.Parameters.Add("@sta", SqlDbType.NVarChar).Value = "Cleaning";
                                db.openConnection();
                                cmd1.ExecuteNonQuery();
                                db.closeConnection();
                                btnClean.Visible = false;
                            }
                        };
                    };
                }
                else if (roomStatus == "Booking") // booked
                {
                    Button btnCheckout = new Button();
                    btnCheckout.Text = "Check-out";
                    btnCheckout.Size = new Size(80, 30);
                    btnCheckout.Location = new Point(40, 100);
                    btnCheckout.AutoSize = true;
                    btnCheckout.Click += (CheckoutSender, CheckoutEvent) =>
                    {
                        idroom = Convert.ToInt32(roomNumber);
                        CheckOutRoom check = new CheckOutRoom();
                        check.Show();
                        check.FormClosed += (fsender, fe) =>
                        {
                            // Kiểm tra khi form CleanerList đã đóng
                            if (check.DialogResult == DialogResult.OK)
                            {
                                roomStatusLabel.Text = "Status: " + "Not Cleaned";
                                roomPanel.BackColor= Color.YellowGreen;
                                Button btnBook = new Button();
                                btnBook.Text = "Clean";
                                btnBook.Size = new Size(80, 30);
                                btnBook.Location = new Point(50, 100);
                                btnBook.AutoSize = true;
                                int check2 = 0;
                                btnBook.Click += (bookSender, bookEvent) =>
                                {

                                    CleanerList FormCleaner = new CleanerList(check2);
                                    FormCleaner.idRoom = Convert.ToInt32(roomNumber);
                                    FormCleaner.FormBorderStyle = FormBorderStyle.Sizable;
                                    FormCleaner.guna2GradientButtonCleanR.Visible = true;
                                    FormCleaner.Show();
                                    FormCleaner.FormClosed += (csender, ce) =>
                                    {
                                        // Kiểm tra khi form CleanerList đã đóng
                                        if (FormCleaner.DialogResult == DialogResult.OK)
                                        {
                                            roomPanel.BackColor = Color.Yellow;
                                            // Nếu form CleanerList được đóng lại với DialogResult là OK, cập nhật trạng thái của phòng và vô hiệu hóa nút Clean
                                            roomStatusLabel.Text = "Status: " + "Cleaning";
                                            SqlCommand cmd1 = new SqlCommand("update Room set status=@sta where Id=@id", db.getConnection);
                                            cmd1.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(roomNumber);
                                            cmd1.Parameters.Add("@sta", SqlDbType.NVarChar).Value = "Cleaning";
                                            db.openConnection();
                                            cmd1.ExecuteNonQuery();
                                            db.closeConnection();
                                            btnBook.Visible = false;
                                        }
                                    };
                                };
                                roomPanel.Controls.Add(btnBook);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        };
                    };
                    roomPanel.Controls.Add(btnCheckout);
                }
                else if (roomStatus == "Cleaning")
                {
                    Button btnClean = new Button();
                    btnClean.Text = "Clean";
                    btnClean.Size = new Size(80, 30);
                    btnClean.Location = new Point(50, 100);
                    btnClean.AutoSize = true;
                    btnClean.Enabled = false;
                }    
                roomPanel.Controls.Add(roomNumberLabel);
                roomPanel.Controls.Add(roomTypeLabel);
                roomPanel.Controls.Add(roomStatusLabel);

                if (roomStatusLabel.Text == "Status: Blank")
                {
                    roomPanel.BackColor = Color.Teal;
                }    
                else if (roomStatusLabel.Text == "Status: Booking")
                {
                    roomPanel.BackColor = Color.IndianRed;
                }    
                else if (roomStatusLabel.Text == "Status: Not Cleaned")
                {
                    roomPanel.BackColor= Color.YellowGreen;
                }    
                else if (roomStatusLabel.Text == "Status: Cleaning")
                {
                    roomPanel.BackColor = Color.Yellow;
                }    
                flowLayoutPanel1.Controls.Add(roomPanel);
                panelCount++;
            }
            reader.Close();
            db.closeConnection();
        }


    }
}
