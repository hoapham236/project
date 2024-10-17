using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Diagnostics;

namespace HotelManagement_FinalProject
{
    internal class Room
    {
        MyDatabase mydb = new MyDatabase();
        public DataTable getAllRoom()
        {
            SqlCommand command = new SqlCommand("Select * from Room", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateRoom(int id,string status)
        {
            SqlCommand command = new SqlCommand("Update Room SET status=@status where Id = @idb", mydb.getConnection);
            command.Parameters.Add("@idb", SqlDbType.Int).Value = id;
            command.Parameters.AddWithValue("@status",status);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {

                return true; 
            }
            else
            {

                return false;
            }
        }
        public bool insertService(int id, string idService,int sl)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ExtraService(IdBill,IdService,SL) values (@idbill,@id,@sl)", mydb.getConnection);
            command.Parameters.AddWithValue("@idbill", id);
            command.Parameters.AddWithValue("@id",idService);
            command.Parameters.AddWithValue("@sl", sl);

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public int getIdBill(int idr, DateTime timecin, DateTime timecout, string customerName)
        {
            SqlCommand command = new SqlCommand("SELECT IdBil FROM BookRoom WHERE IdRoom = @id AND TimeCin = @cin AND TimeCout = @cout AND name = @customerName", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idr;
            command.Parameters.Add("@cin", SqlDbType.DateTime).Value = timecin;
            command.Parameters.Add("@cout", SqlDbType.DateTime).Value = timecout;
            command.Parameters.Add("@customerName", SqlDbType.NVarChar).Value = customerName;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);

            // Kiểm tra xem DataTable có hàng không
            if (table1.Rows.Count > 0)
            {
                // Lấy giá trị IdBil từ hàng đầu tiên và chuyển đổi thành kiểu int
                int idBill = Convert.ToInt32(table1.Rows[0]["IdBil"]);
                mydb.closeConnection(); // Đóng kết nối sau khi hoàn thành
                return idBill;
            }
            else
            {
                // Nếu không tìm thấy kết quả phù hợp, đóng kết nối và trả về một giá trị mặc định hoặc thực hiện xử lý phù hợp
                mydb.closeConnection();
                return 0; // hoặc trả về giá trị khác tùy thuộc vào yêu cầu của bạn
            }
        }

        public DataTable getAllBookRoom()
        {
            SqlCommand command = new SqlCommand("Select * from BookRoom", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int creatIdBill()
        {
            SqlCommand command = new SqlCommand("Select * from BookRoom", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return (dt.Rows.Count);
        }
        public bool insertRoomBooked(int idroom, DateTime TimeCin, DateTime TimeCout, string name, string cmnd,string add, string phone, string note, int price)
        {
            Worksession.idb = creatIdBill() + 1;
            SqlCommand command = new SqlCommand("INSERT INTO BookRoom (IdBil,IdRoom,TimeCin,TimeCout,name,CMND,address,phone,note,price,status) VALUES (@idb,@idr,@timecin,@timeout,@name,@cmnd,@add,@phone,@note,@price,@status)", mydb.getConnection);
            command.Parameters.Add("@idb", SqlDbType.Int).Value = Worksession.idb;
            command.Parameters.Add("@idr", SqlDbType.Int).Value = idroom;
            command.Parameters.Add("@timecin", SqlDbType.DateTime).Value = TimeCin;
            command.Parameters.Add("@timeout", SqlDbType.DateTime).Value = TimeCout;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = add;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = "Booking";

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {

                return true;
            }
            else
            {

                return false;
            }
        }
        public bool updateRoomBooked(int idBil, int idroom, string name, string cmnd, string add, string phone, string note, string status)
        {
            SqlCommand command = new SqlCommand("Update BookRoom SET IdRoom=@idr, name=@name, CMND=@cmnd, address=@add, phone=@phone, note=@note, status=@status where IdBil = @idb", mydb.getConnection);
            command.Parameters.Add("@idb", SqlDbType.Int).Value = idBil;
            command.Parameters.Add("@idr", SqlDbType.Int).Value = idroom;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = add;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {

                return true;
            }
            else
            {

                return false;
            }
        }
        public bool addRoom(int id, int floor, string status, string type)
        {
            SqlCommand command = new SqlCommand("Insert into Room(Id,floor,status,type) Values(@Id,@floor,@status,@type)", mydb.getConnection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@floor", floor);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@type", type);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool checkExistidRoom(int id)
        {
            SqlCommand command = new SqlCommand("Select * from Room where Id = @id", mydb.getConnection);
            command.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateRoom(int id, int floor, string status, string type)
        {
            SqlCommand command = new SqlCommand("Update Room set floor = @floor,status = @status,type = @type where id = @id", mydb.getConnection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@floor", floor);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@type", type);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public bool deleteRoom(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Room WHERE Id = @id", mydb.getConnection);
            command.Parameters.AddWithValue("@id", id);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
