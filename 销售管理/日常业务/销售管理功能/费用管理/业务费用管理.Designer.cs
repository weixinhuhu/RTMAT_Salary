namespace 销售管理.日常业务
{
    partial class 业务费用管理
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
            this.dgvBusinessFee = new System.Windows.Forms.DataGridView();
            this.tSaleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSaleDetails = new 销售管理.DAL.DataSetSaleDetails();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFeeType = new System.Windows.Forms.ComboBox();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.CmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.mYDB_RT_MATDataSet = new 销售管理.MYDB_RT_MATDataSet();
            this.tFeeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_FeeTypeTableAdapter = new 销售管理.MYDB_RT_MATDataSetTableAdapters.T_FeeTypeTableAdapter();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mYDB_RT_MATDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFeeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvBusinessFee
            // 
            this.dgvBusinessFee.AllowUserToAddRows = false;
            this.dgvBusinessFee.AllowUserToDeleteRows = false;
            this.dgvBusinessFee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusinessFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBusinessFee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvBusinessFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusinessFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDel,
            this.ColModify,
            this.idDataGridViewTextBoxColumn,
            this.UserName,
            this.FeeTypeName,
            this.Notes,
            this.SumFee,
            this.CreateDate,
            this.日期});
            this.dgvBusinessFee.Location = new System.Drawing.Point(70, 287);
            this.dgvBusinessFee.Margin = new System.Windows.Forms.Padding(6);
            this.dgvBusinessFee.Name = "dgvBusinessFee";
            this.dgvBusinessFee.ReadOnly = true;
            this.dgvBusinessFee.RowHeadersWidth = 82;
            this.dgvBusinessFee.RowTemplate.Height = 23;
            this.dgvBusinessFee.ShowEditingIcon = false;
            this.dgvBusinessFee.Size = new System.Drawing.Size(1870, 1107);
            this.dgvBusinessFee.TabIndex = 1;
            this.dgvBusinessFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBills_CellContentClick);
            this.dgvBusinessFee.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSaleDetails_RowsAdded);
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
            this.groupBox1.Controls.Add(this.cmbFeeType);
            this.groupBox1.Controls.Add(this.llAdd);
            this.groupBox1.Controls.Add(this.CmbDepartmentName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(70, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1870, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.DisplayMember = "UserName";
            this.cmbFeeType.DropDownHeight = 300;
            this.cmbFeeType.DropDownWidth = 200;
            this.cmbFeeType.FormattingEnabled = true;
            this.cmbFeeType.IntegralHeight = false;
            this.cmbFeeType.Items.AddRange(new object[] {
            "销售",
            "领导",
            "财务",
            "融通创投",
            "RTM",
            "商务经理",
            "商务助理",
            "生产与质量"});
            this.cmbFeeType.Location = new System.Drawing.Point(155, 137);
            this.cmbFeeType.Margin = new System.Windows.Forms.Padding(6);
            this.cmbFeeType.Name = "cmbFeeType";
            this.cmbFeeType.Size = new System.Drawing.Size(311, 32);
            this.cmbFeeType.TabIndex = 40;
            this.cmbFeeType.ValueMember = "Id";
            // 
            // llAdd
            // 
            this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(1633, 145);
            this.llAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(118, 24);
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
            this.CmbDepartmentName.Location = new System.Drawing.Point(605, 52);
            this.CmbDepartmentName.Margin = new System.Windows.Forms.Padding(6);
            this.CmbDepartmentName.Name = "CmbDepartmentName";
            this.CmbDepartmentName.Size = new System.Drawing.Size(346, 32);
            this.CmbDepartmentName.TabIndex = 22;
            this.CmbDepartmentName.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "所属部门";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "费用类别";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(155, 54);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(311, 32);
            this.cmbUserName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(854, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "销售员";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1402, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加业务费记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1637, 42);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(221, 69);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查询业务费记录";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = false;
            this.dtpEnd.Location = new System.Drawing.Point(1146, 133);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(236, 35);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1140, 50);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(242, 35);
            this.dtpStart.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1035, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "日期";
            // 
            // t_SaleDetailsTableAdapter
            // 
            this.t_SaleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // mYDB_RT_MATDataSet
            // 
            this.mYDB_RT_MATDataSet.DataSetName = "MYDB_RT_MATDataSet";
            this.mYDB_RT_MATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tFeeTypeBindingSource
            // 
            this.tFeeTypeBindingSource.DataMember = "T_FeeType";
            this.tFeeTypeBindingSource.DataSource = this.mYDB_RT_MATDataSet;
            // 
            // t_FeeTypeTableAdapter
            // 
            this.t_FeeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ColDel
            // 
            this.ColDel.HeaderText = "删除";
            this.ColDel.MinimumWidth = 10;
            this.ColDel.Name = "ColDel";
            this.ColDel.ReadOnly = true;
            this.ColDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDel.Text = "删除";
            this.ColDel.UseColumnTextForButtonValue = true;
            this.ColDel.Width = 103;
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "修改";
            this.ColModify.MinimumWidth = 10;
            this.ColModify.Name = "ColModify";
            this.ColModify.ReadOnly = true;
            this.ColModify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColModify.Text = "修改";
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Width = 103;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 79;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "销售员";
            this.UserName.MinimumWidth = 10;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 127;
            // 
            // FeeTypeName
            // 
            this.FeeTypeName.DataPropertyName = "FeeTypeName";
            dataGridViewCellStyle1.NullValue = null;
            this.FeeTypeName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FeeTypeName.HeaderText = "费用类别";
            this.FeeTypeName.MinimumWidth = 10;
            this.FeeTypeName.Name = "FeeTypeName";
            this.FeeTypeName.ReadOnly = true;
            this.FeeTypeName.Width = 151;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "费用说明";
            this.Notes.MinimumWidth = 10;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 151;
            // 
            // SumFee
            // 
            this.SumFee.DataPropertyName = "SumFee";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.SumFee.DefaultCellStyle = dataGridViewCellStyle2;
            this.SumFee.HeaderText = "报销金额";
            this.SumFee.MinimumWidth = 10;
            this.SumFee.Name = "SumFee";
            this.SumFee.ReadOnly = true;
            this.SumFee.Width = 151;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.CreateDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.CreateDate.HeaderText = "报销日期";
            this.CreateDate.MinimumWidth = 10;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 151;
            // 
            // 日期
            // 
            this.日期.DataPropertyName = "UpDateDate";
            dataGridViewCellStyle4.Format = "d";
            this.日期.DefaultCellStyle = dataGridViewCellStyle4;
            this.日期.HeaderText = "录入日期";
            this.日期.MinimumWidth = 10;
            this.日期.Name = "日期";
            this.日期.ReadOnly = true;
            this.日期.Width = 151;
            // 
            // 业务费用管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBusinessFee);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "业务费用管理";
            this.Load += new System.EventHandler(this.销售明细管理_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvBusinessFee, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mYDB_RT_MATDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFeeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusinessFee;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.BindingSource tFeeTypeBindingSource;
        private MYDB_RT_MATDataSet mYDB_RT_MATDataSet;
        private MYDB_RT_MATDataSetTableAdapters.T_FeeTypeTableAdapter t_FeeTypeTableAdapter;
        private System.Windows.Forms.ComboBox cmbFeeType;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
    }
}
