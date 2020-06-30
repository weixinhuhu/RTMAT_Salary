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
    public partial class 销售回款管理 : 销售管理.UserControlBase
    {
        public 销售回款管理()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            mSql = @"SELECT  Temp.UserName UserName ,
                    Temp.CompanyName CompanyName ,
                    历史欠款金额 ,
                    总发货金额 ,
                    已回款金额 ,
		            (历史欠款金额+总发货金额-已回款金额) as  剩余欠款金额
            FROM    ( SELECT    b.UserName ,
                                a.CompanyName ,
                                ISNULL(c.Total_Arrears, 0) AS 历史欠款金额 ,
                                ISNULL(SUM(SumMoney), 0) AS 总发货金额 ,
                                ISNULL(SUM(e.ReturnMoney), 0) AS 已回款金额                   
                      FROM      T_Customers a
                                LEFT JOIN dbo.T_Users b ON a.OperName = b.id
                                LEFT JOIN dbo.T_Customers_billsdue c ON c.CompanyName = a.CompanyName
                                LEFT JOIN dbo.T_SaleDetails d ON  a.id =d.CustomerName 
					            AND d.SaleDate>='2018-1-1'
                                LEFT JOIN dbo.T_Customers_MoneyReturnList e ON a.CompanyName = e.CompanyName 
			            WHERE a.Status	='正常'		
                      GROUP BY  a.CompanyName ,
                                b.UserName ,
                                Total_Arrears
                    ) Temp
            WHERE   
                     (历史欠款金额+总发货金额-已回款金额) != 0 ";
            
            if (!Common.AuthenticateRight.AuthOperation(110301) && Common.CommonClass.SttUser.blSuperUser == false)
            {
                mSql += @" and UserName='" + Classes.PubClass.UserName + "'";
            }
            else if (cmbUserName.Text.Trim() != "")
            {
                mSql += " and UserName like '%" + cmbUserName.Text.Trim() + "%'";
            }

            if (txtCusName.Text.Trim() != "")
            {
                mSql += " and CompanyName like '%" + txtCusName.Text.Trim() + "%'";
            }

            //if (dtp1.Checked == true)
            //{
            //    mSql += " and a.SaleDate between '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59'";
            //}
          
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvCustomerBills.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void 销售明细管理_Load(object sender, EventArgs e)
        {         
            cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "id";
            cmbUserName.SelectedIndex = -1;
            if (!Common.AuthenticateRight.AuthOperation(110301) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUserName.SelectedValue = Classes.PubClass.UserId;
                cmbUserName.Enabled = false;
            }
           
            
            DateTime dt = DateTime.Now;
            dtp1.Value = dt.AddMonths(-dt.Month + 1).AddDays(-dt.Day + 1);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (销售明细录入 mForm = new 销售明细录入())
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
            using (销售回款录入 mForm = new 销售回款录入())
            {
                mForm.ShowDialog();
            }
        }

        private void dgvCustomerBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          if (e.RowIndex >= 0) { 
            if (dgvCustomerBills.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString() == "客户回款明细查看")
            {
                if (dgvCustomerBills.Rows[e.RowIndex].Cells["CompanyName"].FormattedValue.ToString() != "")
                {
                   CommonClass.CompanyName = dgvCustomerBills.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                   客户回款明细 mForm = new 客户回款明细();                     
                   mForm.ShowDialog();
                }                                                                           
            }
          }
        }
    }
}
