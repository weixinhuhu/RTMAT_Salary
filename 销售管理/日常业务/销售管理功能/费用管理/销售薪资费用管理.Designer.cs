namespace 销售管理.日常业务
{
    partial class 销售薪资费用管理
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
            this.dgvUserSalary = new System.Windows.Forms.DataGridView();
            this.tSaleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSaleDetails = new 销售管理.DAL.DataSetSaleDetails();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.CmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_SaleDetailsTableAdapter = new 销售管理.DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvUserSalary
            // 
            this.dgvUserSalary.AllowUserToAddRows = false;
            this.dgvUserSalary.AllowUserToDeleteRows = false;
            this.dgvUserSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUserSalary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvUserSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColModify,
            this.idDataGridViewTextBoxColumn,
            this.UserName,
            this.Price1,
            this.Price2,
            this.Price3,
            this.Price4,
            this.Price5,
            this.SumMoney,
            this.SalaryDate});
            this.dgvUserSalary.Location = new System.Drawing.Point(82, 233);
            this.dgvUserSalary.Margin = new System.Windows.Forms.Padding(7);
            this.dgvUserSalary.Name = "dgvUserSalary";
            this.dgvUserSalary.RowTemplate.Height = 23;
            this.dgvUserSalary.ShowEditingIcon = false;
            this.dgvUserSalary.Size = new System.Drawing.Size(2182, 1335);
            this.dgvUserSalary.TabIndex = 1;
            this.dgvUserSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBills_CellContentClick);
            this.dgvUserSalary.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSaleDetails_RowsAdded);
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(82, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(2182, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // llAdd
            // 
            this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(1909, 107);
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
            this.CmbDepartmentName.Location = new System.Drawing.Point(650, 65);
            this.CmbDepartmentName.Margin = new System.Windows.Forms.Padding(7);
            this.CmbDepartmentName.Name = "CmbDepartmentName";
            this.CmbDepartmentName.Size = new System.Drawing.Size(403, 35);
            this.CmbDepartmentName.TabIndex = 13;
            this.CmbDepartmentName.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "所属部门";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1663, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加薪资记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(139, 65);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(7);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(282, 35);
            this.cmbUserName.TabIndex = 4;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            this.cmbUserName.SelectionChangeCommitted += new System.EventHandler(this.cmbUserName_SelectionChangeCommitted);
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1914, 42);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(7);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(236, 58);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查询薪资记录";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = false;
            this.dtpEnd.Location = new System.Drawing.Point(1347, 97);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(7);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(275, 38);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1340, 45);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(7);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(282, 38);
            this.dtpStart.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1260, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售员";
            // 
            // t_SaleDetailsTableAdapter
            // 
            this.t_SaleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "修改";
            this.ColModify.Name = "ColModify";
            this.ColModify.ReadOnly = true;
            this.ColModify.Text = "修改";
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Width = 72;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Price1
            // 
            this.Price1.DataPropertyName = "Price1";
            dataGridViewCellStyle1.Format = "C2";
            this.Price1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price1.HeaderText = "工资";
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
            this.Price1.Width = 115;
            // 
            // Price2
            // 
            this.Price2.DataPropertyName = "Price2";
            dataGridViewCellStyle2.Format = "C2";
            this.Price2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Price2.HeaderText = "五险费用";
            this.Price2.Name = "Price2";
            this.Price2.ReadOnly = true;
            this.Price2.Width = 169;
            // 
            // Price3
            // 
            this.Price3.DataPropertyName = "Price3";
            dataGridViewCellStyle3.Format = "C2";
            this.Price3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price3.HeaderText = "住房公积金";
            this.Price3.Name = "Price3";
            this.Price3.ReadOnly = true;
            this.Price3.Width = 196;
            // 
            // Price4
            // 
            this.Price4.DataPropertyName = "Price4";
            dataGridViewCellStyle4.Format = "C2";
            this.Price4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price4.HeaderText = "提成";
            this.Price4.Name = "Price4";
            this.Price4.ReadOnly = true;
            this.Price4.Width = 115;
            // 
            // Price5
            // 
            this.Price5.DataPropertyName = "Price5";
            dataGridViewCellStyle5.Format = "C2";
            this.Price5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Price5.HeaderText = "其它";
            this.Price5.Name = "Price5";
            this.Price5.ReadOnly = true;
            this.Price5.Width = 115;
            // 
            // SumMoney
            // 
            this.SumMoney.DataPropertyName = "SumMoney";
            dataGridViewCellStyle6.Format = "C2";
            this.SumMoney.DefaultCellStyle = dataGridViewCellStyle6;
            this.SumMoney.HeaderText = "合计金额";
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.ReadOnly = true;
            this.SumMoney.Width = 169;
            // 
            // SalaryDate
            // 
            this.SalaryDate.DataPropertyName = "SalaryDate";
            this.SalaryDate.HeaderText = "发放日期";
            this.SalaryDate.Name = "SalaryDate";
            this.SalaryDate.ReadOnly = true;
            this.SalaryDate.Width = 169;
            // 
            // 销售薪资费用管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUserSalary);
            this.Margin = new System.Windows.Forms.Padding(14);
            this.Name = "销售薪资费用管理";
            this.Load += new System.EventHandler(this.销售明细管理_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvUserSalary, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tSaleDetailsBindingSource;
        private DAL.DataSetSaleDetails dataSetSaleDetails;
        private DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter t_SaleDetailsTableAdapter;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbDepartmentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryDate;
    }
}
