using System;
using System.Data;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetExpenseAllocationTableAdapters;
using 销售管理.DAL.DataSetSaleDetailsTableAdapters;
using 销售管理.DAL.DataSetProductsTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 申请费用分配1 : Form
    {
        public 申请费用分配1()
        {
            InitializeComponent();
        }
        public DataGridViewRow mRow;  //销售明细行
        public long ExId = -1; //费用分配ID
        public bool isModify = false;  //修改
        public string type;   //订单类型
        public long SalerId;  //销售ID
        public string FailTableNo;//审核不通过表号
        public string oldType; //原订单类型
        public bool isLoading;//判断是否窗口加载中
        public DateTime DeliverDate;//发货日期
        decimal deliverPrice, salePrice, commissionPrice, deliverSum, SaleSum, saleWages, commissionSum, saleCommission, agentSum, agentCommission;
        long Amount;
        private void 申请费用分配_Load(object sender, EventArgs e)
        {
            rbPersonal.Checked = true;
            isLoading = true;


            if (ExId > -1)   //如果费用分配ID大于-1,查看费用分配信息
            {
                DataTable mTable1 = new T_ExpenseAllocationTableAdapter().GetDataById(ExId);
                if (mTable1.Rows.Count > 0)
                {
                    var mDataRow = (销售管理.DAL.DataSetExpenseAllocation.T_ExpenseAllocationRow)mTable1.Rows[0];

                    txtProjectName.Text = mDataRow.ProjectName;
                    var mProductTable = new T_ProductsTableAdapter().GetDataByID(mDataRow.ProductName);
                    if (mProductTable.Rows.Count > 0)
                    {
                        txtProductName.Text = mProductTable[0].Name;
                    }
                    var mCustomerTable = new T_CustomersTableAdapter().GetDataById(Convert.ToInt64(mDataRow.CustomerName));
                    if (mProductTable.Rows.Count > 0)
                    {
                        txtCustomerName.Text = mCustomerTable[0].CompanyName;
                    }

                    var mSaleDetailsTable = new T_SaleDetailsTableAdapter().GetDataByExId(ExId);

                    if (mSaleDetailsTable.Rows.Count > 0)
                    {
                        DeliverDate = mSaleDetailsTable[0].SaleDate;
                        //付款方式
                        cmbSettlementModes.Text = mSaleDetailsTable[0].SettlementModes.ToString();
                        dtpDate1.Text = mSaleDetailsTable[0].SaleDate.ToString();
                    }

                    txtProductName.Tag = mDataRow.ProductName;
                    txtCustomerName.Tag = mDataRow.CustomerName;

                    txtAmount.Text = mDataRow.Amount.ToString();
                    var DeliverPrice = mDataRow.DeliverPrice.ToString("0.00");
                    txtDeliverPrice.Text = DeliverPrice;
                    txtSalePrice.Text = DeliverPrice;
                    txtDeliverSum.Text = mDataRow.DeliverSum.ToString("0.00");
                    txtSaleSum.Text = mDataRow.SaleSum.ToString("0.00");
                    txtSaleWages.Text = mDataRow.SaleWages.ToString("0.00");
                    txtCommissionPrice.Text = mDataRow.CommissionPrice.ToString("0.00");
                    var CommissionSum = mDataRow.CommissionSum.ToString("0.00");
                    txtCommissionSum.Text = CommissionSum;
                    txtSaleCommission.Text = mDataRow.SaleComission.ToString("0.00");
                    agentSum = mDataRow.AgentSum;
                    txtAgent.Text = agentSum.ToString("0.00");
                    txtAgentCommission.Text = mDataRow.AgentCommission.ToString("0.00");

                    SalerId = mDataRow.UserName;
                    DataTable mTable = new T_UsersTableAdapter().GetDataById(SalerId);
                    if (mTable.Rows.Count > 0)
                    {
                        var mDataRow1 = (销售管理.DAL.DataSetUsers.T_UsersRow)mTable.Rows[0];
                        txtUserName.Text = mDataRow1.UserName;
                    }

                    if (mDataRow.type == "A类订单")
                    {
                        rbPersonal.Checked = true;
                    }

                    else if (mDataRow.type == "B类订单")
                    {
                        rbDepart.Checked = true;
                    }

                    oldType = mDataRow.type;
                    FailTableNo = mDataRow.TableNo;
                    txtTableNo.Text = mDataRow.TableNo;

                    if (mDataRow.IsPaid == "已付款")
                    {
                        cbIsPaid.Checked = true;
                        if (mDataRow.IsPaidDateNull() == false)
                        {
                            dtpPaidDate.Value = mDataRow.PaidDate;
                        }
                    }
                    else
                    {
                        cbIsPaid.Checked = false;
                    }

                    cbIsPaid.Visible = true;

                    if (mDataRow.Status.Contains("不通过") == true && isModify == true && Classes.PubClass.UserRight == "客服")
                    {
                        btnApply.Enabled = true;
                        btnApply.Text = "重新申请";
                        cbIsPaid.Visible = false;
                    }
                    else
                    {                        
                        btnApply.Enabled = false;
                    }
                    //groupBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("该费用分配表号不存在");
                    this.Close();
                    return;
                }

                if (Classes.PubClass.UserRight == "领导" && agentSum > 0)
                {                  
                    btnModifyPaid.Visible = true;
                }
                else
                {            
                    btnModifyPaid.Visible = false;
                }
            }
            else  //申请费用分配
                if (mRow != null)
            {
                //判断 如果是销售只能查看不能申请
                if (Classes.PubClass.UserRight == "销售")
                {
                    this.Close();
                    return;
                }

                txtCustomerName.Text = mRow.Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();
                txtProductName.Text = mRow.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
                txtAmount.Text = mRow.Cells["amountDataGridViewTextBoxColumn"].Value.ToString();

                //销售价格20200712
                var DeliverPrice = Convert.ToDecimal(mRow.Cells["priceDataGridViewTextBoxColumn"].Value).ToString("0.00");
                txtDeliverPrice.Text = DeliverPrice;
                txtSalePrice.Text = DeliverPrice;
                var Agent = Convert.ToDecimal(mRow.Cells["AgentSum"].Value).ToString("0.00");
                txtAgent.Text = Agent;
                long SaleDetailsId = Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value);
                var SaleDetailsTable = new T_SaleDetailsTableAdapter().GetDataById(SaleDetailsId);
                if (SaleDetailsTable.Rows.Count > 0)
                {
                    txtProductName.Tag = SaleDetailsTable[0].ProductName;
                    txtCustomerName.Tag = SaleDetailsTable[0].CustomerName;
                    SalerId = SaleDetailsTable[0].UserName;
                    var mUserTable = new T_UsersTableAdapter().GetDataById(SalerId);
                    if (mUserTable.Rows.Count > 0)
                    {
                        txtUserName.Text = mUserTable[0].UserName;
                    }
                    SetTableNo();
                }
                btnModifyPaid.Visible = false;
            }

            isLoading = false;
        }

        private void cmbSettlementModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSettlementModes.Text == "自定义天数")
            {
                txtDays.Visible = true;
            }
            else
            {
                txtDays.Visible = false;
            }
        }

        public void SetTableNo()
        {
            if (SalerId > 0)
            {
                string mTableNo;
                if (DateTime.Now.Year.ToString() == "1")
                {
                    mTableNo = DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00");
                }
                else
                {
                    mTableNo = DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00");
                }

                if (type == "A类订单")
                {
                    mTableNo = "RTMAT" + "-A-" + mTableNo;
                }
                else
                {
                    mTableNo = "RTMAT" + "-B-" + mTableNo;
                }
                string mTable1 = new T_ExpenseAllocationTableAdapter().GetMaxTableNo(mTableNo).ToString();
                txtTableNo.Text = mTableNo + (Convert.ToInt32(mTable1.Substring(mTable1.Length - 3, 3)) + 1).ToString("000");

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断佣金是否超额         
            if (agentSum > (deliverSum * (decimal)0.05))
            {
                MessageBox.Show("佣金占售价比例超过 5%！");
                return;
            }

            //判断又没选择结款方式
            if (cmbSettlementModes.SelectedIndex == -1)
            {
                MessageBox.Show("请选择结款方式");
                return;
            }

            if (String.IsNullOrEmpty(txtCommissionPrice.Text.Trim())) {
                MessageBox.Show("请输入实际价格");
                return;
            }

            //计算结算日期
            var exDate = ExpireDate(cmbSettlementModes.Text.Trim(), dtpDate1.Value, Convert.ToInt32(txtDays.Text.Trim()));

            var Paid = agentSum > 0 ? "未付款" : "无佣金";

            object ret;
            try
            {
                //插入分配表
                ret = new T_ExpenseAllocationTableAdapter().MyInsert("", SalerId, txtTableNo.Text, Convert.ToInt64(txtCustomerName.Tag), txtProjectName.Text, Convert.ToInt64(txtProductName.Tag), "", Amount, deliverPrice, Math.Round(deliverSum, 2), salePrice, Math.Round(SaleSum, 2), 0, Math.Round(saleWages, 2), commissionPrice, Math.Round(commissionSum, 2), Math.Round(saleCommission, 2), 0, Math.Round(agentSum, 2), Math.Round(agentCommission, 2), Paid, null, "客服已确认等待财务审核", null, null, null, null, null, null, null, null, null, Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value), type, SalerId, 0, 0, "含税", 0, 0, 0);

                if ((long)ret > 0)
                {
                    //插入发货时间和付款方式
                    ret = new T_SaleDetailsTableAdapter().UpdateSaleDateAndSettlementModesById(dtpDate1.Value, cmbSettlementModes.Text.ToString(), (long)ret, exDate, Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value));
                    MessageBox.Show("已提交");
                    btnApply.Enabled = false;
                }
                else
                {
                    MessageBox.Show("提交失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (isLoading == true) return; //窗口加载时不引发事件
            ComputeNums();
        }

        private DateTime ExpireDate(String settlementModes, DateTime datetime, int days)
        {
            var expiredate = DateTime.Now;
            //计算发货日期最后一天
            var LastDay = datetime.AddDays(1 - datetime.Day).Date.AddMonths(1).AddSeconds(-1);
            switch (settlementModes)
            {
                case "月结30天":
                    expiredate = LastDay.AddDays(30 + 1);
                    break;
                case "月结45天":
                    expiredate = LastDay.AddDays(45 + 1);
                    break;
                case "月结60天":
                    expiredate = LastDay.AddDays(60 + 1);
                    break;
                case "月结90天":
                    expiredate = LastDay.AddDays(90 + 1);
                    break;
                case "月结120天":
                    expiredate = LastDay.AddDays(120 + 1);
                    break;
                case "自定义天数":
                    expiredate = LastDay.AddDays(days + 1);
                    break;
            }
            return expiredate;
        }

        private int ComputeNums() //自动计算界面数值
        {
            if (string.IsNullOrEmpty(txtAmount.Text) == false)
            {
                try
                {
                    Amount = Convert.ToInt64(txtAmount.Text);
                    if (string.IsNullOrEmpty(txtDeliverPrice.Text) == false)
                    {
                        deliverPrice = Convert.ToDecimal(txtDeliverPrice.Text); //发货单价
                        deliverSum = deliverPrice * Amount;                    //发货额
                        txtDeliverSum.Text = deliverSum.ToString("0.00");
                    }

                    if (txtSalePrice.Text == "") //销售单价
                    {
                        txtSalePrice.Text = "0";
                        txtSalePrice.SelectionStart = 0;
                        txtSalePrice.SelectionLength = 1;
                    }

                    if (txtCommissionPrice.Text == "") //提成单价
                    {
                        txtCommissionPrice.Text = "0";
                        txtCommissionPrice.SelectionStart = 0;
                        txtCommissionPrice.SelectionLength = 1;
                    }

                    if (type == "A类订单")
                    {
                        if (string.IsNullOrEmpty(txtSalePrice.Text) == false)
                        {
                            //销售单价
                            salePrice = Convert.ToDecimal(txtSalePrice.Text);

                            if (rbPersonal.Checked == true) //A类订单
                            {
                                //销售额
                                SaleSum = salePrice * Amount;
                                txtSaleSum.Text = SaleSum.ToString("0.00");

                                //提成价格
                                commissionPrice = Convert.ToDecimal(txtCommissionPrice.Text);

                                if (commissionPrice > 0)
                                {
                                    //提成额度
                                    commissionSum = commissionPrice * Amount;

                                    txtCommissionSum.Text = commissionSum.ToString("0.00");

                                    //销售提成 销售提成：高于公司定价部分成交的订单，公司给予销售员高出定价部分销售收入的 10%作为提成奖励

                                    saleCommission = (SaleSum - commissionSum) / (decimal)1.13 * (decimal)0.1;

                                    txtSaleCommission.Text = saleCommission.ToString("0.00");
                                }
                                else
                                {
                                    commissionSum = 0;
                                    saleCommission = 0;
                                    txtCommissionSum.Text = commissionSum.ToString("0.00");
                                    txtSaleCommission.Text = saleCommission.ToString("0.00");
                                }

                                //佣金
                                agentSum = Convert.ToDecimal(txtAgent.Text);

                                //含税佣金
                                agentCommission = agentSum / (decimal)1.13 * (decimal)0.64;

                                txtAgentCommission.Text = agentCommission.ToString("0.00");

                                //销售工资0.2%(M-Y-Z)
                                saleWages = (SaleSum - saleCommission - agentSum) / (decimal)1.13 * (decimal)0.002;

                                txtSaleWages.Text = saleWages.ToString("0.00");
                            }
                        }
                    }
                    //B类订单
                    else
                    {
                        if (string.IsNullOrEmpty(txtSalePrice.Text) == false)
                        {
                            //销售单价
                            salePrice = Convert.ToDecimal(txtSalePrice.Text);

                            if (rbDepart.Checked == true) //B类订单
                            {
                                //销售额
                                SaleSum = salePrice * Amount;
                                txtSaleSum.Text = SaleSum.ToString("0.00");

                                //提成价格

                                commissionSum = 0;
                                saleCommission = 0;
                                txtCommissionSum.Text = commissionSum.ToString("0.00");
                                txtSaleCommission.Text = saleCommission.ToString("0.00");

                                //佣金
                                agentSum = Convert.ToDecimal(txtAgent.Text);

                                //含税佣金
                                agentCommission = agentSum / (decimal)1.13 * (decimal)0.64;

                                txtAgentCommission.Text = agentCommission.ToString("0.00");

                                //销售工资0.2%(M-Y-Z)
                                saleWages = (SaleSum - agentSum) / (decimal)1.13 * (decimal)0.0004;

                                txtSaleWages.Text = saleWages.ToString("0.00");
                            }
                        }
                    }

                    return 0;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 1;
                }
            }
            return 1;
        }

        private void rbPersonal_CheckedChanged(object sender, EventArgs e)
        {
            labCommissionPrice.Visible = true;
            labCommissionSum.Visible = true;
            labSaleCommission.Visible = true;
            txtCommissionPrice.Visible = true;
            txtCommissionSum.Visible = true;
            txtSaleCommission.Visible = true;

            type = rbPersonal.Text;

            txtAmount_Leave(sender, e);

            SetTableNo();

        }

        private void btnModifyPaid_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = 0;
                string isPaid = "";
                if (cbIsPaid.Checked == true)
                {
                    isPaid = "已付款";
                    ret = new T_ExpenseAllocationTableAdapter().UpdateIsPaid(isPaid, dtpPaidDate.Value, ExId);
                }
                else
                {
                    isPaid = "未付款";
                    ret = new T_ExpenseAllocationTableAdapter().UpdateIsPaid(isPaid, null, ExId);
                }
                if (ret > 0)
                {
                    MessageBox.Show("付款信息修改成功");
                }
                else
                {
                    MessageBox.Show("付款信息修改失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbIsPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsPaid.Checked == true)
            {
                label12.Visible = true;
                dtpPaidDate.Visible = true;
            }
            else
            {
                label12.Visible = false;
                dtpPaidDate.Visible = false;
            }
        }

        private void rbDepart_CheckedChanged(object sender, EventArgs e)
        {
            labCommissionPrice.Visible = false;
            labCommissionSum.Visible = false;
            labSaleCommission.Visible = false;
            txtCommissionPrice.Visible = false;
            txtCommissionSum.Visible = false;
            txtSaleCommission.Visible = false;
            type = rbDepart.Text;
            txtAmount_Leave(sender, e);
            SetTableNo();
        }
    }
}
