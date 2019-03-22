using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetCardsTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using Soft.Common;

namespace 销售管理.审核
{
    public partial class 无票费用申请审批 : 销售管理.UserControlBase
    {
        public 无票费用申请审批()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            refresh(); 
        }
        /// <summary>
        /// 刷新查询数据
        /// </summary>
        private void refresh() {
            string mSql = @" SELECT a.[Id] ,
                    c.[UserName] ,
                    b.[CompanyName] ,
                    a.[ProjectName] ,
                    a.[SumMoney] ,
                    a.[SalaryDate] ,
                    a.[Status] ,
                    d.UserName[AuditId] ,
                    a.[AuditDate]                
            FROM[dbo].T_NoTicket a
                    LEFT JOIN T_Users c ON a.UserName = c.id
                    LEFT JOIN T_Users d ON a.AuditId = d.id
                    LEFT JOIN dbo.T_Customers b ON a.CustomerName = b.id
            WHERE   1 = 1 and p1='正常'  {0} {1} {2} {3} {4}";//

            string mC1 = "", mC2 = "", mC3 = "", mC4 = "", sDept = "";

            if (cmbUserName.Text != string.Empty)
            {
                mC1 = " and c.username like '%" + cmbUserName.Text + "%'";
            }
         
            if (cmbCustomers.Text != string.Empty)
            {
                mC2 = " and b.companyname like '%" + cmbCustomers.Text + "%'";
            }
           
            if (cmbHasAudit.Text != string.Empty)
            {                               
               mC3 = " and a.Status='" + cmbHasAudit.Text + "'";                               
            }
            if (CBoxDept.Text != string.Empty)
            {
                sDept = " and c.DepartmentName like '%" + CBoxDept.Text + "%'";
            }

            if (dtpStart.Checked == true)
            {
                mC4 = " and a.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
            }

            mSql = string.Format(mSql, mC1, mC2, mC3,mC4, sDept);

            var mTable = SqlHelper.GetData(mSql);

            dgvNoTicketAudit.DataSource = mTable;
            if (mTable.Rows.Count < 1)
            {
                Dlg.ShowOKInfo("没有记录");
                return;
            }
        }

        private void 消费卡申请审核_Load(object sender, EventArgs e)
        {
            cmbUserName.DisplayMember = "Username";
            cmbUserName.ValueMember = "Id";
            cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
            cmbUserName.SelectedIndex = -1;
         
            CBoxDept.DisplayMember = "VcName";          
            CBoxDept.DataSource = SqlHelper.GetData("SELECT DISTINCT DepartmentName VcName FROM T_Users"); ;
            CBoxDept.SelectedIndex = -1;
            cmbHasAudit.SelectedIndex = 0;

    
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedIndex == -1)
            {
                cmbCustomers.DataSource = new T_CustomersTableAdapter().GetData();
                cmbCustomers.SelectedIndex = -1;
            }
            else
            {
                cmbCustomers.DataSource = new T_CustomersTableAdapter().GetDataByUserId(Convert.ToInt64(cmbUserName.SelectedValue));
                cmbCustomers.SelectedIndex = -1;
            }
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认审批通过？", "提示", MessageBoxButtons.YesNo))
            {

                int ret = 0;
                string auditString = "";
                foreach (DataGridViewRow mRow in dgvNoTicketAudit.Rows)
                {
                    if (Convert.ToBoolean(mRow.Cells["ColumnChecked"].Value) == true)
                    {
                        auditString += mRow.Cells["idDataGridViewTextBoxColumn"].Value + ",";
                    }
                }
                auditString = auditString.TrimEnd(',');

                if (auditString == "")
                {
                    Dlg.ShowErrorInfoAndHelp("没有选择要审批的记录");
                    return;
                }

                string mSql = string.Format("UPDATE T_NoTicket SET Status = '{0}',AuditId = '{1}',P2='{3}', AuditDate = GETDATE()  WHERE Id IN ({2})", "审批已通过", Classes.PubClass.UserId, auditString, "未复核");
                ret = SqlHelper.ExecuteNonQuery(mSql);
                if (ret > 0)
                {
                    Dlg.ShowOKInfo("保存成功");
                    //刷新页面
                    refresh();
                }
                else
                {
                    Dlg.ShowErrorInfo("保存失败");
                }

            }
        }

        private void btnAudit2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认审批不通过？", "提示", MessageBoxButtons.YesNo))
            {

                int ret = 0;
                string auditString = "";
                foreach (DataGridViewRow mRow in dgvNoTicketAudit.Rows)
                {
                    if (Convert.ToBoolean(mRow.Cells["ColumnChecked"].Value) == true)
                    {
                        auditString += mRow.Cells["idDataGridViewTextBoxColumn"].Value + ",";
                    }
                }
                auditString = auditString.TrimEnd(',');
                if (auditString == "")
                {
                    Dlg.ShowErrorInfoAndHelp("没有选择要审批的记录");
                    return;
                }

                string mSql = string.Format("UPDATE T_NoTicket SET Status = '{0}',AuditId = '{1}', AuditDate = GETDATE()  WHERE (Id IN ({2}))", "审批未通过", Classes.PubClass.UserId, auditString);

                ret = SqlHelper.ExecuteNonQuery(mSql);
                if (ret > 0)
                {
                    Dlg.ShowOKInfo("保存成功!");

                    //修改页面显示2016.9.6
                    refresh();

                    //foreach (DataGridViewRow mRow in dgvExAllocation.Rows)
                    //{
                    //    if (Convert.ToBoolean(mRow.Cells["ColumnChecked"].Value) == true)
                    //    {
                    //        dgvExAllocation.Rows.Remove(mRow);
                    //    }
                    //}
                }
                else
                {
                    Dlg.ShowErrorInfo("保存失败");
                }

            }
        }

        private void dgvNoTicketAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
