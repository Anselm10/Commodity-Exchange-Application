using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace commodity_exchange_application
{
    public class productDAO
    {
        public static readonly string con_string = "Data Source=THEBIN\\THEBIN;Initial Catalog=commodity_exchange_application;Persist Security Info=True;User ID=sa;Password=123456";
        public static SqlConnection con = new SqlConnection(con_string);
        Byte[] imageByteArray;


        public productDAO() { }
        public bool RegisterUser(Product pro)
        {

            try
            {
                string query = "INSERT INTO DONHANG (TenSanPham, HinhAnh, GiaTienBan, TenTaiKhoan) VALUES (@TenSanPham, @HinhAnh, @GiaTienBan, @TenTaiKhoan)";

                Image temp = new Bitmap(pro.HinhAnh);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();


                Hashtable ht = new Hashtable();
                ht.Add("@TenSanPham", pro.TenSanPham);
                ht.Add("@HinhAnh", imageByteArray);
                ht.Add("@GiaTienBan", pro.GiaTienBan);
                ht.Add("@TenTaiKhoan", pro.TenTaiKhoan);

                if (DBConnection.SQl(query, ht) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm người dùng vào cơ sở dữ liệu: " + ex.Message);
            }
            return false;
        }
        public bool DeleteProduct(Product pro)
        {

            try
            {
                string query = "DELETE FROM DONHANG WHERE TenTaiKhoan = @TenTaiKhoan and TenSanPham = @TenSanPham";
                Hashtable ht = new Hashtable();
                ht.Add("@TenSanPham", pro.TenSanPham);
                ht.Add("@TenTaiKhoan", pro.TenTaiKhoan);

                if (DBConnection.SQl(query, ht) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm người dùng vào cơ sở dữ liệu: " + ex.Message);
            }
            return false;
        }
    }
}
