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
    public partial class ShowShift : Form
    {
        public ShowShift()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();
        private void guna2ButtonTotal_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select ID from LichLam where [Ngay] = @day", mydb.getConnection);

        }

        private int DaysSinceBeginOfWeek(DateTime dt)
        {
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return 0;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Saturday:
                    return 5;
                case DayOfWeek.Sunday:
                    return 6;
            }
            throw new Exception("impossible happened");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "This week")
            {
                var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
                var endOfWeek = beginOfWeek.AddDays(6);
                guna2DateTimePicker1.Value = beginOfWeek;
                guna2DateTimePicker2.Value = endOfWeek;
            }
            else if (comboBox1.Text == "Next week")
            {
                var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
                var endOfWeek = beginOfWeek.AddDays(6);
                guna2DateTimePicker1.Value = beginOfWeek.AddDays(7);
                guna2DateTimePicker2.Value = endOfWeek.AddDays(7);
            }
            else
            {
                var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
                var endOfWeek = beginOfWeek.AddDays(6);
                guna2DateTimePicker1.Value = beginOfWeek.AddDays(14);
                guna2DateTimePicker2.Value = endOfWeek.AddDays(14);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }    
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }    
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }    
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek;
            dt.ca = "Day";
            dt.Show();
        }

        private void guna2ImageButton9_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek;
            dt.ca = "Night";
            dt.Show();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(1);
            dt.ca = "Day";
            dt.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(1);
            dt.ca = "Night";
            dt.Show();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(2);
            dt.ca = "Day";
            dt.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(2);
            dt.ca = "Night";
            dt.Show();
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(3);
            dt.ca = "Day";
            dt.Show();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(3);
            dt.ca = "Night";
            dt.Show();
        }

        private void guna2ImageButton10_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(4);
            dt.ca = "Day";
            dt.Show();
        }

        private void guna2ImageButton12_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(5);
            dt.ca = "Day";
            dt.Show();
        }

        private void guna2ImageButton14_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(6);
            dt.ca = "Day";
            dt.Show();
        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(4);
            dt.ca = "Night";
            dt.Show();
        }

        private void guna2ImageButton11_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(5);
            dt.ca = "Night";
            dt.Show();
        }

        private void guna2ImageButton13_Click(object sender, EventArgs e)
        {
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            if (comboBox1.Text == "This week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            }
            else if (comboBox1.Text == "Next week")
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(7);
            }
            else
            {
                beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now)).AddDays(14);
            }
            DetailShift dt = new DetailShift();
            dt.date = beginOfWeek.AddDays(6);
            dt.ca = "Night";
            dt.Show();
        }

        private void guna2ButtonYourShift_Click(object sender, EventArgs e)
        {
            pictureBoxDay1.Visible = false;
            pictureBoxDay2.Visible = false;
            pictureBoxDay3.Visible = false;
            pictureBoxDay4.Visible = false;
            pictureBoxDay5.Visible = false;
            pictureBoxDay6.Visible = false;
            pictureBoxDay7.Visible = false;

            pictureBoxNight1.Visible = false;
            pictureBoxNight2.Visible = false;
            pictureBoxNight3.Visible = false;
            pictureBoxNight4.Visible = false;
            pictureBoxnight5.Visible = false;
            pictureBoxNight6.Visible = false;
            pictureBoxNight7.Visible = false;



            panelYourShift.Show();
            panelYourShift.Visible = true;
            panelCalender.Visible = false;
            SqlCommand command = new SqlCommand("Select Ngay,Ca from LichLam where ID = @id and [Ngay] >= @dayfrom and [Ngay] <= @dayto", mydb.getConnection);
            command.Parameters.AddWithValue("@id", LoginForm.idlogin);
            command.Parameters.Add("@dayfrom", SqlDbType.Date).Value = guna2DateTimePicker1.Value;
            command.Parameters.Add("@dayto", SqlDbType.Date).Value = guna2DateTimePicker2.Value;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            var beginOfWeek = guna2DateTimePicker1.Value.Date;
            var thu3 = beginOfWeek.AddDays(1);
            var thu4 = beginOfWeek.AddDays(2);
            var thu5 = beginOfWeek.AddDays(3);
            var thu6 = beginOfWeek.AddDays(4);
            var thu7 = beginOfWeek.AddDays(5);
            var cn = beginOfWeek.AddDays(6);
            foreach (DataRow row in dt.Rows)
            {
                if (DateTime.Parse(row[0].ToString()).Date == beginOfWeek)
                {
                    if ((int)row[1] == 1)
                    {
                        pictureBoxDay1.Visible = true;
                    }
                    else
                        pictureBoxNight1.Visible = true;
                }
                if (DateTime.Parse(row[0].ToString()).Date == thu3)
                {
                    if ((int)row[1] == 1)
                    {
                        pictureBoxDay2.Visible = true;
                    }
                    else
                        pictureBoxNight2.Visible = true;
                }
                if (DateTime.Parse(row[0].ToString()).Date == thu4)
                {
                    if ((int)row[1] == 1)
                    {
                        pictureBoxDay3.Visible = true;
                    }
                    else
                        pictureBoxNight3.Visible = true;
                }
                if (DateTime.Parse(row[0].ToString()).Date == thu5)
                {
                    if ((int)row[1] == 1)
                    {
                        pictureBoxDay4.Visible = true;
                    }
                    else
                        pictureBoxNight4.Visible = true;
                }
                if (DateTime.Parse(row[0].ToString()).Date == thu6)
                {
                    if ((int)row[1] == 1)
                    {
                        pictureBoxDay5.Visible = true;
                    }
                    else
                        pictureBoxnight5.Visible = true;
                }
                if (DateTime.Parse(row[0].ToString()).Date == thu7)
                {
                    if ((int)row[1] == 1)
                    {
                        pictureBoxDay6.Visible = true;
                    }
                    else
                        pictureBoxNight6.Visible = true;
                }
                if (DateTime.Parse(row[0].ToString()).Date == cn)
                {
                    if ((int)row[1] == 1)
                    {
                        pictureBoxDay7.Visible = true;
                    }
                    else
                        pictureBoxNight7.Visible = true;
                }

            }
        }
        Employee employee = new Employee();
             
        private void ShowShift_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            if (employee.getNV(LoginForm.idlogin) == "Manager")
                guna2Button1.Visible = true;
            var beginOfWeek = DateTime.Now.AddDays(-1 * DaysSinceBeginOfWeek(DateTime.Now));
            var endOfWeek = beginOfWeek.AddDays(6);
            guna2DateTimePicker1.Value = beginOfWeek;
            guna2DateTimePicker2.Value = endOfWeek;
            guna2ButtonYourShift.PerformClick();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelCalender.Show();
            panelCalender.Visible = true;
            panelYourShift.Visible = false;
        }


    }
}
