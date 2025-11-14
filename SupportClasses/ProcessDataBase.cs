using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BTLLTTQ.SupportClasses   
{
    internal class ProcessDataBase
    {
        string strConnect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLTV;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        SqlConnection sqlConnect = null;

        private void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        private void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }
        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql, sqlConnect);
            sqldataAdapte.Fill(dtBang);
            DongKetNoiCSDL();
            return dtBang;
        }
        public void CapNhatDuLieu(string sql)
        {
            try
            {
                KetNoiCSDL();

                using (SqlCommand cmd = new SqlCommand(sql, sqlConnect))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoiCSDL();
            }
        }
    }
}
