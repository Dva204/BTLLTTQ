namespace BTLLTTQ
{
    partial class TraSach
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblMaSinhVien = new Label();
            label2 = new Label();
            txtMaSinhVien = new TextBox();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnTimKiem = new Button();
            dataGridView = new DataGridView();
            MaPhieuMuon = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            NgayMuon = new DataGridViewTextBoxColumn();
            HanTra = new DataGridViewTextBoxColumn();
            ChonTra = new DataGridViewCheckBoxColumn();
            lblNgayTra = new Label();
            dtpNgayTra = new DateTimePicker();
            lblNgayTre = new Label();
            txtSoNgayTre = new TextBox();
            txtPhiPhat = new TextBox();
            txtGhiChu = new TextBox();
            lblPhiPhat = new Label();
            lblGhiChu = new Label();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnThoat = new Button();
            btnInPhieu = new Button();
            btnTraSach = new Button();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(333, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ TRẢ SÁCH ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaSinhVien
            // 
            lblMaSinhVien.AutoSize = true;
            lblMaSinhVien.Location = new Point(739, 66);
            lblMaSinhVien.Name = "lblMaSinhVien";
            lblMaSinhVien.Size = new Size(101, 21);
            lblMaSinhVien.TabIndex = 1;
            lblMaSinhVien.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 63);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 2;
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(852, 63);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(274, 29);
            txtMaSinhVien.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(102, 60);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(318, 29);
            txtTimKiem.TabIndex = 4;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(14, 63);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(77, 21);
            lblTimKiem.TabIndex = 5;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1244, 62);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(106, 30);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaPhieuMuon, MaSach, TenSach, SoLuong, NgayMuon, HanTra, ChonTra });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.Location = new Point(0, 99);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1586, 344);
            dataGridView.TabIndex = 7;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // MaPhieuMuon
            // 
            MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            MaPhieuMuon.HeaderText = "Mã phiếu";
            MaPhieuMuon.MinimumWidth = 6;
            MaPhieuMuon.Name = "MaPhieuMuon";
            MaPhieuMuon.Width = 125;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaSach.DefaultCellStyle = dataGridViewCellStyle2;
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.Width = 150;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenSach.DefaultCellStyle = dataGridViewCellStyle3;
            TenSach.HeaderText = "Tên Sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.Width = 220;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle4;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 180;
            // 
            // NgayMuon
            // 
            NgayMuon.DataPropertyName = "NgayMuon";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NgayMuon.DefaultCellStyle = dataGridViewCellStyle5;
            NgayMuon.HeaderText = "Ngày mượn";
            NgayMuon.MinimumWidth = 6;
            NgayMuon.Name = "NgayMuon";
            NgayMuon.Width = 125;
            // 
            // HanTra
            // 
            HanTra.DataPropertyName = "HanTra";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HanTra.DefaultCellStyle = dataGridViewCellStyle6;
            HanTra.HeaderText = "Hạn trả";
            HanTra.MinimumWidth = 6;
            HanTra.Name = "HanTra";
            HanTra.Width = 125;
            // 
            // ChonTra
            // 
            ChonTra.HeaderText = "Chọn trả";
            ChonTra.MinimumWidth = 6;
            ChonTra.Name = "ChonTra";
            ChonTra.Width = 125;
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(14, 453);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(124, 21);
            lblNgayTra.TabIndex = 8;
            lblNgayTra.Text = "Ngày trả thực tế:";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Location = new Point(154, 449);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(167, 29);
            dtpNgayTra.TabIndex = 9;
            dtpNgayTra.ValueChanged += dtpNgayTra_ValueChanged;
            // 
            // lblNgayTre
            // 
            lblNgayTre.AutoSize = true;
            lblNgayTre.Location = new Point(380, 453);
            lblNgayTre.Name = "lblNgayTre";
            lblNgayTre.Size = new Size(96, 21);
            lblNgayTre.TabIndex = 10;
            lblNgayTre.Text = "Số ngày trễ: ";
            // 
            // txtSoNgayTre
            // 
            txtSoNgayTre.Location = new Point(489, 449);
            txtSoNgayTre.Name = "txtSoNgayTre";
            txtSoNgayTre.ReadOnly = true;
            txtSoNgayTre.Size = new Size(140, 29);
            txtSoNgayTre.TabIndex = 11;
            txtSoNgayTre.Text = "txtSoNgayTre";
            // 
            // txtPhiPhat
            // 
            txtPhiPhat.Location = new Point(154, 485);
            txtPhiPhat.Name = "txtPhiPhat";
            txtPhiPhat.ReadOnly = true;
            txtPhiPhat.Size = new Size(140, 29);
            txtPhiPhat.TabIndex = 12;
            txtPhiPhat.Text = "txtPhiPhat";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(154, 521);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(475, 29);
            txtGhiChu.TabIndex = 13;
            // 
            // lblPhiPhat
            // 
            lblPhiPhat.AutoSize = true;
            lblPhiPhat.Location = new Point(14, 488);
            lblPhiPhat.Name = "lblPhiPhat";
            lblPhiPhat.Size = new Size(70, 21);
            lblPhiPhat.TabIndex = 14;
            lblPhiPhat.Text = "Phí phạt:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(14, 524);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(66, 21);
            lblGhiChu.TabIndex = 15;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnInPhieu);
            groupBox1.Controls.Add(btnTraSach);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(844, 445);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 231);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(137, 146);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(137, 48);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(400, 146);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 48);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInPhieu
            // 
            btnInPhieu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInPhieu.Location = new Point(400, 34);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.Size = new Size(137, 48);
            btnInPhieu.TabIndex = 4;
            btnInPhieu.Text = "In phiếu";
            btnInPhieu.UseVisualStyleBackColor = true;
            btnInPhieu.Click += btnInPhieu_Click;
            // 
            // btnTraSach
            // 
            btnTraSach.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTraSach.Location = new Point(137, 34);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(137, 48);
            btnTraSach.TabIndex = 0;
            btnTraSach.Text = "Trả sách";
            btnTraSach.UseVisualStyleBackColor = true;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(19, 564);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(104, 25);
            lblTrangThai.TabIndex = 17;
            lblTrangThai.Text = "Trạng thái ";
            // 
            // TraSach
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1587, 706);
            Controls.Add(lblTrangThai);
            Controls.Add(groupBox1);
            Controls.Add(lblGhiChu);
            Controls.Add(lblPhiPhat);
            Controls.Add(txtGhiChu);
            Controls.Add(txtPhiPhat);
            Controls.Add(txtSoNgayTre);
            Controls.Add(lblNgayTre);
            Controls.Add(dtpNgayTra);
            Controls.Add(lblNgayTra);
            Controls.Add(dataGridView);
            Controls.Add(btnTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtMaSinhVien);
            Controls.Add(label2);
            Controls.Add(lblMaSinhVien);
            Controls.Add(lblTitle);
            Name = "TraSach";
            Text = "Quản Lý Trả Sách";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMaSinhVien;
        private Label label2;
        private TextBox txtMaSinhVien;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnTimKiem;
        private DataGridView dataGridView;
        private Label lblNgayTra;
        private DateTimePicker dtpNgayTra;
        private Label lblNgayTre;
        private TextBox txtSoNgayTre;
        private TextBox txtPhiPhat;
        private TextBox txtGhiChu;
        private Label lblPhiPhat;
        private Label lblGhiChu;
        private GroupBox groupBox1;
        private Button btnTraSach;
        private Button btnLamMoi;
        private Button btnThoat;
        private Button btnInPhieu;
        private Label lblTrangThai;
        private DataGridViewTextBoxColumn MaPhieuMuon;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn HanTra;
        private DataGridViewCheckBoxColumn ChonTra;
    }
}
