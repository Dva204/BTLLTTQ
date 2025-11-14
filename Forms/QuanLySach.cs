using System;
using System.Data;
using System.Windows.Forms;
using BTLLTTQ;
using BTLLTTQ.SupportClasses;

namespace BTLLTTQ
{
    public partial class QuanLySach : Form
    {
        private DatabaseHelper dbHelper;
        private bool isAdding = false;
        private bool isEditing = false;
        private string currentMaSach = "";

        public QuanLySach()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo DatabaseHelper trong Form_Load để có thể catch exception
                dbHelper = new DatabaseHelper();
                
                LoadComboBoxes();
                LoadData();
                DisableControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo form: {ex.Message}\n\nVui lòng kiểm tra:\n1. Database đã được tạo chưa\n2. Connection string trong App.config\n3. SQL Server đang chạy", 
                    "Lỗi khởi tạo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                if (dbHelper == null)
                    return;

                if (dgvSach == null || lblRowCount == null)
                    return;

                string searchText = txtSearch?.Text?.Trim() ?? "";
                string filterTheLoai = "";
                if (cboFilterTheLoai != null && cboFilterTheLoai.SelectedIndex > 0 && cboFilterTheLoai.SelectedValue != null)
                {
                    // Bỏ qua "Tất cả" (index 0)
                    filterTheLoai = cboFilterTheLoai.SelectedValue.ToString();
                }

                DataTable dt = dbHelper.GetDanhSachSach(searchText, filterTheLoai);
                
                if (dt != null)
                {
                    dgvSach.DataSource = dt;

                    // Ẩn các cột không cần hiển thị
                    if (dgvSach.Columns.Count > 0)
                    {
                        if (dgvSach.Columns["MaTheLoai"] != null)
                            dgvSach.Columns["MaTheLoai"].Visible = false;
                        if (dgvSach.Columns["MaTacGia"] != null)
                            dgvSach.Columns["MaTacGia"].Visible = false;
                        if (dgvSach.Columns["MaNhaXB"] != null)
                            dgvSach.Columns["MaNhaXB"].Visible = false;
                        if (dgvSach.Columns["MaTinhTrang"] != null)
                            dgvSach.Columns["MaTinhTrang"].Visible = false;
                    }

                    lblRowCount.Text = $"Danh sách có {dt.Rows.Count} dòng.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                if (dbHelper == null)
                    return;

                // Load thể loại cho filter
                DataTable dtTheLoai = dbHelper.GetTheLoai();
                // Thêm dòng "Tất cả" vào đầu danh sách
                DataRow rowAll = dtTheLoai.NewRow();
                rowAll["MaTheLoai"] = 0;
                rowAll["TenTheLoai"] = "Tất cả";
                dtTheLoai.Rows.InsertAt(rowAll, 0);
                
                cboFilterTheLoai.DataSource = dtTheLoai;
                cboFilterTheLoai.DisplayMember = "TenTheLoai";
                cboFilterTheLoai.ValueMember = "TenTheLoai";
                cboFilterTheLoai.SelectedIndex = 0; // Chọn "Tất cả" mặc định

                // Load thể loại cho form (không có "Tất cả")
                DataTable dtTheLoaiForm = dbHelper.GetTheLoai();
                cboTheLoai.DataSource = dtTheLoaiForm;
                cboTheLoai.DisplayMember = "TenTheLoai";
                cboTheLoai.ValueMember = "MaTheLoai";
                cboTheLoai.SelectedIndex = -1;

                // Load tác giả
                DataTable dtTacGia = dbHelper.GetTacGia();
                cboTacGia.DataSource = dtTacGia;
                cboTacGia.DisplayMember = "TenTacGia";
                cboTacGia.ValueMember = "MaTacGia";
                cboTacGia.SelectedIndex = -1;

                // Load nhà xuất bản
                DataTable dtNhaXB = dbHelper.GetNhaXuatBan();
                cboNhaXB.DataSource = dtNhaXB;
                cboNhaXB.DisplayMember = "TenNhaXB";
                cboNhaXB.ValueMember = "MaNhaXB";
                cboNhaXB.SelectedIndex = -1;

                // Load tình trạng
                DataTable dtTinhTrang = dbHelper.GetTinhTrang();
                cboTinhTrang.DataSource = dtTinhTrang;
                cboTinhTrang.DisplayMember = "TenTinhTrang";
                cboTinhTrang.ValueMember = "MaTinhTrang";
                cboTinhTrang.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu combobox: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSach != null && dgvSach.SelectedRows.Count > 0 && !isAdding && !isEditing)
            {
                DataGridViewRow row = dgvSach.SelectedRows[0];
                LoadBookInfo(row);
            }
        }

