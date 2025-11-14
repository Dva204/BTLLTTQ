using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BTLLTTQ.SupportClasses
{
    public class DatabaseHelper
    {
        
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLTV;Integrated Security=True;TrustServerCertificate=True";

        public DatabaseHelper()
        {
            // constructor để trống vì connection string đã được gán cố định
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Lấy danh sách sách
        public DataTable GetDanhSachSach(string searchText = "", string filterTheLoai = "")
        {
            DataTable dt = new DataTable();
            try
            {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT s.MaSach, s.TenSach, tl.TenTheLoai AS TheLoai, 
                           tg.TenTacGia AS TacGia, nxb.TenNhaXB AS NhaXB, 
                           s.ViTri, s.NoiDung, s.ChoMuon, tt.TenTinhTrang AS TinhTrang,
                           s.MaTheLoai, s.MaTacGia, s.MaNhaXB, s.MaTinhTrang
                    FROM Sach s
                    INNER JOIN TheLoai tl ON s.MaTheLoai = tl.MaTheLoai
                    INNER JOIN TacGia tg ON s.MaTacGia = tg.MaTacGia
                    INNER JOIN NhaXuatBan nxb ON s.MaNhaXB = nxb.MaNhaXB
                    INNER JOIN TinhTrang tt ON s.MaTinhTrang = tt.MaTinhTrang
                    WHERE 1=1";

                if (!string.IsNullOrEmpty(searchText))
                {
                    query += " AND (s.MaSach LIKE @SearchText OR s.TenSach LIKE @SearchText OR s.ViTri LIKE @SearchText)";
                }

                if (!string.IsNullOrEmpty(filterTheLoai))
                {
                    query += " AND tl.TenTheLoai = @FilterTheLoai";
                }

                query += " ORDER BY s.MaSach";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }
                    if (!string.IsNullOrEmpty(filterTheLoai))
                    {
                        cmd.Parameters.AddWithValue("@FilterTheLoai", filterTheLoai);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách sách: {ex.Message}", ex);
            }
            return dt;
        }

        // Lấy danh sách thể loại
        public DataTable GetTheLoai()
        {
            DataTable dt = new DataTable();
            try
            {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT MaTheLoai, TenTheLoai FROM TheLoai ORDER BY TenTheLoai";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách thể loại: {ex.Message}", ex);
            }
            return dt;
        }

        // Lấy danh sách tác giả
        public DataTable GetTacGia()
        {
            DataTable dt = new DataTable();
            try
            {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT MaTacGia, TenTacGia FROM TacGia ORDER BY TenTacGia";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách tác giả: {ex.Message}", ex);
            }
            return dt;
        }

        // Lấy danh sách nhà xuất bản
        public DataTable GetNhaXuatBan()
        {
            DataTable dt = new DataTable();
            try
            {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT MaNhaXB, TenNhaXB FROM NhaXuatBan ORDER BY TenNhaXB";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách nhà xuất bản: {ex.Message}", ex);
            }
            return dt;
        }

        // Lấy danh sách tình trạng
        public DataTable GetTinhTrang()
        {
            DataTable dt = new DataTable();
            try
            {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT MaTinhTrang, TenTinhTrang FROM TinhTrang ORDER BY TenTinhTrang";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách tình trạng: {ex.Message}", ex);
            }
            return dt;
        }

        // Thêm sách mới
        public bool ThemSach(Sach sach)
        {
            try
            {
                if (sach == null)
                    throw new ArgumentNullException(nameof(sach));

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Sach (MaSach, TenSach, MaTheLoai, MaTacGia, MaNhaXB, ViTri, NoiDung, ChoMuon, MaTinhTrang)
                                VALUES (@MaSach, @TenSach, @MaTheLoai, @MaTacGia, @MaNhaXB, @ViTri, @NoiDung, @ChoMuon, @MaTinhTrang)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                        cmd.Parameters.AddWithValue("@MaSach", sach.MaSach ?? "");
                        cmd.Parameters.AddWithValue("@TenSach", sach.TenSach ?? "");
                    cmd.Parameters.AddWithValue("@MaTheLoai", sach.MaTheLoai);
                    cmd.Parameters.AddWithValue("@MaTacGia", sach.MaTacGia);
                    cmd.Parameters.AddWithValue("@MaNhaXB", sach.MaNhaXB);
                        cmd.Parameters.AddWithValue("@ViTri", sach.ViTri ?? "");
                    cmd.Parameters.AddWithValue("@NoiDung", sach.NoiDung ?? "");
                    cmd.Parameters.AddWithValue("@ChoMuon", sach.ChoMuon);
                    cmd.Parameters.AddWithValue("@MaTinhTrang", sach.MaTinhTrang);

                    return cmd.ExecuteNonQuery() > 0;
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sách: {ex.Message}", ex);
            }
        }

        // Cập nhật sách
        public bool CapNhatSach(Sach sach)
        {
            try
            {
                if (sach == null)
                    throw new ArgumentNullException(nameof(sach));

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Sach 
                                SET TenSach = @TenSach, MaTheLoai = @MaTheLoai, MaTacGia = @MaTacGia, 
                                    MaNhaXB = @MaNhaXB, ViTri = @ViTri, NoiDung = @NoiDung, 
                                    ChoMuon = @ChoMuon, MaTinhTrang = @MaTinhTrang
                                WHERE MaSach = @MaSach";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                        cmd.Parameters.AddWithValue("@MaSach", sach.MaSach ?? "");
                        cmd.Parameters.AddWithValue("@TenSach", sach.TenSach ?? "");
                    cmd.Parameters.AddWithValue("@MaTheLoai", sach.MaTheLoai);
                    cmd.Parameters.AddWithValue("@MaTacGia", sach.MaTacGia);
                    cmd.Parameters.AddWithValue("@MaNhaXB", sach.MaNhaXB);
                        cmd.Parameters.AddWithValue("@ViTri", sach.ViTri ?? "");
                    cmd.Parameters.AddWithValue("@NoiDung", sach.NoiDung ?? "");
                    cmd.Parameters.AddWithValue("@ChoMuon", sach.ChoMuon);
                    cmd.Parameters.AddWithValue("@MaTinhTrang", sach.MaTinhTrang);

                    return cmd.ExecuteNonQuery() > 0;
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật sách: {ex.Message}", ex);
            }
        }

        // Xóa sách
        public bool XoaSach(string maSach)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maSach))
                    throw new ArgumentException("Mã sách không được để trống", nameof(maSach));

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Sach WHERE MaSach = @MaSach";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    return cmd.ExecuteNonQuery() > 0;
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sách: {ex.Message}", ex);
            }
        }

        // Kiểm tra mã sách đã tồn tại chưa
        public bool KiemTraMaSach(string maSach)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maSach))
                    return false;

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Sach WHERE MaSach = @MaSach";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                        object result = cmd.ExecuteScalar();
                        return result != null && Convert.ToInt32(result) > 0;
                }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi kiểm tra mã sách: {ex.Message}", ex);
            }
        }
    }
}

