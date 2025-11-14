using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BTLLTTQ.SupportClasses
{
    public class ExcelHelper
    {
        /// <summary>
        /// Xuất DataTable ra file Excel (CSV format với UTF-8 BOM để Excel có thể mở)
        /// </summary>
        public static bool ExportToExcel(DataTable dataTable, string fileName)
        {
            try
            {
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Sử dụng SaveFileDialog để chọn nơi lưu file
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveDialog.FileName = fileName;
                saveDialog.DefaultExt = "csv";
                saveDialog.AddExtension = true;
                saveDialog.Title = "Xuất danh sách sách ra file Excel";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveDialog.FileName;

                    // Tạo file CSV với UTF-8 BOM để Excel có thể đọc tiếng Việt
                    using (StreamWriter writer = new StreamWriter(filePath, false, new UTF8Encoding(true)))
                    {
                        // Ghi header
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            if (i > 0) writer.Write(",");
                            writer.Write(EncodeCSVField(dataTable.Columns[i].ColumnName));
                        }
                        writer.WriteLine();

                        // Ghi dữ liệu
                        foreach (DataRow row in dataTable.Rows)
                        {
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                if (i > 0) writer.Write(",");
                                string value = row[i]?.ToString() ?? "";
                                writer.Write(EncodeCSVField(value));
                            }
                            writer.WriteLine();
                        }
                    }

                    DialogResult openResult = MessageBox.Show(
                        $"Xuất file Excel thành công!\nĐường dẫn: {filePath}\n\nBạn có muốn mở file ngay bây giờ không?",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    
                    if (openResult == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(filePath);
                        }
                        catch
                        {
                            // Nếu không mở được, bỏ qua
                        }
                    }
                    
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Encode field để tránh lỗi khi có dấu phẩy, dấu ngoặc kép trong CSV
        /// </summary>
        private static string EncodeCSVField(string field)
        {
            if (string.IsNullOrEmpty(field))
                return "";

            // Nếu field chứa dấu phẩy, dấu ngoặc kép hoặc xuống dòng, cần đặt trong dấu ngoặc kép
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r"))
            {
                // Escape dấu ngoặc kép bằng cách thêm dấu ngoặc kép
                field = field.Replace("\"", "\"\"");
                return "\"" + field + "\"";
            }

            return field;
        }

        /// <summary>
        /// Xuất DataGridView ra file Excel
        /// </summary>
        public static bool ExportDataGridViewToExcel(DataGridView dataGridView, string fileName)
        {
            try
            {
                if (dataGridView == null || dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Chuyển DataGridView thành DataTable
                DataTable dt = new DataTable();

                // Thêm các cột (chỉ lấy cột visible)
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Visible)
                    {
                        dt.Columns.Add(column.HeaderText ?? column.Name);
                    }
                }

                // Thêm dữ liệu
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow newRow = dt.NewRow();
                        int colIndex = 0;
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            if (column.Visible)
                            {
                                newRow[colIndex] = row.Cells[column.Index].Value?.ToString() ?? "";
                                colIndex++;
                            }
                        }
                        dt.Rows.Add(newRow);
                    }
                }

                return ExportToExcel(dt, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

