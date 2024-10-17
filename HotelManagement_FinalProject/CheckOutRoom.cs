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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HotelManagement_FinalProject
{
    public partial class CheckOutRoom : Form
    {
        public static int price;
        public static int idbil;
        public CheckOutRoom()
        {
            InitializeComponent();
        }
        MyDatabase db = new MyDatabase();
        int idr = RoomList.idroom;
        Room room = new Room();
        int total = 0;
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonPay_Click(object sender, EventArgs e)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("update BookRoom set status=@status where IdBil=@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = room.getIdBill(idr, guna2DateTimePickerFrom.Value, guna2DateTimePickerTo.Value, guna2TextBoxName.Text);
            cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Paid";

            SqlCommand cmd1 = new SqlCommand("update Room set status=@status where Id=@id", db.getConnection);
            cmd1.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(guna2TextBoxRoom.Text);
            cmd1.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Not Cleaned";
            if (cmd.ExecuteNonQuery() == 1 && cmd1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Paid", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Not Paid", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckOutRoom_Load(object sender, EventArgs e)
        {
            guna2DateTimePickerFrom.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            guna2DateTimePickerTo.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            DataTable table = new DataTable();
            table = room.getAllBookRoom();
            foreach (DataRow row in table.Rows)
            {
                if ((int)row[1] == idr && row[10].ToString() == "Booking")
                {
                    guna2TextBoxName.Text = row[4].ToString();
                    guna2TextBoxRoom.Text = row[1].ToString();
                    guna2DateTimePickerFrom.Value = (DateTime)row[2];
                    guna2DateTimePickerTo.Value = (DateTime)row[3];
                }
            }

            int idbill = room.getIdBill(idr, guna2DateTimePickerFrom.Value, guna2DateTimePickerTo.Value, guna2TextBoxName.Text);

            SqlCommand cmd = new SqlCommand("Select IdBill as 'ID', Name as 'Service Name', SL as 'Amount', SL * Price as 'Price' from ExtraService join Service on ExtraService.IdService = Service.Id where IdBill = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idbill;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            SqlCommand cmd1 = new SqlCommand("Select IdBill as 'ID', TenMon as 'Service Name', SL as 'Amount', SL * GiaMon as 'Price' from Mon join ExtraService on ExtraService.IdService = Mon.IdMon where IdBill = @id", db.getConnection);
            cmd1.Parameters.Add("@id", SqlDbType.Int).Value = idbill;
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            adapter1.Fill(table1);
            guna2DataGridView1.DataSource = table1;

            total = 0;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    total += Convert.ToInt32(row.Cells[3].Value);
                }
            }
            total = total + getPrice(idbill);
            guna2HtmlLabelTotal.Text = "Total payment: " + total.ToString();
            labelPrice.Text = "Price of Room : " + getPrice(idbill).ToString();
            price = total;
            idbil = idbill;
            guna2DataGridView1.ColumnHeadersHeight = 28;
        }
        public int getPrice(int idbill)
        {
            SqlCommand cmd = new SqlCommand("SELECT price FROM BookRoom WHERE IdBil = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idbill;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);

            // Kiểm tra xem DataTable có hàng không
            if (table1.Rows.Count > 0)
            {
                // Lấy giá trị của cột price từ hàng đầu tiên và chuyển đổi thành kiểu int
                int price = Convert.ToInt32(table1.Rows[0]["price"]);
                return price;
            }
            else
            {
                // Nếu không có hàng nào thỏa mãn điều kiện, trả về giá trị mặc định hoặc thực hiện xử lý phù hợp
                return 0; // hoặc trả về giá trị khác tùy thuộc vào yêu cầu của bạn
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            XuatBill xuatBill = new XuatBill();
            xuatBill.Show();
        }
    }
}
