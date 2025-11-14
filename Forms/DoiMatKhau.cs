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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTLLTTQ.Forms
{
    public partial class DoiMatKhau : Form
    {
        private string userName;
        public DoiMatKhau(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirmPass = txtConfirm.Text.Trim();
            if (oldPass == "" || newPass == "" || confirmPass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLTV;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sqlCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhauCu";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@TenDangNhap", userName);
                    cmdCheck.Parameters.AddWithValue("@MatKhauCu", oldPass);

                    int exist = (int)cmdCheck.ExecuteScalar();

                    if (exist == 0)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sqlUpdate = "UPDATE TaiKhoan SET MatKhau=@MatKhauMoi WHERE TenDangNhap=@TenDangNhap";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@MatKhauMoi", newPass);
                    cmdUpdate.Parameters.AddWithValue("@TenDangNhap", userName);

                    int rows = cmdUpdate.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
