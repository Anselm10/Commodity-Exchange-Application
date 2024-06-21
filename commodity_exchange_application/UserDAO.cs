using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace commodity_exchange_application
{
    public class UserDAO
    {
        /*public static readonly string con_string = "Data Source=LAPTOP-K6GL17UI\\NHATLINH;Initial Catalog=commodity_exchange_application;Persist Security Info=True;User ID=sa;Password=123456";*/
        public static readonly string con_string = "Data Source=THEBIN\\THEBIN;Initial Catalog=commodity_exchange_application;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        User acc = new User();
        public UserDAO() { }

        public bool RegisterUser(User acc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con_string))
                {
                    connection.Open();
                    string query = "INSERT INTO DANGKY (TenTaiKhoan, Email, MatKhau, SDT, DiaChi, HoTen) VALUES (@TenTaiKhoan, @Email, @MatKhau, @SoDienThoai, @DiaChi, @HoTen)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenTaiKhoan", acc.TaiKhoan);
                    command.Parameters.AddWithValue("@Email", acc.Email);
                    command.Parameters.AddWithValue("@MatKhau", acc.MatKhau);
                    command.Parameters.AddWithValue("@SoDienThoai", acc.SoDienThoai);
                    command.Parameters.AddWithValue("@DiaChi", acc.DiaChi);
                    command.Parameters.AddWithValue("@HoTen", acc.HoTen);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm người dùng vào cơ sở dữ liệu: " + ex.Message);
            }
            return false;
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {

            string pattern = @"^0\d{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public bool IsEmailValid(string email)
        {
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, pattern);
        }
        public bool CheckDuplicateUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(con_string))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM DANGNHAP WHERE TenTaiKhoan = '@Username'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    return true;
                }

            }
            return false;
        }

        public bool ValidateInput(User user)
        {
            if (string.IsNullOrWhiteSpace(user.HoTen) ||
                string.IsNullOrWhiteSpace(user.TaiKhoan) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.MatKhau) ||
                string.IsNullOrWhiteSpace(user.DiaChi) ||
                string.IsNullOrWhiteSpace(user.HoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            // Kiểm tra tính hợp lệ của tên đăng nhập (ví dụ: không chứa ký tự đặc biệt)
            if (!Regex.IsMatch(user.TaiKhoan, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("Tên đăng nhập chỉ có thể chứa các ký tự chữ, số và dấu gạch dưới.");
                return false;
            }
            if (CheckDuplicateUsername(user.TaiKhoan))
            {
                MessageBox.Show("Tên tài khoản đã tồn tài!");
                return false;
            }

            if (IsEmailValid(user.Email) == false)
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            if (IsValidPhoneNumber(user.SoDienThoai)==false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }
            // Kiểm tra độ dài của mật khẩu (ví dụ: ít nhất 6 ký tự)
            if (user.MatKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 6 ký tự.");
                return false;
            }

            return true;
        }

        
    }
}
