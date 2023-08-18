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
using System.Reflection.Emit;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Controls;
using System.Data.Common;
using System.Net.NetworkInformation;
using 期中專案_0420.mydbDataSetTableAdapters;

namespace 期中專案_0420
{
    public partial class 預約系統 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        List<int> list小型犬服務價格 = new List<int> { 600, 300, 650, 350, 50, 50, 100, 100 };
        List<int> list中型犬服務價格 = new List<int> { 800, 400, 850, 450, 50, 50, 100, 100 };
        List<int> list中大型短毛犬服務價格 = new List<int> { 1000, 500, 1100, 600, 50, 50, 100, 100 };
        List<int> list中大型長毛犬服務價格 = new List<int> { 1200, 600, 1300, 700, 50, 50, 100, 100 };
        List<int> list大型短毛犬服務價格 = new List<int> { 1300, 700, 1400, 800, 100, 100, 150, 150 };
        List<int> list大型長毛犬服務價格 = new List<int> { 1400, 750, 1500, 850, 100, 100, 150, 150 };
        string 所選寵物種類 = "";
        string 所選服務內容 = "";
        int 總價格 = 0;
        string 所選預約日期 = "";
        string 所選預約時段 = "";

        public 預約系統()
        {
            InitializeComponent();
        }
        private void 預約系統_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱;
            scsb.IntegratedSecurity = true; //Windows 驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            strDBConnectionString = scsb.ConnectionString;

            
            if (GlobalVar.is登入認證成功 == false) //一進系統先跳轉到登入頁面
            {
                Login myFormLogin = new Login();
                myFormLogin.ShowDialog();
            }
            /*
            else if(GlobalVar.is會員註冊 == true)
            {
                Create myFormLogin = new Create();
                myFormLogin.ShowDialog();
            }
            */
            
            
            
