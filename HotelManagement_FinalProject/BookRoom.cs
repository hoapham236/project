using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{
    public partial class BookRoom : Form
    {
        public BookRoom(string idr)
        {
            InitializeComponent();
            id = idr;
        }
        Room room = new Room();
        MyDatabase db = new MyDatabase();
        Worksession check = new Worksession();
        string id;
        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBoxName.Text == "" || guna2TextBoxCMND.Text == "" || guna2TextBoxAdd.Text == "" || guna2TextBoxPhone.Text == "" || guna2TextBoxNote.Text == "" || guna2TextBoxPrice.Text == "")
                {
                    MessageBox.Show("Empty Valid", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!check.checkname(guna2TextBoxName.Text))
                {
                    MessageBox.Show("Name cannot have number and special char", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!check.hasChar(guna2TextBoxPhone.Text) || guna2TextBoxPhone.Text.Trim().Length != 10)
                {
                    MessageBox.Show("Phone cannot char and enough 10 number", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!check.hasChar(guna2TextBoxCMND.Text) || guna2TextBoxCMND.Text.Trim().Length != 12)
                {
                    MessageBox.Show("CMND cannot char and enough 12 number", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime cin = guna2DateTimePickerFrom.Value;
                DateTime cout = guna2DateTimePickerTo.Value;
                int idroom = Convert.ToInt32(guna2ComboBoxRoom.Text);
                string name = guna2TextBoxName.Text;
                string cmnd = guna2TextBoxCMND.Text;
                string add = guna2TextBoxAdd.Text;
                string phone = guna2TextBoxPhone.Text;
                string note = guna2TextBoxNote.Text;
                int price = Convert.ToInt32(guna2TextBoxPrice.Text);

                if (room.insertRoomBooked(idroom, cin, cout, name, cmnd, add, phone, note, price))
                {
                    MessageBox.Show("Booked Success", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    SqlCommand cmd = new SqlCommand("Update Room set status = @sta where Id =@id", db.getConnection);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idroom;
                    cmd.Parameters.Add("@sta", SqlDbType.NVarChar).Value = "Booking";
                    db.openConnection();
                    cmd.ExecuteNonQuery();
                    foreach (var tam in this.tuples)
                    {
                        if (room.insertService(Worksession.idb, tam.Item1, tam.Item3))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }

                    db.closeConnection();
                }
                else
                {
                    MessageBox.Show("Booked Not Success", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void BookRoom_Load(object sender, EventArgs e)
        {
            guna2ComboBoxRoom.DataSource = room.getAllRoom();
            guna2ComboBoxRoom.DisplayMember = "Id";
            guna2ComboBoxRoom.ValueMember = "Id";

            guna2ComboBoxRoom.Text = id;
            try
            {
                DataTable dt = new DataTable();
                dt = room.getAllRoom();
                foreach (DataRow row in dt.Rows)
                {
                    if (guna2ComboBoxRoom.Text!= "")
                    {
                        if (row[0].ToString() == guna2ComboBoxRoom.Text)
                        {
                            guna2TextBoxFloor.Text = row[1].ToString();
                            guna2TextBoxStatus.Text = row[2].ToString();
                            guna2TextBoxType.Text = row[3].ToString();
                        }
                    }
                }
            }
            catch { }
            
            this.guna2DateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            this.guna2DateTimePickerTo.Format = DateTimePickerFormat.Custom;
            guna2DateTimePickerFrom.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            guna2DateTimePickerTo.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.guna2DateTimePickerFrom.ShowUpDown = true;
            this.guna2DateTimePickerTo.ShowUpDown = true;

            guna2DateTimePickerFrom.Value = DateTime.Now;
            guna2DateTimePickerTo.Value = DateTime.Now;

        }

        private void BookRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFormReceptionist mainForm = new MainFormReceptionist();
            RoomList room = new RoomList();
            mainForm.panelShow.Controls.Clear();
            room.TopLevel = false;
            mainForm.panelShow.Controls.Add(room);
            room.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ChooseExtraService exS = new ChooseExtraService();
            exS.tuples = this.tuples;
            exS.Show();
            exS.FormClosed += (fsender, fe) =>
            {
                if (exS.DialogResult == DialogResult.OK)
                {
                    this.tuples = exS.tuples;

                }
            };
        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }
        public int getPrice(string name)
        {
            DataTable tb = new DataTable();
            SqlCommand command = new SqlCommand("Select Price from Price where Name = @name", db.getConnection);
            command.Parameters.AddWithValue("@name", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(tb);
            int luong = (int)tb.Rows[0]["Price"];
            return luong;
        }

        private void guna2DateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            int price = getPrice(guna2TextBoxType.Text.Trim());
            TimeSpan time = guna2DateTimePickerTo.Value - guna2DateTimePickerFrom.Value;
            float gio = (float)time.TotalHours;
            int gia = (int)Math.Round((gio * price) / 1000) * 1000;
            guna2TextBoxPrice.Text = (gia).ToString();
            guna2TextBoxPrice.Enabled = false;
        }
    }
}
