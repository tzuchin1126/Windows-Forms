using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace 期中專案_0420
{
    public partial class add_to_cart : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";


        public add_to_cart()
        {
            InitializeComponent();
        }

        private void add_to_cart_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mydbDataSet1.訂單' 資料表。您可以視需要進行移動或移除。
            this.訂單TableAdapter.Fill(this.mydbDataSet1.訂單);


            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱;
            scsb.IntegratedSecurity = true; //Windows 驗證
            strDBConnectionString = scsb.ConnectionString;

            foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項)
            {
                string 寵物種類 = (string)訂購單品[0];
                string 訂單內容 = (string)訂購單品[1];
                string 預約日期 = (string)訂購單品[2];
                string 預約時段 = (string)訂購單品[3];
                int 總金額 = (int)訂購單品[4];

                string 訂購資訊 = string.Format("寵物類型:{0} 訂單內容:{1} 預約日期{2} 時段:{3} 金額:{4}元", 寵物種類, 訂單內容, 預約日期, 預約時段, 總金額);
                listBox_訂購品項列表.Items.Add(訂購資訊);
            }
            listBox_備註.Items.Add(GlobalVar.備註事項);
        }

        private void add_to_cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要離開此頁面嗎?", "關閉表單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (R == DialogResult.Yes) //確定關閉
                e.Cancel = false; //Cance就是取消這個事件l
            else //否 確定不取消
                e.Cancel = true; //Cance就是取消這個事件l
        }

        private void btn_輸出訂單_Click(object sender, EventArgs e)
        {
            string str路徑 = @"C:\Users\USER\Downloads\訂單";
            Random myRan = new Random();
            int ranNum = myRan.Next(1000, 10000);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + ranNum + "預約單txt";
            string str完整路徑 = str路徑 + @"\" + str檔名;
            
            SaveFileDialog sfd = new SaveFileDialog(); //存檔
            sfd.InitialDirectory = str路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File |*.txt";
            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
                str完整路徑 = sfd.FileName;
            else
                return;
            
            //訂單內容存檔
            List<string> list訂單 = new List<string>();
            list訂單.Add("********************寵物美容預約單********************");
            list訂單.Add("*****************************************************");
            list訂單.Add($"************訂單已送出:{DateTime.Now}************");
            list訂單.Add("*****************************************************");
            list訂單.Add($"********************預約項目:************************");
            foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項)
            {
                string 寵物種類 = (string)訂購單品[0];
                string 訂單內容 = (string)訂購單品[1];
                string 預約日期 = (string)訂購單品[2];
                string 預約時段 = (string)訂購單品[3];
                int 訂單金額 = (int)訂購單品[4];

                string 訂購資訊 = string.Format("寵物類型:{0} 訂單內容:{1} 預約日期{2} 預約時段:{3} 總金額:{4}元", 寵物種類, 訂單內容, 預約日期, 預約時段, 訂單金額);
                list訂單.Add(訂購資訊);
            }
            list訂單.Add("*****************************************************");
            list訂單.Add($"**********************備註事項:**********************");
            list訂單.Add($"**********備註事項:{GlobalVar.備註事項}**************");
            list訂單.Add("*****************************************************");
            list訂單.Add("***********************感謝您的預約*******************");
            System.IO.File.WriteAllLines(str完整路徑, list訂單, Encoding.UTF8);
            MessageBox.Show("訂購單存檔成功");
        }

        private void btn_清除_Click(object sender, EventArgs e)
        {
            //單選
            if (listBox_訂購品項列表.SelectedIndex >= 0)
            {
                int selectIndex = listBox_訂購品項列表.SelectedIndex;
                GlobalVar.list訂購品項.RemoveAt(selectIndex); //全域變數的品名要移除(利用索引值對應)
                listBox_訂購品項列表.Items.RemoveAt(selectIndex); //listbox的品名要移除

                //資料庫刪除:
                int intID = 0;
                Int32.TryParse(GlobalVar.使用者名稱, out intID);
                if (intID > 0)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "delete from 訂單 where id = @DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", intID);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
            else
                MessageBox.Show("請選擇要移除的品項", "關閉表單確認", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (listBox_備註.SelectedIndex >= 0)
            {
                int selectIndex2 = listBox_備註.SelectedIndex;
                listBox_備註.Items.RemoveAt(selectIndex2);
            }
        }

        private void btn_離開頁面_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_返回上一頁_Click(object sender, EventArgs e)
        {
            GlobalVar.is登入認證成功 = true;
            Form item = new 預約系統();
            item.Show();
            this.Hide();
        }
    }
}
