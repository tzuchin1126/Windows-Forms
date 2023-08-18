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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Controls.Primitives;

namespace 期中專案_0420
{
    public partial class order : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        //進階搜尋結果 為甚麼要用int? a:要存id資料 之後用id可以查詢全部資料
        int 總價格 = 0;
        string 所選服務內容 = "";
        List<int> list小型犬服務價格 = new List<int> { 600, 300, 650, 350, 50, 50, 100, 100 };
        List<int> list中型犬服務價格 = new List<int> { 800, 400, 850, 450, 50, 50, 100, 100 };
        List<int> list中大型短毛犬服務價格 = new List<int> { 1000, 500, 1100, 600, 50, 50, 100, 100 };
        List<int> list中大型長毛犬服務價格 = new List<int> { 1200, 600, 1300, 700, 50, 50, 100, 100 };
        List<int> list大型短毛犬服務價格 = new List<int> { 1300, 700, 1400, 800, 100, 100, 150, 150 };
        List<int> list大型長毛犬服務價格 = new List<int> { 1400, 750, 1500, 850, 100, 100, 150, 150 };




        List<int> searchIDs = new List<int>();

        public order()
        {
            InitializeComponent();
        }
        private void order_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mydbDataSet1.訂單' 資料表。您可以視需要進行移動或移除。
            this.訂單TableAdapter.Fill(this.mydbDataSet.訂單);

            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱;
            scsb.IntegratedSecurity = true; //Windows 驗證

            combo資料欄位.Items.Add("服務項目");
            combo資料欄位.Items.Add("寵物種類");
            combo資料欄位.SelectedIndex = 0;

