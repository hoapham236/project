using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;

namespace HotelManagement_FinalProject
{
    enum Role { Manager,Receptionist,Cleaner}
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Role Role { get; set; }

        MyDatabase db = new MyDatabase();
        HotelSystem htSystem = new HotelSystem();

        public List<Worksession> Worksessions { get; set; } = new List<Worksession>();

        public bool addEmployee(string id, string name, DateTime bdate, string address, string phone, string nghiepvu, MemoryStream picture, string email, string gender)
        {
            SqlCommand command = new SqlCommand("Insert into NHANVIEN(ID,HoTen,NgaySinh,DiaChi,Sdt,NghiepVu,Anh,Email,GioiTinh) Values(@ID,@name,@bdt,@dc,@phn,@nv,@pic,@email,@gt)", db.getConnection);
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.AddWithValue("@dc", address);
            command.Parameters.AddWithValue("@phn", phone);
            command.Parameters.AddWithValue("@nv", nghiepvu);
            command.Parameters.AddWithValue("@gt", gender);
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool addAccount(string username,string pass,string status)
        {
            SqlCommand command = new SqlCommand("Insert into LOGIN(Username,Password,Status) Values(@us,@pa,@sta)", db.getConnection);
            command.Parameters.AddWithValue("@us", username);
            command.Parameters.AddWithValue("@pa", pass);
            command.Parameters.AddWithValue("@sta", status);
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool deleteAccount(string username)
        {
            SqlCommand command = new SqlCommand("Delete from LOGIN where Username = @us", db.getConnection);
            command.Parameters.AddWithValue("@us", username);

            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool updateEmployee(string id, string name , DateTime bdate, string address,string phone,string nghiepvu, MemoryStream picture, string email, string gender)
        {
            SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET HoTen=@name,NgaySinh=@bdt, DiaChi = @dc,sdt=@phn,NghiepVu = @nv, Anh=@pic,Email =@email,GioiTinh = @gt WHERE ID=@ID", db.getConnection);
            command.Parameters.Add("@ID",SqlDbType.NVarChar).Value = id; 
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.AddWithValue("@dc", address);
            command.Parameters.AddWithValue("@phn", phone);
            command.Parameters.AddWithValue("@nv", nghiepvu);
            command.Parameters.AddWithValue("@gt",gender);
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool deleteEmployee(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NHANVIEN WHERE ID = @id", db.getConnection);
            command.Parameters.AddWithValue("@id", id);
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public DataTable getAllEmployee()
        {
            SqlCommand command = new SqlCommand("Select ID,HoTen as 'Full Name',NgaySinh as Birthdate,GioiTinh as Gender,DiaChi as Address,Sdt as 'Phone Number',NghiepVu as 'Role',Anh as Picture,Email from NHANVIEN", db.getConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public string getNV(string id)
        {
            SqlCommand command = new SqlCommand("Select NghiepVu from NHANVIEN where ID = @id", db.getConnection);
            command.Parameters.AddWithValue("@id", id);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt.Rows[0]["NghiepVu"].ToString();

        }
        public DataTable getAllExcepEmployee(string nv)
        {
            SqlCommand command = new SqlCommand("Select ID,HoTen as 'Full Name',NgaySinh as Birthdate,GioiTinh as Gender,DiaChi as Address,Sdt as 'Phone Number',NghiepVu as 'Role',Anh as Picture,Email from NHANVIEN where NghiepVu != @nv", db.getConnection);
            command.Parameters.AddWithValue("@nv", nv);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;

        }

        public bool checkID(string id)
        {
            SqlCommand command = new SqlCommand("Select * from NHANVIEN where id = @id", db.getConnection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            SqlCommand command1 = new SqlCommand("Select * from CALAM where id = @id", db.getConnection);
            command1.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adap1 = new SqlDataAdapter(command1);
            DataTable dt1 = new DataTable();
            adap1.Fill(dt1);

            if (dt.Rows.Count > 0 || dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public DataTable getEmByNghiepVu(string nv)
        {
            SqlCommand command = new SqlCommand("Select ID,HoTen as 'Full Name',NgaySinh as Birthdate,GioiTinh as Gender,DiaChi as Address,Sdt as 'Phone Number',NghiepVu as 'Role',Anh as Picture,Email from NHANVIEN where NghiepVu = @nv ", db.getConnection);
            command.Parameters.AddWithValue("@nv", nv);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;

        }
        // Ham insert de them vao data kieu checkin la Day and Night 
        public bool insertCheckin(string ID, DateTime Ngay, TimeSpan GioVao, TimeSpan GioRa, string Ca)
        {
            
            SqlCommand command = new SqlCommand("Insert into CALAM (ID,Ngay,GioVao,GioRa,Ca) Values (@id,@ngay,@giovao,@giora,@ca)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@ngay", SqlDbType.Date).Value = Ngay;
            command.Parameters.Add("@giovao", SqlDbType.Time).Value = GioVao;
            command.Parameters.Add("@giora", SqlDbType.Time).Value = GioRa;
            command.Parameters.Add("@ca", SqlDbType.NVarChar).Value = Ca;
           

            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        // Ham update de cap nhat time lam bu cho ca chinh o ham insert 
        public bool updateCheckinout (string ID, DateTime Ngay,TimeSpan GioVao, TimeSpan GioRa)
        {
           
            SqlCommand command = new SqlCommand("UPDATE CALAM SET Ngay=@ngay,checkinBu=@giovao, checkoutBu=@giora,SoGioBu = @timeBu WHERE ID=@id and Ngay = @ngay", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@ngay", SqlDbType.Date).Value = Ngay;
            command.Parameters.Add("@giovao", SqlDbType.Time).Value = GioVao;
            command.Parameters.Add("@giora", SqlDbType.Time).Value = GioRa;
            TimeSpan SoGioBu = GioRa - GioVao;
            command.Parameters.Add("@timeBu", SqlDbType.Int).Value = SoGioBu.TotalHours;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public double luong(TimeSpan giovao, TimeSpan giora, string nghiepvu)
        {
            TimeSpan gio = giora - giovao;
            if (gio < TimeSpan.Zero)
            {
                gio = -gio;
            }
            double sogio = (double)gio.TotalHours;
            if (nghiepvu == "Cleaner")
            {
                return sogio * htSystem.luongLC;
            }
            else if (nghiepvu == "Receptionist")
            {
                return sogio * htSystem.luongTT;
            }
            return -1;
        }

        public void updateSalary(string ngay)
        {
            DataTable tb = new DataTable();
            db.openConnection();
            SqlCommand command = new SqlCommand("Select CALAM.ID,GioVao,GioRa,NghiepVu From CALAM join NHANVIEN on CALAM.ID = NHANVIEN.ID Where Ngay=@ngay", db.getConnection);
            command.Parameters.AddWithValue("@ngay", ngay);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(tb);
            foreach (DataRow dr in tb.Rows)
            {
                SqlCommand cmd = new SqlCommand("Update CALAM set LuongTrongNgay=@luong where ID = @id and Ngay=@ngay", db.getConnection);
                cmd.Parameters.AddWithValue("@ngay", ngay);
                cmd.Parameters.AddWithValue("@id", dr[0]);
                cmd.Parameters.AddWithValue("@luong", (int)luong((TimeSpan)dr[1], (TimeSpan)dr[2], (string)dr[3]));
                if (luong((TimeSpan)dr[1], (TimeSpan)dr[2], (string)dr[3]) > 0)
                {
                    cmd.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
    }
}
