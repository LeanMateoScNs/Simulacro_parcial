using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RecetasSLN.datos
{
    internal class HelpDatabase
    {
        protected SqlConnection conn = new SqlConnection(Properties.Resources.connection);
        protected SqlCommand cmd = new SqlCommand();

        public void open()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public void close()
        {
            conn.Close();
        }
    }
}
