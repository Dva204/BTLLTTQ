namespace BTLLTTQ
{
    partial class frmQuanLy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            dgvView1 = new DataGridView();
            btnTim = new Button();
            txtTim = new TextBox();
            groupBox1 = new GroupBox();
            txtPhieuMuon = new TextBox();
            label1 = new Label();
            txtMaSV = new TextBox();
            label12 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            dtpTra = new DateTimePicker();
            dtpMuon = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            txtMaSach = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            dgvView2 = new DataGridView();
            btnTimMuon = new Button();
            txtTimMuon = new TextBox();
            groupBox3 = new GroupBox();
            btnLamMoiMuon = new Button();
            txtSDT = new TextBox();
            label11 = new Label();
            cbGt = new ComboBox();
            txtKhoa = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtLop = new TextBox();
            label8 = new Label();
            btnXoaMuon = new Button();
            btnSuaMuon = new Button();
            btnThemMuon = new Button();
            txtHoTenMuon = new TextBox();
            txtMaMuon = new TextBox();
            txtHoTen = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvView1).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvView2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(35, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1452, 741);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1444, 707);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phiếu mượn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvView1);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(txtTim);
            groupBox2.Location = new Point(381, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1055, 694);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu mượn ";
            // 
            // dgvView1
            // 
            dgvView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView1.Location = new Point(18, 78);
            dgvView1.Name = "dgvView1";
            dgvView1.RowHeadersWidth = 51;
            dgvView1.Size = new Size(1030, 596);
            dgvView1.TabIndex = 12;
            dgvView1.CellClick += dgvView1_CellClick;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(425, 41);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(164, 30);
            btnTim.TabIndex = 11;
            btnTim.Text = "Tìm ";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(18, 43);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(376, 29);
            txtTim.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhieuMuon);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(dtpTra);
            groupBox1.Controls.Add(dtpMuon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 694);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu mượn ";
            // 
            // txtPhieuMuon
            // 
            txtPhieuMuon.Location = new Point(128, 57);
            txtPhieuMuon.Name = "txtPhieuMuon";
            txtPhieuMuon.Size = new Size(183, 29);
            txtPhieuMuon.TabIndex = 19;
            txtPhieuMuon.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 57);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 18;
            label1.Text = "Mã Phiếu:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(128, 105);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(183, 29);
            txtMaSV.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 108);
            label12.Name = "label12";
            label12.Size = new Size(62, 21);
            label12.TabIndex = 16;
            label12.Text = "Mã SV: ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(206, 578);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 84);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(36, 578);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 84);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(206, 487);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(112, 84);
            btnCapNhat.TabIndex = 11;
            btnCapNhat.Text = "Cập nhật ";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(36, 487);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 84);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpTra
            // 
            dtpTra.Location = new Point(15, 394);
            dtpTra.Name = "dtpTra";
            dtpTra.Size = new Size(344, 29);
            dtpTra.TabIndex = 9;
            // 
            // dtpMuon
            // 
            dtpMuon.Location = new Point(15, 314);
            dtpMuon.Name = "dtpMuon";
            dtpMuon.Size = new Size(344, 29);
            dtpMuon.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 356);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 7;
            label5.Text = "Thời gian trả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 278);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 6;
            label4.Text = "Thời gian mượn:";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(128, 165);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(183, 29);
            txtMaSach.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 173);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 4;
            label3.Text = "Mã sách: ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1444, 707);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lý người mượn ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvView2);
            groupBox4.Controls.Add(btnTimMuon);
            groupBox4.Controls.Add(txtTimMuon);
            groupBox4.Location = new Point(350, 18);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1087, 462);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách người mượn ";
            // 
            // dgvView2
            // 
            dgvView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView2.Location = new Point(20, 90);
            dgvView2.Name = "dgvView2";
            dgvView2.RowHeadersWidth = 51;
            dgvView2.Size = new Size(1060, 365);
            dgvView2.TabIndex = 8;
            dgvView2.CellClick += dgvView2_CellClick;
            // 
            // btnTimMuon
            // 
            btnTimMuon.Location = new Point(407, 41);
            btnTimMuon.Name = "btnTimMuon";
            btnTimMuon.Size = new Size(106, 30);
            btnTimMuon.TabIndex = 7;
            btnTimMuon.Text = "Tìm";
            btnTimMuon.UseVisualStyleBackColor = true;
            btnTimMuon.Click += btnTimMuon_Click;
            // 
            // txtTimMuon
            // 
            txtTimMuon.Location = new Point(20, 43);
            txtTimMuon.Name = "txtTimMuon";
            txtTimMuon.Size = new Size(228, 29);
            txtTimMuon.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLamMoiMuon);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(cbGt);
            groupBox3.Controls.Add(txtKhoa);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtLop);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnXoaMuon);
            groupBox3.Controls.Add(btnSuaMuon);
            groupBox3.Controls.Add(btnThemMuon);
            groupBox3.Controls.Add(txtHoTenMuon);
            groupBox3.Controls.Add(txtMaMuon);
            groupBox3.Controls.Add(txtHoTen);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(7, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(336, 462);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin người mượn ";
            // 
            // btnLamMoiMuon
            // 
            btnLamMoiMuon.Location = new Point(26, 425);
            btnLamMoiMuon.Name = "btnLamMoiMuon";
            btnLamMoiMuon.Size = new Size(106, 30);
            btnLamMoiMuon.TabIndex = 18;
            btnLamMoiMuon.Text = "Làm mới";
            btnLamMoiMuon.UseVisualStyleBackColor = true;
            btnLamMoiMuon.Click += btnLamMoiMuon_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(114, 318);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(140, 29);
            txtSDT.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 326);
            label11.Name = "label11";
            label11.Size = new Size(57, 21);
            label11.TabIndex = 16;
            label11.Text = "Số DT: ";
            // 
            // cbGt
            // 
            cbGt.FormattingEnabled = true;
            cbGt.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGt.Location = new Point(114, 259);
            cbGt.Name = "cbGt";
            cbGt.Size = new Size(169, 29);
            cbGt.TabIndex = 15;
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(101, 208);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(140, 29);
            txtKhoa.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 268);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 12;
            label10.Text = "Giới tính :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 215);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 11;
            label9.Text = "Khoa:";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(101, 160);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(140, 29);
            txtLop.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 167);
            label8.Name = "label8";
            label8.Size = new Size(40, 21);
            label8.TabIndex = 9;
            label8.Text = "Lớp:";
            // 
            // btnXoaMuon
            // 
            btnXoaMuon.Location = new Point(177, 425);
            btnXoaMuon.Name = "btnXoaMuon";
            btnXoaMuon.Size = new Size(106, 30);
            btnXoaMuon.TabIndex = 8;
            btnXoaMuon.Text = "Xóa";
            btnXoaMuon.UseVisualStyleBackColor = true;
            btnXoaMuon.Click += btnXoaMuon_Click;
            // 
            // btnSuaMuon
            // 
            btnSuaMuon.Location = new Point(177, 369);
            btnSuaMuon.Name = "btnSuaMuon";
            btnSuaMuon.Size = new Size(106, 30);
            btnSuaMuon.TabIndex = 7;
            btnSuaMuon.Text = "Sửa";
            btnSuaMuon.UseVisualStyleBackColor = true;
            btnSuaMuon.Click += btnSuaMuon_Click;
            // 
            // btnThemMuon
            // 
            btnThemMuon.Location = new Point(26, 369);
            btnThemMuon.Name = "btnThemMuon";
            btnThemMuon.Size = new Size(106, 30);
            btnThemMuon.TabIndex = 6;
            btnThemMuon.Text = "Thêm ";
            btnThemMuon.UseVisualStyleBackColor = true;
            btnThemMuon.Click += btnThemMuon_Click;
            // 
            // txtHoTenMuon
            // 
            txtHoTenMuon.Location = new Point(101, 105);
            txtHoTenMuon.Name = "txtHoTenMuon";
            txtHoTenMuon.Size = new Size(228, 29);
            txtHoTenMuon.TabIndex = 4;
            // 
            // txtMaMuon
            // 
            txtMaMuon.Location = new Point(166, 43);
            txtMaMuon.Name = "txtMaMuon";
            txtMaMuon.Size = new Size(163, 29);
            txtMaMuon.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.AutoSize = true;
            txtHoTen.Location = new Point(26, 112);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(63, 21);
            txtHoTen.TabIndex = 1;
            txtHoTen.Text = "Họ tên: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 50);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 0;
            label6.Text = "Mã người mượn:";
            // 
            // frmQuanLy
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1501, 791);
            Controls.Add(tabControl1);
            Name = "frmQuanLy";
            Text = "Quản Lý Mượn Sách ";
            Load += frmQuanLy_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtMaSach;
        private Label label3;
        private Button btnTim;
        private TextBox txtTim;
        private DateTimePicker dtpTra;
        private DateTimePicker dtpMuon;
        private Label label5;
        private Label label4;
        private DataGridView dgvView1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label txtHoTen;
        private Label label6;
        private DataGridView dgvView2;
        private Button btnTimMuon;
        private TextBox txtTimMuon;
        private TextBox txtHoTenMuon;
        private TextBox txtMaMuon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnXoaMuon;
        private Button btnSuaMuon;
        private Button btnThemMuon;
        private TextBox txtLop;
        private Label label8;
        private ComboBox cbGt;
        private TextBox txtKhoa;
        private Label label10;
        private Label label9;
        private TextBox txtSDT;
        private Label label11;
        private TextBox txtMaSV;
        private Label label12;
        private TextBox txtPhieuMuon;
        private Label label1;
        private Button btnLamMoiMuon;
    }
}
