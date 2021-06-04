using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPI_Class
{
    public partial class Frm_Report : Form
    {
        SQLServer obj = new SQLServer();
        public Frm_Report()
        {
            InitializeComponent();
        }

        private void Frm_Report_Load(object sender, EventArgs e)
        {
            //SqlConnection cnn;
            //string sql = null;
            //string connectionString = "data source=Gurutech;initial catalog=CSharp;user id=sa;password=123;";
            //cnn = new SqlConnection(connectionString);
            //cnn.Open();
            //sql = "SELECT * From  tbl_user where usertype='Admin'";
            //SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            //DataSet1 ds = new DataSet1();
            //dscmd.Fill(ds, "tbl_User");
            //cnn.Close();

            //CR_Data objRpt = new CR_Data();
            //objRpt.SetDataSource(ds.Tables["tbl_user"]);
            //crystalReportViewer1.ReportSource = objRpt;
            //crystalReportViewer1.Refresh();

            obj.crf(crystalReportViewer1,"*","tbl_user");

        }
    }
}
