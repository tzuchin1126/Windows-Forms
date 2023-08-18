namespace 期中專案_0420
{
    partial class order
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            this.dgv_會員資料列表 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.服務idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.預約日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.預約時段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訂單狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fK訂單產品BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.產品BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new 期中專案_0420.mydbDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_刪除資料 = new System.Windows.Forms.Button();
            this.btn_更新 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.產品TableAdapter = new 期中專案_0420.mydbDataSetTableAdapters.產品TableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_登出系統 = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl服務項目 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.combo資料欄位 = new System.Windows.Forms.ComboBox();
            this.txt欄位搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.訂單TableAdapter = new 期中專案_0420.mydbDataSetTableAdapters.訂單TableAdapter();
            this.tableAdapterManager = new 期中專案_0420.mydbDataSetTableAdapters.TableAdapterManager();
            this.fK訂單產品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.產品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.訂單BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_新增 = new System.Windows.Forms.Button();
            this.訂單BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_金額 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_預約日期 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_預約時段 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_訂單狀態 = new System.Windows.Forms.ComboBox();
            this.txt_會員id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listbox搜尋結果 = new System.Windows.Forms.ListBox();
            this.comboBox_服務項目 = new System.Windows.Forms.ComboBox();
            this.comboBox_寵物類型 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_備註內容 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_會員資料列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fK訂單產品BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.產品BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fK訂單產品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.產品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_會員資料列表
            // 
            this.dgv_會員資料列表.AllowUserToResizeColumns = false;
            this.dgv_會員資料列表.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_會員資料列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_會員資料列表.AutoGenerateColumns = false;
            this.dgv_會員資料列表.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_會員資料列表.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_會員資料列表.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_會員資料列表.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_會員資料列表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_會員資料列表.ColumnHeadersHeight = 30;
            this.dgv_會員資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_會員資料列表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.服務idDataGridViewTextBoxColumn,
            this.預約日期DataGridViewTextBoxColumn,
            this.預約時段DataGridViewTextBoxColumn,
            this.總價DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.訂單狀態DataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn});
            this.dgv_會員資料列表.DataSource = this.fK訂單產品BindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(88)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_會員資料列表.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_會員資料列表.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_會員資料列表.EnableHeadersVisualStyles = false;
            this.dgv_會員資料列表.Location = new System.Drawing.Point(0, 360);
            this.dgv_會員資料列表.Name = "dgv_會員資料列表";
            this.dgv_會員資料列表.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(88)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_會員資料列表.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_會員資料列表.RowHeadersVisible = false;
            this.dgv_會員資料列表.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(43)))));
            this.dgv_會員資料列表.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_會員資料列表.RowTemplate.Height = 31;
            this.dgv_會員資料列表.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_會員資料列表.Size = new System.Drawing.Size(1373, 305);
            this.dgv_會員資料列表.TabIndex = 1;
            this.dgv_會員資料列表.UseWaitCursor = true;
            this.dgv_會員資料列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_會員資料列表_CellClick_1);
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
            this.預約日期DataGridViewTextBoxColumn.Width = 180;
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
            this.備註DataGridViewTextBoxColumn.Width = 250;
            // 
            // 訂單狀態DataGridViewTextBoxColumn
            // 
            this.訂單狀態DataGridViewTextBoxColumn.DataPropertyName = "訂單狀態";
            this.訂單狀態DataGridViewTextBoxColumn.HeaderText = "訂單狀態";
            this.訂單狀態DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.訂單狀態DataGridViewTextBoxColumn.Name = "訂單狀態DataGridViewTextBoxColumn";
            this.訂單狀態DataGridViewTextBoxColumn.Width = 200;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 150;
            // 
            // fK訂單產品BindingSource1
            // 
            this.fK訂單產品BindingSource1.DataMember = "FK_訂單_產品";
            this.fK訂單產品BindingSource1.DataSource = this.產品BindingSource1;
            // 
            // 產品BindingSource1
            // 
            this.產品BindingSource1.DataMember = "產品";
            this.產品BindingSource1.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.btn_刪除資料);
            this.panel4.Controls.Add(this.btn_更新);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 665);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1373, 57);
            this.panel4.TabIndex = 5;
            // 
            // btn_刪除資料
            // 
            this.btn_刪除資料.BackColor = System.Drawing.Color.Brown;
            this.btn_刪除資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_刪除資料.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_刪除資料.ForeColor = System.Drawing.Color.Transparent;
            this.btn_刪除資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_刪除資料.Location = new System.Drawing.Point(1156, 10);
            this.btn_刪除資料.Name = "btn_刪除資料";
            this.btn_刪除資料.Size = new System.Drawing.Size(150, 40);
            this.btn_刪除資料.TabIndex = 123;
            this.btn_刪除資料.Text = "刪除";
            this.btn_刪除資料.UseVisualStyleBackColor = false;
            this.btn_刪除資料.Click += new System.EventHandler(this.btn_刪除資料_Click);
            // 
            // btn_更新
            // 
            this.btn_更新.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(117)))));
            this.btn_更新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_更新.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_更新.ForeColor = System.Drawing.Color.White;
            this.btn_更新.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_更新.Location = new System.Drawing.Point(976, 10);
            this.btn_更新.Name = "btn_更新";
            this.btn_更新.Size = new System.Drawing.Size(150, 40);
            this.btn_更新.TabIndex = 125;
            this.btn_更新.Text = "更新";
            this.btn_更新.UseVisualStyleBackColor = false;
            this.btn_更新.Click += new System.EventHandler(this.btn_儲存資料_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(15, 130);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(107, 34);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "00000";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 產品TableAdapter
            // 
            this.產品TableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label5.Location = new System.Drawing.Point(311, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 104;
            this.label5.Text = "預約時段";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label4.Location = new System.Drawing.Point(311, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "金額";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 102;
            this.label3.Text = "寵物類型";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(16, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "服務項目";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 100;
            this.label1.Text = "訂單 ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(214, -11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 100);
            this.label6.TabIndex = 114;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_登出系統
            // 
            this.btn_登出系統.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.btn_登出系統.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_登出系統.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_登出系統.ForeColor = System.Drawing.Color.White;
            this.btn_登出系統.Image = ((System.Drawing.Image)(resources.GetObject("btn_登出系統.Image")));
            this.btn_登出系統.Location = new System.Drawing.Point(1291, 15);
            this.btn_登出系統.Name = "btn_登出系統";
            this.btn_登出系統.Size = new System.Drawing.Size(60, 50);
            this.btn_登出系統.TabIndex = 96;
            this.btn_登出系統.UseVisualStyleBackColor = false;
            this.btn_登出系統.Click += new System.EventHandler(this.btn_登出系統_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(14, 7);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(60, 60);
            this.btn_home.TabIndex = 92;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(104, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 36);
            this.label13.TabIndex = 101;
            this.label13.Text = "訂單管理系統";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl服務項目
            // 
            this.lbl服務項目.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.lbl服務項目.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl服務項目.ForeColor = System.Drawing.Color.White;
            this.lbl服務項目.Location = new System.Drawing.Point(427, 144);
            this.lbl服務項目.Name = "lbl服務項目";
            this.lbl服務項目.Size = new System.Drawing.Size(164, 26);
            this.lbl服務項目.TabIndex = 41;
            this.lbl服務項目.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btn搜尋);
            this.panel1.Controls.Add(this.combo資料欄位);
            this.panel1.Controls.Add(this.txt欄位搜尋關鍵字);
            this.panel1.Controls.Add(this.lbl服務項目);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_登出系統);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 75);
            this.panel1.TabIndex = 2;
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(117)))));
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.White;
            this.btn搜尋.Image = ((System.Drawing.Image)(resources.GetObject("btn搜尋.Image")));
            this.btn搜尋.Location = new System.Drawing.Point(1117, 21);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(108, 39);
            this.btn搜尋.TabIndex = 157;
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // combo資料欄位
            // 
            this.combo資料欄位.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo資料欄位.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo資料欄位.FormattingEnabled = true;
            this.combo資料欄位.Location = new System.Drawing.Point(940, 22);
            this.combo資料欄位.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo資料欄位.Name = "combo資料欄位";
            this.combo資料欄位.Size = new System.Drawing.Size(171, 36);
            this.combo資料欄位.TabIndex = 156;
            // 
            // txt欄位搜尋關鍵字
            // 
            this.txt欄位搜尋關鍵字.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt欄位搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt欄位搜尋關鍵字.Location = new System.Drawing.Point(712, 21);
            this.txt欄位搜尋關鍵字.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt欄位搜尋關鍵字.Name = "txt欄位搜尋關鍵字";
            this.txt欄位搜尋關鍵字.Size = new System.Drawing.Size(222, 37);
            this.txt欄位搜尋關鍵字.TabIndex = 155;
            // 
            // 訂單TableAdapter
            // 
            this.訂單TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 期中專案_0420.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.會員TableAdapter = null;
            this.tableAdapterManager.產品TableAdapter = null;
            this.tableAdapterManager.訂單TableAdapter = this.訂單TableAdapter;
            // 
            // fK訂單產品BindingSource
            // 
            this.fK訂單產品BindingSource.DataSource = this.產品BindingSource;
            // 
            // 產品BindingSource
            // 
            this.產品BindingSource.DataMember = "產品";
            // 
            // 訂單BindingSource
            // 
            this.訂單BindingSource.DataMember = "訂單";
            // 
            // btn_新增
            // 
            this.btn_新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_新增.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_新增.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_新增.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_新增.Image = ((System.Drawing.Image)(resources.GetObject("btn_新增.Image")));
            this.btn_新增.Location = new System.Drawing.Point(1308, 83);
            this.btn_新增.Name = "btn_新增";
            this.btn_新增.Size = new System.Drawing.Size(55, 43);
            this.btn_新增.TabIndex = 127;
            this.btn_新增.UseVisualStyleBackColor = false;
            this.btn_新增.UseWaitCursor = true;
            this.btn_新增.Click += new System.EventHandler(this.btn_新增_Click);
            // 
            // 訂單BindingSource1
            // 
            this.訂單BindingSource1.DataMember = "訂單";
            this.訂單BindingSource1.DataSource = this.mydbDataSet;
            // 
            // txt_金額
            // 
            this.txt_金額.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.txt_金額.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_金額.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_金額.ForeColor = System.Drawing.Color.White;
            this.txt_金額.Location = new System.Drawing.Point(305, 307);
            this.txt_金額.Name = "txt_金額";
            this.txt_金額.Size = new System.Drawing.Size(260, 34);
            this.txt_金額.TabIndex = 143;
            this.txt_金額.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(310, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 144;
            this.label7.Text = "預約日期";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_預約日期
            // 
            this.dtp_預約日期.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_預約日期.Location = new System.Drawing.Point(305, 130);
            this.dtp_預約日期.Name = "dtp_預約日期";
            this.dtp_預約日期.Size = new System.Drawing.Size(260, 34);
            this.dtp_預約日期.TabIndex = 145;
            this.dtp_預約日期.ValueChanged += new System.EventHandler(this.dtp_預約日期_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label8.Location = new System.Drawing.Point(603, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 146;
            this.label8.Text = "備註";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_預約時段
            // 
            this.comboBox_預約時段.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.comboBox_預約時段.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_預約時段.ForeColor = System.Drawing.Color.White;
            this.comboBox_預約時段.FormattingEnabled = true;
            this.comboBox_預約時段.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.comboBox_預約時段.Location = new System.Drawing.Point(305, 216);
            this.comboBox_預約時段.Name = "comboBox_預約時段";
            this.comboBox_預約時段.Size = new System.Drawing.Size(260, 33);
            this.comboBox_預約時段.TabIndex = 148;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label9.Location = new System.Drawing.Point(603, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 149;
            this.label9.Text = "訂單狀態";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_訂單狀態
            // 
            this.comboBox_訂單狀態.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.comboBox_訂單狀態.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_訂單狀態.ForeColor = System.Drawing.Color.White;
            this.comboBox_訂單狀態.FormattingEnabled = true;
            this.comboBox_訂單狀態.Items.AddRange(new object[] {
            "成功預約",
            "取消預約",
            "來電預約",
            "來店預約",
            "改日期(已更新更改日期)",
            "改日期(尚未確認日期)",
            "待確認"});
            this.comboBox_訂單狀態.Location = new System.Drawing.Point(604, 308);
            this.comboBox_訂單狀態.Name = "comboBox_訂單狀態";
            this.comboBox_訂單狀態.Size = new System.Drawing.Size(262, 33);
            this.comboBox_訂單狀態.TabIndex = 150;
            // 
            // txt_會員id
            // 
            this.txt_會員id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.txt_會員id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_會員id.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_會員id.ForeColor = System.Drawing.Color.White;
            this.txt_會員id.Location = new System.Drawing.Point(159, 130);
            this.txt_會員id.Name = "txt_會員id";
            this.txt_會員id.Size = new System.Drawing.Size(107, 34);
            this.txt_會員id.TabIndex = 152;
            this.txt_會員id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_會員id.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label10.Location = new System.Drawing.Point(155, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 151;
            this.label10.Text = "會員ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listbox搜尋結果
            // 
            this.listbox搜尋結果.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listbox搜尋結果.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox搜尋結果.FormattingEnabled = true;
            this.listbox搜尋結果.ItemHeight = 23;
            this.listbox搜尋結果.Location = new System.Drawing.Point(903, 144);
            this.listbox搜尋結果.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbox搜尋結果.Name = "listbox搜尋結果";
            this.listbox搜尋結果.Size = new System.Drawing.Size(422, 186);
            this.listbox搜尋結果.TabIndex = 158;
            // 
            // comboBox_服務項目
            // 
            this.comboBox_服務項目.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.comboBox_服務項目.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_服務項目.ForeColor = System.Drawing.Color.White;
            this.comboBox_服務項目.FormattingEnabled = true;
            this.comboBox_服務項目.Items.AddRange(new object[] {
            "剪毛服務",
            "洗澡服務",
            "剪毛+SPA",
            "洗澡+SPA",
            "剪指甲",
            "拔耳毛+清耳朵",
            "藥浴",
            "除蚤+除蟲"});
            this.comboBox_服務項目.Location = new System.Drawing.Point(15, 308);
            this.comboBox_服務項目.Name = "comboBox_服務項目";
            this.comboBox_服務項目.Size = new System.Drawing.Size(260, 33);
            this.comboBox_服務項目.TabIndex = 159;
            this.comboBox_服務項目.SelectedIndexChanged += new System.EventHandler(this.comboBox_服務項目_SelectedIndexChanged);
            // 
            // comboBox_寵物類型
            // 
            this.comboBox_寵物類型.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.comboBox_寵物類型.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_寵物類型.ForeColor = System.Drawing.Color.White;
            this.comboBox_寵物類型.FormattingEnabled = true;
            this.comboBox_寵物類型.Items.AddRange(new object[] {
            "小型犬 (5kg以下)",
            "中型犬 (5-10kg)",
            "中大型短毛犬 (11-15kg)",
            "中大型長毛犬 (11-15kg)",
            "大型短毛犬 (15-20kg)",
            "大型長毛犬 (15-20kg)"});
            this.comboBox_寵物類型.Location = new System.Drawing.Point(15, 216);
            this.comboBox_寵物類型.Name = "comboBox_寵物類型";
            this.comboBox_寵物類型.Size = new System.Drawing.Size(260, 33);
            this.comboBox_寵物類型.TabIndex = 160;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label11.Location = new System.Drawing.Point(898, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 28);
            this.label11.TabIndex = 161;
            this.label11.Text = "搜尋結果";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_備註內容
            // 
            this.txt_備註內容.AllowDrop = true;
            this.txt_備註內容.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txt_備註內容.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.txt_備註內容.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_備註內容.ForeColor = System.Drawing.Color.White;
            this.txt_備註內容.Location = new System.Drawing.Point(597, 130);
            this.txt_備註內容.Multiline = true;
            this.txt_備註內容.Name = "txt_備註內容";
            this.txt_備註內容.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_備註內容.Size = new System.Drawing.Size(262, 119);
            this.txt_備註內容.TabIndex = 164;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1373, 722);
            this.Controls.Add(this.txt_備註內容);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_寵物類型);
            this.Controls.Add(this.comboBox_服務項目);
            this.Controls.Add(this.listbox搜尋結果);
            this.Controls.Add(this.txt_會員id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_訂單狀態);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_預約時段);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_預約日期);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_金額);
            this.Controls.Add(this.btn_新增);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_會員資料列表);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "order";
            this.Text = "訂單管理系統";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_會員資料列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fK訂單產品BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.產品BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fK訂單產品BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.產品BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_刪除資料;
        private System.Windows.Forms.Button btn_更新;
        private System.Windows.Forms.DataGridView dgv_會員資料列表;
        private System.Windows.Forms.Label lblID;
        private mydbDataSetTableAdapters.產品TableAdapter 產品TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_登出系統;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl服務項目;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource fK訂單產品BindingSource;
        private System.Windows.Forms.BindingSource 產品BindingSource;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource 訂單BindingSource;
        private mydbDataSetTableAdapters.訂單TableAdapter 訂單TableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_新增;
        private System.Windows.Forms.BindingSource fK訂單產品BindingSource1;
        private System.Windows.Forms.BindingSource 產品BindingSource1;
        private System.Windows.Forms.BindingSource 訂單BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 服務idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 預約日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 預約時段DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂單狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_金額;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_預約日期;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_預約時段;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_訂單狀態;
        private System.Windows.Forms.TextBox txt_會員id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo資料欄位;
        private System.Windows.Forms.TextBox txt欄位搜尋關鍵字;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ListBox listbox搜尋結果;
        private System.Windows.Forms.ComboBox comboBox_服務項目;
        private System.Windows.Forms.ComboBox comboBox_寵物類型;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_備註內容;
    }
}

