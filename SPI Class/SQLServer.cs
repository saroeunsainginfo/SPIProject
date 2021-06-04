using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace SPI_Class
{

    public class SQLServer : SQLConn
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;


        public void crf(CrystalReportViewer cr_report,string column,string table)
        {
            //Call
            //obj.crf(crystalReportViewer1,"*","tbl_user");

            using (var cn = con())
            {
                
            cn.Open();
            string sql = "SELECT"+column+"  From  "+table+"";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, table);
            cn.Close();

            CR_Data objRpt = new CR_Data();
            objRpt.SetDataSource(ds.Tables[table]);
            cr_report.ReportSource = objRpt;
                cr_report.Refresh();
        }
        }

        public void Retrive(string qty, DataGridView dgv)
        {
            using (var cn = con())
            {

                cmd = new SqlCommand(qty, cn);
                da = new SqlDataAdapter(cmd);

                dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;

            }
        }
        public string GetMaxID(string table, string field, int num, string pre, string defualt)

        {
            string id;
            using (var cn = con())
            {
                cn.Open();
                cmd = new SqlCommand("Select top 1 " + field + " From " + table + " order by " + field + " DESC", cn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string s = dr.GetString(0);
                    s = s.Substring(num, s.Length - 2);

                    int str = Convert.ToInt32(s) + 1;
                    id = pre + Convert.ToString(str).PadLeft(s.Length, '0');
                }
                else
                {
                    id = defualt;
                }

                dr.Close();

                return id;

                cn.Close();
            }
        }

        //public bool ExecuteNonQuery(string sql, CommandType commandType,  List<SqlParameter> parameters)
        //{
        //    using (var cn = con())
        //    {
        //        using (var cmd = new SqlCommand(sql, cn))
        //        {
        //            cmd.CommandType = commandType;
        //            foreach (var parameter in parameters)
        //            {
        //                cmd.Parameters.Add(parameter);
        //            }
        //            cn.Open();
        //            return Convert.ToBoolean(cmd.ExecuteNonQuery());
        //        }
        //    }
        //}
        public bool ExeQuery(string sql, List<SqlParameter> Parameters)
        {
            using (var cn = con())
            {
                cn.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    foreach (SqlParameter parameter in Parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                    return Convert.ToBoolean(cmd.ExecuteNonQuery());
                }
            }
        }
    }
        public static class SQlControl
    {
        //Placeholder
        public const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        //    public static SqlParameter AddSqlParameter(this List<SqlParameter> list, SqlParameter parameter)
        //    {
        //        list.Add(parameter);
        //        return parameter;
        //    }

        //    public static void AddParams(this SqlParameterCollection collection, List<SqlParameter> list)
        //    {
        //        foreach (SqlParameter parameter in list)
        //        {
        //            collection.Add(parameter);
        //        }
        //    }


    }
    

}
