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
    public partial class ManageRoomList : Form
    {
        public ManageRoomList()
        {
            InitializeComponent();
        }
        public static int idroom;
        MyDatabase db = new MyDatabase();
        Room room = new Room();
        public void ManageRoomList_Load(object sender, EventArgs e)
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
                roomTypeLabel.Text = "Type: " + roomType;
                roomTypeLabel.Location = new Point(10, 40);
                roomTypeLabel.AutoSize = true;

                Label roomStatusLabel = new Label();
                roomStatusLabel.Text = "Status: " + roomStatus;
                roomStatusLabel.Location = new Point(10, 70);
                roomStatusLabel.AutoSize = true;

                if (roomStatus == "Blank")
                {
                    roomPanel.BackColor = Color.LightGreen;
                    Button btnBook = new Button();
                    btnBook.Text = "Book";
                    btnBook.Size = new Size(80, 30);
                    btnBook.Location = new Point(0, 100);
                    btnBook.AutoSize = true;
                    btnBook.Click += (bookSender, bookEvent) =>
                    {
                        BookRoom bookRoom = new BookRoom(roomNumber);
                        bookRoom.Show();
                    };

                    Button btnCheckin = new Button();
                    btnCheckin.Text = "Check-in";
                    btnCheckin.Size = new Size(80, 30);
                    btnCheckin.Location = new Point(85, 100);
                    btnCheckin.AutoSize = true;

                    roomPanel.Controls.Add(btnBook);
                    roomPanel.Controls.Add(btnCheckin);
                }
                else if (roomStatus == "Not Cleaned")
                {
                    roomPanel.BackColor = Color.YellowGreen;
                    Button btnBook = new Button();
                    btnBook.Text = "Book";
                    btnBook.Size = new Size(80, 30);
                    btnBook.Location = new Point(0, 100);
                    btnBook.AutoSize = true;
                    btnBook.Click += (bookSender, bookEvent) =>
                    {
                        BookRoom bookRoom = new BookRoom(roomNumber);
                        bookRoom.Show();
                    };

                    Button btnClean = new Button();
                    btnClean.Text = "Clean";
                    btnClean.Size = new Size(80, 30);
                    btnClean.Location = new Point(85, 100);
                    btnClean.AutoSize = true;

                    roomPanel.Controls.Add(btnBook);
                    roomPanel.Controls.Add(btnClean);
                    btnClean.Click += (CleanSender, CleanEvent) =>
                    {
                        CleanerList FormCleaner = new CleanerList(0);
                        FormCleaner.idRoom = Convert.ToInt32(roomNumber);
                        FormCleaner.FormBorderStyle = FormBorderStyle.Sizable;
                        FormCleaner.guna2GradientButtonCleanR.Visible = true;
                        FormCleaner.Show();
                    };
                }
                else // booked
                {
                    roomPanel.BackColor = Color.IndianRed;
                    Button btnBook = new Button();
                    btnBook.Text = "Book";
                    btnBook.Size = new Size(80, 30);
                    btnBook.Location = new Point(0, 100);
                    btnBook.AutoSize = true;

                    Button btnCheckout = new Button();
                    btnCheckout.Text = "Check-out";
                    btnCheckout.Size = new Size(80, 30);
                    btnCheckout.Location = new Point(80, 100);
                    btnCheckout.AutoSize = true;
                    btnCheckout.Click += (CheckoutSender, CheckoutEvent) =>
                    {
                        idroom = Convert.ToInt32(roomNumber);
                        CheckOutRoom check = new CheckOutRoom();
                        check.Show();
                    };

                    roomPanel.Controls.Add(btnBook);
                    roomPanel.Controls.Add(btnCheckout);
                }
                roomPanel.Controls.Add(roomNumberLabel);
                roomPanel.Controls.Add(roomTypeLabel);
                roomPanel.Controls.Add(roomStatusLabel);


                flowLayoutPanel1.Controls.Add(roomPanel);
                panelCount++;
            }
            reader.Close();
            db.closeConnection();
        }


    }
}

