using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BTLLTTQ.SupportClasses
{
    internal class ProcessDataBaseMS
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
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnect;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
        public object DocGiaTri(string sql)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object result = cmd.ExecuteScalar(); // chỉ lấy 1 giá trị (ô đầu tiên)
                conn.Close();
                return result;
            }
        }
    }
}
