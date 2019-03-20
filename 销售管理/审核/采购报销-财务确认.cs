﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;
using 销售管理.日常业务.供应商管理;

namespace 销售管理.审核
{
    public partial class 采购报销_财务确认 : 销售管理.Main.报销审核Base
    {
        public 采购报销_财务确认()
        {
            InitializeComponent();
        }
        public MYDBEntities2 Mydb = new MYDBEntities2();
        private void 采购报销_财务确认_Load(object sender, EventArgs e)
        {
            tsb审核不通过.Visible = false;
            tsb审核通过.Text = "确认";
            //添加查看借款信息

            dgvNav1.MyBs = resultBindingSource;
            //绑定事件
            BindingEvent();
            InitCmb();
            SearchData();
        }

        private void AddTsb查看借款信息()
        {
            ToolStripButton tsb = new ToolStripButton();
            tsb.Name = "Tsb查看借款信息";
            tsb.Text = "查看该合同借款信息";
            tsb.ToolTipText = "查看该合同借款信息";
            tsb.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb.Click += tsb查看借款信息_Click;
            dgvNav1.Items.Add(tsb);
        }

        private void BindingEvent()
        {
            dgvResult.DataBindingComplete += Classes.PubFunc.dgv_DataBindingComplete;
            tsb审核通过.Click += tsb审核通过_Click;
            //tsb审核不通过.Click += tsb审核不通过_Click;
        }

        private void InitCmb()
        {
            cmbHasAudit.DisplayMember = "VcDesc";
            cmbHasAudit.ValueMember = "IntID";
            cmbHasAudit.DataSource = new[] { new { IntID = 7, VcDesc = "未确认" }, new { IntID = 8, VcDesc = "已确认" } };
            cmbHasAudit.SelectedIndex = 0;

        }

        private void SearchData()
        {
            if ((int)cmbHasAudit.SelectedValue == 7)
            {
                var daExpenses = Mydb.DaExpenses.Where(a => a.IntStatus == (int)cmbHasAudit.SelectedValue);
                if (string.IsNullOrWhiteSpace(txtContractNum.Text.Trim()) == false)
                {
                    daExpenses = daExpenses.Where(a => a.DaContractGood.DaPurchaseContract.VcNum.Contains(txtContractNum.Text.Trim()));
                }
                if (string.IsNullOrWhiteSpace(txtGoodsName.Text.Trim()) == false)
                {
                    daExpenses = daExpenses.Where(a => a.DaGood.VcName.Contains(txtGoodsName.Text.Trim()));
                }
                if (string.IsNullOrWhiteSpace(txtGoodsNum.Text.Trim()) == false)
                {
                    daExpenses = daExpenses.Where(a => a.DaGood.VcNum.Contains(txtGoodsNum.Text.Trim()));
                }
                dgvNav1.DataSource = daExpenses.Select(a => new
                {
                    编号 = a.IntID,
                    合同编号 = a.DaContractGood.DaPurchaseContract.VcNum,
                    物料编号 = a.DaGood.VcNum,
                    物品名称 = a.DaGood.VcName,
                    单价 = a.MonPrice,
                    数量 = a.NumCount,
                    金额 = a.MonSum,
                    状态 = a.ZdExpenseStatu.VcDesc
                });
                tsb审核不通过.Enabled = true;
                tsb审核通过.Enabled = true;
            }
            else
            {
                var daExpenseAuditLogs =
                    Mydb.DaExpenseAuditLogs.Where(a => a.IntOperationID == (int)cmbHasAudit.SelectedValue);

                if (string.IsNullOrWhiteSpace(txtContractNum.Text.Trim()) == false)
                {
                    daExpenseAuditLogs = daExpenseAuditLogs.Where(a => a.DaExpense.DaContractGood.DaPurchaseContract.VcNum.Contains(txtContractNum.Text.Trim()));
                }
                if (string.IsNullOrWhiteSpace(txtGoodsName.Text.Trim()) == false)
                {
                    daExpenseAuditLogs = daExpenseAuditLogs.Where(a => a.DaExpense.DaGood.VcName.Contains(txtGoodsName.Text.Trim()));
                }
                if (string.IsNullOrWhiteSpace(txtGoodsNum.Text.Trim()) == false)
                {
                    daExpenseAuditLogs = daExpenseAuditLogs.Where(a => a.DaExpense.DaGood.VcNum.Contains(txtGoodsNum.Text.Trim()));
                }
                dgvNav1.DataSource = daExpenseAuditLogs.Select(a => new
                {
                    编号 = a.DaExpense.IntID,
                    合同编号 = a.DaExpense.DaContractGood.DaPurchaseContract.VcNum,
                    物料编号 = a.DaExpense.DaGood.VcNum,
                    物品名称 = a.DaExpense.DaGood.VcName,
                    单价 = a.DaExpense.MonPrice,
                    数量 = a.DaExpense.NumCount,
                    金额 = a.DaExpense.MonSum,
                    操作 = a.ZdExpenseStatu.VcDesc
                });
                tsb审核不通过.Enabled = false;
                tsb审核通过.Enabled = false;
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SearchData();
            Cursor = Cursors.Default;
        }

        private void tsb审核通过_Click(object sender, EventArgs e)
        {

            //确认
            if (MessageBox.Show("是否确认报销？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            dgvResult.EndEdit();//结束dgv的编辑状态，防止选择状态为改变
            //判断是否选择记录

            int count = 0;
            try
            {
                foreach (DataGridViewRow mRow in dgvResult.Rows)
                {
                    if (Convert.ToBoolean(mRow.Cells["ColumnChecked"].Value) == true)
                    {
                        int expenseId = Convert.ToInt32(mRow.Cells["编号"].Value);
                        var daExpense = Mydb.DaExpenses.SingleOrDefault(a => a.IntID == expenseId);
                        if (daExpense != null)
                        {
                            daExpense.IntStatus = 8;
                            //插入一条操作记录
                            var daExpenseAuditLog = new DaExpenseAuditLog()
                            {
                                IntOperationID = 8,
                                IntExpenseID = expenseId,
                                IntUserID = Classes.PubClass.UserId
                            };
                            Mydb.DaExpenseAuditLogs.Add(daExpenseAuditLog);
                            count++;
                        }
                    }
                }
                if (count < 1)
                {
                    MessageBox.Show("请勾选要审核的行");
                    return;

                }
                else
                {
                    int ret = Mydb.SaveChanges();
                    if (ret > 0)
                    {
                        MessageBox.Show("审核成功");
                        SearchData();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("审核失败");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tsb查看借款信息_Click(object sender, EventArgs e)
        {
            var obj = dgvResult.SelectedRows[0].Cells["编号"].Value;
            if (obj == null)
                return;
            int mExpenseId = Convert.ToInt32(obj);
            var daExpense = Mydb.DaExpenses.SingleOrDefault(a => a.IntID == mExpenseId);
            if (daExpense == null)
                return;
            int mContractId = daExpense.DaContractGood.IntContractID;

            using (var mForm = new 采购借款记录())
            {
                mForm.Mydb = Mydb;
                mForm.MyPurchaseContractId = mContractId;
                mForm.DisplayWriteOff = true;
                if (mForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

    }
}
