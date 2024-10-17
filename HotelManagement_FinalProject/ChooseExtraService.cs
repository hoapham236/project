using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace HotelManagement_FinalProject
{
    public partial class ChooseExtraService : Form
    {
        public ChooseExtraService()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();
        Kho kho = new Kho();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public DataTable getData(SqlCommand command)
        {
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable getMon(DataTable mon)
        {
            DataTable filteredMon = mon.Clone();

            foreach (DataRow dr in mon.Rows)
            {
                string idMon = dr[0].ToString();
                SqlCommand command = new SqlCommand("SELECT IdNL, SL FROM CongThuc WHERE Idmon = @id", mydb.getConnection);
                command.Parameters.AddWithValue("@id", idMon);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                bool shouldIncludeRow = true;
                foreach (DataRow dataRow in dt.Rows)
                {
                    string id = dataRow[0].ToString();
                    double sl = Convert.ToDouble(dataRow[1]);
                    if (!kho.CheckNLCon(id, sl))   // If not available
                    {
                        shouldIncludeRow = false;
                        break;
                    }
                }

                if (shouldIncludeRow)
                {
                    filteredMon.ImportRow(dr);
                }
            }

            return filteredMon;
        }
        private void ChooseExtraService_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Service", mydb.getConnection);
            listBoxService.DataSource = getData(command);
            listBoxService.ValueMember = "Id";
            listBoxService.DisplayMember = "Name";
            listBoxService.SelectedItem = null;

            SqlCommand command1 = new SqlCommand("Select * from Mon", mydb.getConnection);
            DataTable mon = getData(command1);
            listBoxMon.DataSource = getMon(mon);
            listBoxMon.ValueMember = "IdMon";
            listBoxMon.DisplayMember = "TenMon";
            listBoxMon.SelectedItem = null;


            panelShow.Controls.Clear();
            panelShow.Controls.Add(label3);
            int vitri = 30;
            foreach (var x in this.tuples)
            {
                Label labelname = new Label();

                labelname.Text = x.Item2;
                labelname.Location = new Point(80, vitri);
                panelShow.Controls.Add(labelname);



                Label labelsl = new Label();

                labelsl.Text = x.Item3.ToString();
                labelsl.Location = new Point(400, vitri);
                panelShow.Controls.Add(labelsl);

                vitri += 20;

            }

        }
        string id;
        private void listBoxService_Click(object sender, EventArgs e)
        {
            string name = listBoxService.GetItemText(listBoxService.SelectedItem);
            id = listBoxService.SelectedValue.ToString();
            textBoxName.Text = name;

        }

        private void listBoxMon_Click(object sender, EventArgs e)
        {
            string tenMon = listBoxMon.GetItemText(listBoxMon.SelectedItem);
            id = listBoxMon.SelectedValue.ToString();
            textBoxName.Text = tenMon;
            numericUpDown1.Maximum = NumberMon(id);
        }

        private void listBoxMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int NumberMon(string idMon)
        {
            int maxInstances = int.MaxValue; // Set an initial value

            SqlCommand command = new SqlCommand("SELECT IdNL, SL FROM CongThuc WHERE Idmon = @id", mydb.getConnection);
            command.Parameters.AddWithValue("@id", idMon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dataRow in dt.Rows)
            {
                string id = dataRow[0].ToString();
                double sl = 0;
                if (double.TryParse(dataRow[1].ToString(), out sl)) // Safely parse SL to double
                {
                    int instances = 1;
                    while (kho.CheckNLCon(id, sl * instances)) // Increment instances until it's not available
                    {
                        instances++;
                    }
                    maxInstances = Math.Min(maxInstances, instances - 1); // Update maxInstances
                }
                else
                {

                }
            }
            return maxInstances;
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            foreach (var x in this.tuples)
            {
                if (x.Item1 == id)
                {
                    this.tuples.Remove(x);
                    break;
                }
            }
            this.tuples.Add(new Tuple<string, string, int>(id, textBoxName.Text, (int)numericUpDown1.Value));
            panelShow.Controls.Clear();
            panelShow.Controls.Add(label3);
            int vitri = 30;
            foreach (var x in this.tuples)
            {
                Label labelname = new Label();

                labelname.Text = x.Item2;
                labelname.Location = new Point(80, vitri);
                panelShow.Controls.Add(labelname);



                Label labelsl = new Label();

                labelsl.Text = x.Item3.ToString();
                labelsl.Location = new Point(400, vitri);
                panelShow.Controls.Add(labelsl);

                vitri += 20;

            }
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
