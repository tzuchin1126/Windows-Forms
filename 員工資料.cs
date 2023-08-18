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

namespace 期中專案_0420
{
    public partial class 員工資料 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>(); //進階搜尋結果, 存 ID 資料;

        public 員工資料()
        {
            InitializeComponent();
        }

        private void 員工資料_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mydbDataSet2.員工' 資料表。您可以視需要進行移動或移除。
            this.員工TableAdapter.Fill(this.mydbDataSet2.員工);
            
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱;
            scsb.IntegratedSecurity = true; //Windows 驗證

            strDBConnectionString = scsb.ConnectionString;

            combo資料欄位.Items.Add("e_id");
            combo資料欄位.Items.Add("姓名");
            combo資料欄位.Items.Add("職位");
            combo資料欄位.SelectedIndex = 0;

            產生員工資料列表DGV();
        }
        void 產生員工資料列表DGV()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from 員工";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true) //HasRows有無資料 = bool
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv_員工資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btn_新增資料_Click(object sender, EventArgs e)
        {
            if ((txt_姓名.Text != "") && (txt_電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into 員工 values (@姓名, @身分證, @生日, @電話, @職位, @薪資, @入職日, @任職狀況,@密碼, @權限);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@姓名", txt_姓名.Text);
                cmd.Parameters.AddWithValue("@身分證", txt_身分證.Text);
                cmd.Parameters.AddWithValue("@生日", dtp_生日.Value);
                cmd.Parameters.AddWithValue("@電話", txt_電話.Text);
                cmd.Parameters.AddWithValue("@職位", txt_職位.Text);
                int intPoints = 0;
                Int32.TryParse(txt_薪資.Text, out intPoints);
                cmd.Parameters.AddWithValue("@薪資", intPoints);
                cmd.Parameters.AddWithValue("@入職日", dtp_入職日期.Value);
                cmd.Parameters.AddWithValue("@任職狀況", comboBox_任職狀態.SelectedItem);
                int intPoints1 = 0;
                Int32.TryParse(txt_密碼.Text, out intPoints1);
                cmd.Parameters.AddWithValue("@密碼", intPoints1);
                int intPoints2 = 0;
                Int32.TryParse(txt_權限.Text, out intPoints2);
                cmd.Parameters.AddWithValue("@權限", intPoints2);


                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"員工資料新增成功,{rows}筆資料受影響");

                // 重新查詢資料並重新綁定至 DataGridView
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 員工", strDBConnectionString);
                da.Fill(dt);
                dgv_員工資料列表.DataSource = dt;
            }
            else
            {
                MessageBox.Show("資料尚未填寫完", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_訂單_Click(object sender, EventArgs e)
        {
            Form item = new order();
            item.Show();
            this.Hide();
        }

        private void btn_預約系統_Click(object sender, EventArgs e)
        {
            Form item = new Form2();
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

        private void btn_刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl_ID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from 員工 where e_id = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);
                int rows = cmd.ExecuteNonQuery();

                // 檢查是否選擇了行
                if (dgv_員工資料列表.SelectedRows.Count > 0)
                {
                    // 刪除選中的行
                    dgv_員工資料列表.Rows.Remove(dgv_員工資料列表.SelectedRows[0]);
                }
                con.Close();
                MessageBox.Show("資料已刪除", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_儲存資料_Click(object sender, EventArgs e)
        {//btn_更新資料
            int intID = 0;
            Int32.TryParse(lbl_ID.Text, out intID);

            if ((intID > 0) && (txt_姓名.Text != "") && (txt_電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update 員工 set 姓名 = @姓名, 身分證字號 = @身分證字號, 生日 = @生日, 電話 = @電話, 職位 = @職位, 薪資 = @薪資, 入職日期 = @入職日期, 任職狀態 = @任職狀態, 密碼 = @密碼, 系統權限 = @系統權限 where e_id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@姓名", txt_姓名.Text);
                cmd.Parameters.AddWithValue("@身分證字號", txt_身分證.Text);
                cmd.Parameters.AddWithValue("@生日", dtp_生日.Value);
                cmd.Parameters.AddWithValue("@電話", txt_電話.Text);
                cmd.Parameters.AddWithValue("@職位", txt_職位.Text);
                int intPoints = 0;
                Int32.TryParse(txt_薪資.Text, out intPoints);
                cmd.Parameters.AddWithValue("@薪資", intPoints);
                cmd.Parameters.AddWithValue("@入職日期", dtp_入職日期.Value);
                cmd.Parameters.AddWithValue("@任職狀態", comboBox_任職狀態.Text);
                int intPoints1 = 0;
                Int32.TryParse(txt_密碼.Text, out intPoints1);
                cmd.Parameters.AddWithValue("@密碼", intPoints1);

                int intPoints2 = 0;
                Int32.TryParse(txt_權限.Text, out intPoints2);
                cmd.Parameters.AddWithValue("@系統權限", intPoints2);

                int rows = cmd.ExecuteNonQuery();
                // 重新查詢資料並重新綁定至 DataGridView
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 員工", strDBConnectionString);
                da.Fill(dt);
                dgv_員工資料列表.DataSource = dt;

                con.Close();
                MessageBox.Show($"會員資料修改成功,{rows}筆資料受影響");
            }
        }

        private void btn_新增_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_員工資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectID = dgv_員工資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                //string strSQL = "SELECT * from 員工";
                string strSQL = "SELECT * from 員工 WHERE e_id=@SearchID";


                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lbl_ID.Text = reader["e_id"].ToString();
                    txt_姓名.Text = reader["姓名"].ToString();
                    txt_身分證.Text = reader["身分證字號"].ToString();
                    txt_電話.Text = reader["電話"].ToString();
                    txt_職位.Text = reader["職位"].ToString();
                    txt_薪資.Text = reader["薪資"].ToString();
                    comboBox_任職狀態.Text = reader["任職狀態"].ToString();
                    txt_密碼.Text = reader["密碼"].ToString();
                    txt_權限.Text = reader["系統權限"].ToString();

                }
                else
                    MessageBox.Show("沒有此筆資料", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (e.RowIndex >= 0)  // 檢查是否選擇了行（而不是列標題等）
                {
                    dgv_員工資料列表.ClearSelection(); // 取消先前選中的行，以便只選擇單個行
                    dgv_員工資料列表.Rows[e.RowIndex].Selected = true; // 選擇點擊的行
                    strSelectID = "";  //清空變數
                    selectID = 0;
                    reader.Close();
                    con.Close();
                }
                
            }
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt欄位搜尋關鍵字.Text != "")
            {
                listbox搜尋結果.Items.Clear();
                searchIDs.Clear();
                string str欄位名稱 = combo資料欄位.SelectedItem.ToString();
                string sql = "";

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select * from 員工 where {str欄位名稱} like @SearchKeyword {sql};";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txt欄位搜尋關鍵字.Text}%");

                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read() == true)
                {
                    searchIDs.Add((int)reader["e_id"]);
                    listbox搜尋結果.Items.Add($"{reader["姓名"]} {reader["職位"]} {Convert.ToDateTime(reader["入職日期"]).ToString("yyyy/MM/dd")}");
                    count += 1;
                }

                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
        }

        private void dtp_生日_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form item = new 系統頁面();
            item.Show();
            this.Hide();
        }
    }
}
