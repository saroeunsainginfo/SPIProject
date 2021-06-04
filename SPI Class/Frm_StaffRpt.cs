using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace SPI_Class

{
    
    public partial class Frm_StaffRpt : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        string cs = "Data Source=Gurutech; Initial catalog=Csharp; User ID = sa; Password = 123";
        public Frm_StaffRpt()
        {
            InitializeComponent();
        }

        private void Frm_StaffRpt_Load(object sender, EventArgs e)
        {
            using(cn = new SqlConnection(cs))
            { 
                cn.Open();
                da = new SqlDataAdapter("Select * from tbl_staff where nameen='Saroeun'", cn);
                DataSet ds = new DataSet1();
                da.Fill(ds, "tbl_Staff");
                cn.Close();
                cn.Open();
                da = new SqlDataAdapter("Select * from tbl_user", cn);
                DataSet ds1 = new DataSet1();
                da.Fill(ds1, "tbl_Staff");
                cn.Close();

                CR_Stafff staff = new CR_Stafff();
                staff.SetDataSource(ds.Tables["tbl_Staff"]);
                staff.SetDataSource(ds1.Tables["tbl_user"]);
                crystalReportViewer1.ReportSource = staff;
                crystalReportViewer1.Refresh();
            }

        }
    }
}
