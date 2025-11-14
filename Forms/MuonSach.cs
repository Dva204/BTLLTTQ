using System;
using System.Data;
using System.Windows.Forms;
using BTLLTTQ;
using BTLLTTQ.SupportClasses;

namespace BTLLTTQ
{
    public partial class frmQuanLy : Form
    {

        ProcessDataBaseMS db = new ProcessDataBaseMS();

        public frmQuanLy()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }


        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridViews();
            LoadDataNguoiMuon();
            ClearInputControls();

        }


        private void LoadDataToDataGridViews()
        {

            string sqlPhieuMuon = @"
            SELECT
                PM.MaPhieuMuon, 
                SV.MaSV, 
                SV.HoTen AS HoTenSV, 
                CTPM.MaSach, 
                S.TenSach AS TenSachMuon, 
                --CTPM.SoLuong, 
                PM.NgayMuon, 
                PM.HanTra
            FROM PhieuMuon PM
            JOIN SinhVien SV ON PM.MaSV = SV.MaSV
            JOIN ChiTietPhieuMuon CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
            JOIN Sach S ON CTPM.MaSach = S.MaSach
            ORDER BY PM.NgayMuon DESC";

            DataTable dtPhieuMuon = db.DocBang(sqlPhieuMuon);

            //dtPhieuMuon.Columns.Add("TinhTrang", typeof(string));

            //foreach (DataRow row in dtPhieuMuon.Rows)
            //{
            //    if (row["MaTinhTrang"] != DBNull.Value)
            //    {
            //        int tinhTrang = Convert.ToInt32(row["MaTinhTrang"]);
            //        row["TinhTrang"] = (tinhTrang == 1) ? "Đang mượn" : "Chưa mượn";
            //    }
            //}
            dgvView1.DataSource = dtPhieuMuon;


            dgvView1.AutoGenerateColumns = true;
            dgvView1.ReadOnly = true;
            dgvView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvView1.Columns["MaPhieuMuon"].HeaderText = "Mã Phiếu";
            dgvView1.Columns["MaSV"].HeaderText = "Mã Sinh Viên";
            dgvView1.Columns["MaSach"].HeaderText = "Mã Sách";
            //dgvView1.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvView1.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            dgvView1.Columns["HanTra"].HeaderText = "Hạn Trả";
            dgvView1.Columns["TenSachMuon"].HeaderText = "Tên Sách Mượn";


            dgvView1.Columns["MaSV"].Width = 80;
            dgvView1.Columns["MaSach"].Width = 80;





            dgvView1.Columns["MaSV"].Visible = true;
            dgvView1.Columns["MaPhieuMuon"].Visible = false;
            dgvView1.Columns["MaSach"].Visible = true;
        }


        private void ClearInputControls()
        {
            txtPhieuMuon.Text = "";
            //txtNguoiMuon.Text = "";
            txtMaSach.Text = "";
            //   txtSach.Text = "";
            txtMaSV.Text = "";
            //cbTinhTrang.Text = "";

            dtpMuon.Value = DateTime.Now;
            dtpTra.Value = DateTime.Now.AddDays(7);
            txtPhieuMuon.Focus();
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtPhieuMuon.ReadOnly = false;
            txtMaSV.ReadOnly = false;
            //txtNguoiMuon.ReadOnly = false;
            //txtSach.ReadOnly = false;
            txtPhieuMuon.ReadOnly = false;
            dtpMuon.Enabled = true;
            ClearInputControls();
            LoadDataToDataGridViews();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã Sinh Viên và Mã Sách!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = txtMaSV.Text.Trim();
            //   string hoTen = txtNguoiMuon.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            string ngayMuon = dtpMuon.Value.ToString("yyyy-MM-dd");
            string ngayTra = dtpTra.Value.ToString("yyyy-MM-dd");
            string maPhieuMuon = txtPhieuMuon.Text.Trim();

            try
            {
                // 1. Kiểm tra và thêm Sinh Viên nếu chưa tồn tại
                if (db.DocBang($"SELECT MaSV FROM SinhVien WHERE MaSV='{maSV}'").Rows.Count == 0)
                {
                    string sqlInsertSV = $"INSERT INTO SinhVien(MaSV) VALUES('{maSV}')";
                    db.CapNhatDuLieu(sqlInsertSV);
                }

                // 2. Thêm Phiếu Mượn
                string sqlInsertPM = $"INSERT INTO PhieuMuon(MaPhieuMuon, MaSV, NgayMuon, HanTra, GhiChu) VALUES('{maPhieuMuon}','{maSV}', '{ngayMuon}', '{ngayTra}', N'')";
                db.CapNhatDuLieu(sqlInsertPM);

                // 3. Lấy MaPhieuMuon mới nhất
                DataTable dt = db.DocBang("SELECT TOP 1 MaPhieuMuon FROM PhieuMuon ORDER BY MaPhieuMuon DESC");
                string maPhieuMoi = dt.Rows[0]["MaPhieuMuon"].ToString();

                // 4. Thêm Chi Tiết Phiếu Mượn
                string sqlInsertCTPM = $"INSERT INTO ChiTietPhieuMuon(MaPhieuMuon, MaSach, SoLuong) VALUES('{maPhieuMoi}', '{maSach}', 1)";
                db.CapNhatDuLieu(sqlInsertCTPM);

                // 5. Cập nhật tình trạng sách
                //string sqlUpdateSach = $"UPDATE Sach SET MaTinhTrang=1 WHERE MaSach='{maSach}'";
                //db.CapNhatDuLieu(sqlUpdateSach);

                MessageBox.Show("Thêm Phiếu Mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm Phiếu Mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDataToDataGridViews();
            ClearInputControls();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng chọn Phiếu Mượn để Cập nhật!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = txtPhieuMuon.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            //string ngayMuon = dtpMuon.Value.ToString("yyyy-MM-dd");
            string ngayTra = dtpTra.Value.ToString("yyyy-MM-dd");
            //int tinhTrang = (cbTinhTrang.Text == "Đang mượn") ? 1 : 0;

            try
            {
                // 1. Cập nhật Phiếu Mượn
                string sqlUpdatePM = $"UPDATE PhieuMuon SET HanTra='{ngayTra}' WHERE MaPhieuMuon='{maPhieu}'";
                db.CapNhatDuLieu(sqlUpdatePM);
                string sqlUpdateCTPM = $"UPDATE ChiTietPhieuMuon SET MaSach='{maSach}' WHERE MaPhieuMuon='{maPhieu}'";
                db.CapNhatDuLieu(sqlUpdateCTPM);

                // 2. Cập nhật tình trạng sách
                //string sqlUpdateSach = $"UPDATE Sach SET MaTinhTrang={tinhTrang} WHERE MaSach='{maSach}'";
                //db.CapNhatDuLieu(sqlUpdateSach);

                MessageBox.Show("Cập nhật Phiếu Mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật Phiếu Mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDataToDataGridViews();
            ClearInputControls();
        }

        // Sự kiện Click nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng chọn Phiếu Mượn để Xóa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = txtPhieuMuon.Text.Trim();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa Phiếu Mượn '{maPhieu}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                string sqlCheckPhieuTra = $"SELECT COUNT(*) FROM PhieuTra WHERE MaPhieuMuon = '{maPhieu}'";
                int countPhieuTra = Convert.ToInt32(db.DocGiaTri(sqlCheckPhieuTra));

                if (countPhieuTra > 0)
                {
                    MessageBox.Show("Không thể xóa Phiếu Mượn này vì đã có Phiếu Trả liên quan!",
                                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Lấy tất cả sách trong phiếu mượn
                DataTable dtSach = db.DocBang($"SELECT MaSach FROM ChiTietPhieuMuon WHERE MaPhieuMuon='{maPhieu}'");

                // 2. Cập nhật tình trạng sách về chưa mượn
                //foreach (DataRow r in dtSach.Rows)
                //{
                //    string maSach = r["MaSach"].ToString();
                //    string sqlUpdateSach = $"UPDATE Sach SET MaTinhTrang=0 WHERE MaSach='{maSach}'";
                //    db.CapNhatDuLieu(sqlUpdateSach);
                //}

                // 3. Xóa chi tiết phiếu mượn
                string sqlDeleteCTPM = $"DELETE FROM ChiTietPhieuMuon WHERE MaPhieuMuon='{maPhieu}'";
                db.CapNhatDuLieu(sqlDeleteCTPM);

                // 4. Xóa phiếu mượn
                string sqlDeletePM = $"DELETE FROM PhieuMuon WHERE MaPhieuMuon='{maPhieu}'";
                db.CapNhatDuLieu(sqlDeletePM);

                MessageBox.Show("Xóa Phiếu Mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa Phiếu Mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDataToDataGridViews();
            ClearInputControls();
        }
        private void dgvView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView1.Rows[e.RowIndex];

                //  txtNguoiMuon.Text = row.Cells["HoTenSV"].Value.ToString();
                //txtSach.Text = row.Cells["TenSachMuon"].Value.ToString();
                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtPhieuMuon.Text = row.Cells["MaPhieuMuon"].Value.ToString();
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                //cbTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();

                // Gán giá trị cho DateTimePicker
                dtpMuon.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                dtpTra.Value = Convert.ToDateTime(row.Cells["HanTra"].Value);


                txtPhieuMuon.ReadOnly = true;
                txtMaSV.ReadOnly = true;
                //txtNguoiMuon.ReadOnly = true;
                //txtSach.ReadOnly = true;
                txtPhieuMuon.ReadOnly = true;
                dtpMuon.Enabled = false;

                txtMaSach.ReadOnly = false;
                dtpTra.Enabled = true;
            }
        }

        // Sự kiện Click nút Tìm
        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDataToDataGridViews();
                return;
            }


            DataTable dt = (DataTable)dgvView1.DataSource;
            if (dt != null)
            {
                try
                {

                    string filter = $"MaPhieuMuon LIKE '%{keyword}%' OR [Họ Tên Độc Giả] LIKE '%{keyword}%' OR [Tên Sách Mượn] LIKE '%{keyword}%'";
                    dt.DefaultView.RowFilter = filter;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi Filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // ---------------------------------------------

        private void LoadDataNguoiMuon()
        {
            string sqlNguoiMuon = "SELECT MaSV, HoTen, Lop, Khoa, NgayCap, HanSuDung, GioiTinh, SoDienThoai FROM SinhVien ORDER BY MaSV ASC";

            DataTable dtNguoiMuon = db.DocBang(sqlNguoiMuon);

            // Gán dữ liệu cho DataGridView của tab Người Mượn
            dgvView2.DataSource = dtNguoiMuon;

            // Cấu hình hiển thị
            dgvView2.AutoGenerateColumns = true;
            dgvView2.ReadOnly = true;
            dgvView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổi tên Header
            dgvView2.Columns["MaSV"].HeaderText = "Mã Độc Giả";
            dgvView2.Columns["HoTen"].HeaderText = "Họ Tên";

            dgvView2.Columns["NgayCap"].HeaderText = "Ngày Cấp";
            dgvView2.Columns["HanSuDung"].HeaderText = "Hạn SD";
            dgvView2.Columns["SoDienThoai"].HeaderText = "SĐT";

        }
        private void ClearInputNguoiMuon()
        {

            txtMaMuon.Text = "";
            txtHoTenMuon.Text = "";



            txtMaMuon.Focus();
        }

        private void dgvView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView2.Rows[e.RowIndex];


                txtMaMuon.Text = row.Cells["MaSV"].Value.ToString();
                txtHoTenMuon.Text = row.Cells["HoTen"].Value.ToString();
                txtLop.Text = row.Cells["Lop"].Value.ToString();
                txtKhoa.Text = row.Cells["Khoa"].Value.ToString();
                cbGt.Text = row.Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();

            }
        }

        private void btnThemMuon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMuon.Text) || string.IsNullOrEmpty(txtHoTenMuon.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã Người Mượn và Họ Tên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = txtMaMuon.Text.Trim();
            string hoTen = txtHoTenMuon.Text.Trim();



            string lop = txtLop.Text.Trim();
            string khoa = txtKhoa.Text.Trim();
            string gioiTinh = cbGt.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string ngayCap = DateTime.Now.ToString("yyyy-MM-dd");
            string hanSD = DateTime.Now.AddYears(4).ToString("yyyy-MM-dd");

            try
            {
                // Kiểm tra trùng mã trước khi thêm
                if (db.DocBang($"SELECT MaSV FROM PhieuMuon  WHERE MaSV = '{maSV}'").Rows.Count > 0)
                {
                    MessageBox.Show("Mã Người Mượn đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sqlInsert = $"INSERT INTO SinhVien ( HoTen, Lop, Khoa, NgayCap, HanSuDung, GioiTinh, SoDienThoai) " +
                                    $"VALUES (N'{hoTen}',  N'{lop}', N'{khoa}', '{ngayCap}', '{hanSD}', N'{gioiTinh}', '{sdt}')";
                db.CapNhatDuLieu(sqlInsert);

                MessageBox.Show("Thêm Người Mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm Người Mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDataNguoiMuon();
            ClearInputNguoiMuon();
        }

        private void btnSuaMuon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMuon.Text))
            {
                MessageBox.Show("Vui lòng chọn Người Mượn để Cập nhật!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = txtMaMuon.Text.Trim();
            string hoTen = txtHoTenMuon.Text.Trim();


            // Giả định các giá trị mặc định (cần sửa nếu có controls đầy đủ trên UI)
            string lop = txtLop.Text.Trim();
            string khoa = txtKhoa.Text.Trim();
            string gioiTinh = cbGt.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            try
            {
                // Cập nhật các trường có trên UI và các trường mặc định khác
                string sqlUpdate = $"UPDATE SinhVien SET HoTen = N'{hoTen}', Lop = N'{lop}', Khoa = N'{khoa}', GioiTinh = N'{gioiTinh}', SoDienThoai = '{sdt}' WHERE MaSV = '{maSV}'";
                db.CapNhatDuLieu(sqlUpdate);

                MessageBox.Show("Cập nhật Người Mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật Người Mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDataNguoiMuon();
            ClearInputNguoiMuon();
        }

        private void btnXoaMuon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMuon.Text))
            {
                MessageBox.Show("Vui lòng chọn Người Mượn để Xóa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = txtMaMuon.Text.Trim();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa Người Mượn có Mã '{maSV}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                if (db.DocBang($"SELECT MaSV FROM PhieuMuon WHERE MaSV = '{maSV}'").Rows.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vì Người Mượn này còn Phiếu Mượn đang tồn tại!", "Lỗi Ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sqlDelete = $"DELETE FROM SinhVien WHERE MaSV = '{maSV}'";
                db.CapNhatDuLieu(sqlDelete);

                MessageBox.Show("Xóa Người Mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa Người Mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDataNguoiMuon();
            ClearInputNguoiMuon();
        }

        private void btnTimMuon_Click(object sender, EventArgs e)
        {
            string keyword = txtTimMuon.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadDataNguoiMuon();
                return;
            }


            string sqlSearch = $"SELECT MaSV, HoTen, Lop, Khoa, NgayCap, HanSuDung, GioiTinh, SoDienThoai FROM SinhVien " +
                               $"WHERE MaSV LIKE '%{keyword}%' OR HoTen LIKE N'%{keyword}%' OR SoDienThoai LIKE '%{keyword}%'";

            DataTable dtNguoiMuon = db.DocBang(sqlSearch);
            dgvView2.DataSource = dtNguoiMuon;

            if (dtNguoiMuon.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoiMuon_Click(object sender, EventArgs e)
        {
            txtMaMuon.Text = "";    
            txtHoTenMuon.Text = "";
            txtLop.Text = "";
            txtKhoa.Text = "";
            cbGt.Text = "";
            txtSDT.Text = "";
            txtMaMuon.Focus();
            LoadDataNguoiMuon();    

        }
    }



}