            if (GlobalVar.權限 == 1000)//會員
            {
                btn_回系統.Enabled = false;
                btn_購物車頁面.Enabled = true;
                btn_會員頁面.Enabled = false;
                btn_登出系統.Enabled = true;
                btn_訂單.Enabled = false;
                btn_員工.Enabled = false;
                label7.Text = $"使用者:{GlobalVar.使用者名稱}";

            }
            else if (GlobalVar.權限 == 100 )//員工
            {
                btn_回系統.Enabled = true;
                btn_購物車頁面.Enabled = true;
                btn_會員頁面.Enabled = true;
                btn_登出系統.Enabled = true;
                btn_訂單.Enabled = true;
                btn_員工.Enabled = true;
                label7.Text = $"員工:{GlobalVar.使用者名稱}";
            }
        }
        private void comboBox_寵物種類_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_寵物種類.Text !="")
                所選寵物種類 = comboBox_寵物種類.Text;
        }

        private void comboBox_服務內容_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox_寵物種類.Text !="") && comboBox_服務內容.Text !="")
            {
                所選服務內容 = comboBox_服務內容.Text;
                
                //-------
                if ((comboBox_寵物種類.Text == "小型犬 (5kg以下)") && (comboBox_服務內容.Text == "剪毛服務"))
                {
                    總價格 = list小型犬服務價格[0];
                    lbl_選擇服務內容.Text = 所選寵物種類 + 所選服務內容;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "小型犬 (5kg以下)") && (comboBox_服務內容.Text == "洗澡服務"))
                {
                    總價格 = list小型犬服務價格[1];
                    lbl_選擇服務內容.Text = 所選寵物種類 + 所選服務內容;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "小型犬 (5kg以下)") && (comboBox_服務內容.Text == "剪毛+SPA"))
                {
                    總價格 = list小型犬服務價格[2];
                    lbl_選擇服務內容.Text = 所選寵物種類 + 所選服務內容;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "小型犬 (5kg以下)") && (comboBox_服務內容.Text == "洗澡+SPA"))
                {
                    總價格 = list小型犬服務價格[3];
                    lbl_選擇服務內容.Text = 所選寵物種類 + 所選服務內容;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "小型犬 (5kg以下)") && (comboBox_服務內容.Text == "剪指甲"))
                {
                    總價格 = list小型犬服務價格[4];
                    lbl_選擇服務內容.Text = 所選寵物種類 + 所選服務內容;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "小型犬 (5kg以下)") && (comboBox_服務內容.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list小型犬服務價格[5];
                    lbl_選擇服務內容.Text = 所選寵物種類 + 所選服務內容;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "小型犬 (5kg以下)") && (comboBox_服務內容.Text == "藥浴"))
                {
                    總價格 = list小型犬服務價格[6];
                    lbl_選擇服務內容.Text = 所選寵物種類 + 所選服務內容;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "小型犬 (5kg以下)") && (comboBox_服務內容.Text == "除蚤+除蟲"))
                {
                    總價格 = list小型犬服務價格[7];
                    lbl_選擇服務內容.Text = 所選寵物種類 + 所選服務內容;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                //-------
                if ((comboBox_寵物種類.Text == "中型犬 (5-10kg)") && (comboBox_服務內容.Text == "剪毛服務"))
                {
                    總價格 = list中型犬服務價格[0];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中型犬 (5-10kg)") && (comboBox_服務內容.Text == "洗澡服務"))
                {
                    總價格 = list中型犬服務價格[1];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中型犬 (5-10kg)") && (comboBox_服務內容.Text == "剪毛+SPA"))
                {
                    總價格 = list中型犬服務價格[2];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中型犬 (5-10kg)") && (comboBox_服務內容.Text == "洗澡+SPA"))
                {
                    總價格 = list中型犬服務價格[3];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中型犬 (5-10kg)") && (comboBox_服務內容.Text == "剪指甲") )
                {
                    總價格 = list中型犬服務價格[4];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中型犬 (5-10kg)") &&  (comboBox_服務內容.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list中型犬服務價格[5];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中型犬 (5-10kg)") && (comboBox_服務內容.Text == "藥浴") )
                {
                    總價格 = list中型犬服務價格[6];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中型犬 (5-10kg)") && (comboBox_服務內容.Text == "除蚤+除蟲"))
                {
                    總價格 = list中型犬服務價格[7];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                //-----
                if ((comboBox_寵物種類.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務內容.Text == "剪毛服務"))
                {
                    總價格 = list中大型短毛犬服務價格[0];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務內容.Text == "洗澡服務"))
                {
                    總價格 = list中大型短毛犬服務價格[1];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務內容.Text == "剪毛+SPA"))
                {
                    總價格 = list中大型短毛犬服務價格[2];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務內容.Text == "洗澡+SPA"))
                {
                    總價格 = list中大型短毛犬服務價格[3];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務內容.Text == "剪指甲") )
                {
                    總價格 = list中大型短毛犬服務價格[4];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務內容.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list中大型短毛犬服務價格[5];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務內容.Text == "藥浴") )
                {
                    總價格 = list中大型短毛犬服務價格[6];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型短毛犬 (11-15kg)") &&  (comboBox_服務內容.Text == "除蚤+除蟲"))
                {
                    總價格 = list中大型短毛犬服務價格[7];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                //-----
                if ((comboBox_寵物種類.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務內容.Text == "剪毛服務"))
                {
                    總價格 = list中大型長毛犬服務價格[0];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務內容.Text == "洗澡服務"))
                {
                    總價格 = list中大型長毛犬服務價格[1];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務內容.Text == "剪毛+SPA"))
                {
                    總價格 = list中大型長毛犬服務價格[2];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務內容.Text == "洗澡+SPA"))
                {
                    總價格 = list中大型長毛犬服務價格[3];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型長毛犬 (11-15kg)") &&  (comboBox_服務內容.Text == "剪指甲"))
                {
                    總價格 = list中大型長毛犬服務價格[4];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型長毛犬 (11-15kg)") &&  (comboBox_服務內容.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list中大型長毛犬服務價格[5];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務內容.Text == "藥浴") )
                {
                    總價格 = list中大型長毛犬服務價格[6];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務內容.Text == "除蚤+除蟲"))
                {
                    總價格 = list中大型長毛犬服務價格[7];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                //-----
                if ((comboBox_寵物種類.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務內容.Text == "剪毛服務"))
                {
                    總價格 = list大型短毛犬服務價格[0];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務內容.Text == "洗澡服務"))
                {
                    總價格 = list大型短毛犬服務價格[1];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務內容.Text == "剪毛+SPA"))
                {
                    總價格 = list大型短毛犬服務價格[2];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務內容.Text == "洗澡+SPA"))
                {
                    總價格 = list大型短毛犬服務價格[3];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務內容.Text == "剪指甲") )
                {
                    總價格 = list大型短毛犬服務價格[4];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型短毛犬 (15-20kg)") &&  (comboBox_服務內容.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list大型短毛犬服務價格[5];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務內容.Text == "藥浴") )
                {
                    總價格 = list大型短毛犬服務價格[6];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型短毛犬 (15-20kg)") &&  (comboBox_服務內容.Text == "除蚤+除蟲"))
                {
                    總價格 = list大型短毛犬服務價格[7];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                //-----
                if ((comboBox_寵物種類.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務內容.Text == "剪毛服務"))
                {
                    總價格 = list大型長毛犬服務價格[0];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務內容.Text == "洗澡服務"))
                {
                    總價格 = list大型長毛犬服務價格[1];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務內容.Text == "剪毛+SPA"))
                {
                    總價格 = list大型長毛犬服務價格[2];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務內容.Text == "洗澡+SPA"))
                {
                    總價格 = list大型長毛犬服務價格[3];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務內容.Text == "剪指甲") )
                {
                    總價格 = list大型長毛犬服務價格[4];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務內容.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list大型長毛犬服務價格[5];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務內容.Text == "藥浴") )
                {
                    總價格 = list大型長毛犬服務價格[6];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物種類.Text == "大型長毛犬 (15-20kg)") &&  (comboBox_服務內容.Text == "除蚤+除蟲"))
                {
                    總價格 = list大型長毛犬服務價格[7];
                    lbl_選擇服務內容.Text = comboBox_寵物種類.Text + comboBox_服務內容.Text;
                    lbl_顯示總金額.Text = 總價格.ToString();
                }
            }
            else
                MessageBox.Show("請先選擇寵物類型", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_預約_Click(object sender, EventArgs e)
        {
            //解決:要去看價錢就會彈出視窗 
            if ((comboBox_寵物種類.SelectedIndex >= 0) && (comboBox_服務內容.SelectedIndex >= 0) && (dtp_預約日期.Checked == true) && (listBox_預約時段.Text != ""))
            {
                ArrayList 訂購單品資料 = new ArrayList();
                訂購單品資料.Add(所選寵物種類);
                訂購單品資料.Add(所選服務內容);
                訂購單品資料.Add(所選預約日期);
                訂購單品資料.Add(所選預約時段);
                訂購單品資料.Add(總價格);
                GlobalVar.list訂購品項.Add(訂購單品資料);
                MessageBox.Show("感謝您的預約，預約資訊已存入訂單內", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("請選擇預約內容", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //預約訂單傳入資料庫
            if ((comboBox_寵物種類.SelectedIndex != -1) && (comboBox_服務內容.SelectedIndex != -1))
            {
                string timeStr = listBox_預約時段.SelectedItem.ToString();
                DateTime time = DateTime.Parse(timeStr);
                //獲取服務id
                int serviceId = GetServiceId(comboBox_服務內容.SelectedItem.ToString(),comboBox_寵物種類.SelectedItem.ToString());
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "INSERT INTO 訂單 (預約日期, 預約時段, 總價, 備註, 服務id, 訂單狀態,user_id) VALUES (@orderDay, @orderTime, @price, @ps, @serviceId, @orderStatus,@user_id)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@serviceId", serviceId); //服務id
                cmd.Parameters.AddWithValue("@orderDay", dtp_預約日期.Value); //預約日期
                cmd.Parameters.AddWithValue("@orderTime", time); //預約時段
                cmd.Parameters.AddWithValue("@ps", txt_備註內容.Text); //備註
                cmd.Parameters.AddWithValue("@price", lbl_顯示總金額.Text); //金額
                cmd.Parameters.AddWithValue("@orderStatus", "預約成功");
                cmd.Parameters.AddWithValue("@user_id", GlobalVar.使用者ID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show($"會員資料新增成功,{rows}筆資料受影響");
            }
            
            int GetServiceId(string serviceName, string servicepet)
            {
                int serviceId = -1; //預設值為-1，代表查詢失敗
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "select * from 產品 where 服務項目 = @p_name and 寵物種類 = @petType;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@p_name", serviceName);
                    cmd.Parameters.AddWithValue("@petType", servicepet);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        serviceId = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                return serviceId;
            }
        }

        private void dtp_預約日期_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtp_預約日期.Value.Date; // 獲取選擇的日期，忽略時間部分
            string formattedDate = selectedDate.ToString("yyyy/MM/dd"); // 將日期轉換為指定格式的字符串

            if (selectedDate >= DateTime.Today)
            {
                所選預約日期 = formattedDate;
            }
            else
            {
                dtp_預約日期.Value = DateTime.Now;
                MessageBox.Show("請重新選擇日期", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_預約時段_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtp_預約日期.Value.Date;
            DateTime currentTime = DateTime.Now;

            if (listBox_預約時段.SelectedItem.ToString() != "")
                所選預約時段 = listBox_預約時段.Text;
            else
                MessageBox.Show("請重新選擇日期", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // 判斷使用者是否選擇當天的日期
            if (selectedDate == currentTime.Date)
            {
                DateTime earliestTime = DateTime.MaxValue;
                foreach (string item in listBox_預約時段.Items)
                {
                    DateTime time = DateTime.Parse(item);
                    if (time < earliestTime)
                    {
                        earliestTime = time;
                    }
                }
                if (currentTime > earliestTime)
                {
                    MessageBox.Show("時段已過，請重新選取時段", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_備註內容_TextChanged(object sender, EventArgs e)
        {
            if (txt_備註內容.Text.Length > 0)
                GlobalVar.備註事項 = txt_備註內容.Text;
        }

        private void 預約系統_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult R = MessageBox.Show("您確定要關閉表單?", "關閉表單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true; //Cance就是取消這個事件l
        }

        private void btn_清除_Click(object sender, EventArgs e)
        {
            comboBox_寵物種類.SelectedIndex = -1;
            comboBox_服務內容.SelectedIndex = -1;
            txt_備註內容.Clear();
            dtp_預約日期.Value = DateTime.Now;
            lbl_顯示總金額.Text = "";
            lbl_選擇服務內容.Text = "";
        }

        private void btn_登出系統_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }

        private void btn_購物車頁面_Click(object sender, EventArgs e)
        {
            Form item = new add_to_cart();
            item.Show();
            this.Hide();
        }

        private void btn_查看訂單_Click(object sender, EventArgs e)
        {
            Form item = new add_to_cart();
            item.Show();
            this.Hide();
        }

        private void btn_會員頁面_Click(object sender, EventArgs e)
        {
            Form item = new Form2();
            item.Show();
            this.Hide();
        }

        private void btn_訂單_Click(object sender, EventArgs e)
        {
            Form item = new order();
            item.Show();
            this.Hide();
        }

        private void btn_回系統_Click(object sender, EventArgs e)
        {
            Form item = new 系統頁面();
            item.Show();
            this.Hide();
        }

        private void btn_員工_Click(object sender, EventArgs e)
        {
            Form item = new 員工資料();
            item.Show();
            this.Hide();
        }
    }
}
