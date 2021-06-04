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
    
    public partial class Frm_User : Form
    {
        SQLServer sql = new SQLServer();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        string cs = "Data Source = Gurutech; initial catalog=CSharp;user id= sa; password= 123";

    private const int EM_SETCUEBANNER = 0x1501;
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,[MarshalAs(UnmanagedType.LPWStr)] string lParam);

    public Frm_User()
        {
            InitializeComponent();
        }
        private void Frm_User_Load(object sender, EventArgs e)
        {
            SQLServer obj = new SQLServer();

            obj.Retrive("Select id,username,password,usertype from tbl_user", Dgv_Data);

            SendMessage(Txt_UserID.Handle,EM_SETCUEBANNER, 0,"លេខសម្គាល់");
            SendMessage(Txt_Username.Handle, EM_SETCUEBANNER, 0, "លេខគណនី");
            SendMessage(Txt_Password.Handle, EM_SETCUEBANNER, 0, "លេខសម្ងាត់");
            SendMessage(Cmb_Usertype.Handle,EM_SETCUEBANNER, 0, " ជ្រើសរើសប្រភេទ");

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //cn = new SqlConnection(cs);
            //cn.Open();

            //cmd = new SqlCommand("insert into tbl_user(id,username,password,usertype) Values(@id,@user,@pass,@usertype)",cn);

            //cmd.Parameters.Add("@id", SqlDbType.NChar).Value = Txt_UserID.Text;
            //cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = Txt_Username.Text;
            //cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = .Text;
            //cmd.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = Cmb_Usertype.Text;

            //cmd.ExecuteNonQuery();
            //MessageBox.Show("គណនីប្រើប្រាស់ត្រូវបានបង្កើតជោគជ័យ");
            //Retrive();
           

            List<SqlParameter> paramList = new List<SqlParameter>()
            {
                new SqlParameter("@id",  Txt_UserID.Text),
                new SqlParameter("@user",  Txt_Username.Text),
                new SqlParameter("@pass",  Txt_Password.Text),
                new SqlParameter("@usertype",Cmb_Usertype.Text)
            };
            
            sql.ExeQuery("insert into tbl_user(id, username, password, usertype) Values(@id, @user, @pass, @usertype)", paramList);

            sql.Retrive("Select id,username,password,usertype from tbl_user", Dgv_Data);

        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            //cn = new SqlConnection(cs);
            //cn.Open();

            //cmd = new SqlCommand("update tbl_user SET username=@user,password=@pass,usertype=@usertype Where id=@id", cn);


            //cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = Txt_Username.Text;
            //cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Txt_Password.Text;
            //cmd.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = Cmb_Usertype.Text;
            //cmd.Parameters.Add("@id", SqlDbType.NChar).Value = Txt_UserID.Text;

            //cmd.ExecuteNonQuery();
            //MessageBox.Show("គណនីប្រើប្រាស់ត្រូវបានកែប្រែបានជោគជ័យ");
            // Retrive();
            List<SqlParameter> paramList = new List<SqlParameter>()
            {
                new SqlParameter("@id",  Txt_UserID.Text),
                new SqlParameter("@user",  Txt_Username.Text),
                new SqlParameter("@pass",  Txt_Password.Text),
                new SqlParameter("@usertype",Cmb_Usertype.Text)

            };

            sql.ExeQuery("update tbl_user SET username=@user,password=@pass,usertype=@usertype Where id=@id", paramList);
            sql.Retrive("Select id,username,password,usertype from tbl_user", Dgv_Data);

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //cn = new SqlConnection(cs);
            //cn.Open();

            //cmd = new SqlCommand("Delete tbl_user Where id=@id", cn);



            //cmd.Parameters.Add("@id", SqlDbType.NChar).Value = Txt_UserID.Text;

            //cmd.ExecuteNonQuery();
            //MessageBox.Show("គណនីប្រើប្រាស់ត្រូវបានលុបដោយជោគជ័យ");
            ////Retrive();
            List<SqlParameter> paramList = new List<SqlParameter>()

            {

                new SqlParameter("@id",  Txt_UserID.Text),
                

            };

            sql.ExeQuery("Delete tbl_user Where id=@id", paramList);
            sql.Retrive("Select id,username,password,usertype from tbl_user", Dgv_Data);
        }

        private void Dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row;

                row = Dgv_Data.Rows[e.RowIndex];

                Txt_UserID.Text = row.Cells["id"].Value.ToString();
                Txt_Username.Text = row.Cells["username"].Value.ToString();
                Txt_Password.Text = row.Cells["password"].Value.ToString();
                Cmb_Usertype.Text = row.Cells["usertype"].Value.ToString();

            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Staff staff = new Frm_Staff();
            staff.Show();
        }
    }
    
}
