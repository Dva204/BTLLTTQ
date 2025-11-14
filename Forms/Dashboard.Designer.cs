namespace BTLLTTQ.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelMenu = new Panel();
            btnCaiDat = new Button();
            btnLogout = new Button();
            btnThongKe = new Button();
            btnTra = new Button();
            btnMuon = new Button();
            btnSach = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnCaiDat);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnTra);
            panelMenu.Controls.Add(btnMuon);
            panelMenu.Controls.Add(btnSach);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 700);
            panelMenu.TabIndex = 0;
            // 
            // btnCaiDat
            // 
            btnCaiDat.Dock = DockStyle.Top;
            btnCaiDat.FlatAppearance.BorderSize = 0;
            btnCaiDat.FlatStyle = FlatStyle.Flat;
            btnCaiDat.Font = new Font("Segoe UI", 10F);
            btnCaiDat.ForeColor = Color.Gainsboro;
            btnCaiDat.Location = new Point(0, 370);
            btnCaiDat.Name = "btnCaiDat";
            btnCaiDat.Size = new Size(200, 70);
            btnCaiDat.TabIndex = 9;
            btnCaiDat.Text = "Cài Đặt";
            btnCaiDat.UseVisualStyleBackColor = true;
            btnCaiDat.Click += btnCaiDat_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.Gainsboro;
            btnLogout.Location = new Point(0, 616);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 84);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F);
            btnThongKe.ForeColor = Color.Gainsboro;
            btnThongKe.Location = new Point(0, 300);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(200, 70);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnTra
            // 
            btnTra.Dock = DockStyle.Top;
            btnTra.FlatAppearance.BorderSize = 0;
            btnTra.FlatStyle = FlatStyle.Flat;
            btnTra.Font = new Font("Segoe UI", 10F);
            btnTra.ForeColor = Color.Gainsboro;
            btnTra.Location = new Point(0, 230);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(200, 70);
            btnTra.TabIndex = 3;
            btnTra.Text = "Trả Sách";
            btnTra.UseVisualStyleBackColor = true;
            btnTra.Click += btnTra_Click;
            // 
            // btnMuon
            // 
            btnMuon.Dock = DockStyle.Top;
            btnMuon.FlatAppearance.BorderSize = 0;
            btnMuon.FlatStyle = FlatStyle.Flat;
            btnMuon.Font = new Font("Segoe UI", 10F);
            btnMuon.ForeColor = Color.Gainsboro;
            btnMuon.Location = new Point(0, 160);
            btnMuon.Name = "btnMuon";
            btnMuon.Size = new Size(200, 70);
            btnMuon.TabIndex = 2;
            btnMuon.Text = "Mượn Sách";
            btnMuon.UseVisualStyleBackColor = true;
            btnMuon.Click += btnMuon_Click;
            // 
            // btnSach
            // 
            btnSach.Dock = DockStyle.Top;
            btnSach.FlatAppearance.BorderSize = 0;
            btnSach.FlatStyle = FlatStyle.Flat;
            btnSach.Font = new Font("Segoe UI", 10F);
            btnSach.ForeColor = Color.Gainsboro;
            btnSach.Location = new Point(0, 90);
            btnSach.Name = "btnSach";
            btnSach.Size = new Size(200, 70);
            btnSach.TabIndex = 1;
            btnSach.Text = "Quản Lý Sách";
            btnSach.UseVisualStyleBackColor = true;
            btnSach.Click += btnSach_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 78);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 90);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Navy;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(200, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1016, 90);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25F);
            lblTitle.ForeColor = SystemColors.Window;
            lblTitle.Location = new Point(355, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(366, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lý Thư Viện";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktopPane.Location = new Point(200, 90);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1016, 610);
            panelDesktopPane.TabIndex = 2;
            panelDesktopPane.Paint += panelDesktopPane_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 700);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.Highlight;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnLogout;
        private Button btnThongKe;
        private Button btnTra;
        private Button btnMuon;
        private Button btnSach;
        private Panel panelTitleBar;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Panel panelDesktopPane;
        private Button btnCaiDat;
    }
}