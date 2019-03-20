using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetSaleDetailsTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using Common;
using 销售管理.日常业务.销售管理功能;
namespace 销售管理.日常业务
{
    public partial class 无票费用管理 : 销售管理.UserControlBase
    {
        public 无票费用管理()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() {

            string mSql;
            mSql = @" SELECT  a.[Id] ,
                    c.[UserName] ,
                    b.[CompanyName] ,
                    a.[ProjectName] ,
                    a.[SumMoney] ,
                    a.[SalaryDate] ,
                    a.[Status] ,
                    d.UserName [AuditId] ,
                    a.[AuditDate]
            FROM    [dbo].T_NoTicket a
                    LEFT JOIN T_Users c ON a.UserName = c.id
                    LEFT JOIN T_Users d ON a.AuditId = d.id
                    LEFT JOIN dbo.T_Customers b ON a.CustomerName = b.id
            WHERE   1 = 1 and P1='正常'";

            if (cmbUserName.Text.Trim() != "")
            {
                mSql += " and c.UserName like '%" + cmbUserName.Text.Trim() + "%'";
            }

            if (txtCusName.Text.Trim() != "")
            {
                mSql += " and CompanyName like '%" + txtCusName.Text.Trim() + "%'";
            }

            if (CmbDepartmentName.Text != string.Empty)
            {
                mSql += " and c.DepartmentName ='" + CmbDepartmentName.Text + "'";
            }

            if (TxtPorjectName.Text != string.Empty)
            {
                mSql += " and a.ProjectName like '%" + TxtPorjectName.Text + "%'";
            }

            if (cmbStatus.Text != string.Empty)
            {
                mSql += " and a.Status  like '%" + cmbStatus.Text.Trim() + "%'";
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
                dgvNoTicket.DataSource = mTable;
                dgvNoTicket.Rows[dgvNoTicket.Rows.Count - 1].Cells["ColDel"] = new DataGridViewTextBoxCell();
                dgvNoTicket.Rows[dgvNoTicket.Rows.Count - 1].Cells["ColDel"].Value = "总计";
                dgvNoTicket.Rows[dgvNoTicket.Rows.Count - 1].Cells["ColModify"] = new DataGridViewTextBoxCell();
                dgvNoTicket.Rows[dgvNoTicket.Rows.Count - 1].Cells["ColModify"].Value = "";
                if ((dgvNoTicket.DataSource as DataTable).Rows.Count < 0)
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


            if (!Common.AuthenticateRight.AuthOperation(110301) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUserName.SelectedValue = Classes.PubClass.UserId;
                cmbUserName.Enabled = false;
            }
            
            DateTime dt = DateTime.Now;
            dtpStart.Value = dt.AddMonths(-dt.Month + 1).AddDays(-dt.Day + 1);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (产品赠送明细录入 mForm = new 产品赠送明细录入())
            {
                mForm.ShowDialog();
            }

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
            using (无票费用录入 mForm = new 无票费用录入())
            {
                mForm.ShowDialog();
            }
        }

        private void dgvCustomerBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (dgvNoTicket.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "未审核")
                {
                    if (e.ColumnIndex == dgvNoTicket.Columns["ColModify"].Index)//修改
                    {

                        无票费用录入 mForm = new 无票费用录入();
                        mForm.mId = Convert.ToInt64(dgvNoTicket.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                        mForm.ShowDialog();

                    }
                    if (e.ColumnIndex == dgvNoTicket.Columns["ColDel"].Index)//删除
                    {
                        if (MessageBox.Show("确认要删除该条记录吗?", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (dgvNoTicket.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "未审核")
                            {
                                string mSql = string.Format("UPDATE T_NoTicket SET P1 = '{0}'  WHERE Id = {1}", "删除", Convert.ToInt64(dgvNoTicket.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
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
            }
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Classes.ExcelDeport.Deport(dgvNoTicket, 3);
        }
    }
}
