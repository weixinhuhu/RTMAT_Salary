using System;
using System.Data;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using Common;
using 销售管理.日常业务.销售管理功能;
using System.Data.SqlClient;

namespace 销售管理.查询统计
{
    public partial class 销售费用查询 : 销售管理.UserControlBase
    {
        public 销售费用查询()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql = "";
            string mSql1 = "";
            if (rbSum.Checked == true)//汇总
            {
                dgvReports.Visible = false; //明细
                dgvSumFee.Visible = true;//合计
                dgvSumFee.DataSource = null;
                String fee1 = "", fee2 = "", fee3 = "", fee4 = "", fee5 = "", fee6 = "", fee7 = "", fee8 = "", sDept = "";

                if (dtpStart.Checked == true)
                {
                    sDept = " and b.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
                }

                fee1 = @"( SELECT    ISNULL(SUM(CONVERT(DECIMAL(18, 2), b.[SumMoney])), 0)
                                      FROM      dbo.T_TravelExpenses b
                                      WHERE     c.id = b.UserName" + sDept + " )";

                if (dtpStart.Checked == true)
                {

                    sDept = " and b.RecDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                }

                fee2 = @"( SELECT    ISNULL(SUM(CONVERT(DECIMAL(18, 2), b.MealMoney)), 0)
                                      FROM dbo.T_Meals b
                                      WHERE c.id = b.UserId
                                                AND b.Status NOT IN('已删除', '审核未通过')" + sDept + "   )";

                if (dtpStart.Checked == true)
                {
                    sDept = " and b.RecDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
                }

                fee3 = @"( SELECT    ISNULL(SUM(CONVERT(DECIMAL(18, 2), b.GiftSum)), 0)
                                      FROM      [dbo].[T_GiftStockOut] b
                                      WHERE     c.id = b.UserId
                                               AND b.Status = '审核已通过'
                                               AND HasStockOut = '已出库'" + sDept + " )";

                if (dtpStart.Checked == true)
                {
                    sDept = " and b.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
                }

