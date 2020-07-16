namespace 销售管理.日常业务
{
    partial class 销售回款管理1
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
            this.dgvCustomerBills = new System.Windows.Forms.DataGridView();
            this.tSaleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSaleDetails = new 销售管理.DAL.DataSetSaleDetails();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_SaleDetailsTableAdapter = new 销售管理.DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter();
            this.dgvMoneyReturnList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColRecode = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.公司名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettlementModes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.历史欠款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总发货金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已回款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.剩余欠款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyReturnList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvCustomerBills
            // 
            this.dgvCustomerBills.AllowUserToAddRows = false;
            this.dgvCustomerBills.AllowUserToDeleteRows = false;
            this.dgvCustomerBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomerBills.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomerBills.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvCustomerBills.ColumnHeadersHeight = 32;
            this.dgvCustomerBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.CompanyName,
            this.历史欠款金额,
            this.总发货金额,
            this.已回款金额,
            this.剩余欠款金额});
            this.dgvCustomerBills.Location = new System.Drawing.Point(9, 37);
            this.dgvCustomerBills.Margin = new System.Windows.Forms.Padding(6);
            this.dgvCustomerBills.Name = "dgvCustomerBills";
            this.dgvCustomerBills.RowHeadersWidth = 82;
            this.dgvCustomerBills.RowTemplate.Height = 23;
            this.dgvCustomerBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerBills.ShowEditingIcon = false;
            this.dgvCustomerBills.Size = new System.Drawing.Size(1830, 659);
            this.dgvCustomerBills.TabIndex = 1;
            this.dgvCustomerBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBills_CellClick);
            this.dgvCustomerBills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBills_CellContentClick);
            this.dgvCustomerBills.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSaleDetails_RowsAdded);
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
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(70, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1870, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtCustomer
            // 
            this.txtCustomer.DisplayMember = "CompanyName";
            this.txtCustomer.DropDownHeight = 300;
            this.txtCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCustomer.DropDownWidth = 200;
            this.txtCustomer.FormattingEnabled = true;
            this.txtCustomer.IntegralHeight = false;
            this.txtCustomer.Location = new System.Drawing.Point(493, 58);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(238, 32);
            this.txtCustomer.TabIndex = 10;
            this.txtCustomer.ValueMember = "id";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1441, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加回款记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1079, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "--";
            this.label7.Visible = false;
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(119, 58);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(242, 32);
            this.cmbUserName.TabIndex = 4;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            this.cmbUserName.SelectionChangeCommitted += new System.EventHandler(this.cmbUserName_SelectionChangeCommitted);
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1656, 42);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(173, 69);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查询客户回款";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // dtp2
            // 
            this.dtp2.Checked = false;
            this.dtp2.Location = new System.Drawing.Point(1137, 56);
            this.dtp2.Margin = new System.Windows.Forms.Padding(6);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(236, 35);
            this.dtp2.TabIndex = 2;
            this.dtp2.Visible = false;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(831, 54);
            this.dtp1.Margin = new System.Windows.Forms.Padding(6);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowCheckBox = true;
            this.dtp1.Size = new System.Drawing.Size(242, 35);
            this.dtp1.TabIndex = 2;
            this.dtp1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(761, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "日期";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "客户名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售员";
            // 
            // t_SaleDetailsTableAdapter
            // 
            this.t_SaleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMoneyReturnList
            // 
            this.dgvMoneyReturnList.AllowUserToAddRows = false;
            this.dgvMoneyReturnList.AllowUserToDeleteRows = false;
            this.dgvMoneyReturnList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMoneyReturnList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMoneyReturnList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvMoneyReturnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoneyReturnList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ColDel,
            this.ColRecode,
            this.ColDetails,
            this.ColModify,
            this.公司名称,
            this.销售员,
            this.ProductName,
            this.Amount,
            this.Price,
            this.SumMoney,
            this.SaleDate,
            this.SettlementModes,
            this.ExpDate});
            this.dgvMoneyReturnList.Location = new System.Drawing.Point(9, 28);
            this.dgvMoneyReturnList.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMoneyReturnList.Name = "dgvMoneyReturnList";
            this.dgvMoneyReturnList.RowHeadersWidth = 82;
            this.dgvMoneyReturnList.RowTemplate.Height = 23;
            this.dgvMoneyReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMoneyReturnList.ShowEditingIcon = false;
            this.dgvMoneyReturnList.Size = new System.Drawing.Size(1830, 247);
            this.dgvMoneyReturnList.TabIndex = 3;
            this.dgvMoneyReturnList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoneyReturnList_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dgvCustomerBills);
            this.groupBox2.Location = new System.Drawing.Point(70, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1870, 705);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户货款台账";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dgvMoneyReturnList);
            this.groupBox3.Location = new System.Drawing.Point(70, 915);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1870, 284);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "订单流水";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 40;
            // 
            // ColDel
            // 
            this.ColDel.HeaderText = "删除";
            this.ColDel.MinimumWidth = 10;
            this.ColDel.Name = "ColDel";
            this.ColDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDel.Text = "删除";
            this.ColDel.UseColumnTextForButtonValue = true;
            this.ColDel.Visible = false;
            this.ColDel.Width = 64;
            // 
            // ColRecode
            // 
            this.ColRecode.HeaderText = "录入";
            this.ColRecode.MinimumWidth = 10;
            this.ColRecode.Name = "ColRecode";
            this.ColRecode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColRecode.Text = "录入";
            this.ColRecode.UseColumnTextForButtonValue = true;
            this.ColRecode.Width = 103;
            // 
            // ColDetails
            // 
            this.ColDetails.HeaderText = "回款明细";
            this.ColDetails.MinimumWidth = 10;
            this.ColDetails.Name = "ColDetails";
            this.ColDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDetails.Text = "回款明细";
            this.ColDetails.UseColumnTextForButtonValue = true;
            this.ColDetails.Width = 151;
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "修改";
            this.ColModify.MinimumWidth = 10;
            this.ColModify.Name = "ColModify";
            this.ColModify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColModify.Text = "修改";
            this.ColModify.Visible = false;
            this.ColModify.Width = 103;
            // 
            // 公司名称
            // 
            this.公司名称.DataPropertyName = "CompanyName";
            this.公司名称.HeaderText = "公司名称";
            this.公司名称.MinimumWidth = 10;
            this.公司名称.Name = "公司名称";
            this.公司名称.Width = 151;
            // 
            // 销售员
            // 
            this.销售员.DataPropertyName = "UserName";
            this.销售员.HeaderText = "销售员";
            this.销售员.MinimumWidth = 10;
            this.销售员.Name = "销售员";
            this.销售员.Visible = false;
            this.销售员.Width = 127;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "产品名称";
            this.ProductName.MinimumWidth = 10;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 151;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "数量";
            this.Amount.MinimumWidth = 10;
            this.Amount.Name = "Amount";
            this.Amount.Width = 103;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "发货价格";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.Width = 151;
            // 
            // SumMoney
            // 
            this.SumMoney.DataPropertyName = "SumMoney";
            this.SumMoney.HeaderText = "发货金额";
            this.SumMoney.MinimumWidth = 10;
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.Width = 151;
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "发货日期";
            this.SaleDate.MinimumWidth = 10;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Width = 151;
            // 
            // SettlementModes
            // 
            this.SettlementModes.DataPropertyName = "SettlementModes";
            this.SettlementModes.HeaderText = "结算方式";
            this.SettlementModes.MinimumWidth = 10;
            this.SettlementModes.Name = "SettlementModes";
            this.SettlementModes.Width = 151;
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "ExpDate";
            this.ExpDate.HeaderText = "结算日期";
            this.ExpDate.MinimumWidth = 10;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Width = 151;
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
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "客户名称";
            this.CompanyName.MinimumWidth = 10;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 151;
            // 
            // 历史欠款金额
            // 
            this.历史欠款金额.DataPropertyName = "历史欠款金额";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.历史欠款金额.DefaultCellStyle = dataGridViewCellStyle1;
            this.历史欠款金额.HeaderText = "历史欠款金额";
            this.历史欠款金额.MinimumWidth = 10;
            this.历史欠款金额.Name = "历史欠款金额";
            this.历史欠款金额.ReadOnly = true;
            this.历史欠款金额.Width = 199;
            // 
            // 总发货金额
            // 
            this.总发货金额.DataPropertyName = "总发货金额";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.总发货金额.DefaultCellStyle = dataGridViewCellStyle2;
            this.总发货金额.HeaderText = "总发货金额";
            this.总发货金额.MinimumWidth = 10;
            this.总发货金额.Name = "总发货金额";
            this.总发货金额.ReadOnly = true;
            this.总发货金额.Width = 175;
            // 
            // 已回款金额
            // 
            this.已回款金额.DataPropertyName = "已回款金额";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.已回款金额.DefaultCellStyle = dataGridViewCellStyle3;
            this.已回款金额.HeaderText = "已回款金额";
            this.已回款金额.MinimumWidth = 10;
            this.已回款金额.Name = "已回款金额";
            this.已回款金额.ReadOnly = true;
            this.已回款金额.Width = 175;
            // 
            // 剩余欠款金额
            // 
            this.剩余欠款金额.DataPropertyName = "剩余欠款金额";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.剩余欠款金额.DefaultCellStyle = dataGridViewCellStyle4;
            this.剩余欠款金额.HeaderText = "客户剩余欠款金额";
            this.剩余欠款金额.MinimumWidth = 10;
            this.剩余欠款金额.Name = "剩余欠款金额";
            this.剩余欠款金额.ReadOnly = true;
            this.剩余欠款金额.Width = 247;
            // 
            // 销售回款管理1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "销售回款管理1";
            this.Size = new System.Drawing.Size(2000, 1242);
            this.Load += new System.EventHandler(this.销售明细管理_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyReturnList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerBills;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tSaleDetailsBindingSource;
        private DAL.DataSetSaleDetails dataSetSaleDetails;
        private DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter t_SaleDetailsTableAdapter;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMoneyReturnList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewButtonColumn ColRecode;
        private System.Windows.Forms.DataGridViewButtonColumn ColDetails;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售员;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettlementModes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 历史欠款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总发货金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已回款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 剩余欠款金额;
    }
}
