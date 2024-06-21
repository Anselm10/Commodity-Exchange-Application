using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commodity_exchange_application
{
    internal class AccountDAO
    {

        public static readonly string con_string = "Data Source=THEBIN\\THEBIN;Initial Catalog=commodity_exchange_application;Integrated Security=True";

        public static SqlConnection con = new SqlConnection(con_string);

        Account acc = new Account();
        public AccountDAO() { } 

        public bool IsValidUser(Account acc)
        {
            bool isValid = false;
            string qry = string.Format("Select * from DANGNHAP where TenTaiKhoan = '{0}' and MatKhau = '{1}'", acc.Name, acc.Password);
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0) { isValid = true; }
            return isValid;
        }
    }
}
