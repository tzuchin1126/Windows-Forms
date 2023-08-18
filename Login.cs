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
using System.Windows.Controls.Primitives;
using System.Xml.Linq;

namespace 期中專案_0420
{
    public partial class Login : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱;
            scsb.IntegratedSecurity = true; //Windows 驗證
            strDBConnectionString = scsb.ConnectionString;
        }

        private void btn_登入_Click(object sender, EventArgs e)
        {
            if ((textBox_帳號.Text != "") && (textBox_密碼.Text != ""))
            {
                string str帳號 = textBox_帳號.Text;
                string str密碼 = textBox_密碼.Text;

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                Console.WriteLine(strDBConnectionString);

                string strSQL = "SELECT * FROM 會員 WHERE 姓名 = @name AND 密碼 = @password;";
                
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@name", str帳號);
                cmd.Parameters.AddWithValue("@password", str密碼);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)//驗證成功
                    GlobalVar.is登入認證成功 = true;
                else//驗證失敗
                    GlobalVar.is登入認證成功 = false;


                if (GlobalVar.is登入認證成功 == true)
                {
                    GlobalVar.使用者ID = (int)reader["id"];
                    GlobalVar.權限 = (int)reader["權限"]; 
                    GlobalVar.使用者名稱 = reader["姓名"].ToString();
                    GlobalVar.user_petName = reader["寵物名稱"].ToString();
                    GlobalVar.user_petType = reader["寵物類型"].ToString();
                    MessageBox.Show("登入成功", "寵物美容預約系統", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                //else
                    //MessageBox.Show("登入失敗", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //MessageBox.Show("登入失敗", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);



            if ((textBox_帳號.Text != "") && (textBox_密碼.Text != ""))
            {
                string str帳號 = textBox_帳號.Text;
                string str密碼 = textBox_密碼.Text;

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                Console.WriteLine(strDBConnectionString);

                string strSQL = "SELECT * FROM 員工 WHERE 姓名 = @name AND 密碼 = @password;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@name", str帳號);
                cmd.Parameters.AddWithValue("@password", str密碼);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)//驗證成功
                    GlobalVar.is登入認證成功 = true;
                else//驗證失敗
                    GlobalVar.is登入認證成功 = false;


                if (GlobalVar.is登入認證成功 == true)
                {
                    GlobalVar.使用者ID = (int)reader["e_id"];
                    GlobalVar.權限 = (int)reader["系統權限"];
                    GlobalVar.使用者名稱 = reader["姓名"].ToString();
                    MessageBox.Show("登入成功", "寵物美容預約系統", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                //else
                    //MessageBox.Show("登入失敗", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("登入失敗", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判斷用戶有無登入
            if (GlobalVar.is登入認證成功 == true)
                e.Cancel = false; //e=事件
            else
            {
                e.Cancel = true;
                MessageBox.Show("請先登入", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_員工_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btn_會員註冊_Click(object sender, EventArgs e)
        {
            GlobalVar.is會員註冊 = true;
            if (GlobalVar.is會員註冊 == true)
            {
                Create myFormLogin = new Create();
                myFormLogin.ShowDialog();
            }
            /*
            Form item = new Create();
            item.Show();
            this.Hide();
            */
        }
    }
}
