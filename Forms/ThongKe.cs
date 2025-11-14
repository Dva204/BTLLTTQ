using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BTLLTTQ { 
    public partial class frmThongKe : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLTV;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadTongQuanStats();
            PopulateReportComboBox();
            PopulateChartComboBox(); // <-- HÀM MỚI

            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            this.btnVeBieuDo.Click += new System.EventHandler(this.btnVeBieuDo_Click);
        }

        private void LoadTongQuanStats()
        {
            try
            {
                lblTongSoSach.Text = $"Tổng số sách: {GetScalarValue("SELECT COUNT(*) FROM Sach")}";
                lblDangMuon.Text = $"Đang mượn: {GetScalarValue("SELECT COUNT(*) FROM Sach WHERE ChoMuon = 1")}";
                lblCoSan.Text = $"Có sẵn: {GetScalarValue("SELECT COUNT(*) FROM Sach WHERE ChoMuon = 0 AND MaTinhTrang = 1")}";
                lblBiHong.Text = $"Hỏng/Mất: {GetScalarValue("SELECT COUNT(*) FROM Sach WHERE MaTinhTrang IN (2, 3, 4)")}";

                string queryQuaHan = @"
                    SELECT COUNT(DISTINCT CTPM.MaSach) 
                    FROM PhieuMuon PM
                    JOIN ChiTietPhieuMuon CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                    WHERE 
                        PM.HanTra < GETDATE() 
                        AND PM.MaPhieuMuon NOT IN (SELECT MaPhieuMuon FROM PhieuTra WHERE MaPhieuMuon IS NOT NULL)";
                lblSachQuaHan.Text = $"Sách quá hạn: {GetScalarValue(queryQuaHan)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê tổng quan: " + ex.Message);
            }
        }

        private void PopulateReportComboBox()
        {
            cboLoaiBaoCao.Items.Clear();
            cboLoaiBaoCao.Items.Add("Chi tiết Đầu sách (Kèm TG, NXB, Thể loại)");
            cboLoaiBaoCao.Items.Add("Sách quá hạn trả");
            cboLoaiBaoCao.Items.Add("Sách theo tình trạng");
            cboLoaiBaoCao.SelectedIndex = 0;
        }

        private void PopulateChartComboBox()
        {
            cboBieuDoChon.Items.Add("Biểu đồ Sách theo Thể loại");
            cboBieuDoChon.Items.Add("Biểu đồ Sách theo Nhà Xuất Bản");
            cboBieuDoChon.Items.Add("Biểu đồ Sách theo Tác Giả");
            cboBieuDoChon.Items.Add("Biểu đồ Sách theo Tình trạng"); 
            cboBieuDoChon.SelectedIndex = 0;
        }


        private int GetScalarValue(string query)
        {
            int value = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            value = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi GetScalarValue: " + ex.Message);
                    }
                }
            }
            return value;
        }

        private void LoadDataToGrid(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvBaoCao.DataSource = dataTable;
                        dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu báo cáo: " + ex.Message);
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string selectedReport = cboLoaiBaoCao.SelectedItem.ToString();
            string query = "";

            switch (selectedReport)
            {
                case "Chi tiết Đầu sách (Kèm TG, NXB, Thể loại)":
                    query = @"
                        SELECT 
                            S.TenSach AS N'Tên Sách',
                            T.TenTheLoai AS N'Thể Loại',
                            TG.TenTacGia AS N'Tác Giả',
                            NXB.TenNhaXB AS N'Nhà Xuất Bản'
                        FROM Sach S
                        JOIN TheLoai T ON S.MaTheLoai = T.MaTheLoai
                        JOIN TacGia TG ON S.MaTacGia = TG.MaTacGia
                        JOIN NhaXuatBan NXB ON S.MaNhaXB = NXB.MaNhaXB
                        ORDER BY S.TenSach;";
                    break;

                case "Sách quá hạn trả":
                    query = @"
                        SELECT
                            PM.MaSV AS N'Mã Độc Giả',
                            S.TenSach AS N'Tên Sách',
                            PM.NgayMuon AS N'Ngày Mượn',
                            PM.HanTra AS N'Hạn Trả',
                            DATEDIFF(day, PM.HanTra, GETDATE()) AS N'Số Ngày Quá Hạn'
                        FROM PhieuMuon AS PM
                        JOIN ChiTietPhieuMuon AS CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                        JOIN Sach AS S ON CTPM.MaSach = S.MaSach
                        WHERE
                            PM.HanTra < GETDATE() 
                            AND PM.MaPhieuMuon NOT IN (SELECT MaPhieuMuon FROM PhieuTra WHERE MaPhieuMuon IS NOT NULL)
                        ORDER BY
                            N'Số Ngày Quá Hạn' DESC;";
                    break;

                case "Sách theo tình trạng":
                    query = @"
                        SELECT 
                            TT.TenTinhTrang AS N'Tên Tình Trạng', 
                            S.TenSach AS N'Tên Sách'
                        FROM Sach S
                        JOIN TinhTrang TT ON S.MaTinhTrang = TT.MaTinhTrang
                        ORDER BY TT.TenTinhTrang, S.TenSach;";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                LoadDataToGrid(query);
            }
        }

        private void btnVeBieuDo_Click(object sender, EventArgs e)
        {
            string selectedChart = cboBieuDoChon.SelectedItem.ToString();
            string query = "";
            string xMember = "";
            string yMember = "Số Lượng"; 
            SeriesChartType chartType = SeriesChartType.Column; 
            switch (selectedChart)
            {
                case "Biểu đồ Sách theo Thể loại":
                    xMember = "Thể Loại";
                    chartType = SeriesChartType.Pie; 
                    query = @"
                        SELECT 
                            T.TenTheLoai AS N'Thể Loại', 
                            COUNT(S.MaSach) AS N'Số Lượng' 
                        FROM Sach S
                        JOIN TheLoai T ON S.MaTheLoai = T.MaTheLoai
                        GROUP BY T.TenTheLoai
                        ORDER BY N'Số Lượng' DESC;";
                    break;

                case "Biểu đồ Sách theo Nhà Xuất Bản":
                    xMember = "Nhà Xuất Bản";
                    chartType = SeriesChartType.Column; 
                    query = @"
                        SELECT 
                            NXB.TenNhaXB AS N'Nhà Xuất Bản', 
                            COUNT(S.MaSach) AS N'Số Lượng' 
                        FROM Sach S
                        JOIN NhaXuatBan NXB ON S.MaNhaXB = NXB.MaNhaXB
                        GROUP BY NXB.TenNhaXB
                        ORDER BY N'Số Lượng' DESC;";
                    break;

                case "Biểu đồ Sách theo Tác Giả":
                    xMember = "Tác Giả";
                    chartType = SeriesChartType.Column; 
                    query = @"
                        SELECT TOP 15 
                            TG.TenTacGia AS N'Tác Giả', 
                            COUNT(S.MaSach) AS N'Số Lượng' 
                        FROM Sach S
                        JOIN TacGia TG ON S.MaTacGia = TG.MaTacGia
                        GROUP BY TG.TenTacGia
                        ORDER BY N'Số Lượng' DESC;"; 
                    break;

                case "Biểu đồ Sách theo Tình trạng":
                    xMember = "Tình Trạng";
                    chartType = SeriesChartType.Pie;
                    query = @"
                        SELECT 
                            TT.TenTinhTrang AS N'Tình Trạng', 
                            COUNT(S.MaSach) AS N'Số Lượng' 
                        FROM Sach S
                        JOIN TinhTrang TT ON S.MaTinhTrang = TT.MaTinhTrang
                        GROUP BY TT.TenTinhTrang
                        ORDER BY N'Số Lượng' DESC;";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        adapter.Fill(dt);
                    }
                    // Vẽ biểu đồ
                    LoadChartData(dt, xMember, yMember, chartType, selectedChart);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu biểu đồ: " + ex.Message);
                }
            }
        }

        private void LoadChartData(DataTable dt, string xMember, string yMember, SeriesChartType chartType, string title)
        {
            chartThongKe.Series.Clear();
            chartThongKe.Legends.Clear();
            chartThongKe.DataSource = dt;
            chartThongKe.Titles.Clear();
            chartThongKe.Titles.Add(title); 

            Series series = new Series("Data");
            series.XValueMember = xMember; 
            series.YValueMembers = yMember; 
            series.ChartType = chartType;

            if (chartType == SeriesChartType.Pie)
            {
                series.IsValueShownAsLabel = true; 
                series.Label = "#PERCENT{P0}"; 
                chartThongKe.Legends.Add("Legend1");
                chartThongKe.Legends[0].Docking = Docking.Bottom;
                series.LegendText = "#VALX"; 
            }
            else
            {
                chartThongKe.ChartAreas[0].AxisX.Interval = 1;
                chartThongKe.ChartAreas[0].AxisX.Title = xMember;
                chartThongKe.ChartAreas[0].AxisY.Title = yMember;
            }

            chartThongKe.Series.Add(series);
            chartThongKe.DataBind();
        }
    }
}