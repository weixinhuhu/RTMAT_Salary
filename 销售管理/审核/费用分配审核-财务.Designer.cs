﻿namespace 销售管理.日常业务
{
    partial class 费用分配审核_财务
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHasAudit = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tExpenseAllocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetExpenseAllocation = new 销售管理.DAL.DataSetExpenseAllocation();
            this.t_ExpenseAllocationTableAdapter = new 销售管理.DAL.DataSetExpenseAllocationTableAdapters.T_ExpenseAllocationTableAdapter();
            this.dgvExAllocation = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAudit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColAudit1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleComissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleWagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentCommissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySaler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityWages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySaleSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySaleCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessAuditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinanceAudit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDetailsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tExpenseAllocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetExpenseAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbHasAudit);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTableNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(72, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1860, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // cmbHasAudit
            // 
            this.cmbHasAudit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasAudit.FormattingEnabled = true;
            this.cmbHasAudit.Items.AddRange(new object[] {
            "未审核",
            "已审核"});
            this.cmbHasAudit.Location = new System.Drawing.Point(1492, 70);
            this.cmbHasAudit.Margin = new System.Windows.Forms.Padding(6);
            this.cmbHasAudit.Name = "cmbHasAudit";
            this.cmbHasAudit.Size = new System.Drawing.Size(172, 32);
            this.cmbHasAudit.TabIndex = 5;
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1680, 54);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(168, 68);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(1272, 70);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 35);
            this.txtProductName.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(940, 70);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(196, 35);
            this.txtCustomerName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1154, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "产品名称";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(600, 70);
            this.txtTableNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(196, 35);
            this.txtTableNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户名称";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.DropDownWidth = 200;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(162, 70);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(238, 32);
            this.cmbUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "费用分配表号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售员";
            // 
            // tExpenseAllocationBindingSource
            // 
            this.tExpenseAllocationBindingSource.DataMember = "T_ExpenseAllocation";
            this.tExpenseAllocationBindingSource.DataSource = this.dataSetExpenseAllocation;
            // 
            // dataSetExpenseAllocation
            // 
            this.dataSetExpenseAllocation.DataSetName = "DataSetExpenseAllocation";
            this.dataSetExpenseAllocation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_ExpenseAllocationTableAdapter
            // 
            this.t_ExpenseAllocationTableAdapter.ClearBeforeFill = true;
            // 
            // dgvExAllocation
            // 
            this.dgvExAllocation.AllowUserToAddRows = false;
            this.dgvExAllocation.AllowUserToDeleteRows = false;
            this.dgvExAllocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExAllocation.AutoGenerateColumns = false;
            this.dgvExAllocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExAllocation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvExAllocation.ColumnHeadersHeight = 32;
            this.dgvExAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColAudit,
            this.ColAudit1,
            this.type,
            this.userNameDataGridViewTextBoxColumn,
            this.tableNoDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.deliverPriceDataGridViewTextBoxColumn,
            this.deliverSumDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.saleComissionDataGridViewTextBoxColumn,
            this.saleSumDataGridViewTextBoxColumn,
            this.departSumDataGridViewTextBoxColumn,
            this.saleWagesDataGridViewTextBoxColumn,
            this.commissionPriceDataGridViewTextBoxColumn,
            this.commissionSumDataGridViewTextBoxColumn,
            this.agentPriceDataGridViewTextBoxColumn,
            this.agentSumDataGridViewTextBoxColumn,
            this.agentCommissionDataGridViewTextBoxColumn,
            this.CitySaler,
            this.CitySum,
            this.CityWages,
            this.CitySalePrice,
            this.CitySaleSum,
            this.CitySaleCommission,
            this.isPaidDataGridViewTextBoxColumn,
            this.paidDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.businessAuditDataGridViewTextBoxColumn,
            this.businessDateDataGridViewTextBoxColumn,
            this.recDateDataGridViewTextBoxColumn,
            this.FinanceAudit,
            this.FinanceDate,
            this.saleDetailsIdDataGridViewTextBoxColumn});
            this.dgvExAllocation.DataSource = this.tExpenseAllocationBindingSource;
            this.dgvExAllocation.Location = new System.Drawing.Point(72, 250);
            this.dgvExAllocation.Margin = new System.Windows.Forms.Padding(6);
            this.dgvExAllocation.Name = "dgvExAllocation";
            this.dgvExAllocation.ReadOnly = true;
            this.dgvExAllocation.RowHeadersWidth = 82;
            this.dgvExAllocation.RowTemplate.Height = 23;
            this.dgvExAllocation.Size = new System.Drawing.Size(1860, 1076);
            this.dgvExAllocation.TabIndex = 4;
            this.dgvExAllocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExAllocation_CellContentClick);
            this.dgvExAllocation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExAllocation_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 79;
            // 
            // ColAudit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "审核通过";
            this.ColAudit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColAudit.Frozen = true;
            this.ColAudit.HeaderText = "审核通过";
            this.ColAudit.MinimumWidth = 10;
            this.ColAudit.Name = "ColAudit";
            this.ColAudit.ReadOnly = true;
            this.ColAudit.UseColumnTextForButtonValue = true;
            this.ColAudit.Width = 112;
            // 
            // ColAudit1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "审核不通过";
            this.ColAudit1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColAudit1.Frozen = true;
            this.ColAudit1.HeaderText = "审核不通过";
            this.ColAudit1.MinimumWidth = 10;
            this.ColAudit1.Name = "ColAudit1";
            this.ColAudit1.ReadOnly = true;
            this.ColAudit1.UseColumnTextForButtonValue = true;
            this.ColAudit1.Width = 136;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.Frozen = true;
            this.type.HeaderText = "订单类型";
            this.type.MinimumWidth = 10;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 151;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.Frozen = true;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "销售员";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 127;
            // 
            // tableNoDataGridViewTextBoxColumn
            // 
            this.tableNoDataGridViewTextBoxColumn.DataPropertyName = "TableNo";
            this.tableNoDataGridViewTextBoxColumn.Frozen = true;
            this.tableNoDataGridViewTextBoxColumn.HeaderText = "费用分配表号";
            this.tableNoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tableNoDataGridViewTextBoxColumn.Name = "tableNoDataGridViewTextBoxColumn";
            this.tableNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tableNoDataGridViewTextBoxColumn.Width = 199;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "项目名称";
            this.projectNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectNameDataGridViewTextBoxColumn.Visible = false;
            this.projectNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "产品名称";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "类别";
            this.productTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTypeDataGridViewTextBoxColumn.Width = 103;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "数目";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 103;
            // 
            // deliverPriceDataGridViewTextBoxColumn
            // 
            this.deliverPriceDataGridViewTextBoxColumn.DataPropertyName = "DeliverPrice";
            this.deliverPriceDataGridViewTextBoxColumn.HeaderText = "发货价格";
            this.deliverPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.deliverPriceDataGridViewTextBoxColumn.Name = "deliverPriceDataGridViewTextBoxColumn";
            this.deliverPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverPriceDataGridViewTextBoxColumn.Width = 151;
            // 
            // deliverSumDataGridViewTextBoxColumn
            // 
            this.deliverSumDataGridViewTextBoxColumn.DataPropertyName = "DeliverSum";
            this.deliverSumDataGridViewTextBoxColumn.HeaderText = "发货额";
            this.deliverSumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.deliverSumDataGridViewTextBoxColumn.Name = "deliverSumDataGridViewTextBoxColumn";
            this.deliverSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverSumDataGridViewTextBoxColumn.Width = 127;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "实际价格";
            this.salePriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salePriceDataGridViewTextBoxColumn.Width = 151;
            // 
            // saleComissionDataGridViewTextBoxColumn
            // 
            this.saleComissionDataGridViewTextBoxColumn.DataPropertyName = "SaleComission";
            this.saleComissionDataGridViewTextBoxColumn.HeaderText = "销售提成";
            this.saleComissionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.saleComissionDataGridViewTextBoxColumn.Name = "saleComissionDataGridViewTextBoxColumn";
            this.saleComissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleComissionDataGridViewTextBoxColumn.Width = 151;
            // 
            // saleSumDataGridViewTextBoxColumn
            // 
            this.saleSumDataGridViewTextBoxColumn.DataPropertyName = "SaleSum";
            this.saleSumDataGridViewTextBoxColumn.HeaderText = "个人销售额";
            this.saleSumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.saleSumDataGridViewTextBoxColumn.Name = "saleSumDataGridViewTextBoxColumn";
            this.saleSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleSumDataGridViewTextBoxColumn.Visible = false;
            this.saleSumDataGridViewTextBoxColumn.Width = 175;
            // 
            // departSumDataGridViewTextBoxColumn
            // 
            this.departSumDataGridViewTextBoxColumn.DataPropertyName = "DepartSum";
            this.departSumDataGridViewTextBoxColumn.HeaderText = "部门销售额";
            this.departSumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.departSumDataGridViewTextBoxColumn.Name = "departSumDataGridViewTextBoxColumn";
            this.departSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.departSumDataGridViewTextBoxColumn.Visible = false;
            this.departSumDataGridViewTextBoxColumn.Width = 175;
            // 
            // saleWagesDataGridViewTextBoxColumn
            // 
            this.saleWagesDataGridViewTextBoxColumn.DataPropertyName = "SaleWages";
            this.saleWagesDataGridViewTextBoxColumn.HeaderText = "销售工资";
            this.saleWagesDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.saleWagesDataGridViewTextBoxColumn.Name = "saleWagesDataGridViewTextBoxColumn";
            this.saleWagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleWagesDataGridViewTextBoxColumn.Visible = false;
            this.saleWagesDataGridViewTextBoxColumn.Width = 151;
            // 
            // commissionPriceDataGridViewTextBoxColumn
            // 
            this.commissionPriceDataGridViewTextBoxColumn.DataPropertyName = "CommissionPrice";
            this.commissionPriceDataGridViewTextBoxColumn.HeaderText = "提成单价";
            this.commissionPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.commissionPriceDataGridViewTextBoxColumn.Name = "commissionPriceDataGridViewTextBoxColumn";
            this.commissionPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.commissionPriceDataGridViewTextBoxColumn.Visible = false;
            this.commissionPriceDataGridViewTextBoxColumn.Width = 151;
            // 
            // commissionSumDataGridViewTextBoxColumn
            // 
            this.commissionSumDataGridViewTextBoxColumn.DataPropertyName = "CommissionSum";
            this.commissionSumDataGridViewTextBoxColumn.HeaderText = "提成销售额";
            this.commissionSumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.commissionSumDataGridViewTextBoxColumn.Name = "commissionSumDataGridViewTextBoxColumn";
            this.commissionSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.commissionSumDataGridViewTextBoxColumn.Visible = false;
            this.commissionSumDataGridViewTextBoxColumn.Width = 175;
            // 
            // agentPriceDataGridViewTextBoxColumn
            // 
            this.agentPriceDataGridViewTextBoxColumn.DataPropertyName = "AgentPrice";
            this.agentPriceDataGridViewTextBoxColumn.HeaderText = "代理商单价";
            this.agentPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.agentPriceDataGridViewTextBoxColumn.Name = "agentPriceDataGridViewTextBoxColumn";
            this.agentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentPriceDataGridViewTextBoxColumn.Visible = false;
            this.agentPriceDataGridViewTextBoxColumn.Width = 175;
            // 
            // agentSumDataGridViewTextBoxColumn
            // 
            this.agentSumDataGridViewTextBoxColumn.DataPropertyName = "AgentSum";
            this.agentSumDataGridViewTextBoxColumn.HeaderText = "佣金";
            this.agentSumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.agentSumDataGridViewTextBoxColumn.Name = "agentSumDataGridViewTextBoxColumn";
            this.agentSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentSumDataGridViewTextBoxColumn.Width = 103;
            // 
            // agentCommissionDataGridViewTextBoxColumn
            // 
            this.agentCommissionDataGridViewTextBoxColumn.DataPropertyName = "AgentCommission";
            this.agentCommissionDataGridViewTextBoxColumn.HeaderText = "税后佣金";
            this.agentCommissionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.agentCommissionDataGridViewTextBoxColumn.Name = "agentCommissionDataGridViewTextBoxColumn";
            this.agentCommissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentCommissionDataGridViewTextBoxColumn.Width = 151;
            // 
            // CitySaler
            // 
            this.CitySaler.DataPropertyName = "CitySaler";
            this.CitySaler.HeaderText = "跨区域销售";
            this.CitySaler.MinimumWidth = 10;
            this.CitySaler.Name = "CitySaler";
            this.CitySaler.ReadOnly = true;
            this.CitySaler.Visible = false;
            this.CitySaler.Width = 175;
            // 
            // CitySum
            // 
            this.CitySum.DataPropertyName = "CitySum";
            this.CitySum.HeaderText = "跨区域销售额";
            this.CitySum.MinimumWidth = 10;
            this.CitySum.Name = "CitySum";
            this.CitySum.ReadOnly = true;
            this.CitySum.Visible = false;
            this.CitySum.Width = 199;
            // 
            // CityWages
            // 
            this.CityWages.DataPropertyName = "CityWages";
            this.CityWages.HeaderText = "跨区域销售工资";
            this.CityWages.MinimumWidth = 10;
            this.CityWages.Name = "CityWages";
            this.CityWages.ReadOnly = true;
            this.CityWages.Visible = false;
            this.CityWages.Width = 223;
            // 
            // CitySalePrice
            // 
            this.CitySalePrice.DataPropertyName = "CitySalePrice";
            this.CitySalePrice.HeaderText = "跨区销售提成单价";
            this.CitySalePrice.MinimumWidth = 10;
            this.CitySalePrice.Name = "CitySalePrice";
            this.CitySalePrice.ReadOnly = true;
            this.CitySalePrice.Visible = false;
            this.CitySalePrice.Width = 247;
            // 
            // CitySaleSum
            // 
            this.CitySaleSum.DataPropertyName = "CitySaleSum";
            this.CitySaleSum.HeaderText = "跨区销售提成额";
            this.CitySaleSum.MinimumWidth = 10;
            this.CitySaleSum.Name = "CitySaleSum";
            this.CitySaleSum.ReadOnly = true;
            this.CitySaleSum.Visible = false;
            this.CitySaleSum.Width = 223;
            // 
            // CitySaleCommission
            // 
            this.CitySaleCommission.DataPropertyName = "CitySaleCommission";
            this.CitySaleCommission.HeaderText = "跨区销售提成";
            this.CitySaleCommission.MinimumWidth = 10;
            this.CitySaleCommission.Name = "CitySaleCommission";
            this.CitySaleCommission.ReadOnly = true;
            this.CitySaleCommission.Visible = false;
            this.CitySaleCommission.Width = 199;
            // 
            // isPaidDataGridViewTextBoxColumn
            // 
            this.isPaidDataGridViewTextBoxColumn.DataPropertyName = "IsPaid";
            this.isPaidDataGridViewTextBoxColumn.HeaderText = "是否付佣金";
            this.isPaidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.isPaidDataGridViewTextBoxColumn.Name = "isPaidDataGridViewTextBoxColumn";
            this.isPaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.isPaidDataGridViewTextBoxColumn.Width = 175;
            // 
            // paidDateDataGridViewTextBoxColumn
            // 
            this.paidDateDataGridViewTextBoxColumn.DataPropertyName = "PaidDate";
            this.paidDateDataGridViewTextBoxColumn.HeaderText = "付款日期";
            this.paidDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.paidDateDataGridViewTextBoxColumn.Name = "paidDateDataGridViewTextBoxColumn";
            this.paidDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidDateDataGridViewTextBoxColumn.Width = 151;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "订单状态";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 151;
            // 
            // businessAuditDataGridViewTextBoxColumn
            // 
            this.businessAuditDataGridViewTextBoxColumn.DataPropertyName = "BusinessAudit";
            this.businessAuditDataGridViewTextBoxColumn.HeaderText = "商务审核人";
            this.businessAuditDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.businessAuditDataGridViewTextBoxColumn.Name = "businessAuditDataGridViewTextBoxColumn";
            this.businessAuditDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessAuditDataGridViewTextBoxColumn.Visible = false;
            this.businessAuditDataGridViewTextBoxColumn.Width = 175;
            // 
            // businessDateDataGridViewTextBoxColumn
            // 
            this.businessDateDataGridViewTextBoxColumn.DataPropertyName = "BusinessDate";
            this.businessDateDataGridViewTextBoxColumn.HeaderText = "商务审核日期";
            this.businessDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.businessDateDataGridViewTextBoxColumn.Name = "businessDateDataGridViewTextBoxColumn";
            this.businessDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessDateDataGridViewTextBoxColumn.Visible = false;
            this.businessDateDataGridViewTextBoxColumn.Width = 199;
            // 
            // recDateDataGridViewTextBoxColumn
            // 
            this.recDateDataGridViewTextBoxColumn.DataPropertyName = "RecDate";
            this.recDateDataGridViewTextBoxColumn.HeaderText = "申请时间";
            this.recDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.recDateDataGridViewTextBoxColumn.Name = "recDateDataGridViewTextBoxColumn";
            this.recDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.recDateDataGridViewTextBoxColumn.Width = 151;
            // 
            // FinanceAudit
            // 
            this.FinanceAudit.DataPropertyName = "FinanceAudit";
            this.FinanceAudit.HeaderText = "财务审核人";
            this.FinanceAudit.MinimumWidth = 10;
            this.FinanceAudit.Name = "FinanceAudit";
            this.FinanceAudit.ReadOnly = true;
            this.FinanceAudit.Width = 175;
            // 
            // FinanceDate
            // 
            this.FinanceDate.DataPropertyName = "FinanceDate";
            this.FinanceDate.HeaderText = "财务审核日期";
            this.FinanceDate.MinimumWidth = 10;
            this.FinanceDate.Name = "FinanceDate";
            this.FinanceDate.ReadOnly = true;
            this.FinanceDate.Width = 199;
            // 
            // saleDetailsIdDataGridViewTextBoxColumn
            // 
            this.saleDetailsIdDataGridViewTextBoxColumn.DataPropertyName = "SaleDetailsId";
            this.saleDetailsIdDataGridViewTextBoxColumn.HeaderText = "SaleDetailsId";
            this.saleDetailsIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.saleDetailsIdDataGridViewTextBoxColumn.Name = "saleDetailsIdDataGridViewTextBoxColumn";
            this.saleDetailsIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleDetailsIdDataGridViewTextBoxColumn.Visible = false;
            this.saleDetailsIdDataGridViewTextBoxColumn.Width = 211;
            // 
            // 费用分配审核_财务
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.dgvExAllocation);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "费用分配审核_财务";
            this.Load += new System.EventHandler(this.费用分配审核_财务_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvExAllocation, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tExpenseAllocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetExpenseAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tExpenseAllocationBindingSource;
        private DAL.DataSetExpenseAllocation dataSetExpenseAllocation;
        private DAL.DataSetExpenseAllocationTableAdapters.T_ExpenseAllocationTableAdapter t_ExpenseAllocationTableAdapter;
        private System.Windows.Forms.DataGridView dgvExAllocation;
        private System.Windows.Forms.ComboBox cmbHasAudit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColAudit;
        private System.Windows.Forms.DataGridViewButtonColumn ColAudit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleComissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleWagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentCommissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySaler;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityWages;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySaleSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySaleCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessAuditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinanceAudit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDetailsIdDataGridViewTextBoxColumn;
    }
}
