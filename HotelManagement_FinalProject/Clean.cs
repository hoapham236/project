using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManagement_FinalProject
{
    internal class Clean
    {
        MyDatabase mydb = new MyDatabase();
        public bool insertClean(string idCleaner,int idRoom )
        {
            SqlCommand command = new SqlCommand("INSERT INTO Clean(IdCleaner,IdRoom) VALUES (@cleaner,@room)", mydb.getConnection);
            command.Parameters.AddWithValue("@cleaner", idCleaner);
            command.Parameters.AddWithValue("@room", idRoom);


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
        public bool deleteClean(string idCleaner)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Clean where IdCleaner = @cleaner", mydb.getConnection);
            command.Parameters.AddWithValue("@cleaner", idCleaner);


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
        public int getIdRoom(string idCleaner)
        {
            int id = 0;
            SqlCommand command = new SqlCommand("Select IdRoom From Clean where IdCleaner = @cleaner", mydb.getConnection);
            command.Parameters.AddWithValue("@cleaner", idCleaner);
            mydb.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                id = (int)reader[0];
            }
            reader.Close();
            return id;
        }
        public bool Exist(string idCleaner)
        {
            SqlCommand command = new SqlCommand("Select * From Clean where IdCleaner = @cleaner", mydb.getConnection);
            command.Parameters.AddWithValue("@cleaner", idCleaner);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(command);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;

        }
        public string checkLC(string id, string date)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("Select Id,Ngay,GioVao,GioRa From CALAM where Id = @id and Ngay=@ngay", mydb.getConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@ngay", date);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(2) && reader.IsDBNull(3))
                    {
                        reader.Close();
                        mydb.closeConnection();
                        return "checkin";
                    }
                    else
                    {
                        reader.Close();
                        mydb.closeConnection();
                        return "check";
                    }
                }
            }
            reader.Close();
            mydb.closeConnection();
            return "uncheck";
        }
    }
}
