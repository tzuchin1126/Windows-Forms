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

namespace 期中專案_0420
{
    public partial class Create : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱;
            scsb.IntegratedSecurity = true; //Windows 驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            strDBConnectionString = scsb.ConnectionString;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            //id

            if ((txt_name.Text != "") && (txt_phone.Text != "") && (txt_password.Text != "") && (txt_petName.Text != "") && (cmb_PetType.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into 會員(姓名, 電話, 生日, 寵物名稱, 寵物類型, 密碼, 權限) values ( @NewName, @NewPhone, @NewBirth, @NewPetName, @NewPetType, @NewPassword, @access);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt_name.Text); 
                cmd.Parameters.AddWithValue("@NewPhone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp_birthday.Value);
                cmd.Parameters.AddWithValue("@NewPetName", txt_petName.Text);
                cmd.Parameters.AddWithValue("@NewPetType", cmb_PetType.SelectedItem);
                cmd.Parameters.AddWithValue("@NewPassword", txt_password.Text);
                cmd.Parameters.AddWithValue("@access", 1000);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                GlobalVar.is會員註冊 = true;
                MessageBox.Show("註冊成功，請重新登入進入頁面", "註冊成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("資料尚未填寫完成", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Create_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btn_回登入頁面_Click(object sender, EventArgs e)
        {
            
        }
    }
}
