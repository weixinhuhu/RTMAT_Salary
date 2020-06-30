using System;
using System.Data;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using Common;
using 销售管理.日常业务.销售管理功能;
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
            string mSql;         
            mSql = @" SELECT a.[Id]
                  ,c.[UserName]
                  ,a.[ProjectName]               
                  ,a.[SumMoney]
                  ,a.[SalaryDate]
                FROM [dbo].[T_AdvertisingFee] a
                LEFT JOIN T_Users c ON a.UserName = c.id
                WHERE 1=1";

            if (cmbUserName.Text.Trim() != "")
            {
                mSql += " and UserName like '%" + cmbUserName.Text.Trim() + "%'";
            }

            if (CmbDepartmentName.Text != string.Empty)
            {
                mSql += " and c.DepartmentName ='" + CmbDepartmentName.Text + "'";
            }

            if (TxtPorjectName.Text != string.Empty)
            {
                mSql += " and a.ProjectName like '%" + TxtPorjectName.Text + "%'";
            }

            if (dtpStart.Checked == true)
            {
                mSql += " and a.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
            }

            try
            {
                DataTable mTable = SqlHelper.GetData(mSql);
                DataRow mRow = mTable.NewRow();
                mRow["SumMoney"] = mTable.Compute("sum(SumMoney)", "true");
                mTable.Rows.Add(mRow);
                dgvAdvertisingFee.DataSource = mTable;
                dgvAdvertisingFee.Rows[dgvAdvertisingFee.Rows.Count - 1].Cells["ColModify"] = new DataGridViewTextBoxCell();
                dgvAdvertisingFee.Rows[dgvAdvertisingFee.Rows.Count - 1].Cells["ColModify"].Value = "总计";

                if ((dgvAdvertisingFee.DataSource as DataTable).Rows.Count < 0)
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
                if (e.ColumnIndex == dgvAdvertisingFee.Columns["ColModify"].Index)
                {
                    业务费用录入 mForm = new 业务费用录入();
                    mForm.mId = Convert.ToInt64(dgvAdvertisingFee.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.ShowDialog();
                }
            }
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Classes.ExcelDeport.Deport(dgvAdvertisingFee, 2);
        }
    }
    }

