namespace 销售管理.日常业务
{
    partial class 差旅费录入
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.TxtSumMoney = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.TxtPorjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(88, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DropDownHeight = 300;
            this.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.IntegralHeight = false;
            this.cmbCustomerName.Location = new System.Drawing.Point(206, 92);
            this.cmbCustomerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(830, 32);
            this.cmbCustomerName.TabIndex = 1;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            this.cmbCustomerName.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomerName_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(631, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "报销日期";
            // 
            // dtpDate1
            // 
            this.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate1.Location = new System.Drawing.Point(746, 268);
            this.dtpDate1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(288, 35);
            this.dtpDate1.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Location = new System.Drawing.Point(88, 208);
            this.lb1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(106, 24);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "差旅费用";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(801, 412);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 70);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 412);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 70);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(88, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "销售名称";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(206, 40);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(830, 32);
            this.cmbUserName.TabIndex = 8;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectionChangeCommitted);
            this.cmbUserName.SelectionChangeCommitted += new System.EventHandler(this.cmbUserName_SelectionChangeCommitted);
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(206, 205);
            this.Txt1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(290, 35);
            this.Txt1.TabIndex = 3;
            this.Txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            this.Txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt1_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(-276, 376);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "单价";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.TxtSumMoney);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.Txt2);
            this.groupBox1.Controls.Add(this.TxtPorjectName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.Txt1);
            this.groupBox1.Controls.Add(this.cmbCustomerName);
            this.groupBox1.Controls.Add(this.dtpDate1);
            this.groupBox1.Location = new System.Drawing.Point(54, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1268, 357);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Location = new System.Drawing.Point(88, 268);
            this.lb3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(106, 24);
            this.lb3.TabIndex = 13;
            this.lb3.Text = "报销费用";
            this.lb3.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtSumMoney
            // 
            this.TxtSumMoney.Enabled = false;
            this.TxtSumMoney.Location = new System.Drawing.Point(203, 268);
            this.TxtSumMoney.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSumMoney.Name = "TxtSumMoney";
            this.TxtSumMoney.ReadOnly = true;
            this.TxtSumMoney.Size = new System.Drawing.Size(290, 35);
            this.TxtSumMoney.TabIndex = 14;
            this.TxtSumMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSumMoney_KeyPress);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Location = new System.Drawing.Point(628, 211);
            this.lb2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(106, 24);
            this.lb2.TabIndex = 11;
            this.lb2.Text = "公车费用";
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(746, 208);
            this.Txt2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(290, 35);
            this.Txt2.TabIndex = 12;
            this.Txt2.Text = "0";
            this.Txt2.TextChanged += new System.EventHandler(this.Txt2_TextChanged);
            this.Txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt2_KeyPress);
            // 
            // TxtPorjectName
            // 
            this.TxtPorjectName.Location = new System.Drawing.Point(206, 148);
            this.TxtPorjectName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtPorjectName.Name = "TxtPorjectName";
            this.TxtPorjectName.Size = new System.Drawing.Size(830, 35);
            this.TxtPorjectName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(88, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "项目名称";
            // 
            // 差旅费录入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1361, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label14);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "差旅费录入";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "差旅费记录录入";
            this.Load += new System.EventHandler(this.销售明细维护_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TxtPorjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox TxtSumMoney;
    }
}