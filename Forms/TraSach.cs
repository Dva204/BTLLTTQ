using System;
using System.Data;
using System.Windows.Forms;
using BTLLTTQ.SupportClasses;

namespace BTLLTTQ
{
    public partial class TraSach : Form
    {
        ProcessDataBase db = new ProcessDataBase();

        public TraSach()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgayTra.Value = DateTime.Now;

            // Gắn sự kiện
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            dtpNgayTra.ValueChanged += dtpNgayTra_ValueChanged;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            dataGridView.CurrentCellDirtyStateChanged += dataGridView_CurrentCellDirtyStateChanged;

            // ✅ Không tự sinh cột
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadDanhSachMuon();
        }

        private void LoadDanhSachMuon()
        {
            string sql = @"
                SELECT 
                    PM.MaPhieuMuon,
                    S.MaSach,
                    S.TenSach AS TenSach,
                    CTPM.SoLuong,
                    PM.NgayMuon,
                    PM.HanTra
                FROM PhieuMuon PM
                INNER JOIN SinhVien SV ON PM.MaSV = SV.MaSV
                INNER JOIN ChiTietPhieuMuon CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                INNER JOIN Sach S ON CTPM.MaSach = S.MaSach
                WHERE PM.MaPhieuMuon NOT IN (SELECT MaPhieuMuon FROM PhieuTra)
                ORDER BY PM.NgayMuon DESC";

            try
            {
                DataTable dt = db.DocBang(sql);

                // ✅ Không thêm cột mới, chỉ gán DataSource
                dataGridView.DataSource = dt;
                CapNhatTrangThai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSinhVien.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                LoadDanhSachMuon();
                return;
            }

            string sql = $@"
                SELECT 
                    PM.MaPhieuMuon,
                    S.MaSach,
                    S.TenSach AS TenSach,
                    CTPM.SoLuong,
                    PM.NgayMuon,
                    PM.HanTra
                FROM PhieuMuon PM
                INNER JOIN SinhVien SV ON PM.MaSV = SV.MaSV
                INNER JOIN ChiTietPhieuMuon CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                INNER JOIN Sach S ON CTPM.MaSach = S.MaSach
                WHERE SV.MaSV = {maSV}
                ORDER BY PM.NgayMuon DESC";

            try
            {
                DataTable dt = db.DocBang(sql);
                dataGridView.DataSource = dt;
                CapNhatTrangThai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void TinhNgayTreVaPhiPhat()
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                    return;

                var cell = dataGridView.CurrentRow.Cells["HanTra"];
                if (cell?.Value == null || cell.Value == DBNull.Value)
                {
                    txtSoNgayTre.Text = "0";
                    txtPhiPhat.Text = "0";
                    return;
                }

                DateTime ngayHenTra = Convert.ToDateTime(cell.Value);
                DateTime ngayTra = dtpNgayTra.Value.Date;

                int soNgayTre = (ngayTra - ngayHenTra.Date).Days;
                if (soNgayTre < 0) soNgayTre = 0;

                txtSoNgayTre.Text = soNgayTre.ToString();
                txtPhiPhat.Text = (soNgayTre * 5000).ToString("N0");
            }
            catch
            {
                txtSoNgayTre.Text = "0";
                txtPhiPhat.Text = "0";
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            TinhNgayTreVaPhiPhat();
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            TinhNgayTreVaPhiPhat();
            CapNhatTrangThai();
        }

        private void CapNhatTrangThai()
        {
            if (dataGridView.DataSource == null) return;

            int tongSach = dataGridView.Rows.Count;
            int daChon = 0;
            decimal tongPhat = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool isChecked = false;
                if (row.Cells["ChonTra"]?.Value != null)
                    bool.TryParse(row.Cells["ChonTra"].Value.ToString(), out isChecked);

                if (isChecked)
                {
                    daChon++;
                    decimal phi = 0;
                    decimal.TryParse(txtPhiPhat.Text.Replace(",", ""), out phi);
                    tongPhat += phi;
                }
            }

            lblTrangThai.Text = $"Tổng sách đang mượn: {tongSach} | Đã chọn trả: {daChon} | Tổng phí phạt: {tongPhat:N0} VNĐ";
            lblTrangThai.ForeColor = tongPhat > 0 ? System.Drawing.Color.Red : System.Drawing.Color.Black;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dataGridView.Columns[e.ColumnIndex];
            if (col == null) return;

            if (string.Equals(col.Name, "ChonTra", StringComparison.OrdinalIgnoreCase))
                CapNhatTrangThai();
        }

        private void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView.IsCurrentCellDirty)
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("Không có sách nào để trả!");
                    return;
                }

                var dsChon = dataGridView.Rows.Cast<DataGridViewRow>()
                    .Where(r => Convert.ToBoolean(r.Cells["ChonTra"].Value))
                    .ToList();

                if (dsChon.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một sách để trả!");
                    return;
                }

                foreach (var row in dsChon)
                {
                    string maPhieuMuon = row.Cells["MaPhieuMuon"].Value.ToString();
                    string maSach = row.Cells["MaSach"].Value.ToString();
                    decimal tienPhat = string.IsNullOrEmpty(txtPhiPhat.Text) ? 0 : Convert.ToDecimal(txtPhiPhat.Text.Replace(",", ""));
                    string ghiChu = txtGhiChu.Text;

                    string sqlPhieuTra = $@"
                INSERT INTO PhieuTra (MaPhieuMuon, NgayTra, TienPhat, GhiChu)
                VALUES ({maPhieuMuon}, '{dtpNgayTra.Value:yyyy-MM-dd}', {tienPhat}, N'{ghiChu}');
                DECLARE @MaPhieuTra INT = SCOPE_IDENTITY();
                INSERT INTO ChiTietPhieuTra (MaPhieuTra, MaSach, SoLuong, TinhTrang)
                VALUES (@MaPhieuTra, '{maSach}', 1, N'Tốt');
                UPDATE Sach SET ChoMuon = 0 WHERE MaSach = '{maSach}';
            ";

                    db.CapNhatDuLieu(sqlPhieuTra);

                }

                MessageBox.Show("Trả sách thành công!");
                LoadDanhSachMuon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trả sách: " + ex.Message);
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            string thongTin = $"Ngày trả: {dtpNgayTra.Value:dd/MM/yyyy}\n" +
                              $"Số ngày trễ: {txtSoNgayTre.Text}\n" +
                              $"Phí phạt: {txtPhiPhat.Text} VNĐ\n" +
                              $"Ghi chú: {txtGhiChu.Text}";

            MessageBox.Show(thongTin, "Phiếu Trả Sách");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSinhVien.Clear();
            txtSoNgayTre.Clear();
            txtPhiPhat.Clear();
            txtGhiChu.Clear();
            dtpNgayTra.Value = DateTime.Now;

            foreach (DataGridViewRow row in dataGridView.Rows)
                row.Cells["ChonTra"].Value = false;

            lblTrangThai.Text = "Tổng sách đang mượn: 0 | Đã chọn trả: 0 | Tổng phí phạt: 0 VNĐ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
