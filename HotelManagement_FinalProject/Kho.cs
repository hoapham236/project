using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FinalProject
{
    internal class Kho
    {
        MyDatabase mydb = new MyDatabase();
        public string getIdNL(string TenNL)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("Select IdNL from NguyenLieu where TenNL = @ten", mydb.getConnection);
            command.Parameters.AddWithValue("@ten", TenNL);
            SqlDataReader reader = command.ExecuteReader();
            string id = "";
            while (reader.Read())
            {
                id = (string)reader["IdNL"];
            }
            reader.Close();
            mydb.closeConnection();
            return id;
        }
        public bool CheckNLCon(string Idnl, double sl)
        {
            SqlCommand command = new SqlCommand("SELECT SL FROM KHOHIENTAI WHERE IdNL = @id", mydb.getConnection);
            command.Parameters.AddWithValue("@id", Idnl);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            // Check if any rows are returned
            if (tb.Rows.Count > 0)
            {
                double slValue = Convert.ToDouble(tb.Rows[0]["SL"]);
                return slValue >= sl;
            }
            else
            {
                return false;
            }
        }
        public bool updateKhoHienTai(string idmon, int slmon)
        {
            SqlCommand command = new SqlCommand("SELECT IdNL, SL FROM CongThuc WHERE Idmon = @id", mydb.getConnection);
            command.Parameters.AddWithValue("@id", idmon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dataRow in dt.Rows)
            {
                string id = dataRow[0].ToString();
                double sl = Convert.ToDouble(dataRow[1]) * slmon;

                SqlCommand command1 = new SqlCommand("Update KHOHIENTAI set SL = SL - @sl where IdNL = @id", mydb.getConnection);
                command1.Parameters.AddWithValue("@sl", sl);
                command1.Parameters.AddWithValue("@id", id);
                mydb.openConnection();
                if (command1.ExecuteNonQuery() != 1)
                {
                    mydb.closeConnection();
                    return false;
                }
            }
            mydb.closeConnection();
            return true;

        }
        public string getTenNL(string IdNL)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("Select TenNL from NguyenLieu where IdNL = @ten", mydb.getConnection);
            command.Parameters.AddWithValue("@ten", IdNL);
            SqlDataReader reader = command.ExecuteReader();
            string id = "";
            while (reader.Read())
            {
                id = (string)reader["TenNL"];
            }
            reader.Close();
            mydb.closeConnection();
            return id;
        }
        public string getTen(SqlCommand command)
        {
            mydb.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            string id = "";
            while (reader.Read())
            {
                id = (string)reader[0];
            }
            reader.Close();
            mydb.closeConnection();
            return id;
        }
        public int getGiaTien(string TenNL)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("Select GiaTien from NguyenLieu where TenNL = @ten", mydb.getConnection);
            command.Parameters.AddWithValue("@ten", TenNL);
            SqlDataReader reader = command.ExecuteReader();
            int gia = 0;
            while (reader.Read())
            {
                gia = (int)reader["GiaTien"];
            }
            reader.Close();
            mydb.closeConnection();
            return gia;
        }
    }
}
