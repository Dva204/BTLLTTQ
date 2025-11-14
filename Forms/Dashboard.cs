using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLTTQ.SupportClasses;

namespace BTLLTTQ.Forms
{
    public partial class Dashboard : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string hoTen;
        private string vaiTro;
        private string userName;
        public Dashboard(string Ten, string role, string User)
        {
            InitializeComponent();
            random = new Random();
            hoTen = Ten;
            vaiTro = role;
            userName = User;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            OpenChildFormClone(new QuanLySach());
        }
        private void OpenChildFormClone(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoScroll = true;
            panelDesktopPane.Controls.Clear();
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLySach(), sender);
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLy(), sender);
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TraSach(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }

        }

        //private void btnThongBao_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new ThongBao(), sender);
        //}

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CaiDat(hoTen, vaiTro, userName), sender);
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
