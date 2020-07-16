using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetUsersTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 费用分配审核_财务 : 销售管理.UserControlBase
    {
        public 费用分配审核_财务()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql;
           
            mSql = @"SELECT type,
                           a.Id,
                           a.Month,
                           b.UserName,
                           a.TableNo,
                           e.CompanyName AS CustomerName,
                           a.ProjectName,
                           p.Name AS ProductName,
                           pt.Name ProductType,
                           a.Amount,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.DeliverPrice, 0)) DeliverPrice,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.DeliverSum, 0)) DeliverSum,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.SalePrice, 0)) SalePrice,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.SaleSum, 0)) SaleSum,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.DepartSum, 0)) DepartSum,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.SaleWages, 0)) SaleWages,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.CommissionPrice, 0)) CommissionPrice,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.CommissionSum, 0)) CommissionSum,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.SaleComission, 0)) SaleComission,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.AgentPrice, 0)) AgentPrice,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.AgentSum, 0)) AgentSum,
                           CONVERT(DECIMAL(20, 2), ISNULL(a.AgentCommission, 0)) AgentCommission,
                           a.IsPaid,
                           a.PaidDate,
                           a.Status,
                           c.UserName AS BusinessAudit,
                           a.BusinessDate,
                           a.BusinessRemark,
                           d.UserName AS FinanceAudit,
                           a.FinanceDate,
                           a.FinanceRemark,
                           a.LeaderAudit,
                           a.LeaderDate,
                           a.LeaderRemark,
                           a.RecDate,
                           a.SaleDetailsId,
                           cs.UserName citysaler,
                           a.CitySum,
                           a.CityWages,
                           a.CitySalePrice,
                           a.CitySaleSum,
                           a.CitySaleCommission
                    FROM T_ExpenseAllocation a
                        LEFT JOIN T_Users b
                            ON a.UserName = b.id
                        LEFT JOIN T_Users c
                            ON a.BusinessAudit = c.id
                        LEFT JOIN T_Users d
                            ON a.FinanceAudit = d.id
                        LEFT JOIN T_Customers e
                            ON a.CustomerName = e.id
                        LEFT JOIN T_Products p
                            ON a.ProductName = p.Id
                        LEFT JOIN T_Products pt
                            ON p.ParentId = pt.Id
                        LEFT JOIN T_Users cs
                            ON cs.id = a.CitySaler  ";

            if (cmbHasAudit.Text == "未审核")
            {
                mSql += "  where a.status = '客服已确认等待财务审核'";
                dgvExAllocation.Columns["ColAudit"].Visible = true;
                dgvExAllocation.Columns["ColAudit1"].Visible = true;
            }
            else
            {
                mSql += "  where a.financeaudit is not null";
                dgvExAllocation.Columns["ColAudit"].Visible = false;
                dgvExAllocation.Columns["ColAudit1"].Visible = false;
            }

            if (cmbUserName.Text != "")
            {
                mSql += " and b.username like '%" + cmbUserName.Text + "%'";
            }
            if (txtTableNo.Text != "")
            {
                mSql += " and tableno like '%" + txtTableNo.Text + "%'";
            }
            if (txtCustomerName.Text != "")
            {
                mSql += " and e.CompanyName like '%" + txtCustomerName.Text + "%'";
            }
            if (txtProductName.Text != "")
            {
                mSql += " and p.name like '%" + txtProductName.Text + "%'";
            }

            if (!String.IsNullOrEmpty(cmbType.Text))
            {
                if (cmbType.Text != "全部") 
                {
                    mSql += " and a.type ='" + cmbType.Text + "'";
                }
            }

            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();

            try
            {
                adapter.Fill(mTable);
                dgvExAllocation.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 费用分配审核_财务_Load(object sender, EventArgs e)
        {
            dgvExAllocation.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dgvExAllocation, true, null);
            cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.SelectedIndex = -1;
            cmbHasAudit.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
        }

        private void dgvExAllocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvExAllocation.Columns["ColAudit"].Index)
                {
                    if (DialogResult.Yes == MessageBox.Show("确认审核通过？", "提示", MessageBoxButtons.YesNo))
                    {
                        var status = "财务已审核等待领导审核";
                        if (Convert.ToDecimal(dgvExAllocation.Rows[e.RowIndex].Cells["agentSumDataGridViewTextBoxColumn"].Value) > 0)
                        {
                            status = "财务已审核等待领导审核";
                        }
                        else
                        {
                            status = "领导审核通过";
                        }
                        int ret = t_ExpenseAllocationTableAdapter.UpdateFinanceAudit(status, Classes.PubClass.UserId, "", Convert.ToInt64(dgvExAllocation.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                        if (ret > 0)
                        {
                            MessageBox.Show("提交成功");
                            dgvExAllocation.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("提交失败");
                        }
                    }
                }
                if (e.ColumnIndex == dgvExAllocation.Columns["ColAudit1"].Index)
                {
                    if (DialogResult.Yes == MessageBox.Show("确认审核不通过？", "提示", MessageBoxButtons.YesNo))
                    {                 
                        int ret = t_ExpenseAllocationTableAdapter.UpdateFinanceAudit("财务审核不通过", Classes.PubClass.UserId, "", Convert.ToInt64(dgvExAllocation.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                        if (ret > 0)
                        {
                            MessageBox.Show("提交成功");
                            dgvExAllocation.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("提交失败");
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvExAllocation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                using (申请费用分配1 mForm = new 申请费用分配1())
                {
                    mForm.mRow = dgvExAllocation.Rows[e.RowIndex];
                    mForm.ExId = Convert.ToInt64(dgvExAllocation.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.ShowDialog();
                }
            }
        }
    }
}
