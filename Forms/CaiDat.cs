using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ.Forms
{
    public partial class CaiDat : Form
    {
        private string hoTen;
        private string vaiTro;
        private string userName;
        public CaiDat(string hoTen, string vaiTro, string userName)
        {
            InitializeComponent();
            this.hoTen = hoTen;
            this.vaiTro = vaiTro;
            this.userName = userName;
        }

        private void CaiDat_Load(object sender, EventArgs e)
        {
            lblName.Text = "Tên người dùng : " + hoTen;
            lblRole.Text = "Vai trò : " + vaiTro;
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            DoiMatKhau changePassForm = new DoiMatKhau(userName);
            changePassForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form parent = this.ParentForm;
                parent.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
