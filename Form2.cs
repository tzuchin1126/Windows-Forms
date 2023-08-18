using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace 期中專案_0420
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 會員BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.會員BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet4);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mydbDataSet4.訂單' 資料表。您可以視需要進行移動或移除。
            this.訂單TableAdapter.Fill(this.mydbDataSet4.訂單);
            // TODO: 這行程式碼會將資料載入 'mydbDataSet4.會員' 資料表。您可以視需要進行移動或移除。
            this.會員TableAdapter.Fill(this.mydbDataSet4.會員);
          
            comboBox_會員資料.Items.Add("姓名");
            comboBox_會員資料.Items.Add("電話");
            comboBox_會員資料.Items.Add("寵物名稱");
            comboBox_會員資料.SelectedIndex = 0;
            顯示資料筆數();

        }

        private void btn_第一筆_Click(object sender, EventArgs e)
        {
            
        }

        void 顯示資料筆數()
        {
            int 目前第幾筆 = 會員BindingSource.Position + 1;
            int 總資料筆數 = 會員BindingSource.Count;
            lbl_筆數資料.Text = $"第{目前第幾筆}筆/共{總資料筆數}筆";
        }

        private void listBox_會員資料_SelectedIndexChanged(object sender, EventArgs e)
        {
            顯示資料筆數();
        }

        private void txt_關鍵查詢_TextChanged(object sender, EventArgs e)
        {
            if (txt_關鍵查詢.Text != "")
            {
                string str關鍵字 = txt_關鍵查詢.Text;
                string str欄位名稱 = comboBox_會員資料.SelectedItem.ToString();
                會員BindingSource.Filter = $"{str欄位名稱} like '%{str關鍵字}%'";
                顯示資料筆數();
            }
        }

        private void checkBox_搜尋功能_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_搜尋功能.Checked == true)
            {
                顯示資料筆數();
            }
            else
            {
                會員BindingSource.RemoveFilter();
                txt_關鍵查詢.Text = "";
                MessageBox.Show("搜尋功能已關閉", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                顯示資料筆數();
            }
            
        }

        private void comboBox_搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            顯示資料筆數();
        }

        private void btn_新增資料_Click_1(object sender, EventArgs e)
        {
            會員BindingSource.AddNew();
            dtp_生日.Value = DateTime.Now;
        }

        private void btn_訂單_Click(object sender, EventArgs e)
        {
            Form item = new order();
            item.Show();
            this.Hide();
        }

        private void btn_Signout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Form item = new Form2();
            item.Show();
            this.Hide();
        }

        private void btn_預約_Click(object sender, EventArgs e)
        {
            Form item = new 預約系統();
            item.Show();
            this.Hide();
        }

        private void btn_訂單_Click_1(object sender, EventArgs e)
        {
            Form item = new order();
            item.Show();
            this.Hide();
        }

        private void txt_姓名_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_新增_Click(object sender, EventArgs e)
        {
            Validate();
            會員BindingSource.EndEdit();
            會員TableAdapter.Update(mydbDataSet4.會員);
            顯示資料筆數();
            MessageBox.Show("資料儲存成功", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.None);
            txt_權限.Text = GlobalVar.使用者名稱;
        }

        private void btn_回復資料_Click(object sender, EventArgs e)
        {

        }

        private void btn_刪除_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要刪除此筆資料嗎?", "提示訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                會員BindingSource.EndEdit();
                int 目前索引值 = 會員BindingSource.Position;
                會員BindingSource.RemoveAt(目前索引值);
                會員TableAdapter.Update(mydbDataSet4.會員);
                顯示資料筆數();
                MessageBox.Show("資料已經刪除", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_第一筆資料_Click(object sender, EventArgs e)
        {
            會員BindingSource.MoveFirst();
            顯示資料筆數();
        }

        private void btn_上一筆資料_Click(object sender, EventArgs e)
        {
            會員BindingSource.MovePrevious();
            顯示資料筆數();
        }

        private void btn_下一筆資料_Click(object sender, EventArgs e)
        {
            會員BindingSource.MoveNext();
            顯示資料筆數();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form item = new 系統頁面();
            item.Show();
            this.Hide();
        }

        private void 員工BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.會員DataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet4);

        }

        private void 會員BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.會員BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet4);

        }

        private void 會員BindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.會員BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet4);

        }

        private void btn_回復_Click(object sender, EventArgs e)
        {

        }
    }
}
