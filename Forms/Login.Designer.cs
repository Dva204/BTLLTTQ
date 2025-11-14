namespace BTLLTTQ.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblTitle = new Label();
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            ckbShowPass = new CheckBox();
            lklForgot = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.223999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(111, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(564, 66);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(290, 147);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(151, 30);
            lblUser.TabIndex = 1;
            lblUser.Text = "Tên đăng nhập";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(290, 216);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(101, 30);
            lblPass.TabIndex = 2;
            lblPass.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(485, 142);
            txtUser.Margin = new Padding(5);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(214, 35);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(485, 211);
            txtPass.Margin = new Padding(5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(214, 35);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(345, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "🔑 Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(571, 324);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 38);
            btnExit.TabIndex = 6;
            btnExit.Text = "❌Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ckbShowPass
            // 
            ckbShowPass.AutoSize = true;
            ckbShowPass.Location = new Point(566, 269);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(133, 25);
            ckbShowPass.TabIndex = 7;
            ckbShowPass.Text = "Hiện mật khẩu";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // lklForgot
            // 
            lklForgot.AutoSize = true;
            lklForgot.Location = new Point(634, 392);
            lklForgot.Name = "lklForgot";
            lklForgot.Size = new Size(124, 21);
            lklForgot.TabIndex = 8;
            lklForgot.TabStop = true;
            lklForgot.Text = "Quên mật khẩu?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(808, 456);
            Controls.Add(pictureBox1);
            Controls.Add(lklForgot);
            Controls.Add(ckbShowPass);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(lblTitle);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnExit;
        private CheckBox ckbShowPass;
        private LinkLabel lklForgot;
        private PictureBox pictureBox1;
    }
}