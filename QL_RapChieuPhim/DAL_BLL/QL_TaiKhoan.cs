using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class QL_TaiKhoan
    {
        TaiKhoanBLL tkbll = new TaiKhoanBLL();

        public int Check_Config()
        {
            if (Properties.Settings.Default.QUANLYRAPCHIEUPHIMConnectionString == string.Empty)
            {
                return 1;
            }
            SqlConnection Sqlconn = new SqlConnection(Properties.Settings.Default.QUANLYRAPCHIEUPHIMConnectionString);
            try
            {
                if (Sqlconn.State == System.Data.ConnectionState.Closed)
                {
                    Sqlconn.Open();
                }
                return 0;
            }
            catch
            {
                return 2;
            }
        }

        public int Check_TaiKhoan(string user, string pass)
        {
            var data = tkbll.Check_TaiKhoan(user, pass);

            if (data.Count == 0)
            {
                return 0;
            }
            else if (data[0].TinhTrang == null || data[0].TinhTrang == false)
            {
                return 1;
            }
            return 2;
        }

        public DataTable GetServerName()
        {
            return SqlDataSourceEnumerator.Instance.GetDataSources();
        }

        public DataTable GetDbName(string Server, string User, string Pass)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
                    "Data Source=" + Server + ";Initial Catalog=master;User ID=" + User + ";Password=" + Pass);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public void SaveConfig(string Server, string User, string Pass, string DBname)
        {
            DAL_BLL.Properties.Settings.Default.QUANLYRAPCHIEUPHIMConnectionString = "Data Source=" + Server + ";Initial Catalog=" + DBname + ";User ID=" + User + ";Password=" + Pass;
            DAL_BLL.Properties.Settings.Default.Save();
        }
    }
}
