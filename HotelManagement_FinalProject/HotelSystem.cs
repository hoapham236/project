using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FinalProject
{
    

    internal class HotelSystem
    {
        public int luongLC = 40000;
        public int luongTT = 60000;
        public int gioVaoCaNgay = 7;
        public int gioVaoCaDem = 19;
        MyDatabase mydb = new MyDatabase();
        public DataTable getHistory(string id,string month)
        {
            DataTable tb = new DataTable();
            SqlCommand command = new SqlCommand("Select Ngay as 'Day',GioVao as 'Time in',GioRa as 'Time out',Ca as 'Shift',LuongTrongNgay as 'Salary' From CALAM Where ID = @id and MONTH(Ngay) = @month",mydb.getConnection);
            command.Parameters.Add("@id",SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@month", SqlDbType.NVarChar).Value = month;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(tb);
            return tb;
        }
        public bool checkLate(string ca,DateTime time)
        {
            // false : khong tre , true : tre 
            if (ca == "Day")
            {
                if (time.Hour < gioVaoCaNgay || (time.Hour == gioVaoCaNgay && time.Minute == 0))
                {
                    return false;
                }
                else
                    return true;
            }
            else if (ca == "Night")
            {
                if (time.Hour < gioVaoCaDem || (time.Hour == gioVaoCaDem && time.Minute == 0))
                {
                    return false;
                }
                else
                    return true;
            }
            else // Ca Bu 
            {
                return false; // tam thoi gan bang false, sau nay co code xin nghi thi them 
            }
        }
        public int luong(TimeSpan giovao, TimeSpan giora, string nghiepvu)
        {
            TimeSpan gio = giora - giovao;
            if (gio < TimeSpan.Zero)
            {
                gio = -gio;
            }
            int sogio = (int)gio.TotalHours;
            if (nghiepvu == "Cleaner")
            {
                return sogio * luongLC;
            }    
            else if (nghiepvu == "Receptionist")
            {
                return sogio * luongTT;
            }
            return -1;
        }
        public void tinhLuong(string ngay)
        {
            DataTable tb = new DataTable();
            mydb.openConnection();
            SqlCommand command = new SqlCommand("Select CALAM.ID,GioVao,GioRa,NghiepVu From CALAM join NHANVIEN on CALAM.ID = NHANVIEN.ID Where Ngay=@ngay", mydb.getConnection);
            command.Parameters.AddWithValue("@ngay", ngay);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(tb);
            foreach (DataRow dr in tb.Rows)
            {
                SqlCommand cmd = new SqlCommand("Update CALAM set LuongTrongNgay=@luong where ID = @id and Ngay=@ngay", mydb.getConnection);
                cmd.Parameters.AddWithValue("@ngay", ngay);
                cmd.Parameters.AddWithValue("@id", dr[0]);
                cmd.Parameters.AddWithValue("@luong", luong((TimeSpan)dr[1], (TimeSpan)dr[2], (string)dr[3]));
                cmd.ExecuteNonQuery();
            }
            mydb.closeConnection();
        }

        void KhoiTaoVaPhanCongCaLam(List<Employee> employees)
        {

        }
        void VaoCa(string Id, DateTime time, Worksession worksession)
        {

        }
        void KetThucCa(string Id, DateTime time)
        {

        }
        void TinhVaBaoCaoLuong(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                double totalTime = 0;
                foreach (Worksession session in employee.Worksessions)
                {
                    totalTime += (session.TimeOut - session.TimeIn).TotalHours;

                }
                double salary;
                if (employee.Role == Role.Receptionist)
                {
                    salary = totalTime * luongTT;  // Luong 60k moi gio cho 1 le tan 

                }
                else if (employee.Role == Role.Cleaner)
                {
                    salary = totalTime * luongLC; // Luong 40k 1 gio cho 1 lao cong

                }
            }
        }
    }
}
