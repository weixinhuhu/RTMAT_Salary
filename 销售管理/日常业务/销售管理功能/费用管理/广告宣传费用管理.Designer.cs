namespace 销售管理.日常业务
{
    partial class 广告宣传费用管理
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
            this.dgvAdvertisingFee = new System.Windows.Forms.DataGridView();
            this.tSaleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSaleDetails = new 销售管理.DAL.DataSetSaleDetails();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.CmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPorjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.t_SaleDetailsTableAdapter = new 销售管理.DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvertisingFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvAdvertisingFee
            // 
            this.dgvAdvertisingFee.AllowUserToAddRows = false;
            this.dgvAdvertisingFee.AllowUserToDeleteRows = false;
            this.dgvAdvertisingFee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdvertisingFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAdvertisingFee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvAdvertisingFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColModify,
            this.idDataGridViewTextBoxColumn,
            this.UserName,
            this.ProjectName,
            this.SumMoney,
            this.日期});
            this.dgvAdvertisingFee.Location = new System.Drawing.Point(82, 323);
            this.dgvAdvertisingFee.Margin = new System.Windows.Forms.Padding(7);
            this.dgvAdvertisingFee.Name = "dgvAdvertisingFee";
            this.dgvAdvertisingFee.RowTemplate.Height = 23;
            this.dgvAdvertisingFee.ShowEditingIcon = false;
            this.dgvAdvertisingFee.Size = new System.Drawing.Size(2182, 1245);
            this.dgvAdvertisingFee.TabIndex = 1;
            this.dgvAdvertisingFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBills_CellContentClick);
            this.dgvAdvertisingFee.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSaleDetails_RowsAdded);
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
            this.groupBox1.Controls.Add(this.llAdd);
            this.groupBox1.Controls.Add(this.CmbDepartmentName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtPorjectName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(82, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(2182, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // llAdd
            // 
            this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(1905, 163);
            this.llAdd.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(136, 27);
            this.llAdd.TabIndex = 39;
            this.llAdd.TabStop = true;
            this.llAdd.Text = "导入EXCEL";
            this.llAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
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
            this.CmbDepartmentName.Location = new System.Drawing.Point(706, 59);
            this.CmbDepartmentName.Margin = new System.Windows.Forms.Padding(7);
            this.CmbDepartmentName.Name = "CmbDepartmentName";
            this.CmbDepartmentName.Size = new System.Drawing.Size(403, 35);
            this.CmbDepartmentName.TabIndex = 22;
            this.CmbDepartmentName.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "所属部门";
            // 
            // TxtPorjectName
            // 
            this.TxtPorjectName.Location = new System.Drawing.Point(181, 150);
            this.TxtPorjectName.Margin = new System.Windows.Forms.Padding(7);
            this.TxtPorjectName.Name = "TxtPorjectName";
            this.TxtPorjectName.Size = new System.Drawing.Size(928, 38);
            this.TxtPorjectName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "费用名称";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(181, 61);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(7);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(362, 35);
            this.cmbUserName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "销售员";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1636, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 78);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加广告宣传记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1910, 47);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(7);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(258, 78);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查询广告宣传记录";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = false;
            this.dtpEnd.Location = new System.Drawing.Point(1337, 150);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(7);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(275, 38);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1330, 56);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(7);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(282, 38);
            this.dtpStart.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1207, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "日期";
            // 
            // t_SaleDetailsTableAdapter
            // 
            this.t_SaleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "修改";
            this.ColModify.Name = "ColModify";
            this.ColModify.Text = "修改";
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Width = 72;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 89;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "销售员";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 142;
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ProjectName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectName.HeaderText = "费用说明";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 169;
            // 
            // SumMoney
            // 
            this.SumMoney.DataPropertyName = "SumMoney";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.SumMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.SumMoney.HeaderText = "分摊费用";
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.Width = 169;
            // 
            // 日期
            // 
            this.日期.DataPropertyName = "SalaryDate";
            this.日期.HeaderText = "日期";
            this.日期.Name = "日期";
            this.日期.Width = 115;
            // 
            // 广告宣传费用管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAdvertisingFee);
            this.Margin = new System.Windows.Forms.Padding(14);
            this.Name = "广告宣传费用管理";
            this.Load += new System.EventHandler(this.销售明细管理_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvAdvertisingFee, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvertisingFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdvertisingFee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tSaleDetailsBindingSource;
        private DAL.DataSetSaleDetails dataSetSaleDetails;
        private DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter t_SaleDetailsTableAdapter;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbDepartmentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPorjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
    }
}