        private void LoadBookInfo(DataGridViewRow row)
        {
            try
            {
                if (row == null || row.Cells.Count == 0)
                    return;

                // Kiểm tra và load các cell
                if (row.Cells["MaSach"] != null)
                {
                    if (txtMaSach != null)
                        txtMaSach.Text = row.Cells["MaSach"].Value?.ToString() ?? "";
                }
                else
                {
                    if (txtMaSach != null)
                        txtMaSach.Text = "";
                }

                if (row.Cells["ViTri"] != null)
                {
                    if (txtViTri != null)
                        txtViTri.Text = row.Cells["ViTri"].Value?.ToString() ?? "";
                }
                else
                {
                    if (txtViTri != null)
                        txtViTri.Text = "";
                }

                if (row.Cells["TenSach"] != null)
                {
                    if (txtTenSach != null)
                        txtTenSach.Text = row.Cells["TenSach"].Value?.ToString() ?? "";
                }
                else
                {
                    if (txtTenSach != null)
                        txtTenSach.Text = "";
                }

                if (row.Cells["NoiDung"] != null)
                {
                    if (txtNoiDung != null)
                        txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString() ?? "";
                }
                else
                {
                    if (txtNoiDung != null)
                        txtNoiDung.Text = "";
                }

                // Set combobox values
                if (row.Cells["MaTheLoai"] != null && row.Cells["MaTheLoai"].Value != null)
                {
                    try
                    {
                        int maTheLoai = Convert.ToInt32(row.Cells["MaTheLoai"].Value);
                        cboTheLoai.SelectedValue = maTheLoai;
                    }
                    catch
                    {
                        cboTheLoai.SelectedIndex = -1;
                    }
                }
                else
                {
                    cboTheLoai.SelectedIndex = -1;
                }

                if (row.Cells["MaTacGia"] != null && row.Cells["MaTacGia"].Value != null)
                {
                    try
                    {
                        int maTacGia = Convert.ToInt32(row.Cells["MaTacGia"].Value);
                        if (cboTacGia != null)
                            cboTacGia.SelectedValue = maTacGia;
                    }
                    catch
                    {
                        if (cboTacGia != null)
                            cboTacGia.SelectedIndex = -1;
                    }
                }
                else
                {
                    if (cboTacGia != null)
                        cboTacGia.SelectedIndex = -1;
                }

                if (row.Cells["MaNhaXB"] != null && row.Cells["MaNhaXB"].Value != null)
                {
                    try
                    {
                        int maNhaXB = Convert.ToInt32(row.Cells["MaNhaXB"].Value);
                        if (cboNhaXB != null)
                            cboNhaXB.SelectedValue = maNhaXB;
                    }
                    catch
                    {
                        if (cboNhaXB != null)
                            cboNhaXB.SelectedIndex = -1;
                    }
                }
                else
                {
                    if (cboNhaXB != null)
                        cboNhaXB.SelectedIndex = -1;
                }

                if (row.Cells["MaTinhTrang"] != null && row.Cells["MaTinhTrang"].Value != null)
                {
                    try
                    {
                        int maTinhTrang = Convert.ToInt32(row.Cells["MaTinhTrang"].Value);
                        if (cboTinhTrang != null)
                            cboTinhTrang.SelectedValue = maTinhTrang;
                    }
                    catch
                    {
                        if (cboTinhTrang != null)
                            cboTinhTrang.SelectedIndex = -1;
                    }
                }
                else
                {
                    if (cboTinhTrang != null)
                        cboTinhTrang.SelectedIndex = -1;
                }

                // Set ChoMuon
                if (row.Cells["ChoMuon"] != null)
                {
                    try
                    {
                        bool choMuon = row.Cells["ChoMuon"].Value != null && Convert.ToBoolean(row.Cells["ChoMuon"].Value);
                        if (cboChoMuon != null)
                            cboChoMuon.SelectedIndex = choMuon ? 1 : 0;
                    }
                    catch
                    {
                        if (cboChoMuon != null)
                            cboChoMuon.SelectedIndex = 0;
                    }
                }
                else
                {
                    if (cboChoMuon != null)
                        cboChoMuon.SelectedIndex = 0;
                }

                currentMaSach = txtMaSach?.Text ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Chỉ load data nếu form đã được load và dbHelper đã được khởi tạo
            if (dbHelper != null && dgvSach != null)
            {
                LoadData();
            }
        }

        private void cboFilterTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ load data nếu form đã được load và dbHelper đã được khởi tạo
            if (dbHelper != null && dgvSach != null)
            {
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;
            ClearControls();
            EnableControls();
            txtMaSach.Focus();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isEditing = true;
            isAdding = false;
            EnableControls();
            txtMaSach.ReadOnly = true;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sách có mã: {txtMaSach.Text}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dbHelper == null)
                    {
                        MessageBox.Show("Lỗi: DatabaseHelper chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dbHelper.XoaSach(txtMaSach.Text))
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearControls();
                        DisableControls();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                if (dbHelper == null)
                {
                    MessageBox.Show("Lỗi: DatabaseHelper chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Sach sach = GetSachFromForm();

                if (isAdding)
                {
                    if (dbHelper.KiemTraMaSach(sach.MaSach))
                    {
                        MessageBox.Show("Mã sách đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dbHelper.ThemSach(sach))
                    {
                        MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (isEditing)
                {
                    if (dbHelper.CapNhatSach(sach))
                    {
                        MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                LoadData();
                DisableControls();
                ResetButtons();
                isAdding = false;
                isEditing = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy thao tác hiện tại?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvSach.SelectedRows.Count > 0)
                {
                    LoadBookInfo(dgvSach.SelectedRows[0]);
                }
                else
                {
                    ClearControls();
                }

                DisableControls();
                ResetButtons();
                isAdding = false;
                isEditing = false;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát ứng dụng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnKetThuc_Click(sender, e);
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSach == null || dgvSach.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo tên file với ngày giờ
                string fileName = $"DanhSachSach_{DateTime.Now:yyyyMMdd_HHmmss}";
                
                // Xuất ra Excel
                ExcelHelper.ExportDataGridViewToExcel(dgvSach, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}\n\nChi tiết: {ex.ToString()}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (txtMaSach == null || string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach?.Focus();
                return false;
            }

            if (txtTenSach == null || string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach?.Focus();
                return false;
            }

            if (txtViTri == null || string.IsNullOrWhiteSpace(txtViTri.Text))
            {
                MessageBox.Show("Vui lòng nhập vị trí sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtViTri?.Focus();
                return false;
            }

            if (cboTheLoai == null || cboTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTheLoai?.Focus();
                return false;
            }

            if (cboTacGia == null || cboTacGia.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tác giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTacGia?.Focus();
                return false;
            }

            if (cboNhaXB == null || cboNhaXB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhaXB?.Focus();
                return false;
            }

            if (cboTinhTrang == null || cboTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTinhTrang?.Focus();
                return false;
            }

            if (cboChoMuon == null || cboChoMuon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái mượn/trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChoMuon?.Focus();
                return false;
            }

            return true;
        }

        private Sach GetSachFromForm()
        {
            Sach sach = new Sach();
            sach.MaSach = txtMaSach?.Text?.Trim() ?? "";
            sach.TenSach = txtTenSach?.Text?.Trim() ?? "";
            sach.ViTri = txtViTri?.Text?.Trim() ?? "";
            sach.NoiDung = txtNoiDung?.Text?.Trim() ?? "";
            
            if (cboTheLoai?.SelectedValue != null)
                sach.MaTheLoai = Convert.ToInt32(cboTheLoai.SelectedValue);
            else
                throw new Exception("Vui lòng chọn thể loại!");
            
            if (cboTacGia?.SelectedValue != null)
                sach.MaTacGia = Convert.ToInt32(cboTacGia.SelectedValue);
            else
                throw new Exception("Vui lòng chọn tác giả!");
            
            if (cboNhaXB?.SelectedValue != null)
                sach.MaNhaXB = Convert.ToInt32(cboNhaXB.SelectedValue);
            else
                throw new Exception("Vui lòng chọn nhà xuất bản!");
            
            if (cboTinhTrang?.SelectedValue != null)
                sach.MaTinhTrang = Convert.ToInt32(cboTinhTrang.SelectedValue);
            else
                throw new Exception("Vui lòng chọn tình trạng!");
            
            sach.ChoMuon = cboChoMuon?.SelectedIndex == 1;

            return sach;
        }

        private void ClearControls()
        {
            if (txtMaSach != null) txtMaSach.Text = "";
            if (txtViTri != null) txtViTri.Text = "";
            if (txtTenSach != null) txtTenSach.Text = "";
            if (txtNoiDung != null) txtNoiDung.Text = "";
            if (cboTheLoai != null) cboTheLoai.SelectedIndex = -1;
            if (cboTacGia != null) cboTacGia.SelectedIndex = -1;
            if (cboNhaXB != null) cboNhaXB.SelectedIndex = -1;
            if (cboTinhTrang != null) cboTinhTrang.SelectedIndex = -1;
            if (cboChoMuon != null) cboChoMuon.SelectedIndex = -1;
            currentMaSach = "";
        }

        private void EnableControls()
        {
            if (txtMaSach != null) txtMaSach.ReadOnly = false;
            if (txtViTri != null) txtViTri.ReadOnly = false;
            if (txtTenSach != null) txtTenSach.ReadOnly = false;
            if (txtNoiDung != null) txtNoiDung.ReadOnly = false;
            if (cboTheLoai != null) cboTheLoai.Enabled = true;
            if (cboTacGia != null) cboTacGia.Enabled = true;
            if (cboNhaXB != null) cboNhaXB.Enabled = true;
            if (cboTinhTrang != null) cboTinhTrang.Enabled = true;
            if (cboChoMuon != null) cboChoMuon.Enabled = true;
        }

        private void DisableControls()
        {
            if (txtMaSach != null) txtMaSach.ReadOnly = true;
            if (txtViTri != null) txtViTri.ReadOnly = true;
            if (txtTenSach != null) txtTenSach.ReadOnly = true;
            if (txtNoiDung != null) txtNoiDung.ReadOnly = true;
            if (cboTheLoai != null) cboTheLoai.Enabled = false;
            if (cboTacGia != null) cboTacGia.Enabled = false;
            if (cboNhaXB != null) cboNhaXB.Enabled = false;
            if (cboTinhTrang != null) cboTinhTrang.Enabled = false;
            if (cboChoMuon != null) cboChoMuon.Enabled = false;
        }

        private void ResetButtons()
        {
            if (btnThem != null) btnThem.Enabled = true;
            if (btnCapNhat != null) btnCapNhat.Enabled = true;
            if (btnXoa != null) btnXoa.Enabled = true;
            if (txtMaSach != null) txtMaSach.ReadOnly = true;
        }
    }
}


