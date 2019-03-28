namespace 销售管理.审核
{
    partial class 无票费用申请复核
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
            this.tMealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMeals = new 销售管理.DAL.DataSetMeals();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxDept = new System.Windows.Forms.ComboBox();
            this.btnAudit2 = new System.Windows.Forms.Button();
            this.btnAudit = new System.Windows.Forms.Button();
            this.cmbHasAudit = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.t_MealsTableAdapter = new 销售管理.DAL.DataSetMealsTableAdapters.T_MealsTableAdapter();
            this.dgvNoTicketAudit = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.申请日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.含税金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审核人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审核时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.复核状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.复核人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tMealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeals)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoTicketAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // tMealsBindingSource
            // 
            this.tMealsBindingSource.DataMember = "T_Meals";
            this.tMealsBindingSource.DataSource = this.dataSetMeals;
            // 
            // dataSetMeals
            // 
            this.dataSetMeals.DataSetName = "DataSetMeals";
            this.dataSetMeals.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBoxDept);
            this.groupBox1.Controls.Add(this.btnAudit2);
            this.groupBox1.Controls.Add(this.btnAudit);
            this.groupBox1.Controls.Add(this.cmbHasAudit);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Location = new System.Drawing.Point(70, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(2193, 225);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = false;
            this.dtpEnd.Location = new System.Drawing.Point(1121, 156);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(7);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(275, 38);
            this.dtpEnd.TabIndex = 34;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1114, 57);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(7);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(282, 38);
            this.dtpStart.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1023, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "销售员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "所属部门";
            // 
            // CBoxDept
            // 
            this.CBoxDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBoxDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBoxDept.DisplayMember = "CompanyName";
            this.CBoxDept.DropDownHeight = 300;
            this.CBoxDept.DropDownWidth = 300;
            this.CBoxDept.FormattingEnabled = true;
            this.CBoxDept.IntegralHeight = false;
            this.CBoxDept.Location = new System.Drawing.Point(633, 65);
            this.CBoxDept.Margin = new System.Windows.Forms.Padding(7);
            this.CBoxDept.Name = "CBoxDept";
            this.CBoxDept.Size = new System.Drawing.Size(270, 35);
            this.CBoxDept.TabIndex = 9;
            this.CBoxDept.ValueMember = "Id";
            // 
            // btnAudit2
            // 
            this.btnAudit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudit2.Location = new System.Drawing.Point(1937, 142);
            this.btnAudit2.Margin = new System.Windows.Forms.Padding(7);
            this.btnAudit2.Name = "btnAudit2";
            this.btnAudit2.Size = new System.Drawing.Size(243, 54);
            this.btnAudit2.TabIndex = 7;
            this.btnAudit2.Text = "批量复核不通过";
            this.btnAudit2.UseVisualStyleBackColor = true;
            this.btnAudit2.Click += new System.EventHandler(this.btnAudit2_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudit.Location = new System.Drawing.Point(1664, 142);
            this.btnAudit.Margin = new System.Windows.Forms.Padding(7);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(259, 54);
            this.btnAudit.TabIndex = 7;
            this.btnAudit.Text = "批量复核通过";
            this.btnAudit.UseVisualStyleBackColor = true;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // cmbHasAudit
            // 
            this.cmbHasAudit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasAudit.FormattingEnabled = true;
            this.cmbHasAudit.Items.AddRange(new object[] {
            "未复核",
            "复核已通过",
            "复核未通过"});
            this.cmbHasAudit.Location = new System.Drawing.Point(633, 153);
            this.cmbHasAudit.Margin = new System.Windows.Forms.Padding(7);
            this.cmbHasAudit.Name = "cmbHasAudit";
            this.cmbHasAudit.Size = new System.Drawing.Size(270, 35);
            this.cmbHasAudit.TabIndex = 6;
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1983, 58);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(7);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(196, 58);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "复核状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户名称";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomers.DisplayMember = "CompanyName";
            this.cmbCustomers.DropDownHeight = 300;
            this.cmbCustomers.DropDownWidth = 300;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.IntegralHeight = false;
            this.cmbCustomers.Location = new System.Drawing.Point(154, 153);
            this.cmbCustomers.Margin = new System.Windows.Forms.Padding(7);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(277, 35);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.ValueMember = "Id";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.DropDownWidth = 200;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(154, 65);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(7);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(277, 35);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // t_MealsTableAdapter
            // 
            this.t_MealsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvNoTicketAudit
            // 
            this.dgvNoTicketAudit.AllowUserToAddRows = false;
            this.dgvNoTicketAudit.AllowUserToDeleteRows = false;
            this.dgvNoTicketAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNoTicketAudit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNoTicketAudit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvNoTicketAudit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColumnChecked,
            this.申请日期,
            this.UserName,
            this.CompanyName,
            this.项目名称,
            this.SumMoney,
            this.含税金额,
            this.SingerFlag,
            this.审核人,
            this.审核时间,
            this.复核状态,
            this.复核人});
            this.dgvNoTicketAudit.Location = new System.Drawing.Point(70, 335);
            this.dgvNoTicketAudit.Margin = new System.Windows.Forms.Padding(7);
            this.dgvNoTicketAudit.Name = "dgvNoTicketAudit";
            this.dgvNoTicketAudit.RowTemplate.Height = 23;
            this.dgvNoTicketAudit.ShowEditingIcon = false;
            this.dgvNoTicketAudit.Size = new System.Drawing.Size(2182, 1212);
            this.dgvNoTicketAudit.TabIndex = 10;
            this.dgvNoTicketAudit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoTicketAudit_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 89;
            // 
            // ColumnChecked
            // 
            this.ColumnChecked.HeaderText = "选择";
            this.ColumnChecked.Name = "ColumnChecked";
            this.ColumnChecked.Width = 72;
            // 
            // 申请日期
            // 
            this.申请日期.DataPropertyName = "SalaryDate";
            this.申请日期.HeaderText = "申请日期";
            this.申请日期.Name = "申请日期";
            this.申请日期.Width = 169;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "销售员";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 142;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "客户名称";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 169;
            // 
            // 项目名称
            // 
            this.项目名称.DataPropertyName = "ProjectName";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.项目名称.DefaultCellStyle = dataGridViewCellStyle1;
            this.项目名称.HeaderText = "项目名称";
            this.项目名称.Name = "项目名称";
            this.项目名称.ReadOnly = true;
            this.项目名称.Width = 169;
            // 
            // SumMoney
            // 
            this.SumMoney.DataPropertyName = "SumMoney";
            this.SumMoney.HeaderText = "申请金额";
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.Width = 169;
            // 
            // 含税金额
            // 
            this.含税金额.DataPropertyName = "含税金额";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.含税金额.DefaultCellStyle = dataGridViewCellStyle2;
            this.含税金额.HeaderText = "含税金额";
            this.含税金额.Name = "含税金额";
            this.含税金额.Width = 169;
            // 
            // SingerFlag
            // 
            this.SingerFlag.DataPropertyName = "Status";
            this.SingerFlag.HeaderText = "审批状态";
            this.SingerFlag.Name = "SingerFlag";
            this.SingerFlag.Width = 169;
            // 
            // 审核人
            // 
            this.审核人.DataPropertyName = "AuditId";
            this.审核人.HeaderText = "审批人";
            this.审核人.Name = "审核人";
            this.审核人.Width = 142;
            // 
            // 审核时间
            // 
            this.审核时间.DataPropertyName = "AuditDate";
            this.审核时间.HeaderText = "审批时间";
            this.审核时间.Name = "审核时间";
            this.审核时间.Width = 169;
            // 
            // 复核状态
            // 
            this.复核状态.DataPropertyName = "P2";
            this.复核状态.HeaderText = "复核状态";
            this.复核状态.Name = "复核状态";
            this.复核状态.Width = 169;
            // 
            // 复核人
            // 
            this.复核人.DataPropertyName = "P3";
            this.复核人.HeaderText = "复核人";
            this.复核人.Name = "复核人";
            this.复核人.Width = 142;
            // 
            // 无票费用申请复核
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.Controls.Add(this.dgvNoTicketAudit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(16);
            this.Name = "无票费用申请复核";
            this.Load += new System.EventHandler(this.消费卡申请审核_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvNoTicketAudit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tMealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoTicketAudit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAudit2;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.ComboBox cmbHasAudit;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.BindingSource tMealsBindingSource;
        private DAL.DataSetMeals dataSetMeals;
        private DAL.DataSetMealsTableAdapters.T_MealsTableAdapter t_MealsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxDept;
        private System.Windows.Forms.DataGridView dgvNoTicketAudit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn 含税金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审核人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审核时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 复核状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 复核人;
    }
}
