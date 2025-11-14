namespace BTLLTTQ.Forms
{
    partial class DoiMatKhau
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
            lblOldPass = new Label();
            lblNewPass = new Label();
            lblConfirm = new Label();
            btnChange = new Button();
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            txtConfirm = new TextBox();
            btnCancle = new Button();
            SuspendLayout();
            // 
            // lblOldPass
            // 
            lblOldPass.AutoSize = true;
            lblOldPass.Font = new Font("Segoe UI", 12F);
            lblOldPass.Location = new Point(117, 95);
            lblOldPass.Name = "lblOldPass";
            lblOldPass.Size = new Size(129, 30);
            lblOldPass.TabIndex = 0;
            lblOldPass.Text = "Mật khẩu cũ";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Segoe UI", 12F);
            lblNewPass.Location = new Point(117, 155);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(143, 30);
            lblNewPass.TabIndex = 1;
            lblNewPass.Text = "Mật khẩu mới";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 12F);
            lblConfirm.Location = new Point(117, 214);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(192, 30);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Xác nhận mật khẩu";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(136, 310);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(124, 45);
            btnChange.TabIndex = 3;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // txtOldPass
            // 
            txtOldPass.Font = new Font("Segoe UI", 13F);
            txtOldPass.Location = new Point(360, 91);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(200, 38);
            txtOldPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Segoe UI", 13F);
            txtNewPass.Location = new Point(360, 151);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(200, 38);
            txtNewPass.TabIndex = 6;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 13F);
            txtConfirm.Location = new Point(360, 214);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(200, 38);
            txtConfirm.TabIndex = 7;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(482, 310);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(124, 45);
            btnCancle.TabIndex = 8;
            btnCancle.Text = "Hủy";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancle);
            Controls.Add(txtConfirm);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            Controls.Add(btnChange);
            Controls.Add(lblConfirm);
            Controls.Add(lblNewPass);
            Controls.Add(lblOldPass);
            Name = "DoiMatKhau";
            Text = "Đổi mật khẩu";
            Load += DoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOldPass;
        private Label lblNewPass;
        private Label lblConfirm;
        private Button btnChange;
        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private TextBox txtConfirm;
        private Button btnCancle;
    }
}