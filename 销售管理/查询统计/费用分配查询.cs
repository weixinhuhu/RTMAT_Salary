using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using System.Data.SqlClient;
using System.IO;
using NPOI.SS.UserModel;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using Common;

namespace 销售管理.查询统计
{
    public partial class 费用分配查询 : 销售管理.UserControlBase
    {
        public 费用分配查询()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mSql = "", mSql1 = "", mSql2 = "", mSql3 = "";
            if (rbDetails.Checked == true)
            {
                mSql = @"SELECT b.UserName 销售员,
                               a.TableNo 费用分配表号,
                               cu.CompanyName 客户名称,
                               c.Name 产品名称,
                               pt.Name 产品类型,
                               a.Amount 数量,
                               CONVERT(DECIMAL(18, 2), a.DeliverPrice) 发货单价,
                               CONVERT(DECIMAL(18, 2), a.DeliverSum) 发货额,
                               CONVERT(DECIMAL(18, 2), a.SalePrice) 实际单价,
                               CONVERT(DECIMAL(18, 2), a.SaleComission) 销售提成,
                               CONVERT(DECIMAL(18, 2), a.AgentSum) 佣金,
                               CONVERT(DECIMAL(18, 2), a.AgentCommission) 税后佣金,
                               a.IsPaid 是否付佣金,
                               a.PaidDate 付款日期,
                               a.Status 状态,
                               ts.SaleDate 销售日期,
                               a.RecDate 提交日期,
                               a.type 订单类型
                        FROM T_ExpenseAllocation a
                            LEFT JOIN T_Users b
                                ON a.UserName = b.id
                            LEFT JOIN T_Products c
                                ON a.ProductName = c.Id
                            LEFT JOIN T_Products pt
                                ON c.ParentId = pt.Id
                            LEFT JOIN T_Users d
                                ON a.CitySaler = d.id
                            LEFT JOIN T_Customers cu
                                ON cu.id = a.CustomerName
                            LEFT JOIN T_SaleDetails ts
                                ON a.SaleDetailsId = ts.Id
                        WHERE a.Status = '领导审核通过'";

                mSql2 = @"UNION ALL
                        SELECT '总计',
                               NULL,
                               NULL,
                               NULL,
                               NULL,
                               NULL,
                               NULL,
                               CONVERT(DECIMAL(18, 2), SUM(DeliverSum)),
                               NULL,
                               CONVERT(DECIMAL(18, 2), SUM(SaleComission)),
                               SUM(t.AgentSum),
                               CONVERT(DECIMAL(18, 2), SUM(AgentCommission)),
                               NULL,
                               NULL,
                               NULL,
                               NULL,
                               NULL,
                               NULL
                        FROM T_ExpenseAllocation t,
                             T_SaleDetails ts,
                        (
                            SELECT MAX(CitySaler) citysaler,
                                   SUM(CitySum) citysum,
                                   SUM(CityWages) cityWages,
                                   SUM(CitySaleSum) citysalesum,
                                   SUM(CitySaleCommission) citysalecommission
                            FROM T_ExpenseAllocation a,
                                 T_SaleDetails ts,
                                 T_Products c
                            WHERE c.Id = a.ProductName
                                  AND a.SaleDetailsId = ts.Id
                                  AND a.Status = '领导审核通过' ";
                mSql1 = ") b,t_products c where t.productname = c.id and t.saledetailsid = ts.id and t.Status='领导审核通过'";// t.username =b.citysaler and 
            }
            else if (rbUserSum.Checked == true)
            {
                mSql = @"SELECT b.UserName AS 销售员, Convert(decimal(18,2),a_1.DeliverSum) AS 发货额, Convert(decimal(18,2),a_1.SaleSum) AS 个销售额, 
      Convert(decimal(18,2),a_1.DepartSum) AS 部门销售额, Convert(decimal(18,2),a_1.SaleWages) AS 销售工资, 
      Convert(decimal(18,2),c.citysum) AS 跨区销售额, Convert(decimal(18,2),c.cityWages) AS 跨区销售工资, 
      Convert(decimal(18,2),a_1.CommissionSum) AS 提成销售额, Convert(decimal(18,2),a_1.SaleComission) AS 销售提成, 
      Convert(decimal(18,2),a_1.AgentSum) AS 代理商额度, Convert(decimal(18,2),a_1.AgentCommission) AS 代理商税后佣金
FROM T_Users AS b LEFT OUTER JOIN
          (SELECT t.UserName AS username, SUM(DeliverSum) AS DeliverSum, 
               SUM(SaleSum) AS SaleSum, SUM(DepartSum) AS DepartSum, 
               SUM(SaleWages) AS SaleWages, SUM(CommissionSum) 
               AS CommissionSum, SUM(SaleComission) AS SaleComission, 
               SUM(AgentSum) AS AgentSum, SUM(AgentCommission) 
               AS AgentCommission
         FROM T_ExpenseAllocation t,t_saledetails ts
         WHERE (Status = '领导审核通过') and t.saledetailsid = ts.id";
                mSql2 = @" GROUP BY t.UserName) AS a_1 ON a_1.username = b.id LEFT OUTER JOIN
          (SELECT CitySaler, SUM(CitySum) AS citysum, SUM(CityWages) 
               AS cityWages
         FROM T_ExpenseAllocation AS T_ExpenseAllocation_1,t_saledetails ts
         WHERE (Status = '领导审核通过') and T_ExpenseAllocation_1.saledetailsid = ts.id";
                mSql3 = @" GROUP BY CitySaler) AS c ON b.id = c.CitySaler
WHERE b.operright = '销售' ";
                mSql1 = @" UNION ALL
SELECT '总计' AS Expr1, SUM(DeliverSum) AS Expr2, SUM(SaleSum) AS Expr3, 
      SUM(DepartSum) AS Expr4, SUM(SaleWages) AS Expr5, SUM(CitySum) AS Expr6, 
      SUM(CityWages) AS Expr7, SUM(CommissionSum) AS Expr8, SUM(SaleComission) 
      AS Expr9, SUM(AgentSum) AS Expr10, SUM(AgentCommission) AS Expr11
FROM T_ExpenseAllocation AS a ,t_saledetails ts
WHERE (Status = '领导审核通过') and a.saledetailsid = ts.id";
            }
            else
            {
                mSql = @"SELECT min(b.UserName) 销售员,  sum(DeliverSum) 发货额,  sum(SaleSum) 个销售额,sum(DepartSum) 部门销售额 FROM  T_ExpenseAllocation a left join T_Users b on a.UserName=b.id left join t_saledetails ts on a.saledetailsid = ts.id where Status='领导审核通过'";
                mSql1 = @" group by a.username union all SELECT '部门总销售额', null,null,sum(SaleSum)+sum(departsum) FROM T_ExpenseAllocation a,t_saledetails ts where a.saledetailsid = ts.id and Status='领导审核通过'";
            }


            if (cmbUsername.Text != "查询所有" && rbDetails.Checked == true)
            {
                mSql += " and (a.username = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "' or a.CitySaler = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "' )";
                mSql1 += " and t.username = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "'";
                mSql2 += " and citysaler = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "'";
            }

            if (txtProductName.Text.Trim() != "" && rbDetails.Checked == true)
            {
                mSql += " and c.name like '%" + txtProductName.Text.Trim().Replace(" ", "%") + "%'";
                mSql1 += " and c.name like '%" + txtProductName.Text.Trim().Replace(" ", "%") + "%'";
                mSql2 += " and c.name like '%" + txtProductName.Text.Trim().Replace(" ", "%") + "%'";
            }

            if (cbDate.Checked == true)
            {
                mSql += @" and ts.saleDate between '" + dtpStart.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";

                mSql1 += @" and ts.saleDate between '" + dtpStart.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";
                mSql2 += @" and ts.saleDate between '" + dtpStart.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";

            }


            //+加订单类型
            if (cmbType.Text != "查询所有")
            {
                mSql += " and type='" + cmbType.Text + "'";
                mSql1 += " and type='" + cmbType.Text + "'";
                mSql2 += " and type='" + cmbType.Text + "'";
            }
            if (cmbYongJin.Text != "全部" && cmbYongJin.Text != "")
            {
                mSql += " and ispaid='" + cmbYongJin.Text + "'";
                mSql1 += " and ispaid='" + cmbYongJin.Text + "'";
                mSql2 += " and ispaid='" + cmbYongJin.Text + "'";
            }

            if (cmbCompanyName.Text != "" && cmbCompanyName.Text != "全部" && rbDetails.Checked == true)
            {
                mSql += " and  a.customername = " + cmbCompanyName.SelectedValue.ToString();
                mSql1 += " and t.customername = " + cmbCompanyName.SelectedValue.ToString();
                mSql2 += " and a.customername = " + cmbCompanyName.SelectedValue.ToString(); ;
            }
            ////加权限
            //if (!(Classes.PubClass.UserRight == "领导" || Classes.PubClass.UserRight == "超级管理员" || Classes.PubClass.UserRight == "商务经理"))
            //{
            //    mSql += " and a.username = " + Classes.PubClass.UserId;
            //    mSql1 += " and username = " + Classes.PubClass.UserId;
            //}
            if (rbDepartSum.Checked == true)
            {
                mSql += mSql1;
            }
            else
            {
                mSql += mSql2 + mSql3 + mSql1;
            }

            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();

            try
            {
                adapter.Fill(mTable);
                dgvReport.DataSource = null;
                dgvReport.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 费用分配查询_Load(object sender, EventArgs e)
        {
            rbDetails.Checked = true;
            var mTable1 = new T_UsersTableAdapter().GetSalers();
            foreach (销售管理.DAL.DataSetUsers.T_UsersRow mRow in mTable1.Rows)
            {
                cmbUsername.Items.Add(new Classes.PubClass.MyCmbList(mRow.id, mRow.UserName));
            }
            cmbUsername.Items.Insert(0, "查询所有");
            cmbUsername.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;

            cmbCompanyName.ValueMember = "Id";
            cmbCompanyName.DisplayMember = "CompanyName";
            DataTable mTable = new T_CustomersTableAdapter().GetData();
            销售管理.DAL.DataSetCustomers.T_CustomersRow mDataRow = (销售管理.DAL.DataSetCustomers.T_CustomersRow)mTable.NewRow();
            mDataRow.id = 0;
            mDataRow.CompanyName = "全部";
            mTable.Rows.InsertAt(mDataRow, 0);
            cmbCompanyName.DataSource = mTable;

            if (!Common.AuthenticateRight.AuthOperation(140201) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUsername.SelectedIndex = cmbUsername.FindStringExact(Classes.PubClass.UserName);
                cmbUsername.Enabled = false;
                rbUserSum.Visible = false;
                rbDepartSum.Visible = false;
            }

        }

        private void rbUserSum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUserSum.Checked == true)
            {
                cmbUsername.Enabled = false;
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDetails.Checked == true)
            {
                if (!Common.AuthenticateRight.AuthOperation(140201) && !CommonClass.SttUser.blSuperUser)
                {
                }
                else
                {
                    cmbUsername.Enabled = true;
                }
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;

                DataGridView mView = dgvReport;

                //添加标头
                IRow mRow = mSheet.CreateRow(0);
                for (i = 0; i <= mView.Columns.Count - 1; i++)
                {
                    mCell = mRow.CreateCell(i);
                    mCell.SetCellValue(mView.Columns[i].HeaderText);
                    mCell.CellStyle = styleRight;
                }
                //添加内容

                for (i = 1; i <= mView.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i);
                    for (j = 0; j <= mView.Columns.Count - 1; j++)
                    {
                        mCell = mRow.CreateCell(j);

                        if (Classes.PubFunc.IsNumber(Convert.ToString(mView.Rows[i - 1].Cells[j].Value)) == true)
                        {
                            mCell.SetCellValue(Convert.ToDouble(mView.Rows[i - 1].Cells[j].Value));
                        }
                        else
                        {
                            mCell.SetCellValue(Convert.ToString(mView.Rows[i - 1].Cells[j].Value));
                        }
                        mCell.CellStyle = styleRight;

                    }
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = "费用分配-" + DateTime.Now.ToString("yyyyMMddhhmmss");
                if (mDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream mFile = mDialog.OpenFile();
                    mWorkbook.Write(mFile);
                    mFile.Close();
                    MessageBox.Show("保存成功！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void rbDepartSum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCompanyName.DisplayMember = "CompanyName";
            cmbCompanyName.ValueMember = "Id";
            DataTable mTable;
            if (cmbUsername.Text != "查询所有" && cmbUsername.Text != "")
            {
                mTable = new T_CustomersTableAdapter().GetDataByUserId(Convert.ToInt64((cmbUsername.SelectedItem as Classes.PubClass.MyCmbList).Id));
            }
            else
            {
                mTable = new T_CustomersTableAdapter().GetData();
            }
            销售管理.DAL.DataSetCustomers.T_CustomersRow mDataRow = (销售管理.DAL.DataSetCustomers.T_CustomersRow)mTable.NewRow();
            mDataRow.id = 0;
            mDataRow.CompanyName = "全部";
            mTable.Rows.InsertAt(mDataRow, 0);
            cmbCompanyName.DataSource = mTable;
            cmbCompanyName.SelectedIndex = -1;
        }
    }
}
