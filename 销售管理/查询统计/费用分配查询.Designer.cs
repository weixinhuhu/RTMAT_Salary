﻿namespace 销售管理.查询统计
{
    partial class 费用分配查询
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYongJin = new System.Windows.Forms.ComboBox();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbUserSum = new System.Windows.Forms.RadioButton();
            this.rbDepartSum = new System.Windows.Forms.RadioButton();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.Location = new System.Drawing.Point(38, 260);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(6);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 82;
            this.dgvReport.RowTemplate.Height = 23;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1896, 1110);
            this.dgvReport.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbYongJin);
            this.groupBox1.Controls.Add(this.cmbCompanyName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbUserSum);
            this.groupBox1.Controls.Add(this.rbDepartSum);
            this.groupBox1.Controls.Add(this.rbDetails);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1896, 206);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查找";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(1368, 152);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(162, 35);
            this.txtProductName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1364, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "产品名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1364, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "是否付佣金";
            // 
            // cmbYongJin
            // 
            this.cmbYongJin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYongJin.FormattingEnabled = true;
            this.cmbYongJin.Items.AddRange(new object[] {
            "全部",
            "已付款",
            "未付款"});
            this.cmbYongJin.Location = new System.Drawing.Point(1368, 80);
            this.cmbYongJin.Margin = new System.Windows.Forms.Padding(6);
            this.cmbYongJin.Name = "cmbYongJin";
            this.cmbYongJin.Size = new System.Drawing.Size(162, 32);
            this.cmbYongJin.TabIndex = 9;
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.DropDownHeight = 300;
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.DropDownWidth = 200;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.IntegralHeight = false;
            this.cmbCompanyName.Items.AddRange(new object[] {
            "查询所有",
            "个人订单",
            "部门订单",
            "公司跟单",
            "跨区域订单"});
            this.cmbCompanyName.Location = new System.Drawing.Point(144, 148);
            this.cmbCompanyName.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(350, 32);
            this.cmbCompanyName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "公司名称";
            // 
            // cmbType
            // 
            this.cmbType.DropDownHeight = 300;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.DropDownWidth = 200;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.IntegralHeight = false;
            this.cmbType.Items.AddRange(new object[] {
            "A类订单",
            "B类订单"});
            this.cmbType.Location = new System.Drawing.Point(144, 90);
            this.cmbType.Margin = new System.Windows.Forms.Padding(6);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(350, 32);
            this.cmbType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "订单类型";
            // 
            // rbUserSum
            // 
            this.rbUserSum.AutoSize = true;
            this.rbUserSum.Location = new System.Drawing.Point(694, 64);
            this.rbUserSum.Margin = new System.Windows.Forms.Padding(6);
            this.rbUserSum.Name = "rbUserSum";
            this.rbUserSum.Size = new System.Drawing.Size(209, 28);
            this.rbUserSum.TabIndex = 4;
            this.rbUserSum.TabStop = true;
            this.rbUserSum.Text = "所有销售汇总表";
            this.rbUserSum.UseVisualStyleBackColor = true;
            this.rbUserSum.CheckedChanged += new System.EventHandler(this.rbUserSum_CheckedChanged);
            // 
            // rbDepartSum
            // 
            this.rbDepartSum.AutoSize = true;
            this.rbDepartSum.Location = new System.Drawing.Point(510, 136);
            this.rbDepartSum.Margin = new System.Windows.Forms.Padding(6);
            this.rbDepartSum.Name = "rbDepartSum";
            this.rbDepartSum.Size = new System.Drawing.Size(185, 28);
            this.rbDepartSum.TabIndex = 4;
            this.rbDepartSum.TabStop = true;
            this.rbDepartSum.Text = "部门总销售额";
            this.rbDepartSum.UseVisualStyleBackColor = true;
            this.rbDepartSum.Visible = false;
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Location = new System.Drawing.Point(510, 64);
            this.rbDetails.Margin = new System.Windows.Forms.Padding(6);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(113, 28);
            this.rbDetails.TabIndex = 4;
            this.rbDetails.TabStop = true;
            this.rbDetails.Text = "明细表";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.rbDetails_CheckedChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(1706, 76);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(144, 86);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "导出到EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1546, 76);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 86);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDate);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Location = new System.Drawing.Point(908, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(440, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "销售日期区间";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(12, 40);
            this.cbDate.Margin = new System.Windows.Forms.Padding(6);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(138, 28);
            this.cbDate.TabIndex = 1;
            this.cbDate.Text = "日期区间";
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(166, 94);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(250, 35);
            this.dtpEnd.TabIndex = 0;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(166, 40);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(250, 35);
            this.dtpStart.TabIndex = 0;
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownHeight = 300;
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.DropDownWidth = 200;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.IntegralHeight = false;
            this.cmbUsername.Location = new System.Drawing.Point(144, 30);
            this.cmbUsername.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(350, 32);
            this.cmbUsername.TabIndex = 1;
            this.cmbUsername.SelectedIndexChanged += new System.EventHandler(this.cmbUsername_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售名称";
            // 
            // 费用分配查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReport);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "费用分配查询";
            this.Load += new System.EventHandler(this.费用分配查询_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvReport, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUserSum;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDepartSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYongJin;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
    }
}
