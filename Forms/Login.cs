using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace BTLLTTQ.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '•';
        }                
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            //// Simple validation (for demonstration purposes)
            if (username == "" && password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                //{
                //    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtPass.Clear();
                //    txtUser.Focus();
                //}
                SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLTV;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                try
                {
                    conn.Open();
                    string sql = "SELECT HoTen, VaiTro FROM TaiKhoan WHERE TenDangNhap=@username AND MatKhau=@password";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        string fullName = r["HoTen"].ToString();
                        string role = r["VaiTro"].ToString();
                        MessageBox.Show("Đăng nhập thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Dashboard dashboard = new Dashboard(fullName, role, username);
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Clear();
                        txtPass.Clear();
                        txtUser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = ckbShowPass.Checked ? '\0' : '•';
        }

        
    }
}
