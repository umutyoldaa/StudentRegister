using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentRegister.classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-CTR7PJA1;Initial Catalog=MusicSchool;Integrated Security=True");

        public static void checkedconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }
            else
            {

            }
        }
    }
}