using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace database_form
{
    class Database
    {
        static SqlConnection conn;
        public static SqlConnection ConnectDB()
        {
            string connString = @"Server=DESKTOP-49EF6FM\SQLEXPRESS;Database=demo_h_sp21;Integrated Security=true";
            conn = new SqlConnection(connString);
            return conn;
        }
        
        
         

        
        

    }
}
