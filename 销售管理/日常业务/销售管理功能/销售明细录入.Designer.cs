namespace 销售管理.日常业务
{
    partial class 销售明细录入
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSettlementModes = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.txtStockOutNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbProduct1 = new System.Windows.Forms.ComboBox();
            this.cmbProduct2 = new System.Windows.Forms.ComboBox();
            this.cmbProduct3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labAgentSun = new System.Windows.Forms.Label();
            this.txtAgentSum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbInvoiceFlag = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
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
            this.cmbCustomerName.Enabled = false;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.IntegralHeight = false;
            this.cmbCustomerName.Location = new System.Drawing.Point(206, 92);
            this.cmbCustomerName.Margin = new System.Windows.Forms.Padding(6);
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
            this.label3.Location = new System.Drawing.Point(188, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "日期";
            this.label3.Visible = false;
            // 
            // dtpDate1
            // 
            this.dtpDate1.Location = new System.Drawing.Point(258, -5);
            this.dtpDate1.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(220, 35);
            this.dtpDate1.TabIndex = 2;
            this.dtpDate1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(89, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "产品名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(137, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "数量";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(207, 199);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(126, 35);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(796, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "出库单";
            this.label6.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(421, 199);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(146, 35);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(583, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "金额";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(641, 199);
            this.txtSum.Margin = new System.Windows.Forms.Padding(6);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(182, 35);
            this.txtSum.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(494, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "结款方式";
            this.label8.Visible = false;
            // 
            // cmbSettlementModes
            // 
            this.cmbSettlementModes.FormattingEnabled = true;
            this.cmbSettlementModes.Items.AddRange(new object[] {
            "月结",
            "货到付款",
            "支票",
            "已回款",
            "现金",
            "发票到后付款",
            "款到发货",
            "已回款不开票"});
            this.cmbSettlementModes.Location = new System.Drawing.Point(606, -5);
            this.cmbSettlementModes.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSettlementModes.Name = "cmbSettlementModes";
            this.cmbSettlementModes.Size = new System.Drawing.Size(182, 32);
            this.cmbSettlementModes.TabIndex = 1;
            this.cmbSettlementModes.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(694, 884);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 70);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(414, 884);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
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
            this.label2.Location = new System.Drawing.Point(113, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "销售员";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(206, 40);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(830, 32);
            this.cmbUserName.TabIndex = 8;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            this.cmbUserName.SelectionChangeCommitted += new System.EventHandler(this.cmbUserName_SelectionChangeCommitted);
            // 
            // txtStockOutNo
            // 
            this.txtStockOutNo.Location = new System.Drawing.Point(878, -5);
            this.txtStockOutNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtStockOutNo.Name = "txtStockOutNo";
            this.txtStockOutNo.Size = new System.Drawing.Size(212, 35);
            this.txtStockOutNo.TabIndex = 3;
            this.txtStockOutNo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(351, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "单价";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(829, 205);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "单位";
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "KG",
            "G",
            "T"});
            this.cmbUnit.Location = new System.Drawing.Point(891, 201);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(146, 32);
            this.cmbUnit.TabIndex = 1;
            this.cmbUnit.Text = "KG";
            // 
            // cmbProduct1
            // 
            this.cmbProduct1.DisplayMember = "name";
            this.cmbProduct1.DropDownHeight = 300;
            this.cmbProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct1.DropDownWidth = 200;
            this.cmbProduct1.FormattingEnabled = true;
            this.cmbProduct1.IntegralHeight = false;
            this.cmbProduct1.Location = new System.Drawing.Point(207, 147);
            this.cmbProduct1.Margin = new System.Windows.Forms.Padding(6);
            this.cmbProduct1.Name = "cmbProduct1";
            this.cmbProduct1.Size = new System.Drawing.Size(274, 32);
            this.cmbProduct1.TabIndex = 7;
            this.cmbProduct1.ValueMember = "Id";
            this.cmbProduct1.SelectedIndexChanged += new System.EventHandler(this.cmbProduct1_SelectedIndexChanged);
            // 
            // cmbProduct2
            // 
            this.cmbProduct2.DisplayMember = "name";
            this.cmbProduct2.DropDownHeight = 300;
            this.cmbProduct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct2.DropDownWidth = 200;
            this.cmbProduct2.FormattingEnabled = true;
            this.cmbProduct2.IntegralHeight = false;
            this.cmbProduct2.Location = new System.Drawing.Point(485, 147);
            this.cmbProduct2.Margin = new System.Windows.Forms.Padding(6);
            this.cmbProduct2.Name = "cmbProduct2";
            this.cmbProduct2.Size = new System.Drawing.Size(274, 32);
            this.cmbProduct2.TabIndex = 7;
            this.cmbProduct2.ValueMember = "Id";
            this.cmbProduct2.Visible = false;
            this.cmbProduct2.SelectedIndexChanged += new System.EventHandler(this.cmbProduct2_SelectedIndexChanged);
            this.cmbProduct2.SelectionChangeCommitted += new System.EventHandler(this.cmbProduct2_SelectionChangeCommitted);
            // 
            // cmbProduct3
            // 
            this.cmbProduct3.DisplayMember = "name";
            this.cmbProduct3.DropDownHeight = 300;
            this.cmbProduct3.DropDownWidth = 200;
            this.cmbProduct3.Enabled = false;
            this.cmbProduct3.FormattingEnabled = true;
            this.cmbProduct3.IntegralHeight = false;
            this.cmbProduct3.Location = new System.Drawing.Point(763, 147);
            this.cmbProduct3.Margin = new System.Windows.Forms.Padding(6);
            this.cmbProduct3.Name = "cmbProduct3";
            this.cmbProduct3.Size = new System.Drawing.Size(274, 32);
            this.cmbProduct3.TabIndex = 7;
            this.cmbProduct3.ValueMember = "Id";
            this.cmbProduct3.Visible = false;
            this.cmbProduct3.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_DataSourceChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labAgentSun);
            this.groupBox1.Controls.Add(this.txtAgentSum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CmbInvoiceFlag);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbProduct3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbProduct2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbProduct1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Controls.Add(this.cmbCustomerName);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.cmbUnit);
            this.groupBox1.Location = new System.Drawing.Point(54, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1268, 317);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labAgentSun
            // 
            this.labAgentSun.AutoSize = true;
            this.labAgentSun.BackColor = System.Drawing.Color.Transparent;
            this.labAgentSun.Location = new System.Drawing.Point(351, 262);
            this.labAgentSun.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labAgentSun.Name = "labAgentSun";
            this.labAgentSun.Size = new System.Drawing.Size(58, 24);
            this.labAgentSun.TabIndex = 13;
            this.labAgentSun.Text = "佣金";
            // 
            // txtAgentSum
            // 
            this.txtAgentSum.Location = new System.Drawing.Point(421, 256);
            this.txtAgentSum.Margin = new System.Windows.Forms.Padding(6);
            this.txtAgentSum.Name = "txtAgentSum";
            this.txtAgentSum.Size = new System.Drawing.Size(146, 35);
            this.txtAgentSum.TabIndex = 14;
            this.txtAgentSum.Text = "0";
            this.txtAgentSum.TextChanged += new System.EventHandler(this.txtAgentSum_TextChanged);
            this.txtAgentSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgentSum_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(89, 263);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "是否开票";
            // 
            // CmbInvoiceFlag
            // 
            this.CmbInvoiceFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInvoiceFlag.FormattingEnabled = true;
            this.CmbInvoiceFlag.Items.AddRange(new object[] {
            "开票",
            "不开票"});
            this.CmbInvoiceFlag.Location = new System.Drawing.Point(207, 259);
            this.CmbInvoiceFlag.Margin = new System.Windows.Forms.Padding(6);
            this.CmbInvoiceFlag.Name = "CmbInvoiceFlag";
            this.CmbInvoiceFlag.Size = new System.Drawing.Size(126, 32);
            this.CmbInvoiceFlag.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(899, 259);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 42);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDetails);
            this.groupBox2.Location = new System.Drawing.Point(54, 353);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1268, 519);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出库内容";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductName,
            this.ColumnAmount,
            this.ColumnPrice,
            this.ColumnSumMoney,
            this.ColumnUnit,
            this.ColumnProductId,
            this.AgentSum,
            this.InvoiceFlag});
            this.dgvDetails.Location = new System.Drawing.Point(6, 34);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 82;
            this.dgvDetails.RowTemplate.Height = 23;
            this.dgvDetails.Size = new System.Drawing.Size(1256, 438);
            this.dgvDetails.TabIndex = 0;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.HeaderText = "产品名称";
            this.ColumnProductName.MinimumWidth = 10;
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            this.ColumnProductName.Width = 151;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "数量";
            this.ColumnAmount.MinimumWidth = 10;
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            this.ColumnAmount.Width = 103;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "单价";
            this.ColumnPrice.MinimumWidth = 10;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 103;
            // 
            // ColumnSumMoney
            // 
            this.ColumnSumMoney.HeaderText = "金额";
            this.ColumnSumMoney.MinimumWidth = 10;
            this.ColumnSumMoney.Name = "ColumnSumMoney";
            this.ColumnSumMoney.ReadOnly = true;
            this.ColumnSumMoney.Width = 103;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.HeaderText = "单位";
            this.ColumnUnit.MinimumWidth = 10;
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            this.ColumnUnit.Width = 103;
            // 
            // ColumnProductId
            // 
            this.ColumnProductId.HeaderText = "ProductId";
            this.ColumnProductId.MinimumWidth = 10;
            this.ColumnProductId.Name = "ColumnProductId";
            this.ColumnProductId.ReadOnly = true;
            this.ColumnProductId.Visible = false;
            this.ColumnProductId.Width = 200;
            // 
            // AgentSum
            // 
            this.AgentSum.HeaderText = "佣金";
            this.AgentSum.MinimumWidth = 10;
            this.AgentSum.Name = "AgentSum";
            this.AgentSum.ReadOnly = true;
            this.AgentSum.Width = 103;
            // 
            // InvoiceFlag
            // 
            this.InvoiceFlag.HeaderText = "是否开票";
            this.InvoiceFlag.MinimumWidth = 10;
            this.InvoiceFlag.Name = "InvoiceFlag";
            this.InvoiceFlag.ReadOnly = true;
            this.InvoiceFlag.Width = 151;
            // 
            // 销售明细录入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1361, 959);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtStockOutNo);
            this.Controls.Add(this.dtpDate1);
            this.Controls.Add(this.cmbSettlementModes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "销售明细录入";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售明细录入";
            this.Load += new System.EventHandler(this.销售明细维护_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSettlementModes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.TextBox txtStockOutNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbProduct1;
        private System.Windows.Forms.ComboBox cmbProduct2;
        private System.Windows.Forms.ComboBox cmbProduct3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbInvoiceFlag;
        private System.Windows.Forms.Label labAgentSun;
        private System.Windows.Forms.TextBox txtAgentSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceFlag;
    }
}