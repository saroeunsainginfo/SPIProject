using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SPI_Class
{
    public partial class Frm_Staff : Form
    {
        SQLServer obj = new SQLServer();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public const int EM_SETCUEBANNER = 0x1501;

        string cs = "Data Source = Gurutech; initial catalog=CSharp;user id= sa; password= 123";

       
        public Frm_Staff()
        {
            InitializeComponent();
        }
        private void heading()
        {
            DVG_Data.Columns[0].HeaderText = "លេខសម្គាល់";

            DVG_Data.Columns[1].HeaderText = "លេខសម្គាល់";
            DVG_Data.Columns[2].HeaderText = "លេខសម្គាល់";
            DVG_Data.Columns[3].HeaderText = "លេខសម្គាល់";
            DVG_Data.Columns[4].HeaderText = "លេខសម្គាល់";
            DVG_Data.Columns[5].HeaderText = "លេខសម្គាល់";
            DVG_Data.Columns[6].HeaderText = "លេខសម្គាល់";
        }

        private void Frm_Staff_Load(object sender, EventArgs e)
        {

            
            obj.Retrive("Select * from tbl_Staff",DVG_Data);
            heading();

            //obj.SendMessage(Txt_ID.Handle, EM_SETCUEBANNER, 0, "លេខសម្គាល់");
            //obj.SendMessage(Txt_NameKH.Handle, EM_SETCUEBANNER, 0, "គោត្តនាម នាម");
            //obj.SendMessage(Txt_NameEN.Handle, EM_SETCUEBANNER, 0, "ជាអក្សរឡាតាំង");
            //obj.SendMessage(Txt_DOB.Handle, EM_SETCUEBANNER, 0, "ថ្ងៃខែឆ្នាំកំណើត");
            //obj.SendMessage(Txt_Email.Handle, EM_SETCUEBANNER, 0, "អ៊ីម៉ែល");
            //obj.SendMessage(Txt_Address.Handle, EM_SETCUEBANNER, 0, "អាសយដ្ឋាន");
        }

        private void DVG_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string gender = (string)DVG_Data.SelectedRows[0].Cells[3].Value;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row;

                row = DVG_Data.Rows[e.RowIndex];

                Txt_ID.Text = row.Cells["id"].Value.ToString();
                Txt_NameEN.Text = row.Cells["namekh"].Value.ToString();
                Txt_NameEN.Text = row.Cells["nameen"].Value.ToString();

                if (gender == "ប្រុស")
                {
                    Rd_Male.Checked = true;
                    Rd_Female.Checked = false;
                }
                else if (gender == "ស្រី")
                {
                    Rd_Male.Checked = false;
                    Rd_Female.Checked = true;
                }

                Txt_DOB.Text = row.Cells["dob"].Value.ToString();
                Txt_Email.Text = row.Cells["email"].Value.ToString();
                Txt_Address.Text = row.Cells["address"].Value.ToString();

            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string fname = Txt_ID.Text + ".jpg";
            
            //string folder = "D:\\Files\\CSharp";
            string folder = @"D:\Files\CSharp";

            string path = System.IO.Path.Combine(folder, fname);
            Image a = Img.Image;
            a.Save(path);
            // --------------------------- 
            cn = new SqlConnection(cs);
            cn.Open();
            cmd = new SqlCommand("insert into tbl_staff Values(@id,@namekh,@nameEn,@gender,@dob,@email,@address,@img)", cn);
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = Txt_ID.Text;
            cmd.Parameters.Add("@namekh", SqlDbType.NChar).Value = Txt_NameKH.Text;
            cmd.Parameters.Add("@nameEn", SqlDbType.NChar).Value = Txt_NameEN.Text;
            if(Rd_Female.Checked == true)
            {
              Rd_Male.Checked = false;
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = "ស្រី";
            }
            else if (Rd_Male.Checked == true)
            {
                Rd_Female.Checked = false;
                cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = "ប្រុស";
            }
            cmd.Parameters.Add("@dob", SqlDbType.NChar).Value = Txt_DOB.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = Txt_Email.Text;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = Txt_Address.Text;

            cmd.Parameters.Add("@img", SqlDbType.NVarChar).Value = fname;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Success");
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            SQLServer sql = new SQLServer();

            //var params = new SQLParameter[]
            //{
            //    new SqlParameter("@P1", SqlDbType.Int).Value = txt_id,
            //    new SqlParameter("@P2", SqlDbType.NVarChar).Value = txt_namekh,
            //    new SqlParameter("@P3", SqlDbType.DateTime).Value = txt_nameen;
            //};

           // sql.ExecuteNonQuery("INSERT INTO tbl_staff() VALUES (@P1, @P2, @P3)", params);

        }
        

    private void Btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Brow_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
           
            var load = op.ShowDialog();

            if (load == DialogResult.OK)
            {
                Img.Image = System.Drawing.Image.FromFile(op.FileName);
            }


        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            string gender = (string)DVG_Data.SelectedRows[0].Cells[3].Value;
            if(gender == "ប្រុស")
            {
                Rd_Male.Checked = true;
                Rd_Female.Checked = false;
            }
            else
            {
                Rd_Male.Checked = false;
                Rd_Female.Checked = true;
            }
        
        }
    }
}
