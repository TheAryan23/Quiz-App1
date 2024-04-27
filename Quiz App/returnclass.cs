using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Quiz_App
{
    internal class returnclass
    {
        private string conn_sting = ConfigurationManager.ConnectionStrings["quiz"].ConnectionString;

        public string scalerReturn(string q)
        {
            string s;
            SqlConnection conn = new SqlConnection(conn_sting);
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(q,conn);
                s = cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception)
            {
                throw;
            
            
            }


            return s;
        }




    }
}
