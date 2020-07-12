using System;
using System.Data;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using Common;
using 销售管理.日常业务.销售管理功能;
using 销售管理.DAL.DataSetFeeTypeTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 业务费用管理 : 销售管理.UserControlBase
    {
        public 业务费用管理()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() {
            string mSql;
            mSql = @" SELECT a.[Id]
                  ,c.[UserName]
                  ,b.[CompanyName]
                  ,F.[FeeTypeName]
                  ,a.[Notes]   
                  ,a.[SumFee]   
                  ,a.[CreateDate]
                  ,a.[UpDateDate]
                FROM [dbo].[T_BusinessFee] a        
                LEFT JOIN T_Customers b ON a.CustomerName=b.id
                LEFT JOIN T_Users c ON a.UserName = c.id
                LEFT JOIN T_FeeType f ON a.[FeeType]=f.Id
                WHERE a.Status='正常'";

            if (cmbUserName.Text.Trim() != "")
            {
                mSql += " and  c.UserName like '%" + cmbUserName.Text.Trim() + "%'";
            }

            if (CmbDepartmentName.Text != string.Empty)
            {
                mSql += " and c.DepartmentName ='" + CmbDepartmentName.Text + "'";
            }

            if (cmbFeeType.Text != string.Empty)
            {
                mSql += " and F.FeeTypeName = '" + cmbFeeType.Text + "'";
            }

            if (dtpStart.Checked == true)
            {
                mSql += " and a.CreateDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
            }

            try
            {
                DataTable mTable = SqlHelper.GetData(mSql);
                DataRow mRow = mTable.NewRow();
                mRow["SumFee"] = mTable.Compute("sum(SumFee)", "true");
                mTable.Rows.Add(mRow);
                dgvBusinessFee.DataSource = mTable;
                dgvBusinessFee.Rows[dgvBusinessFee.Rows.Count - 1].Cells["ColDel"] = new DataGridViewTextBoxCell();
                dgvBusinessFee.Rows[dgvBusinessFee.Rows.Count - 1].Cells["ColDel"].Value = "总计";
                dgvBusinessFee.Rows[dgvBusinessFee.Rows.Count - 1].Cells["ColModify"] = new DataGridViewTextBoxCell();
                dgvBusinessFee.Rows[dgvBusinessFee.Rows.Count - 1].Cells["ColModify"].Value = "";

                if ((dgvBusinessFee.DataSource as DataTable).Rows.Count < 0)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void 销售明细管理_Load(object sender, EventArgs e)
        {         
            cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "id";
            cmbUserName.SelectedIndex = -1;

            //获取费用类型
            cmbFeeType.DisplayMember = "FeeTypeName";
            cmbFeeType.ValueMember = "id";
            cmbFeeType.DataSource = new T_FeeTypeTableAdapter().GetFeeTypeName();
            cmbFeeType.SelectedIndex = -1;

            CmbDepartmentName.DisplayMember = "VcName";
            CmbDepartmentName.DataSource = SqlHelper.GetData(" SELECT VcName FROM [dbo].[PTDepartment]"); ;
            CmbDepartmentName.SelectedIndex = -1;

            if (!Common.AuthenticateRight.AuthOperation(111701) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUserName.SelectedValue = Classes.PubClass.UserId;
                cmbUserName.Enabled = false;
            }           
            DateTime dt = DateTime.Now;
            dtpStart.Value = dt.AddMonths(-dt.Month + 1).AddDays(-dt.Day + 1);
        }

        private void dgvSaleDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (业务费用录入 mForm = new 业务费用录入())
            {
                mForm.ShowDialog();
            }
        }

        private void dgvCustomerBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvBusinessFee.Columns["ColModify"].Index)
                {
                    业务费用录入 mForm = new 业务费用录入();
                    mForm.mId = Convert.ToInt64(dgvBusinessFee.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.ShowDialog();
                }

                if (e.ColumnIndex == dgvBusinessFee.Columns["ColDel"].Index)//删除
                {
                    if (MessageBox.Show("确认要删除该条记录吗?", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string mSql = string.Format("UPDATE T_BusinessFee SET Status = '{0}'  WHERE Id = {1}", "删除", Convert.ToInt64(dgvBusinessFee.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                        int ret = SqlHelper.ExecuteNonQuery(mSql);
                        if (ret > 0)
                        {
                            MessageBox.Show("删除成功!");
                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                        }
                        refresh();
                    }
                }
            }
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Classes.ExcelDeport.Deport(dgvBusinessFee, 2);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

