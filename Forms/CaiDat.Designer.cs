namespace BTLLTTQ.Forms
{
    partial class CaiDat
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
            lblName = new Label();
            lblRole = new Label();
            btnChangePass = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15F);
            lblName.Location = new Point(204, 84);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 37);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.None;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 15F);
            lblRole.Location = new Point(369, 170);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(90, 37);
            lblRole.TabIndex = 2;
            lblRole.Text = "label2";
            lblRole.Click += lblRole_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.Anchor = AnchorStyles.None;
            btnChangePass.AutoSize = true;
            btnChangePass.Location = new Point(124, 297);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(203, 61);
            btnChangePass.TabIndex = 3;
            btnChangePass.Text = "🔑 Đổi mật khẩu";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.AutoSize = true;
            btnLogout.Location = new Point(369, 297);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(203, 61);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "🚪 Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.AutoSize = true;
            btnExit.Location = new Point(618, 297);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(203, 61);
            btnExit.TabIndex = 5;
            btnExit.Text = "❌ Thoát chương trình";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // CaiDat
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 515);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnChangePass);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaiDat";
            Text = "⚙️ Cài đặt hệ thống";
            Load += CaiDat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblRole;
        private Button btnChangePass;
        private Button btnLogout;
        private Button btnExit;
    }
}