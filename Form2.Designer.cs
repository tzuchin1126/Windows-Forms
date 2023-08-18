namespace 期中專案_0420
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Signout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_會員資料 = new System.Windows.Forms.ComboBox();
            this.checkBox_搜尋功能 = new System.Windows.Forms.CheckBox();
            this.txt_關鍵查詢 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_筆數資料 = new System.Windows.Forms.Label();
            this.btn_新增資料 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_下一筆資料 = new System.Windows.Forms.Button();
            this.btn_上一筆資料 = new System.Windows.Forms.Button();
            this.btn_新增 = new System.Windows.Forms.Button();
            this.btn_刪除 = new System.Windows.Forms.Button();
            this.btn_第一筆資料 = new System.Windows.Forms.Button();
            this.comboBox_搜尋結果 = new System.Windows.Forms.ComboBox();
            this.listBox_會員資料 = new System.Windows.Forms.ListBox();
            this.txt_權限 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_生日 = new System.Windows.Forms.DateTimePicker();
            this.txt_密碼 = new System.Windows.Forms.TextBox();
            this.txt_寵物名 = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_電話 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_姓名 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl服務項目 = new System.Windows.Forms.Label();
            this.mydbDataSet4 = new 期中專案_0420.mydbDataSet4();
            this.會員BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.會員TableAdapter = new 期中專案_0420.mydbDataSet4TableAdapters.會員TableAdapter();
            this.tableAdapterManager = new 期中專案_0420.mydbDataSet4TableAdapters.TableAdapterManager();
            this.會員BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.會員BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.會員DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fK訂單員工BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.訂單TableAdapter = new 期中專案_0420.mydbDataSet4TableAdapters.訂單TableAdapter();
            this.combo寵物種類 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.會員BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.會員BindingNavigator)).BeginInit();
            this.會員BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.會員DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fK訂單員工BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.會員DataGridView);
            this.panel1.Controls.Add(this.btn_Signout);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.comboBox_會員資料);
            this.panel1.Controls.Add(this.checkBox_搜尋功能);
            this.panel1.Controls.Add(this.txt_關鍵查詢);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 74);
            this.panel1.TabIndex = 3;
            // 
            // btn_Signout
            // 
            this.btn_Signout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.btn_Signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signout.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Signout.ForeColor = System.Drawing.Color.White;
            this.btn_Signout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Signout.Image")));
            this.btn_Signout.Location = new System.Drawing.Point(1237, 12);
            this.btn_Signout.Name = "btn_Signout";
            this.btn_Signout.Size = new System.Drawing.Size(50, 50);
            this.btn_Signout.TabIndex = 105;
            this.btn_Signout.UseVisualStyleBackColor = false;
            this.btn_Signout.Click += new System.EventHandler(this.btn_Signout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(14, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 102;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(110, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 36);
            this.label13.TabIndex = 101;
            this.label13.Text = "會員管理系統";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_會員資料
            // 
            this.comboBox_會員資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_會員資料.FormattingEnabled = true;
            this.comboBox_會員資料.Location = new System.Drawing.Point(1040, 16);
            this.comboBox_會員資料.Name = "comboBox_會員資料";
            this.comboBox_會員資料.Size = new System.Drawing.Size(162, 39);
            this.comboBox_會員資料.TabIndex = 0;
            this.comboBox_會員資料.UseWaitCursor = true;
            // 
            // checkBox_搜尋功能
            // 
            this.checkBox_搜尋功能.AutoSize = true;
            this.checkBox_搜尋功能.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_搜尋功能.ForeColor = System.Drawing.Color.White;
            this.checkBox_搜尋功能.Location = new System.Drawing.Point(635, 21);
            this.checkBox_搜尋功能.Name = "checkBox_搜尋功能";
            this.checkBox_搜尋功能.Size = new System.Drawing.Size(126, 32);
            this.checkBox_搜尋功能.TabIndex = 128;
            this.checkBox_搜尋功能.Text = "搜尋功能";
            this.checkBox_搜尋功能.UseVisualStyleBackColor = true;
            this.checkBox_搜尋功能.UseWaitCursor = true;
            this.checkBox_搜尋功能.CheckedChanged += new System.EventHandler(this.checkBox_搜尋功能_CheckedChanged);
            // 
            // txt_關鍵查詢
            // 
            this.txt_關鍵查詢.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_關鍵查詢.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_關鍵查詢.Location = new System.Drawing.Point(778, 18);
            this.txt_關鍵查詢.Name = "txt_關鍵查詢";
            this.txt_關鍵查詢.Size = new System.Drawing.Size(236, 37);
            this.txt_關鍵查詢.TabIndex = 100;
            this.txt_關鍵查詢.UseWaitCursor = true;
            this.txt_關鍵查詢.TextChanged += new System.EventHandler(this.txt_關鍵查詢_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label5.Location = new System.Drawing.Point(1036, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 102;
            this.label5.Text = "資料:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseWaitCursor = true;
            // 
            // lbl_筆數資料
            // 
            this.lbl_筆數資料.AutoSize = true;
            this.lbl_筆數資料.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_筆數資料.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.lbl_筆數資料.Location = new System.Drawing.Point(1090, 28);
            this.lbl_筆數資料.Name = "lbl_筆數資料";
            this.lbl_筆數資料.Size = new System.Drawing.Size(112, 23);
            this.lbl_筆數資料.TabIndex = 99;
            this.lbl_筆數資料.Text = "第0筆/共0筆";
            this.lbl_筆數資料.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_筆數資料.UseWaitCursor = true;
            // 
            // btn_新增資料
            // 
            this.btn_新增資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_新增資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_新增資料.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_新增資料.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_新增資料.Image = ((System.Drawing.Image)(resources.GetObject("btn_新增資料.Image")));
            this.btn_新增資料.Location = new System.Drawing.Point(1210, 6);
            this.btn_新增資料.Name = "btn_新增資料";
            this.btn_新增資料.Size = new System.Drawing.Size(76, 66);
            this.btn_新增資料.TabIndex = 126;
            this.btn_新增資料.UseVisualStyleBackColor = false;
            this.btn_新增資料.UseWaitCursor = true;
            this.btn_新增資料.Click += new System.EventHandler(this.btn_新增資料_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.btn_下一筆資料);
            this.panel4.Controls.Add(this.btn_上一筆資料);
            this.panel4.Controls.Add(this.btn_新增);
            this.panel4.Controls.Add(this.btn_刪除);
            this.panel4.Controls.Add(this.btn_第一筆資料);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 667);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1310, 74);
            this.panel4.TabIndex = 6;
            // 
            // btn_下一筆資料
            // 
            this.btn_下一筆資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(117)))));
            this.btn_下一筆資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_下一筆資料.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_下一筆資料.ForeColor = System.Drawing.Color.White;
            this.btn_下一筆資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_下一筆資料.Location = new System.Drawing.Point(789, 21);
            this.btn_下一筆資料.Name = "btn_下一筆資料";
            this.btn_下一筆資料.Size = new System.Drawing.Size(150, 40);
            this.btn_下一筆資料.TabIndex = 131;
            this.btn_下一筆資料.Text = "下一筆";
            this.btn_下一筆資料.UseVisualStyleBackColor = false;
            this.btn_下一筆資料.Click += new System.EventHandler(this.btn_下一筆資料_Click);
            // 
            // btn_上一筆資料
            // 
            this.btn_上一筆資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(117)))));
            this.btn_上一筆資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_上一筆資料.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_上一筆資料.ForeColor = System.Drawing.Color.White;
            this.btn_上一筆資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_上一筆資料.Location = new System.Drawing.Point(622, 21);
            this.btn_上一筆資料.Name = "btn_上一筆資料";
            this.btn_上一筆資料.Size = new System.Drawing.Size(150, 40);
            this.btn_上一筆資料.TabIndex = 132;
            this.btn_上一筆資料.Text = "上一筆";
            this.btn_上一筆資料.UseVisualStyleBackColor = false;
            this.btn_上一筆資料.Click += new System.EventHandler(this.btn_上一筆資料_Click);
            // 
            // btn_新增
            // 
            this.btn_新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(117)))));
            this.btn_新增.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_新增.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_新增.ForeColor = System.Drawing.Color.White;
            this.btn_新增.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_新增.Location = new System.Drawing.Point(956, 21);
            this.btn_新增.Name = "btn_新增";
            this.btn_新增.Size = new System.Drawing.Size(150, 40);
            this.btn_新增.TabIndex = 128;
            this.btn_新增.Text = "儲存";
            this.btn_新增.UseVisualStyleBackColor = false;
            this.btn_新增.Click += new System.EventHandler(this.btn_新增_Click);
            // 
            // btn_刪除
            // 
            this.btn_刪除.BackColor = System.Drawing.Color.Brown;
            this.btn_刪除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_刪除.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_刪除.ForeColor = System.Drawing.Color.Transparent;
            this.btn_刪除.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_刪除.Location = new System.Drawing.Point(1126, 21);
            this.btn_刪除.Name = "btn_刪除";
            this.btn_刪除.Size = new System.Drawing.Size(150, 40);
            this.btn_刪除.TabIndex = 127;
            this.btn_刪除.Text = "刪除";
            this.btn_刪除.UseVisualStyleBackColor = false;
            this.btn_刪除.Click += new System.EventHandler(this.btn_刪除_Click);
            // 
            // btn_第一筆資料
            // 
            this.btn_第一筆資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(117)))));
            this.btn_第一筆資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_第一筆資料.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_第一筆資料.ForeColor = System.Drawing.Color.White;
            this.btn_第一筆資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_第一筆資料.Location = new System.Drawing.Point(-153, 20);
            this.btn_第一筆資料.Name = "btn_第一筆資料";
            this.btn_第一筆資料.Size = new System.Drawing.Size(150, 40);
            this.btn_第一筆資料.TabIndex = 130;
            this.btn_第一筆資料.Text = "第一筆";
            this.btn_第一筆資料.UseVisualStyleBackColor = false;
            this.btn_第一筆資料.Click += new System.EventHandler(this.btn_第一筆資料_Click);
            // 
            // comboBox_搜尋結果
            // 
            this.comboBox_搜尋結果.BackColor = System.Drawing.Color.White;
            this.comboBox_搜尋結果.DataSource = this.會員BindingSource;
            this.comboBox_搜尋結果.DisplayMember = "電話";
            this.comboBox_搜尋結果.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_搜尋結果.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_搜尋結果.FormattingEnabled = true;
            this.comboBox_搜尋結果.Location = new System.Drawing.Point(14, 370);
            this.comboBox_搜尋結果.Name = "comboBox_搜尋結果";
            this.comboBox_搜尋結果.Size = new System.Drawing.Size(324, 39);
            this.comboBox_搜尋結果.TabIndex = 129;
            this.comboBox_搜尋結果.UseWaitCursor = true;
            this.comboBox_搜尋結果.SelectedIndexChanged += new System.EventHandler(this.comboBox_搜尋結果_SelectedIndexChanged);
            // 
            // listBox_會員資料
            // 
            this.listBox_會員資料.BackColor = System.Drawing.Color.White;
            this.listBox_會員資料.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_會員資料.DataSource = this.會員BindingSource;
            this.listBox_會員資料.DisplayMember = "姓名";
            this.listBox_會員資料.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_會員資料.FormattingEnabled = true;
            this.listBox_會員資料.ItemHeight = 25;
            this.listBox_會員資料.Location = new System.Drawing.Point(10, 423);
            this.listBox_會員資料.Name = "listBox_會員資料";
            this.listBox_會員資料.Size = new System.Drawing.Size(1276, 150);
            this.listBox_會員資料.TabIndex = 127;
            this.listBox_會員資料.UseWaitCursor = true;
            this.listBox_會員資料.SelectedIndexChanged += new System.EventHandler(this.listBox_會員資料_SelectedIndexChanged);
            // 
            // txt_權限
            // 
            this.txt_權限.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.txt_權限.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_權限.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.會員BindingSource, "權限", true));
            this.txt_權限.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_權限.ForeColor = System.Drawing.Color.White;
            this.txt_權限.Location = new System.Drawing.Point(796, 284);
            this.txt_權限.Name = "txt_權限";
            this.txt_權限.Size = new System.Drawing.Size(282, 37);
            this.txt_權限.TabIndex = 120;
            this.txt_權限.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_權限.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label6.Location = new System.Drawing.Point(790, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 28);
            this.label6.TabIndex = 119;
            this.label6.Text = "權限";
            this.label6.UseWaitCursor = true;
            // 
            // dtp_生日
            // 
            this.dtp_生日.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.會員BindingSource, "生日", true));
            this.dtp_生日.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_生日.Location = new System.Drawing.Point(434, 68);
            this.dtp_生日.Name = "dtp_生日";
            this.dtp_生日.Size = new System.Drawing.Size(280, 37);
            this.dtp_生日.TabIndex = 116;
            this.dtp_生日.UseWaitCursor = true;
            // 
            // txt_密碼
            // 
            this.txt_密碼.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.txt_密碼.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_密碼.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.會員BindingSource, "密碼", true));
            this.txt_密碼.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_密碼.ForeColor = System.Drawing.Color.White;
            this.txt_密碼.Location = new System.Drawing.Point(796, 178);
            this.txt_密碼.Name = "txt_密碼";
            this.txt_密碼.Size = new System.Drawing.Size(282, 37);
            this.txt_密碼.TabIndex = 117;
            this.txt_密碼.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_密碼.UseWaitCursor = true;
            // 
            // txt_寵物名
            // 
            this.txt_寵物名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.txt_寵物名.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_寵物名.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.會員BindingSource, "寵物名稱", true));
            this.txt_寵物名.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_寵物名.ForeColor = System.Drawing.Color.White;
            this.txt_寵物名.Location = new System.Drawing.Point(428, 174);
            this.txt_寵物名.Name = "txt_寵物名";
            this.txt_寵物名.Size = new System.Drawing.Size(280, 37);
            this.txt_寵物名.TabIndex = 115;
            this.txt_寵物名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_寵物名.UseWaitCursor = true;
            // 
            // lbl_ID
            // 
            this.lbl_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.lbl_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.會員BindingSource, "id", true));
            this.lbl_ID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(86, 68);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(280, 38);
            this.lbl_ID.TabIndex = 106;
            this.lbl_ID.Text = "000000000";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ID.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(87, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 105;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(87, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 108;
            this.label2.Text = "姓名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label4.Location = new System.Drawing.Point(84, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 109;
            this.label4.Text = "電話";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(429, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 28);
            this.label7.TabIndex = 110;
            this.label7.Text = "生日";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.UseWaitCursor = true;
            // 
            // txt_電話
            // 
            this.txt_電話.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.txt_電話.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_電話.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.會員BindingSource, "電話", true));
            this.txt_電話.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_電話.ForeColor = System.Drawing.Color.White;
            this.txt_電話.Location = new System.Drawing.Point(82, 284);
            this.txt_電話.Name = "txt_電話";
            this.txt_電話.Size = new System.Drawing.Size(280, 37);
            this.txt_電話.TabIndex = 113;
            this.txt_電話.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_電話.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label12.Location = new System.Drawing.Point(790, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 28);
            this.label12.TabIndex = 114;
            this.label12.Text = "密碼";
            this.label12.UseWaitCursor = true;
            // 
            // txt_姓名
            // 
            this.txt_姓名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.txt_姓名.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_姓名.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.會員BindingSource, "姓名", true));
            this.txt_姓名.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_姓名.ForeColor = System.Drawing.Color.White;
            this.txt_姓名.Location = new System.Drawing.Point(86, 174);
            this.txt_姓名.Name = "txt_姓名";
            this.txt_姓名.Size = new System.Drawing.Size(280, 37);
            this.txt_姓名.TabIndex = 107;
            this.txt_姓名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_姓名.UseWaitCursor = true;
            this.txt_姓名.TextChanged += new System.EventHandler(this.txt_姓名_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label8.Location = new System.Drawing.Point(429, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 111;
            this.label8.Text = "寵物名稱";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label9.Location = new System.Drawing.Point(429, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 28);
            this.label9.TabIndex = 112;
            this.label9.Text = "寵物種類";
            this.label9.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.combo寵物種類);
            this.panel3.Controls.Add(this.lbl服務項目);
            this.panel3.Controls.Add(this.listBox_會員資料);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBox_搜尋結果);
            this.panel3.Controls.Add(this.lbl_筆數資料);
            this.panel3.Controls.Add(this.btn_新增資料);
            this.panel3.Controls.Add(this.txt_權限);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dtp_生日);
            this.panel3.Controls.Add(this.txt_密碼);
            this.panel3.Controls.Add(this.txt_寵物名);
            this.panel3.Controls.Add(this.lbl_ID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_電話);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_姓名);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1310, 593);
            this.panel3.TabIndex = 7;
            this.panel3.UseWaitCursor = true;
            // 
            // lbl服務項目
            // 
            this.lbl服務項目.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.lbl服務項目.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl服務項目.ForeColor = System.Drawing.Color.White;
            this.lbl服務項目.Location = new System.Drawing.Point(3, 346);
            this.lbl服務項目.Name = "lbl服務項目";
            this.lbl服務項目.Size = new System.Drawing.Size(1304, 2);
            this.lbl服務項目.TabIndex = 130;
            this.lbl服務項目.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl服務項目.UseWaitCursor = true;
            // 
            // mydbDataSet4
            // 
            this.mydbDataSet4.DataSetName = "mydbDataSet4";
            this.mydbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 會員BindingSource
            // 
            this.會員BindingSource.DataMember = "會員";
            this.會員BindingSource.DataSource = this.mydbDataSet4;
            // 
            // 會員TableAdapter
            // 
            this.會員TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 期中專案_0420.mydbDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.員工TableAdapter = null;
            this.tableAdapterManager.會員TableAdapter = this.會員TableAdapter;
            this.tableAdapterManager.產品TableAdapter = null;
            this.tableAdapterManager.訂單TableAdapter = this.訂單TableAdapter;
            // 
            // 會員BindingNavigator
            // 
            this.會員BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.會員BindingNavigator.BindingSource = this.會員BindingSource;
            this.會員BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.會員BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.會員BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.會員BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.會員BindingNavigatorSaveItem});
            this.會員BindingNavigator.Location = new System.Drawing.Point(0, 74);
            this.會員BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.會員BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.會員BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.會員BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.會員BindingNavigator.Name = "會員BindingNavigator";
            this.會員BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.會員BindingNavigator.Size = new System.Drawing.Size(1310, 33);
            this.會員BindingNavigator.TabIndex = 8;
            this.會員BindingNavigator.Text = "bindingNavigator1";
            this.會員BindingNavigator.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // 會員BindingNavigatorSaveItem
            // 
            this.會員BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.會員BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("會員BindingNavigatorSaveItem.Image")));
            this.會員BindingNavigatorSaveItem.Name = "會員BindingNavigatorSaveItem";
            this.會員BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.會員BindingNavigatorSaveItem.Text = "儲存資料";
            this.會員BindingNavigatorSaveItem.Click += new System.EventHandler(this.會員BindingNavigatorSaveItem_Click_2);
            // 
            // 會員DataGridView
            // 
            this.會員DataGridView.AutoGenerateColumns = false;
            this.會員DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.會員DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.會員DataGridView.DataSource = this.會員BindingSource;
            this.會員DataGridView.Location = new System.Drawing.Point(491, 20);
            this.會員DataGridView.Name = "會員DataGridView";
            this.會員DataGridView.RowHeadersWidth = 62;
            this.會員DataGridView.RowTemplate.Height = 31;
            this.會員DataGridView.Size = new System.Drawing.Size(92, 39);
            this.會員DataGridView.TabIndex = 130;
            this.會員DataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "姓名";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "電話";
            this.dataGridViewTextBoxColumn3.HeaderText = "電話";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "生日";
            this.dataGridViewTextBoxColumn4.HeaderText = "生日";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "寵物名稱";
            this.dataGridViewTextBoxColumn5.HeaderText = "寵物名稱";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "寵物類型";
            this.dataGridViewTextBoxColumn6.HeaderText = "寵物類型";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "密碼";
            this.dataGridViewTextBoxColumn7.HeaderText = "密碼";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "權限";
            this.dataGridViewTextBoxColumn8.HeaderText = "權限";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // fK訂單員工BindingSource
            // 
            this.fK訂單員工BindingSource.DataMember = "FK_訂單_員工";
            this.fK訂單員工BindingSource.DataSource = this.會員BindingSource;
            // 
            // 訂單TableAdapter
            // 
            this.訂單TableAdapter.ClearBeforeFill = true;
            // 
            // combo寵物種類
            // 
            this.combo寵物種類.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.combo寵物種類.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.會員BindingSource, "寵物類型", true));
            this.combo寵物種類.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combo寵物種類.ForeColor = System.Drawing.Color.White;
            this.combo寵物種類.FormattingEnabled = true;
            this.combo寵物種類.Items.AddRange(new object[] {
            "小型犬 (5kg以下)",
            "中型犬 (5-10kg)",
            "中大型短毛犬 (11-15kg)",
            "中大型長毛犬 (11-15kg)",
            "大型短毛犬 (15-20kg)",
            "大型長毛犬 (15-20kg)"});
            this.combo寵物種類.Location = new System.Drawing.Point(434, 285);
            this.combo寵物種類.Name = "combo寵物種類";
            this.combo寵物種類.Size = new System.Drawing.Size(280, 36);
            this.combo寵物種類.TabIndex = 131;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1310, 741);
            this.Controls.Add(this.會員BindingNavigator);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "會員管理系統";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.會員BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.會員BindingNavigator)).EndInit();
            this.會員BindingNavigator.ResumeLayout(false);
            this.會員BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.會員DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fK訂單員工BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_會員資料;
        private System.Windows.Forms.TextBox txt_關鍵查詢;
        private System.Windows.Forms.Label lbl_筆數資料;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_新增資料;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_會員資料;
        private System.Windows.Forms.TextBox txt_權限;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_生日;
        private System.Windows.Forms.TextBox txt_密碼;
        private System.Windows.Forms.TextBox txt_寵物名;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_電話;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_姓名;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_搜尋功能;
        private System.Windows.Forms.ComboBox comboBox_搜尋結果;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Signout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_刪除;
        private System.Windows.Forms.Button btn_新增;
        private System.Windows.Forms.Button btn_上一筆資料;
        private System.Windows.Forms.Button btn_下一筆資料;
        private System.Windows.Forms.Button btn_第一筆資料;
        private System.Windows.Forms.Label lbl服務項目;
        private mydbDataSet4 mydbDataSet4;
        private System.Windows.Forms.BindingSource 會員BindingSource;
        private mydbDataSet4TableAdapters.會員TableAdapter 會員TableAdapter;
        private mydbDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 會員BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 會員BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView 會員DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private mydbDataSet4TableAdapters.訂單TableAdapter 訂單TableAdapter;
        private System.Windows.Forms.BindingSource fK訂單員工BindingSource;
        private System.Windows.Forms.ComboBox combo寵物種類;
    }
}