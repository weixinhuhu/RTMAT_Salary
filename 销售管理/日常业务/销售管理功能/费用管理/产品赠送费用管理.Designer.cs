﻿namespace 销售管理.日常业务
{
    partial class 产品赠送费用管理
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tSaleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSaleDetails = new 销售管理.DAL.DataSetSaleDetails();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.CmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.t_SaleDetailsTableAdapter = new 销售管理.DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter();
            this.赠送日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOutNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvProductSend = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSend)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
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
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCusName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Location = new System.Drawing.Point(70, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1870, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // llAdd
            // 
            this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(1669, 152);
            this.llAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(118, 24);
            this.llAdd.TabIndex = 26;
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
            this.CmbDepartmentName.Location = new System.Drawing.Point(588, 60);
            this.CmbDepartmentName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmbDepartmentName.Name = "CmbDepartmentName";
            this.CmbDepartmentName.Size = new System.Drawing.Size(346, 32);
            this.CmbDepartmentName.TabIndex = 25;
            this.CmbDepartmentName.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "所属部门";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(588, 142);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(346, 35);
            this.txtProductName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "产品名称";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(138, 61);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(311, 32);
            this.cmbUserName.TabIndex = 21;
            // 
            // dtp2
            // 
            this.dtp2.Checked = false;
            this.dtp2.Location = new System.Drawing.Point(1146, 135);
            this.dtp2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(236, 35);
            this.dtp2.TabIndex = 19;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(1140, 60);
            this.dtp1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowCheckBox = true;
            this.dtp1.Size = new System.Drawing.Size(242, 35);
            this.dtp1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1062, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "日期";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(138, 142);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(311, 35);
            this.txtCusName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "客户名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "销售员";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1402, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加赠送记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1652, 42);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(197, 69);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查询赠送记录";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // t_SaleDetailsTableAdapter
            // 
            this.t_SaleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // 赠送日期
            // 
            this.赠送日期.DataPropertyName = "SaleDate";
            this.赠送日期.HeaderText = "赠送日期";
            this.赠送日期.MinimumWidth = 10;
            this.赠送日期.Name = "赠送日期";
            this.赠送日期.ReadOnly = true;
            this.赠送日期.Width = 151;
            // 
            // StockOutNo
            // 
            this.StockOutNo.DataPropertyName = "StockOutNo";
            this.StockOutNo.HeaderText = "出库单号";
            this.StockOutNo.MinimumWidth = 10;
            this.StockOutNo.Name = "StockOutNo";
            this.StockOutNo.ReadOnly = true;
            this.StockOutNo.Width = 151;
            // 
            // 金额
            // 
            this.金额.DataPropertyName = "SumMoney";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.金额.DefaultCellStyle = dataGridViewCellStyle4;
            this.金额.HeaderText = "金额";
            this.金额.MinimumWidth = 10;
            this.金额.Name = "金额";
            this.金额.ReadOnly = true;
            this.金额.Width = 103;
            // 
            // 产品单价
            // 
            this.产品单价.DataPropertyName = "Price";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.产品单价.DefaultCellStyle = dataGridViewCellStyle5;
            this.产品单价.HeaderText = "产品单价";
            this.产品单价.MinimumWidth = 10;
            this.产品单价.Name = "产品单价";
            this.产品单价.ReadOnly = true;
            this.产品单价.Width = 151;
            // 
            // 产品单位
            // 
            this.产品单位.DataPropertyName = "Unit";
            this.产品单位.HeaderText = "产品单位";
            this.产品单位.MinimumWidth = 10;
            this.产品单位.Name = "产品单位";
            this.产品单位.ReadOnly = true;
            this.产品单位.Width = 151;
            // 
            // 产品数量
            // 
            this.产品数量.DataPropertyName = "Amount";
            this.产品数量.HeaderText = "产品数量";
            this.产品数量.MinimumWidth = 10;
            this.产品数量.Name = "产品数量";
            this.产品数量.ReadOnly = true;
            this.产品数量.Width = 151;
            // 
            // 产品名称
            // 
            this.产品名称.DataPropertyName = "ProductName";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.产品名称.DefaultCellStyle = dataGridViewCellStyle6;
            this.产品名称.HeaderText = "产品名称";
            this.产品名称.MinimumWidth = 10;
            this.产品名称.Name = "产品名称";
            this.产品名称.ReadOnly = true;
            this.产品名称.Width = 151;
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
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "销售员";
            this.UserName.MinimumWidth = 10;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 127;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 89;
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "修改";
            this.ColModify.MinimumWidth = 10;
            this.ColModify.Name = "ColModify";
            this.ColModify.Text = "修改";
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Width = 64;
            // 
            // ColDel
            // 
            this.ColDel.HeaderText = "刪除";
            this.ColDel.MinimumWidth = 10;
            this.ColDel.Name = "ColDel";
            this.ColDel.Text = "刪除";
            this.ColDel.UseColumnTextForButtonValue = true;
            this.ColDel.Width = 64;
            // 
            // dgvProductSend
            // 
            this.dgvProductSend.AllowUserToAddRows = false;
            this.dgvProductSend.AllowUserToDeleteRows = false;
            this.dgvProductSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductSend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvProductSend.ColumnHeadersHeight = 46;
            this.dgvProductSend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDel,
            this.ColModify,
            this.idDataGridViewTextBoxColumn,
            this.UserName,
            this.CompanyName,
            this.产品名称,
            this.产品数量,
            this.产品单位,
            this.产品单价,
            this.金额,
            this.StockOutNo,
            this.赠送日期});
            this.dgvProductSend.Location = new System.Drawing.Point(70, 305);
            this.dgvProductSend.Margin = new System.Windows.Forms.Padding(6);
            this.dgvProductSend.Name = "dgvProductSend";
            this.dgvProductSend.RowHeadersWidth = 82;
            this.dgvProductSend.RowTemplate.Height = 23;
            this.dgvProductSend.ShowEditingIcon = false;
            this.dgvProductSend.Size = new System.Drawing.Size(1870, 1063);
            this.dgvProductSend.TabIndex = 1;
            this.dgvProductSend.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerBills_CellContentClick);
            this.dgvProductSend.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSaleDetails_RowsAdded);
            // 
            // 产品赠送费用管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductSend);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Name = "产品赠送费用管理";
            this.Load += new System.EventHandler(this.销售明细管理_Load);
            this.Controls.SetChildIndex(this.dgvProductSend, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tSaleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tSaleDetailsBindingSource;
        private DAL.DataSetSaleDetails dataSetSaleDetails;
        private DAL.DataSetSaleDetailsTableAdapters.T_SaleDetailsTableAdapter t_SaleDetailsTableAdapter;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbDepartmentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn 赠送日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOutNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridView dgvProductSend;
    }
}
