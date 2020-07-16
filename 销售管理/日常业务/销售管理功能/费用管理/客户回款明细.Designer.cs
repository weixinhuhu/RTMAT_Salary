namespace 销售管理.日常业务.销售管理功能
{
    partial class 客户回款明细
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(客户回款明细));
            this.dgvMoneyReturnList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyReturnList)).BeginInit();
            this.SuspendLayout();
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
            this.ColModify,
            this.CompanyName,
            this.ReturnMoney,
            this.ReturnDate,
            this.Notes});
            this.dgvMoneyReturnList.Location = new System.Drawing.Point(0, 2);
            this.dgvMoneyReturnList.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMoneyReturnList.Name = "dgvMoneyReturnList";
            this.dgvMoneyReturnList.RowHeadersWidth = 82;
            this.dgvMoneyReturnList.RowTemplate.Height = 23;
            this.dgvMoneyReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMoneyReturnList.ShowEditingIcon = false;
            this.dgvMoneyReturnList.Size = new System.Drawing.Size(1300, 368);
            this.dgvMoneyReturnList.TabIndex = 4;
            this.dgvMoneyReturnList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoneyReturnList_CellContentClick);
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
            this.ColDel.Width = 103;
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "修改";
            this.ColModify.MinimumWidth = 10;
            this.ColModify.Name = "ColModify";
            this.ColModify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColModify.Text = "修改";
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Visible = false;
            this.ColModify.Width = 103;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "公司名称";
            this.CompanyName.MinimumWidth = 10;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 151;
            // 
            // ReturnMoney
            // 
            this.ReturnMoney.DataPropertyName = "ReturnMoney";
            this.ReturnMoney.HeaderText = "回款金额";
            this.ReturnMoney.MinimumWidth = 10;
            this.ReturnMoney.Name = "ReturnMoney";
            this.ReturnMoney.Width = 151;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "回款时间";
            this.ReturnDate.MinimumWidth = 10;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Width = 151;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "备注";
            this.Notes.MinimumWidth = 10;
            this.Notes.Name = "Notes";
            this.Notes.Width = 103;
            // 
            // 客户回款明细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.ClientSize = new System.Drawing.Size(1302, 372);
            this.Controls.Add(this.dgvMoneyReturnList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "客户回款明细";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户回款明细";
            this.Load += new System.EventHandler(this.Product3List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyReturnList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoneyReturnList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}