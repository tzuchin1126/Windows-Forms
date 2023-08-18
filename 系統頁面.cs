using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專案_0420
{
    public partial class 系統頁面 : Form
    {
        public 系統頁面()
        {
            InitializeComponent();
        }

        private void btn_訂單_Click(object sender, EventArgs e)
        {
            Form item = new order();
            item.Show();
            this.Hide();
        }

        private void btn_預約_Click(object sender, EventArgs e)
        {
            Form item = new 預約系統();
            item.Show();
            this.Hide();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Form item = new Form2();
            item.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form item = new add_to_cart ();
            item.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form item = new Create();
            item.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form item = new 員工資料();
            item.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form item = new Login();
            item.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void 系統頁面_Load(object sender, EventArgs e)
        {
            if (GlobalVar.權限 == 100)//會員
                label7.Text = $"使用者:{GlobalVar.使用者名稱}";

        }
    }
}
