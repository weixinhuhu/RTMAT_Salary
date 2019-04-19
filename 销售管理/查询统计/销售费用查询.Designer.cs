namespace 销售管理.查询统计
{
    partial class 销售费用查询
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.tSaleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSaleDetails = new 销售管理.DAL.DataSetSaleDetails();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdetail = new System.Windows.Forms.RadioButton();
            this.rbSum = new System.Windows.Forms.RadioButton();
            this.cmbFeeType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_SaleDetailsTableAdapter = new 销售管理.DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter();
            this.dgvSumFee = new System.Windows.Forms.DataGridView();
            this.销售员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.差旅费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.餐费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.礼品 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.无票费用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品赠送 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.广告宣传 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.薪资 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.办公费用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumFee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvReports.Location = new System.Drawing.Point(81, 341);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowTemplate.Height = 23;
            this.dgvReports.ShowEditingIcon = false;
            this.dgvReports.Size = new System.Drawing.Size(2181, 1227);
            this.dgvReports.TabIndex = 1;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBills_CellContentClick);
            this.dgvReports.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSaleDetails_RowsAdded);
            // 
            // tSaleDetailsBindingSource
            // 
            this.tSaleDetailsBindingSource.DataMember = "T_SaleDetails";
            this.tSaleDetailsBindingSource.DataSource = this.dataSetSaleDetails;
            // 
            // dataSetSaleDetails
            // 
            this.dataSetSaleDetails.DataSetName = "DataSetSaleDetails";
            this.dataSetSaleDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbdetail);
            this.groupBox1.Controls.Add(this.rbSum);
            this.groupBox1.Controls.Add(this.cmbFeeType);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CmbDepartmentName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(81, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(2181, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rbdetail
            // 
            this.rbdetail.AutoSize = true;
            this.rbdetail.Location = new System.Drawing.Point(725, 156);
            this.rbdetail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbdetail.Name = "rbdetail";
            this.rbdetail.Size = new System.Drawing.Size(124, 31);
            this.rbdetail.TabIndex = 43;
            this.rbdetail.TabStop = true;
            this.rbdetail.Text = "明细表";
            this.rbdetail.UseVisualStyleBackColor = true;
            this.rbdetail.CheckedChanged += new System.EventHandler(this.rbdetail_CheckedChanged);
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.Location = new System.Drawing.Point(916, 156);
            this.rbSum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(124, 31);
            this.rbSum.TabIndex = 42;
            this.rbSum.TabStop = true;
            this.rbSum.Text = "汇总表";
            this.rbSum.UseVisualStyleBackColor = true;
            this.rbSum.CheckedChanged += new System.EventHandler(this.rbSum_CheckedChanged);
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.BackColor = System.Drawing.Color.White;
            this.cmbFeeType.DropDownHeight = 300;
            this.cmbFeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeeType.FormattingEnabled = true;
            this.cmbFeeType.IntegralHeight = false;
            this.cmbFeeType.Items.AddRange(new object[] {
            "差旅费",
            "餐费",
            "礼品",
            "无票费用",
            "产品赠送",
            "广告宣传",
            "薪资",
            "办公费用"});
            this.cmbFeeType.Location = new System.Drawing.Point(163, 157);
            this.cmbFeeType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbFeeType.Name = "cmbFeeType";
            this.cmbFeeType.Size = new System.Drawing.Size(362, 35);
            this.cmbFeeType.TabIndex = 41;
            this.cmbFeeType.SelectedIndexChanged += new System.EventHandler(this.cmbFeeType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1975, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 78);
            this.button1.TabIndex = 40;
            this.button1.Text = "导出EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CmbDepartmentName
            // 
            this.CmbDepartmentName.DisplayMember = "UserName";
            this.CmbDepartmentName.DropDownHeight = 300;
            this.CmbDepartmentName.DropDownWidth = 200;
            this.CmbDepartmentName.FormattingEnabled = true;
            this.CmbDepartmentName.IntegralHeight = false;
            this.CmbDepartmentName.Items.AddRange(new object[] {
            "销售",
            "领导",
            "财务",
            "融通创投",
            "RTM",
            "商务经理",
            "商务助理",
            "生产与质量"});
            this.CmbDepartmentName.Location = new System.Drawing.Point(691, 64);
            this.CmbDepartmentName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmbDepartmentName.Name = "CmbDepartmentName";
            this.CmbDepartmentName.Size = new System.Drawing.Size(402, 35);
            this.CmbDepartmentName.TabIndex = 13;
            this.CmbDepartmentName.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "所属部门";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(165, 66);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(362, 35);
            this.cmbUserName.TabIndex = 4;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            this.cmbUserName.SelectionChangeCommitted += new System.EventHandler(this.cmbUserName_SelectionChangeCommitted);
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1753, 48);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(179, 78);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查询";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = false;
            this.dtpEnd.Location = new System.Drawing.Point(1341, 156);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(275, 38);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1335, 64);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(281, 38);
            this.dtpStart.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(981, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1243, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "费用类别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售员";
            // 
            // t_SaleDetailsTableAdapter
            // 
            this.t_SaleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvSumFee
            // 
            this.dgvSumFee.AllowUserToAddRows = false;
            this.dgvSumFee.AllowUserToDeleteRows = false;
            this.dgvSumFee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSumFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSumFee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvSumFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.销售员,
            this.差旅费,
            this.餐费,
            this.礼品,
            this.无票费用,
            this.产品赠送,
            this.广告宣传,
            this.薪资,
            this.办公费用,
            this.合计});
            this.dgvSumFee.Location = new System.Drawing.Point(81, 341);
            this.dgvSumFee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvSumFee.Name = "dgvSumFee";
            this.dgvSumFee.RowTemplate.Height = 23;
            this.dgvSumFee.ShowEditingIcon = false;
            this.dgvSumFee.Size = new System.Drawing.Size(2181, 1227);
            this.dgvSumFee.TabIndex = 3;
            // 
            // 销售员
            // 
            this.销售员.DataPropertyName = "销售员";
            this.销售员.HeaderText = "销售员";
            this.销售员.Name = "销售员";
            this.销售员.Width = 142;
            // 
            // 差旅费
            // 
            this.差旅费.DataPropertyName = "差旅费";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.差旅费.DefaultCellStyle = dataGridViewCellStyle1;
            this.差旅费.HeaderText = "差旅费";
            this.差旅费.Name = "差旅费";
            this.差旅费.Width = 142;
            // 
            // 餐费
            // 
            this.餐费.DataPropertyName = "餐费";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.餐费.DefaultCellStyle = dataGridViewCellStyle2;
            this.餐费.HeaderText = "餐费";
            this.餐费.Name = "餐费";
            this.餐费.Width = 115;
            // 
            // 礼品
            // 
            this.礼品.DataPropertyName = "礼品";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.礼品.DefaultCellStyle = dataGridViewCellStyle3;
            this.礼品.HeaderText = "礼品";
            this.礼品.Name = "礼品";
            this.礼品.Width = 115;
            // 
            // 无票费用
            // 
            this.无票费用.DataPropertyName = "无票费用";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.无票费用.DefaultCellStyle = dataGridViewCellStyle4;
            this.无票费用.HeaderText = "无票费用";
            this.无票费用.Name = "无票费用";
            this.无票费用.Width = 169;
            // 
            // 产品赠送
            // 
            this.产品赠送.DataPropertyName = "产品赠送";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.产品赠送.DefaultCellStyle = dataGridViewCellStyle5;
            this.产品赠送.HeaderText = "产品赠送";
            this.产品赠送.Name = "产品赠送";
            this.产品赠送.Width = 169;
            // 
            // 广告宣传
            // 
            this.广告宣传.DataPropertyName = "广告宣传";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.广告宣传.DefaultCellStyle = dataGridViewCellStyle6;
            this.广告宣传.HeaderText = "广告宣传";
            this.广告宣传.Name = "广告宣传";
            this.广告宣传.Width = 169;
            // 
            // 薪资
            // 
            this.薪资.DataPropertyName = "薪资";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.薪资.DefaultCellStyle = dataGridViewCellStyle7;
            this.薪资.HeaderText = "薪资";
            this.薪资.Name = "薪资";
            this.薪资.Width = 115;
            // 
            // 办公费用
            // 
            this.办公费用.DataPropertyName = "办公费用";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.办公费用.DefaultCellStyle = dataGridViewCellStyle8;
            this.办公费用.HeaderText = "办公费用";
            this.办公费用.Name = "办公费用";
            this.办公费用.Width = 169;
            // 
            // 合计
            // 
            this.合计.DataPropertyName = "合计";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.合计.DefaultCellStyle = dataGridViewCellStyle9;
            this.合计.HeaderText = "合计";
            this.合计.Name = "合计";
            this.合计.Width = 115;
            // 
            // 销售费用查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.Controls.Add(this.dgvSumFee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReports);
            this.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.Name = "销售费用查询";
            this.Load += new System.EventHandler(this.销售明细管理_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvReports, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvSumFee, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumFee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tSaleDetailsBindingSource;
        private DAL.DataSetSaleDetails dataSetSaleDetails;
        private DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter t_SaleDetailsTableAdapter;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox CmbDepartmentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFeeType;
        private System.Windows.Forms.RadioButton rbdetail;
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.DataGridView dgvSumFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 差旅费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 餐费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 礼品;
        private System.Windows.Forms.DataGridViewTextBoxColumn 无票费用;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品赠送;
        private System.Windows.Forms.DataGridViewTextBoxColumn 广告宣传;
        private System.Windows.Forms.DataGridViewTextBoxColumn 薪资;
        private System.Windows.Forms.DataGridViewTextBoxColumn 办公费用;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合计;
    }
}
