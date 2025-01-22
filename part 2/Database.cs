using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace part_2
{
    internal static class Database
    {
        private static readonly string conn = "Data Source=DESKTOP-L1O0RI0\\IRFAN;Initial Catalog=db_nyoba;Integrated Security=True";

        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conn);
        }

    }
}
