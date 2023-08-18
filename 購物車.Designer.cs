namespace 期中專案_0420
{
    partial class add_to_cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_to_cart));
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_返回上一頁 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl_訂購人資訊 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_備註 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_清除 = new System.Windows.Forms.Button();
            this.btn_輸出訂單 = new System.Windows.Forms.Button();
            this.btn_離開頁面 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mydbDataSet1 = new 期中專案_0420.mydbDataSet1();
            this.訂單BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.訂單TableAdapter = new 期中專案_0420.mydbDataSet1TableAdapters.訂單TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.服務idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.預約日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.預約時段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訂單狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("jf open 粉圓 1.1", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(104, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(726, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thank you for your appointment.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.btn_返回上一頁);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 128);
            this.panel2.TabIndex = 2;
            // 
            // btn_返回上一頁
            // 
            this.btn_返回上一頁.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.btn_返回上一頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_返回上一頁.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_返回上一頁.ForeColor = System.Drawing.Color.White;
            this.btn_返回上一頁.Image = ((System.Drawing.Image)(resources.GetObject("btn_返回上一頁.Image")));
            this.btn_返回上一頁.Location = new System.Drawing.Point(857, 37);
            this.btn_返回上一頁.Name = "btn_返回上一頁";
            this.btn_返回上一頁.Size = new System.Drawing.Size(87, 61);
            this.btn_返回上一頁.TabIndex = 67;
            this.btn_返回上一頁.UseVisualStyleBackColor = false;
            this.btn_返回上一頁.Click += new System.EventHandler(this.btn_返回上一頁_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(114)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 93);
            this.label1.TabIndex = 2;
            // 
            // listBox_訂購品項列表
            // 
            this.listBox_訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_訂購品項列表.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.listBox_訂購品項列表.FormattingEnabled = true;
            this.listBox_訂購品項列表.ItemHeight = 25;
            this.listBox_訂購品項列表.Location = new System.Drawing.Point(38, 192);
            this.listBox_訂購品項列表.Name = "listBox_訂購品項列表";
            this.listBox_訂購品項列表.Size = new System.Drawing.Size(894, 179);
            this.listBox_訂購品項列表.TabIndex = 136;
            // 
            // lbl_訂購人資訊
            // 
            this.lbl_訂購人資訊.AutoSize = true;
            this.lbl_訂購人資訊.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_訂購人資訊.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.lbl_訂購人資訊.Location = new System.Drawing.Point(422, 147);
            this.lbl_訂購人資訊.Name = "lbl_訂購人資訊";
            this.lbl_訂購人資訊.Size = new System.Drawing.Size(110, 31);
            this.lbl_訂購人資訊.TabIndex = 141;
            this.lbl_訂購人資訊.Text = "預約資訊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(412, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 142;
            this.label2.Text = "備註事項";
            // 
            // listBox_備註
            // 
            this.listBox_備註.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_備註.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.listBox_備註.FormattingEnabled = true;
            this.listBox_備註.ItemHeight = 25;
            this.listBox_備註.Location = new System.Drawing.Point(94, 459);
            this.listBox_備註.Name = "listBox_備註";
            this.listBox_備註.Size = new System.Drawing.Size(754, 129);
            this.listBox_備註.TabIndex = 143;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btn_清除);
            this.panel1.Controls.Add(this.btn_輸出訂單);
            this.panel1.Controls.Add(this.btn_離開頁面);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 642);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 124);
            this.panel1.TabIndex = 144;
            // 
            // btn_清除
            // 
            this.btn_清除.AutoSize = true;
            this.btn_清除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_清除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_清除.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_清除.ForeColor = System.Drawing.Color.White;
            this.btn_清除.Image = ((System.Drawing.Image)(resources.GetObject("btn_清除.Image")));
            this.btn_清除.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_清除.Location = new System.Drawing.Point(352, 38);
            this.btn_清除.Name = "btn_清除";
            this.btn_清除.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_清除.Size = new System.Drawing.Size(182, 58);
            this.btn_清除.TabIndex = 156;
            this.btn_清除.Text = "刪除";
            this.btn_清除.UseVisualStyleBackColor = false;
            this.btn_清除.Click += new System.EventHandler(this.btn_清除_Click);
            // 
            // btn_輸出訂單
            // 
            this.btn_輸出訂單.AutoSize = true;
            this.btn_輸出訂單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.btn_輸出訂單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_輸出訂單.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_輸出訂單.ForeColor = System.Drawing.Color.White;
            this.btn_輸出訂單.Image = ((System.Drawing.Image)(resources.GetObject("btn_輸出訂單.Image")));
            this.btn_輸出訂單.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_輸出訂單.Location = new System.Drawing.Point(762, 38);
            this.btn_輸出訂單.Name = "btn_輸出訂單";
            this.btn_輸出訂單.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_輸出訂單.Size = new System.Drawing.Size(182, 58);
            this.btn_輸出訂單.TabIndex = 155;
            this.btn_輸出訂單.Text = "輸出訂單";
            this.btn_輸出訂單.UseVisualStyleBackColor = false;
            this.btn_輸出訂單.Click += new System.EventHandler(this.btn_輸出訂單_Click);
            // 
            // btn_離開頁面
            // 
            this.btn_離開頁面.AutoSize = true;
            this.btn_離開頁面.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.btn_離開頁面.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_離開頁面.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_離開頁面.ForeColor = System.Drawing.Color.White;
            this.btn_離開頁面.Image = ((System.Drawing.Image)(resources.GetObject("btn_離開頁面.Image")));
            this.btn_離開頁面.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_離開頁面.Location = new System.Drawing.Point(560, 38);
            this.btn_離開頁面.Name = "btn_離開頁面";
            this.btn_離開頁面.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_離開頁面.Size = new System.Drawing.Size(182, 58);
            this.btn_離開頁面.TabIndex = 154;
            this.btn_離開頁面.Text = "離開頁面";
            this.btn_離開頁面.UseVisualStyleBackColor = false;
            this.btn_離開頁面.Click += new System.EventHandler(this.btn_離開頁面_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(34, 51);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(263, 46);
            this.label32.TabIndex = 147;
            this.label32.Text = "美容服務完後可享2H免費安親\r\n2H後候須收取100/1H安親費用\r\n";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(36, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 23);
            this.label30.TabIndex = 149;
            this.label30.Text = "注意事項 : ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(114)))));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(645, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 453);
            this.label4.TabIndex = 68;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.服務idDataGridViewTextBoxColumn,
            this.預約日期DataGridViewTextBoxColumn,
            this.預約時段DataGridViewTextBoxColumn,
            this.總價DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.訂單狀態DataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.訂單BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(80, 69);
            this.dataGridView1.TabIndex = 145;
            this.dataGridView1.Visible = false;
            // 
            // mydbDataSet1
            // 
            this.mydbDataSet1.DataSetName = "mydbDataSet1";
            this.mydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 訂單BindingSource
            // 
            this.訂單BindingSource.DataMember = "訂單";
            this.訂單BindingSource.DataSource = this.mydbDataSet1;
            // 
            // 訂單TableAdapter
            // 
            this.訂單TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // 服務idDataGridViewTextBoxColumn
            // 
            this.服務idDataGridViewTextBoxColumn.DataPropertyName = "服務id";
            this.服務idDataGridViewTextBoxColumn.HeaderText = "服務id";
            this.服務idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.服務idDataGridViewTextBoxColumn.Name = "服務idDataGridViewTextBoxColumn";
            this.服務idDataGridViewTextBoxColumn.Width = 150;
            // 
            // 預約日期DataGridViewTextBoxColumn
            // 
            this.預約日期DataGridViewTextBoxColumn.DataPropertyName = "預約日期";
            this.預約日期DataGridViewTextBoxColumn.HeaderText = "預約日期";
            this.預約日期DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.預約日期DataGridViewTextBoxColumn.Name = "預約日期DataGridViewTextBoxColumn";
            this.預約日期DataGridViewTextBoxColumn.Width = 150;
            // 
            // 預約時段DataGridViewTextBoxColumn
            // 
            this.預約時段DataGridViewTextBoxColumn.DataPropertyName = "預約時段";
            this.預約時段DataGridViewTextBoxColumn.HeaderText = "預約時段";
            this.預約時段DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.預約時段DataGridViewTextBoxColumn.Name = "預約時段DataGridViewTextBoxColumn";
            this.預約時段DataGridViewTextBoxColumn.Width = 150;
            // 
            // 總價DataGridViewTextBoxColumn
            // 
            this.總價DataGridViewTextBoxColumn.DataPropertyName = "總價";
            this.總價DataGridViewTextBoxColumn.HeaderText = "總價";
            this.總價DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.總價DataGridViewTextBoxColumn.Name = "總價DataGridViewTextBoxColumn";
            this.總價DataGridViewTextBoxColumn.Width = 150;
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            this.備註DataGridViewTextBoxColumn.Width = 150;
            // 
            // 訂單狀態DataGridViewTextBoxColumn
            // 
            this.訂單狀態DataGridViewTextBoxColumn.DataPropertyName = "訂單狀態";
            this.訂單狀態DataGridViewTextBoxColumn.HeaderText = "訂單狀態";
            this.訂單狀態DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.訂單狀態DataGridViewTextBoxColumn.Name = "訂單狀態DataGridViewTextBoxColumn";
            this.訂單狀態DataGridViewTextBoxColumn.Width = 150;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 150;
            // 
            // add_to_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(968, 766);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_備註);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_訂購人資訊);
            this.Controls.Add(this.listBox_訂購品項列表);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Name = "add_to_cart";
            this.Text = "add_to_cart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.add_to_cart_FormClosing);
            this.Load += new System.EventHandler(this.add_to_cart_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_訂購品項列表;
        private System.Windows.Forms.Label lbl_訂購人資訊;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_備註;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_返回上一頁;
        private System.Windows.Forms.Button btn_清除;
        private System.Windows.Forms.Button btn_輸出訂單;
        private System.Windows.Forms.Button btn_離開頁面;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mydbDataSet1 mydbDataSet1;
        private System.Windows.Forms.BindingSource 訂單BindingSource;
        private mydbDataSet1TableAdapters.訂單TableAdapter 訂單TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 服務idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 預約日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 預約時段DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂單狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
    }
}