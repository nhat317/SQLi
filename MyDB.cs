using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLi
{
    internal class MyDB
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HFIR7331\SQLEXPRESS;Initial Catalog=DemoSqlI;Integrated Security=True;Connect Timeout=30");
        public SqlConnection getConnection
        // get the connection
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