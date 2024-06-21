using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commodity_exchange_application
{
    class DBConnection
    {
        /*        public static readonly string con_string = "Data Source=LAPTOP-K6GL17UI\\NHATLINH;Initial Catalog=commodity_exchange_application;Persist Security Info=True;User ID=sa;Password=123456";
        */
        /*public static readonly string con_string = "Data Source=localhost;Initial Catalog=commodity_exchange_application;Persist Security Info=True;User ID=sa;Password=123456";*/
        public static readonly string con_string = "Data Source=THEBIN\\THEBIN;Initial Catalog=commodity_exchange_application;Integrated Security=True";

        public static SqlConnection con = new SqlConnection(con_string);


        public static int SQl(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return res;
        }

    }
}