            strDBConnectionString = scsb.ConnectionString;
            產生會員資料列表DGV();
        }

        void 產生會員資料列表DGV()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from 訂單";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true) //HasRows有無資料 = bool
            { 
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv_會員資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void 訂單BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_會員資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ltb_搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lbl_筆數資料_Click(object sender, EventArgs e)
        {

        }

        private void btn_新增資料_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_訂單_Click(object sender, EventArgs e)
        {
            Form item = new order();
            item.Show();
            this.Hide();
        }

        private void btn_會員資料_Click(object sender, EventArgs e)
        {
            Form item = new Form2();
            item.Show();
            this.Hide();
        }

        private void btn_登出系統_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dgv_會員資料列表_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectID = dgv_會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                //string strSQL = "select * from 訂單 o, 產品 p where o.id = @SearchID and p.服務id = @服務id;";
                string strSQL = "SELECT o.id, o.預約時段, o.總價,o.備註,o.訂單狀態,o.user_id, p.服務項目, p.寵物種類 FROM 訂單 o JOIN 產品 p ON o.服務id = p.服務id WHERE o.id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    //dtp_預約日期.value = reader["預約日期"].ToString();
                    comboBox_預約時段.Text = reader["預約時段"].ToString();
                    txt_金額.Text = reader["總價"].ToString();
                    txt_備註內容.Text = reader["備註"].ToString();
                    comboBox_訂單狀態.Text = reader["訂單狀態"].ToString();
                    txt_會員id.Text = reader["user_id"].ToString();
                    comboBox_服務項目.Text = reader["服務項目"].ToString();
                    comboBox_寵物類型.Text = reader["寵物種類"].ToString();
                }
                else
                    MessageBox.Show("沒有此筆資料", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (e.RowIndex >= 0)  // 檢查是否選擇了行（而不是列標題等）
                {
                    dgv_會員資料列表.ClearSelection(); // 取消先前選中的行，以便只選擇單個行
                    dgv_會員資料列表.Rows[e.RowIndex].Selected = true; // 選擇點擊的行
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn_刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from 訂單 where id = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);
                int rows = cmd.ExecuteNonQuery();
                // 檢查是否選擇了行
                if (dgv_會員資料列表.SelectedRows.Count > 0)
                {
                    dgv_會員資料列表.Rows.Remove(dgv_會員資料列表.SelectedRows[0]);
                }
                con.Close();
                MessageBox.Show("資料已刪除", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form item = new 系統頁面();
            item.Show();
            this.Hide();
        }

        private void btn_預約系統_Click(object sender, EventArgs e)
        {
            Form item = new 預約系統();
            item.Show();
            this.Hide();
        }

        private void btn_儲存資料_Click(object sender, EventArgs e)
        {//更新資料

            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (comboBox_寵物類型.Text != "") && (comboBox_服務項目.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update 訂單 set 預約日期=@預約日期, 預約時段=@預約時段, 訂單狀態=@訂單狀態, user_id=@user_id where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@預約日期", dtp_預約日期.Value);
                cmd.Parameters.AddWithValue("@預約時段", comboBox_預約時段.SelectedItem);
                cmd.Parameters.AddWithValue("@訂單狀態", comboBox_訂單狀態.SelectedItem);
                cmd.Parameters.AddWithValue("@user_id", GlobalVar.使用者ID); // replace userId with the actual user ID value
                int rows = cmd.ExecuteNonQuery();

                // 重新查詢資料並重新綁定至 DataGridView
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 訂單", strDBConnectionString);
                da.Fill(dt);
                dgv_會員資料列表.DataSource = dt;

                con.Close();
                MessageBox.Show($"會員資料修改成功,{rows}筆資料受影響");
            }
        }

        private void btn_新增_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (comboBox_寵物類型.Text != "") && (comboBox_服務項目.Text != ""))
            {
                int serviceId = GetServiceId(comboBox_服務項目.SelectedItem.ToString(), comboBox_寵物類型.SelectedItem.ToString());
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                //string strSQL = "INSERT INTO 訂單  (預約日期, 預約時段, 總價, 備註, 訂單狀態, user_id) VALUES (@orderDay, @orderTime, @price, @ps, @orderStatus,@user_id);";
                string strSQL = "INSERT INTO 訂單 (預約日期, 預約時段, 總價, 備註, 服務id,訂單狀態, user_id) VALUES (@orderDay, @orderTime, @price, @ps,@serviceId, @orderStatus, @user_id);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@serviceId", serviceId); //服務id
                cmd.Parameters.AddWithValue("@orderDay", dtp_預約日期.Value);
                cmd.Parameters.AddWithValue("@orderTime", comboBox_預約時段.SelectedItem);
                int intPoints = 0;
                Int32.TryParse(txt_金額.Text, out intPoints);
                cmd.Parameters.AddWithValue("@price", intPoints);
                cmd.Parameters.AddWithValue("@ps", txt_備註內容.Text);
                cmd.Parameters.AddWithValue("@orderStatus", comboBox_訂單狀態.SelectedItem);
                cmd.Parameters.AddWithValue("@user_id", GlobalVar.使用者ID); 
                int rows = cmd.ExecuteNonQuery();

               
                // 重新查詢資料並重新綁定至 DataGridView
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 訂單", strDBConnectionString);
                da.Fill(dt);
                dgv_會員資料列表.DataSource = dt;

                con.Close();
                MessageBox.Show($"會員資料修改成功,{rows}筆資料受影響", "新增資料", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("尚未填寫完整", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt欄位搜尋關鍵字.Text != "")
            {
                listbox搜尋結果.Items.Clear();
                searchIDs.Clear();
                string str欄位名稱 = combo資料欄位.SelectedItem.ToString();
                string sql婚姻狀態查詢語法 = "";

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                //string strSQL = $"select * from 訂單,產品 where {str欄位名稱} like @SearchKeyword {sql婚姻狀態查詢語法};";
                string strSQL = $"select * from 訂單 o join 產品 p on o.服務id = p.服務id where {str欄位名稱} like @SearchKeyword {sql婚姻狀態查詢語法};";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txt欄位搜尋關鍵字.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read() == true)
                {
                    searchIDs.Add((int)reader["服務id"]);
                    DateTime dateValue = Convert.ToDateTime(reader["預約日期"]).Date; // 取得日期部分
                    listbox搜尋結果.Items.Add($"{dateValue.ToString("yyyy/MM/dd")} {reader["服務項目"]} {reader["寵物種類"]}");
                    count++;
                }

                if (count == 0)
                {
                    MessageBox.Show("沒有資料", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
                con.Close();
            }
        }

        private void comboBox_服務項目_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox_寵物類型.Text != "") && comboBox_服務項目.Text != "")
            {
                所選服務內容 = comboBox_服務項目.Text;

                //-------
                if ((comboBox_寵物類型.Text == "小型犬 (5kg以下)") && (comboBox_服務項目.Text == "剪毛服務"))
                {
                    總價格 = list小型犬服務價格[0];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "小型犬 (5kg以下)") && (comboBox_服務項目.Text == "洗澡服務"))
                {
                    總價格 = list小型犬服務價格[1];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "小型犬 (5kg以下)") && (comboBox_服務項目.Text == "剪毛+SPA"))
                {
                    總價格 = list小型犬服務價格[2];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "小型犬 (5kg以下)") && (comboBox_服務項目.Text == "洗澡+SPA"))
                {
                    總價格 = list小型犬服務價格[3];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "小型犬 (5kg以下)") && (comboBox_服務項目.Text == "剪指甲"))
                {
                    總價格 = list小型犬服務價格[4];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "小型犬 (5kg以下)") && (comboBox_服務項目.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list小型犬服務價格[5];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "小型犬 (5kg以下)") && (comboBox_服務項目.Text == "藥浴"))
                {
                    總價格 = list小型犬服務價格[6];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "小型犬 (5kg以下)") && (comboBox_服務項目.Text == "除蚤+除蟲"))
                {
                    總價格 = list小型犬服務價格[7];
                    txt_金額.Text = 總價格.ToString();
                }
                //-------
                if ((comboBox_寵物類型.Text == "中型犬 (5-10kg)") && (comboBox_服務項目.Text == "剪毛服務"))
                {
                    總價格 = list中型犬服務價格[0];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中型犬 (5-10kg)") && (comboBox_服務項目.Text == "洗澡服務"))
                {
                    總價格 = list中型犬服務價格[1];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中型犬 (5-10kg)") && (comboBox_服務項目.Text == "剪毛+SPA"))
                {
                    總價格 = list中型犬服務價格[2];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中型犬 (5-10kg)") && (comboBox_服務項目.Text == "洗澡+SPA"))
                {
                    總價格 = list中型犬服務價格[3];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中型犬 (5-10kg)") && (comboBox_服務項目.Text == "剪指甲"))
                {
                    總價格 = list中型犬服務價格[4];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中型犬 (5-10kg)") && (comboBox_服務項目.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list中型犬服務價格[5];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中型犬 (5-10kg)") && (comboBox_服務項目.Text == "藥浴"))
                {
                    總價格 = list中型犬服務價格[6];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中型犬 (5-10kg)") && (comboBox_服務項目.Text == "除蚤+除蟲"))
                {
                    總價格 = list中型犬服務價格[7];
                    txt_金額.Text = 總價格.ToString();
                }
                //-----
                if ((comboBox_寵物類型.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務項目.Text == "剪毛服務"))
                {
                    總價格 = list中大型短毛犬服務價格[0];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務項目.Text == "洗澡服務"))
                {
                    總價格 = list中大型短毛犬服務價格[1];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務項目.Text == "剪毛+SPA"))
                {
                    總價格 = list中大型短毛犬服務價格[2];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務項目.Text == "洗澡+SPA"))
                {
                    總價格 = list中大型短毛犬服務價格[3];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務項目.Text == "剪指甲"))
                {
                    總價格 = list中大型短毛犬服務價格[4];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務項目.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list中大型短毛犬服務價格[5];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務項目.Text == "藥浴"))
                {
                    總價格 = list中大型短毛犬服務價格[6];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型短毛犬 (11-15kg)") && (comboBox_服務項目.Text == "除蚤+除蟲"))
                {
                    總價格 = list中大型短毛犬服務價格[7];
                    txt_金額.Text = 總價格.ToString();
                }
                //-----
                if ((comboBox_寵物類型.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務項目.Text == "剪毛服務"))
                {
                    總價格 = list中大型長毛犬服務價格[0];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務項目.Text == "洗澡服務"))
                {
                    總價格 = list中大型長毛犬服務價格[1];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務項目.Text == "剪毛+SPA"))
                {
                    總價格 = list中大型長毛犬服務價格[2];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務項目.Text == "洗澡+SPA"))
                {
                    總價格 = list中大型長毛犬服務價格[3];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務項目.Text == "剪指甲"))
                {
                    總價格 = list中大型長毛犬服務價格[4];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務項目.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list中大型長毛犬服務價格[5];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務項目.Text == "藥浴"))
                {
                    總價格 = list中大型長毛犬服務價格[6];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "中大型長毛犬 (11-15kg)") && (comboBox_服務項目.Text == "除蚤+除蟲"))
                {
                    總價格 = list中大型長毛犬服務價格[7];
                    txt_金額.Text = 總價格.ToString();
                }
                //-----
                if ((comboBox_寵物類型.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務項目.Text == "剪毛服務"))
                {
                    總價格 = list大型短毛犬服務價格[0];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務項目.Text == "洗澡服務"))
                {
                    總價格 = list大型短毛犬服務價格[1];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務項目.Text == "剪毛+SPA"))
                {
                    總價格 = list大型短毛犬服務價格[2];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務項目.Text == "洗澡+SPA"))
                {
                    總價格 = list大型短毛犬服務價格[3];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務項目.Text == "剪指甲"))
                {
                    總價格 = list大型短毛犬服務價格[4];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務項目.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list大型短毛犬服務價格[5];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務項目.Text == "藥浴"))
                {
                    總價格 = list大型短毛犬服務價格[6];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型短毛犬 (15-20kg)") && (comboBox_服務項目.Text == "除蚤+除蟲"))
                {
                    總價格 = list大型短毛犬服務價格[7];
                    txt_金額.Text = 總價格.ToString();
                }
                //-----
                if ((comboBox_寵物類型.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務項目.Text == "剪毛服務"))
                {
                    總價格 = list大型長毛犬服務價格[0];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務項目.Text == "洗澡服務"))
                {
                    總價格 = list大型長毛犬服務價格[1];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務項目.Text == "剪毛+SPA"))
                {
                    總價格 = list大型長毛犬服務價格[2];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務項目.Text == "洗澡+SPA"))
                {
                    總價格 = list大型長毛犬服務價格[3];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務項目.Text == "剪指甲"))
                {
                    總價格 = list大型長毛犬服務價格[4];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務項目.Text == "拔耳毛+清耳朵"))
                {
                    總價格 = list大型長毛犬服務價格[5];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務項目.Text == "藥浴"))
                {
                    總價格 = list大型長毛犬服務價格[6];
                    txt_金額.Text = 總價格.ToString();
                }
                else if ((comboBox_寵物類型.Text == "大型長毛犬 (15-20kg)") && (comboBox_服務項目.Text == "除蚤+除蟲"))
                {
                    總價格 = list大型長毛犬服務價格[7];
                    txt_金額.Text = 總價格.ToString();
                }
            }
            else
                MessageBox.Show("請先選擇寵物類型", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dtp_預約日期_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
