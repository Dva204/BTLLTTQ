namespace BTLLTTQ
{
    partial class QuanLySach
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
            pnlTop = new Panel();
            btnClose = new Button();
            btnInDanhSach = new Button();
            pnlFilter = new Panel();
            txtFilter = new TextBox();
            cboFilterTheLoai = new ComboBox();
            lblFilter = new Label();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblTitle = new Label();
            pnlMain = new Panel();
            dgvSach = new DataGridView();
            lblRowCount = new Label();
            pnlBottom = new Panel();
            pnlFunctions = new Panel();
            btnKetThuc = new Button();
            btnKhongLuu = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            lblFunctions = new Label();
            pnlBookInfo = new Panel();
            cboTinhTrang = new ComboBox();
            cboNhaXB = new ComboBox();
            cboTacGia = new ComboBox();
            cboChoMuon = new ComboBox();
            cboTheLoai = new ComboBox();
            txtNoiDung = new TextBox();
            txtTenSach = new TextBox();
            txtViTri = new TextBox();
            txtMaSach = new TextBox();
            lblTinhTrang = new Label();
            lblNhaXB = new Label();
            lblTacGia = new Label();
            lblChoMuon = new Label();
            lblTheLoai = new Label();
            lblNoiDung = new Label();
            lblTenSach = new Label();
            lblViTri = new Label();
            lblMaSach = new Label();
            lblBookInfo = new Label();
            pnlTop.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            pnlBottom.SuspendLayout();
            pnlFunctions.SuspendLayout();
            pnlBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.LightBlue;
            pnlTop.Controls.Add(btnClose);
            pnlTop.Controls.Add(btnInDanhSach);
            pnlTop.Controls.Add(pnlFilter);
            pnlTop.Controls.Add(pnlSearch);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(4, 5, 4, 5);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1800, 161);
            pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1782, 80);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(60, 49);
            btnClose.TabIndex = 4;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnInDanhSach
            // 
            btnInDanhSach.BackColor = Color.White;
            btnInDanhSach.FlatStyle = FlatStyle.Flat;
            btnInDanhSach.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInDanhSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnInDanhSach.Location = new Point(1500, 81);
            btnInDanhSach.Margin = new Padding(4, 5, 4, 5);
            btnInDanhSach.Name = "btnInDanhSach";
            btnInDanhSach.Size = new Size(225, 56);
            btnInDanhSach.TabIndex = 3;
            btnInDanhSach.Text = "📊 In danh sách";
            btnInDanhSach.UseVisualStyleBackColor = false;
            btnInDanhSach.Click += btnInDanhSach_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(txtFilter);
            pnlFilter.Controls.Add(cboFilterTheLoai);
            pnlFilter.Controls.Add(lblFilter);
            pnlFilter.Location = new Point(750, 81);
            pnlFilter.Margin = new Padding(4, 5, 4, 5);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(720, 56);
            pnlFilter.TabIndex = 2;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(420, 8);
            txtFilter.Margin = new Padding(4, 5, 4, 5);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(290, 27);
            txtFilter.TabIndex = 2;
            // 
            // cboFilterTheLoai
            // 
            cboFilterTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterTheLoai.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboFilterTheLoai.FormattingEnabled = true;
            cboFilterTheLoai.Location = new Point(150, 8);
            cboFilterTheLoai.Margin = new Padding(4, 5, 4, 5);
            cboFilterTheLoai.Name = "cboFilterTheLoai";
            cboFilterTheLoai.Size = new Size(253, 28);
            cboFilterTheLoai.TabIndex = 1;
            cboFilterTheLoai.SelectedIndexChanged += cboFilterTheLoai_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilter.Location = new Point(8, 13);
            lblFilter.Margin = new Padding(4, 0, 4, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(92, 22);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Lọc sách :";
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Location = new Point(15, 81);
            pnlSearch.Margin = new Padding(4, 5, 4, 5);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(720, 56);
            pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(150, 8);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(560, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(8, 13);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(92, 22);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(15, 16);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(399, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH MỤC SÁCH";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dgvSach);
            pnlMain.Controls.Add(lblRowCount);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 161);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1800, 485);
            pnlMain.TabIndex = 1;
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = Color.White;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.Location = new Point(0, 0);
            dgvSach.Margin = new Padding(4, 5, 4, 5);
            dgvSach.MultiSelect = false;
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 62;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1800, 447);
            dgvSach.TabIndex = 1;
            dgvSach.SelectionChanged += dgvSach_SelectionChanged;
            // 
            // lblRowCount
            // 
            lblRowCount.AutoSize = true;
            lblRowCount.Dock = DockStyle.Bottom;
            lblRowCount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRowCount.Location = new Point(0, 447);
            lblRowCount.Margin = new Padding(4, 0, 4, 0);
            lblRowCount.Name = "lblRowCount";
            lblRowCount.Padding = new Padding(15, 8, 0, 8);
            lblRowCount.Size = new Size(200, 38);
            lblRowCount.TabIndex = 0;
            lblRowCount.Text = "Danh sách có 0 dòng.";
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(pnlFunctions);
            pnlBottom.Controls.Add(pnlBookInfo);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 646);
            pnlBottom.Margin = new Padding(4, 5, 4, 5);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1800, 323);
            pnlBottom.TabIndex = 2;
            // 
            // pnlFunctions
            // 
            pnlFunctions.BackColor = Color.LightBlue;
            pnlFunctions.Controls.Add(btnKetThuc);
            pnlFunctions.Controls.Add(btnKhongLuu);
            pnlFunctions.Controls.Add(btnLuu);
            pnlFunctions.Controls.Add(btnXoa);
            pnlFunctions.Controls.Add(btnCapNhat);
            pnlFunctions.Controls.Add(btnThem);
            pnlFunctions.Controls.Add(lblFunctions);
            pnlFunctions.Dock = DockStyle.Right;
            pnlFunctions.Location = new Point(900, 0);
            pnlFunctions.Margin = new Padding(4, 5, 4, 5);
            pnlFunctions.Name = "pnlFunctions";
            pnlFunctions.Size = new Size(900, 323);
            pnlFunctions.TabIndex = 1;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = Color.White;
            btnKetThuc.FlatStyle = FlatStyle.Flat;
            btnKetThuc.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKetThuc.Location = new Point(600, 210);
            btnKetThuc.Margin = new Padding(4, 5, 4, 5);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(225, 81);
            btnKetThuc.TabIndex = 6;
            btnKetThuc.Text = "❌ Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = false;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnKhongLuu
            // 
            btnKhongLuu.BackColor = Color.White;
            btnKhongLuu.FlatStyle = FlatStyle.Flat;
            btnKhongLuu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKhongLuu.Location = new Point(300, 210);
            btnKhongLuu.Margin = new Padding(4, 5, 4, 5);
            btnKhongLuu.Name = "btnKhongLuu";
            btnKhongLuu.Size = new Size(225, 81);
            btnKhongLuu.TabIndex = 5;
            btnKhongLuu.Text = "📄❌ Không lưu";
            btnKhongLuu.UseVisualStyleBackColor = false;
            btnKhongLuu.Click += btnKhongLuu_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.White;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(75, 210);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(225, 81);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "💾 Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(600, 97);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(225, 81);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "❌ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.White;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(300, 97);
            btnCapNhat.Margin = new Padding(4, 5, 4, 5);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(225, 81);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "✏️ Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(75, 97);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(225, 81);
            btnThem.TabIndex = 1;
            btnThem.Text = "👤 Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblFunctions
            // 
            lblFunctions.AutoSize = true;
            lblFunctions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFunctions.Location = new Point(75, 33);
            lblFunctions.Margin = new Padding(4, 0, 4, 0);
            lblFunctions.Name = "lblFunctions";
            lblFunctions.Size = new Size(125, 25);
            lblFunctions.TabIndex = 0;
            lblFunctions.Text = "Chức năng";
            // 
            // pnlBookInfo
            // 
            pnlBookInfo.BackColor = Color.LightBlue;
            pnlBookInfo.Controls.Add(cboTinhTrang);
            pnlBookInfo.Controls.Add(cboNhaXB);
            pnlBookInfo.Controls.Add(cboTacGia);
            pnlBookInfo.Controls.Add(cboChoMuon);
            pnlBookInfo.Controls.Add(cboTheLoai);
            pnlBookInfo.Controls.Add(txtNoiDung);
            pnlBookInfo.Controls.Add(txtTenSach);
            pnlBookInfo.Controls.Add(txtViTri);
            pnlBookInfo.Controls.Add(txtMaSach);
            pnlBookInfo.Controls.Add(lblTinhTrang);
            pnlBookInfo.Controls.Add(lblNhaXB);
            pnlBookInfo.Controls.Add(lblTacGia);
            pnlBookInfo.Controls.Add(lblChoMuon);
            pnlBookInfo.Controls.Add(lblTheLoai);
            pnlBookInfo.Controls.Add(lblNoiDung);
            pnlBookInfo.Controls.Add(lblTenSach);
            pnlBookInfo.Controls.Add(lblViTri);
            pnlBookInfo.Controls.Add(lblMaSach);
            pnlBookInfo.Controls.Add(lblBookInfo);
            pnlBookInfo.Dock = DockStyle.Left;
            pnlBookInfo.Location = new Point(0, 0);
            pnlBookInfo.Margin = new Padding(4, 5, 4, 5);
            pnlBookInfo.Name = "pnlBookInfo";
            pnlBookInfo.Size = new Size(900, 323);
            pnlBookInfo.TabIndex = 0;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Location = new Point(600, 243);
            cboTinhTrang.Margin = new Padding(4, 5, 4, 5);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(268, 28);
            cboTinhTrang.TabIndex = 18;
            // 
            // cboNhaXB
            // 
            cboNhaXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhaXB.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboNhaXB.FormattingEnabled = true;
            cboNhaXB.Location = new Point(600, 194);
            cboNhaXB.Margin = new Padding(4, 5, 4, 5);
            cboNhaXB.Name = "cboNhaXB";
            cboNhaXB.Size = new Size(268, 28);
            cboNhaXB.TabIndex = 17;
            // 
            // cboTacGia
            // 
            cboTacGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTacGia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTacGia.FormattingEnabled = true;
            cboTacGia.Location = new Point(600, 144);
            cboTacGia.Margin = new Padding(4, 5, 4, 5);
            cboTacGia.Name = "cboTacGia";
            cboTacGia.Size = new Size(268, 28);
            cboTacGia.TabIndex = 16;
            // 
            // cboChoMuon
            // 
            cboChoMuon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChoMuon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboChoMuon.FormattingEnabled = true;
            cboChoMuon.Items.AddRange(new object[] { "Chưa cho mượn", "Đã cho mượn" });
            cboChoMuon.Location = new Point(600, 97);
            cboChoMuon.Margin = new Padding(4, 5, 4, 5);
            cboChoMuon.Name = "cboChoMuon";
            cboChoMuon.Size = new Size(268, 28);
            cboChoMuon.TabIndex = 15;
            // 
            // cboTheLoai
            // 
            cboTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTheLoai.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(600, 49);
            cboTheLoai.Margin = new Padding(4, 5, 4, 5);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(268, 28);
            cboTheLoai.TabIndex = 14;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoiDung.Location = new Point(150, 194);
            txtNoiDung.Margin = new Padding(4, 5, 4, 5);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(268, 79);
            txtNoiDung.TabIndex = 13;
            // 
            // txtTenSach
            // 
            txtTenSach.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenSach.Location = new Point(150, 144);
            txtTenSach.Margin = new Padding(4, 5, 4, 5);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(268, 25);
            txtTenSach.TabIndex = 12;
            // 
            // txtViTri
            // 
            txtViTri.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtViTri.Location = new Point(150, 97);
            txtViTri.Margin = new Padding(4, 5, 4, 5);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new Size(268, 25);
            txtViTri.TabIndex = 11;
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaSach.Location = new Point(150, 49);
            txtMaSach.Margin = new Padding(4, 5, 4, 5);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(268, 25);
            txtMaSach.TabIndex = 10;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTinhTrang.Location = new Point(450, 247);
            lblTinhTrang.Margin = new Padding(4, 0, 4, 0);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(84, 20);
            lblTinhTrang.TabIndex = 9;
            lblTinhTrang.Text = "Tình trạng:";
            // 
            // lblNhaXB
            // 
            lblNhaXB.AutoSize = true;
            lblNhaXB.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNhaXB.Location = new Point(450, 198);
            lblNhaXB.Margin = new Padding(4, 0, 4, 0);
            lblNhaXB.Name = "lblNhaXB";
            lblNhaXB.Size = new Size(68, 20);
            lblNhaXB.TabIndex = 8;
            lblNhaXB.Text = "Nhà XB:";
            // 
            // lblTacGia
            // 
            lblTacGia.AutoSize = true;
            lblTacGia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTacGia.Location = new Point(450, 150);
            lblTacGia.Margin = new Padding(4, 0, 4, 0);
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(64, 20);
            lblTacGia.TabIndex = 7;
            lblTacGia.Text = "Tác giả:";
            // 
            // lblChoMuon
            // 
            lblChoMuon.AutoSize = true;
            lblChoMuon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoMuon.Location = new Point(450, 102);
            lblChoMuon.Margin = new Padding(4, 0, 4, 0);
            lblChoMuon.Name = "lblChoMuon";
            lblChoMuon.Size = new Size(76, 20);
            lblChoMuon.TabIndex = 6;
            lblChoMuon.Text = "Mượn/trả:";
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTheLoai.Location = new Point(450, 54);
            lblTheLoai.Margin = new Padding(4, 0, 4, 0);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(68, 20);
            lblTheLoai.TabIndex = 5;
            lblTheLoai.Text = "Thể loại:";
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoiDung.Location = new Point(30, 198);
            lblNoiDung.Margin = new Padding(4, 0, 4, 0);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(76, 20);
            lblNoiDung.TabIndex = 4;
            lblNoiDung.Text = "Nội dung:";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenSach.Location = new Point(30, 150);
            lblTenSach.Margin = new Padding(4, 0, 4, 0);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(78, 20);
            lblTenSach.TabIndex = 3;
            lblTenSach.Text = "Tên sách:";
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblViTri.Location = new Point(30, 102);
            lblViTri.Margin = new Padding(4, 0, 4, 0);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(82, 20);
            lblViTri.TabIndex = 2;
            lblViTri.Text = "Vị trí sách:";
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaSach.Location = new Point(30, 54);
            lblMaSach.Margin = new Padding(4, 0, 4, 0);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(73, 20);
            lblMaSach.TabIndex = 1;
            lblMaSach.Text = "Mã sách:";
            // 
            // lblBookInfo
            // 
            lblBookInfo.AutoSize = true;
            lblBookInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookInfo.Location = new Point(30, 8);
            lblBookInfo.Margin = new Padding(4, 0, 4, 0);
            lblBookInfo.Name = "lblBookInfo";
            lblBookInfo.Size = new Size(171, 25);
            lblBookInfo.TabIndex = 0;
            lblBookInfo.Text = "Thông tin Sách";
            // 
            // QuanLySach
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1800, 969);
            Controls.Add(pnlMain);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "QuanLySach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Danh Mục Sách";
            Load += FormMain_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlFunctions.ResumeLayout(false);
            pnlFunctions.PerformLayout();
            pnlBookInfo.ResumeLayout(false);
            pnlBookInfo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cboFilterTheLoai;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnInDanhSach;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlBookInfo;
        private System.Windows.Forms.Label lblBookInfo;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Label lblChoMuon;
        private System.Windows.Forms.ComboBox cboChoMuon;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.ComboBox cboTacGia;
        private System.Windows.Forms.Label lblNhaXB;
        private System.Windows.Forms.ComboBox cboNhaXB;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Panel pnlFunctions;
        private System.Windows.Forms.Label lblFunctions;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

