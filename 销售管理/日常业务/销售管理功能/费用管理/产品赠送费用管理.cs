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
    public partial class 产品赠送费用管理 : 销售管理.UserControlBase
    {
        public 产品赠送费用管理()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() {
            string mSql;
            mSql = @"SELECT  a.Id ,
                    c.UserName ,
                    e.CompanyName ,
                    a.SaleDate ,
                    d.Name AS ProductName ,
                    a.Amount ,
                    a.Price ,
                    a.SumMoney ,
		            a.Unit,
		            a.StockOutNo        
            FROM    dbo.T_ProductSend a
                    LEFT JOIN T_Users c ON a.UserName = c.id
                    LEFT JOIN T_Products d ON a.productName = d.Id
                    LEFT JOIN T_Customers e ON a.CustomerName = e.id
            WHERE   a.Status='正常' ";
            if (cmbUserName.Text.Trim() != "")
            {
                mSql += " and c.UserName like '%" + cmbUserName.Text.Trim() + "%'";
            }

            if (txtCusName.Text.Trim() != "")
            {
                mSql += " and e.CompanyName like '%" + txtCusName.Text.Trim() + "%'";
            }

            if (dtp1.Checked == true)
            {
                mSql += " and a.SaleDate between '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59'";
            }
            if (txtProductName.Text.Trim() != "")
            {
                mSql += " and d.Name like '%" + txtProductName.Text.Trim() + "%'";
            }
            if (CmbDepartmentName.Text != string.Empty)
            {
                mSql += "and c.DepartmentName ='" + CmbDepartmentName.Text + "'";
            }

            try
            {
                DataTable mTable = SqlHelper.GetData(mSql);
                DataRow mRow = mTable.NewRow();
                mRow["SumMoney"] = mTable.Compute("sum(SumMoney)", "true");
                mTable.Rows.Add(mRow);
                dgvProductSend.DataSource = mTable;
                dgvProductSend.Rows[dgvProductSend.Rows.Count - 1].Cells["ColDel"] = new DataGridViewTextBoxCell();
                dgvProductSend.Rows[dgvProductSend.Rows.Count - 1].Cells["ColDel"].Value = "总计";
                dgvProductSend.Rows[dgvProductSend.Rows.Count - 1].Cells["ColModify"] = new DataGridViewTextBoxCell();
                dgvProductSend.Rows[dgvProductSend.Rows.Count - 1].Cells["ColModify"].Value = "";

                if ((dgvProductSend.DataSource as DataTable).Rows.Count < 0)
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
            //按配置权限显示数据
            if (Common.AuthenticateRight.AuthOperation(111401) || CommonClass.SttUser.blSuperUser) //查看全部
            {
                cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.ValueMember = "id";
                cmbUserName.SelectedIndex = -1;

                CmbDepartmentName.DisplayMember = "VcName";
                CmbDepartmentName.DataSource = SqlHelper.GetData(" SELECT VcName FROM [dbo].[PTDepartment]");
                CmbDepartmentName.SelectedIndex = -1;
            }
            else if (Common.AuthenticateRight.AuthOperation(111402)) //查看销售
            {
                cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.ValueMember = "id";
                cmbUserName.SelectedIndex = -1;

                CmbDepartmentName.DisplayMember = "VcName";
                CmbDepartmentName.DataSource = SqlHelper.GetData(" SELECT VcName FROM [dbo].[PTDepartment] WHERE VcName LIKE '%销售%' ");
                CmbDepartmentName.SelectedIndex = -1;
            }
            else
            {//普通销售人员
                cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.ValueMember = "id";
                cmbUserName.SelectedValue = Classes.PubClass.UserId;
                cmbUserName.Enabled = false;

                CmbDepartmentName.Text = SqlHelper.ExecuteScalar(" SELECT DepartmentName FROM [dbo].[T_Users] where id=" + Classes.PubClass.UserId).ToString();
                CmbDepartmentName.Enabled = false;

            }

            DateTime dt = DateTime.Now;
            dtp1.Value = dt.AddMonths(-dt.Month + 1).AddDays(-dt.Day + 1);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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
            using (产品赠送明细录入 mForm = new 产品赠送明细录入())
            {
                mForm.ShowDialog();
            }
        }

        private void dgvCustomerBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvProductSend.Columns["ColModify"].Index)
                {
                    产品赠送明细维护 mForm = new 产品赠送明细维护();
                    mForm.mId = Convert.ToInt64(dgvProductSend.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.ShowDialog();
                }

                if (e.ColumnIndex == dgvProductSend.Columns["ColDel"].Index)//删除
                {
                    if (MessageBox.Show("确认要删除该条记录吗?", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string mSql = string.Format("UPDATE T_ProductSend SET Status = '{0}'  WHERE Id = {1}", "删除",  Convert.ToInt64(dgvProductSend.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                        int  ret = SqlHelper.ExecuteNonQuery(mSql);
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
            Classes.ExcelDeport.Deport(dgvProductSend, 2);
        }
    }
}