                fee4 = @"( SELECT     ISNULL(SUM(CONVERT(DECIMAL(18, 2), b.[SumMoney])), 0)
                                      FROM      [dbo].T_NoTicket b
                                      WHERE     c.id = b.UserName
                                                AND b.P2 = '复核已通过'
                                                AND P1 = '正常'" + sDept + " )";

                if (dtpStart.Checked == true)
                {
                    sDept = " and b.SaleDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                }

                fee5 = @" ( SELECT     ISNULL(SUM(CONVERT(DECIMAL(18, 2), b.[SumMoney])), 0)
                                     FROM      dbo.T_ProductSend b
                                    WHERE     c.id = b.UserName" + sDept + ")";

                if (dtpStart.Checked == true)
                {
                    sDept = " and b.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                }

                fee6 = @"( SELECT     ISNULL(SUM(CONVERT(DECIMAL(18, 2), b.[SumMoney])), 0)
                                      FROM      dbo.T_AdvertisingFee b
                                      WHERE     c.id = b.UserName" + sDept + ")";

                if (dtpStart.Checked == true)
                {
                    sDept = " and b.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                }

                fee7 = @"( SELECT     ISNULL(SUM(CONVERT(DECIMAL(18, 2), b.[SumMoney])), 0)
                                      FROM      dbo.T_UserSalary b
                                      WHERE      c.id = b.UserName" + sDept + ")";

                if (dtpStart.Checked == true)
                {
                    sDept = " and b.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                }

                fee8 = @"( SELECT    ISNULL(SUM(CONVERT(DECIMAL(18, 2), b.[SumMoney])), 0)
                                      FROM      dbo.T_OfficeExpenses b
                                      WHERE      c.id = b.UserName" + sDept + ")";

                //按何总要求总费用为 申请金额*1.28
                mSql = @"SELECT  c.UserName '销售员', {0} '差旅费',{1} '餐费',{2} '礼品',{3}*1.28 '无票费用',{4} '产品赠送',{5} '广告宣传',{6} '薪资',{7} '办公费用',({0}+{1}+{2}+{3}*1.28+{4}+{5}+{6}+{7})'合计' FROM dbo.T_Users c WHERE   1=1";

                mSql = string.Format(mSql, fee1, fee2, fee3, fee4, fee5, fee6, fee7, fee8, sDept);

                if (cmbUserName.Text.Trim() != "")
                {
                    mSql += " and c.UserName like '%" + cmbUserName.Text.Trim() + "%'";

                }
                if (CmbDepartmentName.Text != string.Empty)
                {
                    mSql += " and c.DepartmentName ='" + CmbDepartmentName.Text + "'";

                }

                try
                {
                    DataTable mTable = SqlHelper.GetData(mSql);
                    DataRow mRow = mTable.NewRow();
                    mRow["差旅费"] = mTable.Compute("sum(差旅费)", "true");
                    mRow["餐费"] = mTable.Compute("sum(餐费)", "true");
                    mRow["礼品"] = mTable.Compute("sum(礼品)", "true");
                    mRow["无票费用"] = mTable.Compute("sum(无票费用)", "true");
                    mRow["产品赠送"] = mTable.Compute("sum(产品赠送)", "true");
                    mRow["广告宣传"] = mTable.Compute("sum(广告宣传)", "true");
                    mRow["薪资"] = mTable.Compute("sum(薪资)", "true");
                    mRow["办公费用"] = mTable.Compute("sum(办公费用)", "true");
                    mRow["合计"] = mTable.Compute("sum(合计)", "true");
                    mTable.Rows.Add(mRow);
                    dgvSumFee.DataSource = mTable;
                    dgvSumFee.Rows[dgvSumFee.Rows.Count - 1].Cells["销售员"] = new DataGridViewTextBoxCell();
                    dgvSumFee.Rows[dgvSumFee.Rows.Count - 1].Cells["销售员"].Value = "总计";

                    if ((dgvSumFee.DataSource as DataTable).Rows.Count < 0)
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
            else //明细
            {
                dgvReports.Visible = true; //明细
                dgvSumFee.Visible = false;//合计
                dgvReports.DataSource = null;

                if (cmbFeeType.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择费用类别");
                    return;
                }
                if (cmbFeeType.Text.Trim() == "餐费")
                {
                    mSql = @" SELECT c.[UserName]  '销售员'
                              ,b.CompanyName '客户名称'
                              ,CONVERT(DECIMAL(18, 2), a.[MealMoney])  '金额' 
                              ,a.RecDate  '日期'
                             FROM [dbo].[T_Meals] a
                             LEFT JOIN T_Users c ON a.UserId = c.id
                             LEFT JOIN dbo.T_Customers b ON b.id = a.CustomerId
                             WHERE 1 = 1 AND a.Status not in('已删除','审核未通过')";
                    mSql1 = @" UNION ALL
                                SELECT '总计' ,                                    
                                         NULL,
                                        ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[MealMoney])), 0) ,
                                         NULL
                             FROM [dbo].[T_Meals] a
                             LEFT JOIN T_Users c ON a.UserId = c.id
                             LEFT JOIN dbo.T_Customers b ON b.id = a.CustomerId
                             WHERE 1 = 1 AND a.Status not in('已删除','审核未通过')";
                }
                else if (cmbFeeType.Text.Trim() == "礼品")
                {
                    mSql = @" SELECT  c.[UserName] '销售员' ,
                                b.CompanyName '客户名称' ,
                                a.GiftName '礼品名称' ,
                                a.GiftNum '礼品数量' ,
                                CONVERT(DECIMAL(18, 2), a.[GiftPrice]) '礼品价格' ,
                                CONVERT(DECIMAL(18, 2), a.[GiftSum]) '礼品金额' ,
                                a.RecDate '日期'
                        FROM    [dbo].[T_GiftStockOut] a
                                LEFT JOIN T_Users c ON a.UserId = c.id
                                LEFT JOIN dbo.T_Customers b ON b.id = a.CustomerId
                        WHERE   1 = 1
                                AND a.Status = '审核已通过'
                                AND HasStockOut = '已出库'";
                    mSql1 = @" UNION ALL
                                SELECT '总计' , 
                                         NULL,
                                         NULL,
                                         NULL,
                                         NULL,
                                        ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[GiftSum])), 0) ,
                                         NULL
                            FROM [dbo].[T_GiftStockOut] a
                            LEFT JOIN T_Users c ON a.UserId = c.id                       
                            WHERE 1=1 AND A.Status='审核已通过' AND HasStockout='已出库'";

                }
                else if (cmbFeeType.Text.Trim() == "无票费用") //按何总要求总费用为 申请金额*1.28
                {
                    mSql = @" SELECT  c.[UserName] '销售员',
                                b.[CompanyName] '客户名称',
                                a.[ProjectName]  '项目名称',
                                Convert(decimal(18,2),a.[SumMoney])     '申请金额' ,
                                Convert(decimal(18,2),a.[SumMoney]*1.28 )    '含税金额' ,
                                a.[SalaryDate] '日期'     
                        FROM    [dbo].T_NoTicket a
                                LEFT JOIN T_Users c ON a.UserName = c.id
                                LEFT JOIN T_Users d ON a.AuditId = d.id
                                LEFT JOIN dbo.T_Customers b ON a.CustomerName = b.id
                        WHERE   1 = 1 
                        AND   a.P2 = '复核已通过' AND P1='正常'";

                    mSql1 = @"  UNION ALL
                                SELECT '总计' ,
                                            NULL ,
                                            NULL ,     
                                            ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[SumMoney])), 0) ,  
                                            ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[SumMoney]*1.28)), 0) ,  
                                            NULL
                                FROM    [dbo].T_NoTicket a
                                LEFT JOIN T_Users c ON a.UserName = c.id
                                LEFT JOIN T_Users d ON a.AuditId = d.id
                                LEFT JOIN dbo.T_Customers b ON a.CustomerName = b.id
                        WHERE   1 = 1 
                        AND a.P2 = '复核已通过'  AND P1='正常'";

                }

                else
                {
                    string caseSwith = cmbFeeType.Text.Trim();
                    switch (caseSwith)
                    {
                        case "差旅费":
                            mSql = @" SELECT c.[UserName] '销售员'
                                  ,b.[CompanyName] '客户名称'
                                  ,a.[ProjectName]  '项目名称'
                                  ,Convert(decimal(18,2),a.[Price1])       '差旅费用'    
                                  ,Convert(decimal(18,2),a.[Price2])       '招待费用'
                                  ,Convert(decimal(18,2),a.[SumMoney])     '总金额'
                                  ,a.[SalaryDate]                          '日期'
                                FROM [dbo].[T_TravelExpenses] a
                                LEFT JOIN T_Users c ON a.UserName = c.id
                                LEFT JOIN dbo.T_Customers b ON a.Customername=b.id
                                WHERE 1=1";
                            mSql1 = @"  UNION ALL
                                     SELECT '总计' ,
                                            NULL ,
                                            NULL ,
                                            ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price1])), 0) ,
                                            ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price2])), 0) ,
                                            ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[SumMoney])), 0) ,
                                            NULL
                                FROM [dbo].[T_TravelExpenses] a
                                LEFT JOIN T_Users c ON a.UserName = c.id
                                LEFT JOIN dbo.T_Customers b ON a.Customername=b.id
                                WHERE 1=1 ";
                            break;

                        case "产品赠送":
                            mSql = @"SELECT  c.UserName '销售员',
                                        e.CompanyName '客户名称',                                   
                                        d.Name  '产品名称',
                                        a.Amount '数量' ,
                                        Convert(decimal(18,2),a.[Price]) '单价' , 
                                        Convert(decimal(18,2),a.[SumMoney])  '总金额',
		                                a.Unit '单位',
                                        a.SaleDate '日期',
		                                a.StockOutNo '出库单号'       
                                FROM    dbo.T_ProductSend a
                                        LEFT JOIN T_Users c ON a.UserName = c.id
                                        LEFT JOIN T_Products d ON a.productName = d.Id
                                        LEFT JOIN T_Customers e ON a.CustomerName = e.id
                                WHERE   a.Status='正常' ";
                            mSql1 = @"  UNION ALL
                                     SELECT '总计' ,
                                            NULL ,
                                            NULL ,
                                            NULL ,
                                            NULL ,                                     
                                            ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[SumMoney])), 0) ,
                                            NULL ,
                                            NULL ,
                                            NULL
                                FROM    dbo.T_ProductSend a
                                        LEFT JOIN T_Users c ON a.UserName = c.id
                                        LEFT JOIN T_Products d ON a.productName = d.Id
                                        LEFT JOIN T_Customers e ON a.CustomerName = e.id
                                WHERE 1=1 ";
                            break;

                        case "广告宣传":
                            mSql = @" SELECT  c.[UserName] '销售员'
                                          ,a.[ProjectName]     '费用明细'            
                                          ,Convert(decimal(18,2),a.[SumMoney])          '金额'
                                          ,a.[SalaryDate]        '日期'      
                                        FROM [dbo].[T_AdvertisingFee] a
                                        LEFT JOIN T_Users c ON a.UserName = c.id
                                        WHERE 1=1";
                            mSql1 = @"  UNION ALL
                                     SELECT '总计' ,
                                            NULL ,                                                                          
                                            ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[SumMoney])), 0) ,
                                            NULL
                                FROM [dbo].[T_AdvertisingFee] a
                                LEFT JOIN T_Users c ON a.UserName = c.id
                                WHERE 1=1 ";
                            break;

                        case "薪资":
                            mSql = @"SELECT c.UserName  '销售员',
                                    a.SalaryDate  '日期',
                                    a.Price1  '工资',
                                    a.Price2  '五险费用',
                                    a.Price3  '住房公积金',
                                    a.Price4  '提成',
                                    a.Price5  '其它',
                                    a.SumMoney  '总费用'
                            FROM    dbo.T_UserSalary a
                                    LEFT JOIN T_Users c ON a.UserName = c.id 
                            WHERE 1=1 ";
                            mSql1 = @"  UNION ALL
                                     SELECT '总计' ,
                                            NULL ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price1])), 0) ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price2])), 0) ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price3])), 0) ,    
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price4])), 0) ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price5])), 0) ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[SumMoney])), 0) ,                                      
                            FROM    dbo.T_UserSalary a
                                    LEFT JOIN T_Users c ON a.UserName = c.id 
                            WHERE 1=1 ";
                            break;

                        case "办公费用":
                            mSql = @"SELECT  c.UserName '销售员',
                                    a.SalaryDate   '日期' ,
                                    a.Price1  '折旧费',
                                    a.Price2  '工位费',
                                    a.Price3  '水电费',
                                    a.Price4  '培训费',
                                    a.Price5  '其它',
                                    a.SumMoney  '总费用'
                        FROM    dbo.T_OfficeExpenses a
                                LEFT JOIN T_Users c ON a.UserName = c.id 
                        WHERE 1=1 ";
                            mSql1 = @"  UNION ALL
                                     SELECT '总计' ,
                                            NULL ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price1])), 0) ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price2])), 0) ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price3])), 0) ,    
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price4])), 0) ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[Price5])), 0) ,
                                    ISNULL(SUM(CONVERT(DECIMAL(18, 2), a.[SumMoney])), 0)  
                            FROM    dbo.T_OfficeExpenses a
                                    LEFT JOIN T_Users c ON a.UserName = c.id 
                        WHERE 1=1 ";
                            break;
                    }
             
                }
                if (cmbUserName.Text.Trim() != "")
                {
                    mSql += " and c.UserName like '%" + cmbUserName.Text.Trim() + "%'";
                    mSql1 += " and c.UserName like '%" + cmbUserName.Text.Trim() + "%'";
                }

                if (CmbDepartmentName.Text != string.Empty)
                {
                    mSql += " and c.DepartmentName ='" + CmbDepartmentName.Text + "'";
                    mSql1 += " and c.DepartmentName ='" + CmbDepartmentName.Text + "'";
                }

                if (dtpStart.Checked == true)
                {
                    if (cmbFeeType.Text.Trim() == "餐费" || cmbFeeType.Text.Trim() == "礼品")
                    {
                        mSql += " and a.RecDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
                        mSql1 += " and a.RecDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                    }
                    else if (cmbFeeType.Text.Trim() == "产品赠送")
                    {
                        mSql += " and a.SaleDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
                        mSql1 += " and a.SaleDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                    }
                    else
                    {
                        mSql += " and a.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
                        mSql1 += " and a.SalaryDate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                    }
                }

                mSql += mSql1;
                SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
                SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
                DataTable mTable = new DataTable();
                try
                {
                    adapter.Fill(mTable);
                    if (rbSum.Checked == true)
                    { //汇总
                        dgvSumFee.DataSource = null;
                        dgvSumFee.DataSource = mTable;
                    }
                    else
                    {
                        dgvReports.DataSource = null;
                        dgvReports.DataSource = mTable;
                    }
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
        }
        private void 销售明细管理_Load(object sender, EventArgs e)
        {

            dgvReports.Visible = true; //明细
            dgvSumFee.Visible = false;//合计
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

            rbSum.Checked = true;
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

        }

        private void dgvCustomerBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rbSum.Checked == true)
            {
                Classes.ExcelDeport.Deport(dgvSumFee, 0);
            }
            else
            {
                Classes.ExcelDeport.Deport(dgvReports, 0);
            }         
        }

        private void rbdetail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdetail.Checked == true)
            {
                cmbFeeType.Enabled = true;
            }

        }

        private void rbSum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSum.Checked == true)
            {
                cmbFeeType.SelectedIndex = -1;
                cmbFeeType.Enabled = false;
            }
        }

        private void cmbFeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
