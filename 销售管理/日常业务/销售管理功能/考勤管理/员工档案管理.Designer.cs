namespace 销售管理.日常业务
{
    partial class 员工档案管理
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
            this.dgvEmployInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BntQuery = new System.Windows.Forms.Button();
            this.TxtEmployCardNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TxtEmployId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmployName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployCardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployCardDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvEmployInfo
            // 
            this.dgvEmployInfo.AllowUserToAddRows = false;
            this.dgvEmployInfo.AllowUserToDeleteRows = false;
            this.dgvEmployInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvEmployInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColModify,
            this.ColDel,
            this.ID,
            this.EmployId,
            this.EmployName,
            this.EmployCardNum,
            this.EmployCardDepartment});
            this.dgvEmployInfo.Location = new System.Drawing.Point(52, 163);
            this.dgvEmployInfo.Margin = new System.Windows.Forms.Padding(6);
            this.dgvEmployInfo.Name = "dgvEmployInfo";
            this.dgvEmployInfo.ReadOnly = true;
            this.dgvEmployInfo.RowTemplate.Height = 23;
            this.dgvEmployInfo.Size = new System.Drawing.Size(1878, 1185);
            this.dgvEmployInfo.TabIndex = 1;
            this.dgvEmployInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BntQuery);
            this.groupBox1.Controls.Add(this.TxtEmployCardNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.TxtEmployId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtEmployName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1878, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // BntQuery
            // 
            this.BntQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntQuery.Location = new System.Drawing.Point(1446, 24);
            this.BntQuery.Margin = new System.Windows.Forms.Padding(6);
            this.BntQuery.Name = "BntQuery";
            this.BntQuery.Size = new System.Drawing.Size(168, 68);
            this.BntQuery.TabIndex = 6;
            this.BntQuery.Text = "查找";
            this.BntQuery.UseVisualStyleBackColor = true;
            this.BntQuery.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TxtEmployCardNum
            // 
            this.TxtEmployCardNum.Location = new System.Drawing.Point(927, 37);
            this.TxtEmployCardNum.Margin = new System.Windows.Forms.Padding(6);
            this.TxtEmployCardNum.Name = "TxtEmployCardNum";
            this.TxtEmployCardNum.Size = new System.Drawing.Size(196, 35);
            this.TxtEmployCardNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "员工卡号";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(1234, 24);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 68);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // TxtEmployId
            // 
            this.TxtEmployId.Location = new System.Drawing.Point(544, 40);
            this.TxtEmployId.Margin = new System.Windows.Forms.Padding(6);
            this.TxtEmployId.Name = "TxtEmployId";
            this.TxtEmployId.Size = new System.Drawing.Size(196, 35);
            this.TxtEmployId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "员工编号";
            // 
            // TxtEmployName
            // 
            this.TxtEmployName.Location = new System.Drawing.Point(184, 40);
            this.TxtEmployName.Margin = new System.Windows.Forms.Padding(6);
            this.TxtEmployName.Name = "TxtEmployName";
            this.TxtEmployName.Size = new System.Drawing.Size(196, 35);
            this.TxtEmployName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工名称";
            // 
            // ColModify
            // 
            this.ColModify.Frozen = true;
            this.ColModify.HeaderText = "";
            this.ColModify.Name = "ColModify";
            this.ColModify.ReadOnly = true;
            this.ColModify.Text = "修改";
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Width = 5;
            // 
            // ColDel
            // 
            this.ColDel.Frozen = true;
            this.ColDel.HeaderText = "";
            this.ColDel.Name = "ColDel";
            this.ColDel.ReadOnly = true;
            this.ColDel.Text = "删除";
            this.ColDel.UseColumnTextForButtonValue = true;
            this.ColDel.Visible = false;
            this.ColDel.Width = 5;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.Frozen = true;
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 40;
            // 
            // EmployId
            // 
            this.EmployId.DataPropertyName = "EmployId";
            this.EmployId.Frozen = true;
            this.EmployId.HeaderText = "员工编号";
            this.EmployId.Name = "EmployId";
            this.EmployId.ReadOnly = true;
            this.EmployId.Width = 151;
            // 
            // EmployName
            // 
            this.EmployName.DataPropertyName = "EmployName";
            this.EmployName.Frozen = true;
            this.EmployName.HeaderText = "员工姓名";
            this.EmployName.Name = "EmployName";
            this.EmployName.ReadOnly = true;
            this.EmployName.Width = 151;
            // 
            // EmployCardNum
            // 
            this.EmployCardNum.DataPropertyName = "EmployCardNum";
            this.EmployCardNum.Frozen = true;
            this.EmployCardNum.HeaderText = "员工卡号";
            this.EmployCardNum.Name = "EmployCardNum";
            this.EmployCardNum.ReadOnly = true;
            this.EmployCardNum.Width = 151;
            // 
            // EmployCardDepartment
            // 
            this.EmployCardDepartment.DataPropertyName = "EmployCardDepartment";
            this.EmployCardDepartment.Frozen = true;
            this.EmployCardDepartment.HeaderText = "员工部门";
            this.EmployCardDepartment.Name = "EmployCardDepartment";
            this.EmployCardDepartment.ReadOnly = true;
            this.EmployCardDepartment.Width = 151;
            // 
            // 员工档案管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmployInfo);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "员工档案管理";
            this.Load += new System.EventHandler(this.员工档案管理_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvEmployInfo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox TxtEmployId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmployName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmployCardNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BntQuery;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployCardNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployCardDepartment;
    }
}
