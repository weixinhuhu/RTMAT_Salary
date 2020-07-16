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
using 销售管理.DAL.DataSetCustomersTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 销售回款管理1 : 销售管理.UserControlBase
    {
        public 销售回款管理1()
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
                                ISNULL(SUM(ReturnMoney), 0) AS 已回款金额                   
                      FROM      T_Customers a
                                LEFT JOIN dbo.T_Users b ON a.OperName = b.id
                                LEFT JOIN dbo.T_Customers_billsdue c ON c.CompanyName = a.CompanyName
                                LEFT JOIN dbo.T_SaleDetails d ON  a.id =d.CustomerName         
                                LEFT JOIN dbo.T_Customers_MoneyReturnList e ON a.CompanyName = e.CompanyName AND e.Status='正常'
			            WHERE a.Status	='正常'	
                      GROUP BY  a.CompanyName ,
                                b.UserName ,
                                Total_Arrears
                    ) Temp 
            WHERE 1=1 ";

            if (!Common.AuthenticateRight.AuthOperation(110301) && Common.CommonClass.SttUser.blSuperUser == false)
            {
                mSql += @" and UserName='" + Classes.PubClass.UserName + "'";
            }
            else if (cmbUserName.Text.Trim() != "查询所有")
            {
                mSql += " and UserName like '%" + cmbUserName.Text.Trim() + "%'";
            }

            if (txtCustomer.Text.Trim() != "")
            {
                mSql += " and CompanyName like '%" + txtCustomer.Text.Trim() + "%'";
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
            //获取销售列表
            var mTable1 = new T_UsersTableAdapter().GetSalers();
            foreach (销售管理.DAL.DataSetUsers.T_UsersRow mRow in mTable1.Rows)
            {
                cmbUserName.Items.Add(new Classes.PubClass.MyCmbList(mRow.id, mRow.UserName));
            }
            cmbUserName.Items.Insert(0, "查询所有");
            cmbUserName.SelectedIndex = 0;

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
            DataTable mTable = null;
            if (cmbUserName.SelectedIndex > 0)
            {
                long saleId = ((销售管理.Classes.PubClass.MyCmbList)cmbUserName.SelectedItem).Id;
                mTable = new T_CustomersTableAdapter().GetDataByUserId(saleId);
            }
            else
            {
                mTable = new T_CustomersTableAdapter().GetData();
            }
            txtCustomer.DataSource = mTable;
            txtCustomer.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (销售回款录入 mForm = new 销售回款录入())
            {
                mForm.ShowDialog();
            }
        }

        private void getMoneyReturnList()
        {


        }

        private void dgvCustomerBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCustomerBills.Rows[e.RowIndex].Cells["CompanyName"].FormattedValue.ToString() != "")
                {
                    string mSql;
                    mSql = @"SELECT a.Id,
                                   a.UserName UserName,        
                                   b.CompanyName CompanyName,
                                   c.Name ProductName,
                                   a.Amount,
                                   CONVERT(DECIMAL(18, 2), ISNULL(a.Price, 0)) Price,
                                   CONVERT(DECIMAL(18, 2), ISNULL(a.SumMoney, 0)) SumMoney,
                                   a.SaleDate,
                                   a.SettlementModes,
                                   a.ExpDate,
                                   CONVERT(DECIMAL(18, 2), ISNULL(a.SumMoney, 0))
                                           - CONVERT(DECIMAL(18, 2),
                                                     ISNULL(
                                                     (
                                                         SELECT SUM(ReturnMoney)
                                                         FROM dbo.T_Customers_MoneyReturnList
                                                         WHERE Status = '正常'
                                                               AND SaleDetailsId = a.Id
                                                     ),
                                                     0
                                                           )
                                                    ) '项目剩余欠款'
                    FROM dbo.T_SaleDetails a
                        LEFT JOIN dbo.T_Customers b
                            ON a.CustomerName = b.id
                        LEFT JOIN dbo.T_Products c
                            ON a.ProductName = c.Id
                    WHERE 
                    CompanyName= " + "'" + dgvCustomerBills.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString() + "' " +
                    "and Status='正常' ";
                    SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
                    SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
                    DataTable mTable = new DataTable();
                    try
                    {
                        adapter.Fill(mTable);
                        dgvMoneyReturnList.DataSource = mTable;
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
            }
        }

        private void dgvCustomerBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvMoneyReturnList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvMoneyReturnList.Columns["ColRecode"].Index)
                {
                    销售回款录入1 mForm = new 销售回款录入1();
                    mForm.SaleDetailsId = Convert.ToInt64(dgvMoneyReturnList.Rows[e.RowIndex].Cells["id"].Value);
                    mForm.CompanyName = dgvMoneyReturnList.Rows[e.RowIndex].Cells["公司名称"].Value.ToString();
                    mForm.Username = dgvMoneyReturnList.Rows[e.RowIndex].Cells["销售员"].Value.ToString();
                    mForm.ShowDialog();
                    btnSerch_Click(sender, e);
                }

                if (e.ColumnIndex == dgvMoneyReturnList.Columns["ColDetails"].Index)
                {                   
                    客户回款明细 mForm = new 客户回款明细();
                    mForm.SaleDetailsId = Convert.ToInt64(dgvMoneyReturnList.Rows[e.RowIndex].Cells["id"].Value);
                    mForm.ShowDialog();
                    btnSerch_Click(sender, e);
                }

            }
        }
    }
}
