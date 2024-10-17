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
    public partial class HistoryFormCleaner : Form
    {
        HotelSystem htSystem = new HotelSystem();
        List<string> listMonth = new List<string>();
        Employee employee = new Employee();
        public HistoryFormCleaner()
        {
            InitializeComponent();
            string str = "01";
            int t = 0;
            for (int i = 2; i <= 13; i++)
            {
                listMonth.Add(str);
                t = i;
                if (t < 10)
                {
                    str = "0" + t.ToString();
                }
                else
                {
                    str = t.ToString();
                }
            }
            guna2ComboBox1.DataSource = listMonth;
            guna2ComboBox1.Text = DateTime.Now.ToString("MM");


        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKS1DataSet5.CALAM' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qLKS1DataSet4.CALAM' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLKS1DataSet3.CALAM' table. You can move, or remove it, as needed.

            string month = guna2ComboBox1.Text;
            guna2DataGridView1.DataSource = htSystem.getHistory(id,month);
            guna2DataGridView1.Show();
            guna2DataGridView1.ColumnHeadersHeight = 28;
            //labelLateTimes.Text = "Late for work: " + htSystem.countLateTimes(id, month).ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            month = guna2ComboBox1.Text;
            guna2DataGridView1.DataSource = htSystem.getHistory(id,month);
            guna2DataGridView1.Show();
           // labelLateTimes.Text = "Late for work: " + htSystem.countLateTimes(id, month).ToString();
        }

        private void guna2ButtonCheck_Click(object sender, EventArgs e)
        {
            month = guna2ComboBox1.Text;
            guna2DataGridView1.DataSource = htSystem.getHistory(id, month);
            guna2DataGridView1.Show();
           // labelLateTimes.Text = "Late for work: " + htSystem.countLateTimes(id, month).ToString();


        }
    }
}
