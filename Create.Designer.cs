namespace 期中專案_0420
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_訂購人資訊 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_petName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_PetType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.mydbDataSet = new 期中專案_0420.mydbDataSet();
            this.會員BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.會員TableAdapter = new 期中專案_0420.mydbDataSetTableAdapters.會員TableAdapter();
            this.btn_回登入頁面 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.會員BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.Location = new System.Drawing.Point(218, 102);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(320, 37);
            this.txt_name.TabIndex = 149;
            // 
            // lbl_訂購人資訊
            // 
            this.lbl_訂購人資訊.AutoSize = true;
            this.lbl_訂購人資訊.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_訂購人資訊.ForeColor = System.Drawing.Color.White;
            this.lbl_訂購人資訊.Location = new System.Drawing.Point(315, 27);
            this.lbl_訂購人資訊.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_訂購人資訊.Name = "lbl_訂購人資訊";
            this.lbl_訂購人資訊.Size = new System.Drawing.Size(71, 36);
            this.lbl_訂購人資訊.TabIndex = 150;
            this.lbl_訂購人資訊.Text = "註冊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 151;
            this.label2.Text = "姓名/帳號名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 153;
            this.label1.Text = "電話";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_phone.Location = new System.Drawing.Point(218, 189);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(320, 37);
            this.txt_phone.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(129, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 155;
            this.label3.Text = "生日";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CalendarFont = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_birthday.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_birthday.Location = new System.Drawing.Point(220, 276);
            this.dtp_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(320, 39);
            this.dtp_birthday.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 158;
            this.label4.Text = "寵物名稱";
            // 
            // txt_petName
            // 
            this.txt_petName.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_petName.Location = new System.Drawing.Point(218, 452);
            this.txt_petName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_petName.Name = "txt_petName";
            this.txt_petName.Size = new System.Drawing.Size(320, 37);
            this.txt_petName.TabIndex = 157;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 160;
            this.label5.Text = "寵物類型";
            // 
            // cmb_PetType
            // 
            this.cmb_PetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PetType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_PetType.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_PetType.FormattingEnabled = true;
            this.cmb_PetType.Items.AddRange(new object[] {
            "小型犬 (5kg以下)",
            "中型犬 (5-10kg)",
            "中大型短毛犬 (11-15kg)",
            "中大型長毛犬 (11-15kg)",
            "大型短毛犬 (15-20kg)",
            "大型長毛犬 (15-20kg)"});
            this.cmb_PetType.Location = new System.Drawing.Point(218, 542);
            this.cmb_PetType.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_PetType.Name = "cmb_PetType";
            this.cmb_PetType.Size = new System.Drawing.Size(320, 37);
            this.cmb_PetType.TabIndex = 161;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(129, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 163;
            this.label6.Text = "密碼";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_password.Location = new System.Drawing.Point(218, 370);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(320, 37);
            this.txt_password.TabIndex = 162;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(540, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 164;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(114)))));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(208, -9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 106);
            this.label9.TabIndex = 166;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.Image = ((System.Drawing.Image)(resources.GetObject("btn_check.Image")));
            this.btn_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_check.Location = new System.Drawing.Point(254, 622);
            this.btn_check.Name = "btn_check";
            this.btn_check.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_check.Size = new System.Drawing.Size(183, 57);
            this.btn_check.TabIndex = 167;
            this.btn_check.Text = "確 認";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 會員BindingSource
            // 
            this.會員BindingSource.DataMember = "會員";
            this.會員BindingSource.DataSource = this.mydbDataSet;
            // 
            // 會員TableAdapter
            // 
            this.會員TableAdapter.ClearBeforeFill = true;
            // 
            // btn_回登入頁面
            // 
            this.btn_回登入頁面.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.btn_回登入頁面.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_回登入頁面.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_回登入頁面.ForeColor = System.Drawing.Color.White;
            this.btn_回登入頁面.Image = ((System.Drawing.Image)(resources.GetObject("btn_回登入頁面.Image")));
            this.btn_回登入頁面.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_回登入頁面.Location = new System.Drawing.Point(442, 622);
            this.btn_回登入頁面.Name = "btn_回登入頁面";
            this.btn_回登入頁面.Size = new System.Drawing.Size(163, 57);
            this.btn_回登入頁面.TabIndex = 168;
            this.btn_回登入頁面.Text = "回登入頁面";
            this.btn_回登入頁面.UseVisualStyleBackColor = false;
            this.btn_回登入頁面.Visible = false;
            this.btn_回登入頁面.Click += new System.EventHandler(this.btn_回登入頁面_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(688, 694);
            this.Controls.Add(this.btn_回登入頁面);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.cmb_PetType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_petName);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_訂購人資訊);
            this.Controls.Add(this.txt_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Create";
            this.Text = "註冊";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Create_FormClosing);
            this.Load += new System.EventHandler(this.Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.會員BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_訂購人資訊;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_petName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_PetType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_check;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource 會員BindingSource;
        private mydbDataSetTableAdapters.會員TableAdapter 會員TableAdapter;
        private System.Windows.Forms.Button btn_回登入頁面;
        private System.Windows.Forms.Timer timer1;
    }
}