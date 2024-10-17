using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FinalProject
{
    // Data Source=LAPTOP-VDRPOTHT\SQLEXPRESS;Initial Catalog=QLKS1;Integrated Security=True;
    //Data Source=DESKTOP-0N5JBEM\\SQLEXPRESS;Initial Catalog=QLKS1;Integrated Security=True;
    internal class MyDatabase
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0N5JBEM\\SQLEXPRESS;Initial Catalog=QLKS1;Integrated Security=True");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }

    }
}
