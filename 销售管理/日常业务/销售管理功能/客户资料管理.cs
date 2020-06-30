using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetUsersTableAdapters;
using Common;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using 销售管理.DAL.DataSetPromaryTableAdapters;
namespace 销售管理.日常业务
{
    public partial class 客户资料管理 : 销售管理.UserControlBase
    {
        public 客户资料管理()
        {
            InitializeComponent();
        }

        private void 客户资料管理_Load(object sender, EventArgs e)
        {
            //添加省市cmb
            var mTable1 = new T_PromaryTableAdapter().GetData();
            cmbPromary.DisplayMember = "proName";
            cmbPromary.ValueMember = "proID";
            cmbPromary.DataSource = mTable1;
            cmbPromary.SelectedIndex = -1;

            //设置授权额度列右对齐
            dgvContact.Columns["CustomersCredit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            tCustomersBindingSource.DataSource = t_CustomersTableAdapter.GetDataAndCountByUserId(Classes.PubClass.UserId);

            if (!Common.AuthenticateRight.AuthOperation(110101) && Common.CommonClass.SttUser.blSuperUser == false)
            {
                cmbUserName.Items.Add(Classes.PubClass.UserName);
                cmbUserName.Items.Add("全部");
                cmbUserName.SelectedIndex = 0;
            }
            else
            {
                cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.ValueMember = "ID";
                cmbUserName.SelectedValue = Classes.PubClass.UserId;
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql, mSql1;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
          
            //20190328
            mSql = @"SELECT  A.id ,
                            b.UserName opername1,
                            A.CompanyName ,
                            A.CompanyAddress ,
                            A.BusinessContactName ,
                            A.BusinessContactTel ,
                            A.BusinessContactPhone ,
                            A.BusinessContactEmail ,
                            A.TechContactName ,
                            A.TechContactTel ,
                            A.TechContactPhone ,
                            A.TechContactEmail ,
                            b.UserName ,
                            A.DeliverName ,
                            A.DeliverAddress ,
                            A.DeliverPhone ,
                            A.CustomersCredit
                    FROM    dbo.T_Customers A
                            LEFT JOIN T_Users b ON A.OperName = b.id
                            LEFT JOIN T_City c ON A.CityID = c.ID                          
                            WHERE Status='正常'";

            mSql1 = @"   UNION ALL
                                SELECT  NULL ,
                                        '总计' ,
                                        CONVERT(VARCHAR(20), COUNT(*)) ,
                                        NULL ,
                                        NUll ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL ,
                                        NULL
                                FROM    T_Customers a
                                        LEFT JOIN T_City c ON a.CityID = c.ID
                                        LEFT JOIN T_Users b ON A.OperName = b.id                   
                            WHERE Status='正常'";

            if (cmbUserName.Text.Trim() != "" && cmbUserName.Text.Trim() != "全部")
            {
                if (!Common.AuthenticateRight.AuthOperation(110101) && Common.CommonClass.SttUser.blSuperUser == false)
                {
                    mSql += "  and  b.UserName =  '" + cmbUserName.Text.Trim() + "'";
                    mSql1 += " and  b.UserName =  '" + cmbUserName.Text.Trim() + "'";
                }
                else
                {
                    mSql += "  and  a.OperName = " + cmbUserName.SelectedValue;
                    mSql1 += " and  a.OperName =  " + cmbUserName.SelectedValue;
                }
            }

            if (txtComName.Text.Trim() != "")
            {
                mSql += " and a.CompanyName like '%" + txtComName.Text.Trim() + "%'";
                mSql1 += " and a.CompanyName like '%" + txtComName.Text.Trim() + "%'";
            }
            if (txtBusinessName.Text.Trim() != "")
            {
                mSql += " and a.BusinessContactName like '%" + txtBusinessName.Text.Trim() + "%'";
                mSql1 += " and a.BusinessContactName like '%" + txtBusinessName.Text.Trim() + "%'";
            }
            if (txtTechName.Text.Trim() != "")
            {
                mSql += " and a.TechContactName like '%" + txtTechName.Text.Trim() + "%'";
                mSql1 += " and a.TechContactName like '%" + txtTechName.Text.Trim() + "%'";
            }
            //地区
            if (cmbCity.Text.Trim() != "")
            {
                mSql += " and a.CityID=" + cmbCity.SelectedValue;
                mSql1 += " and a.CityID=" + cmbCity.SelectedValue;
            }
            //客户类型
            if (CmbCustomersType.Text.Trim() != "")
            {
                mSql += " and SUBSTRING(a.CustomersType," + (CmbCustomersType.SelectedIndex) + ",1)='1'";
                mSql1 += " and SUBSTRING(a.CustomersType," + (CmbCustomersType.SelectedIndex) + ",1)='1'";
            }

            cmbPromary.SelectedIndex = -1;

            mSql += mSql1;
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvContact.DataSource = mTable;
                
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvContact.EndEdit();
        }

        private void dgvContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == 1)
                {
                    if ((dgvContact.Rows[e.RowIndex].Cells["OperName"].Value.ToString() == Classes.PubClass.UserName || Common.AuthenticateRight.AuthOperation(110101) || CommonClass.SttUser.blSuperUser) && Classes.PubClass.UserStatus == "正常")
                    {
                        客户资料维护 mForm = new 客户资料维护();
                        mForm.mId = Convert.ToInt64(dgvContact.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                        mForm.ShowDialog();
                    }
                }
                if (e.ColumnIndex == 2)
                {
                    if ((dgvContact.Rows[e.RowIndex].Cells["OperName"].Value.ToString() == Classes.PubClass.UserName || Common.AuthenticateRight.AuthOperation(110101) || CommonClass.SttUser.blSuperUser) && Classes.PubClass.UserStatus == "正常")
                    {
                        if (MessageBox.Show("确认删除该客户资料？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            long mId = Convert.ToInt64(dgvContact.Rows[e.RowIndex].Cells[0].Value);
                            int ret = t_CustomersTableAdapter.DeleteById(mId);
                            if (ret > 0)
                            {
                                dgvContact.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show("删除失败");
                            }
                        }
                    }
                }
            }
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            客户资料维护 mForm = new 客户资料维护();
            mForm.ShowDialog();
        }

        private void dgvContact_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvContact.Rows.Count > 0)
            {             
                    if (!Common.AuthenticateRight.AuthOperation(110101) && Common.CommonClass.SttUser.blSuperUser == false)
                    {
                        foreach (DataGridViewRow mRow in dgvContact.Rows)
                        {
                            if (dgvContact.Rows[mRow.Index].Cells["OperName"].Value.ToString() != Classes.PubClass.UserName)
                            {
                                for (int i = 5; i < dgvContact.Columns.Count; i++)
                                {
                                    dgvContact.Rows[mRow.Index].Cells[i].Value = "";
                                }
                            }
                        } 
                     }

                if (dgvContact.Rows[dgvContact.Rows.Count - 1].Cells["OperName"].Value.ToString() == "总计")
                {
                    dgvContact.Rows[dgvContact.Rows.Count - 1].Cells["ColModify"] = new DataGridViewTextBoxCell();
                    dgvContact.Rows[dgvContact.Rows.Count - 1].Cells["ColDel"] = new DataGridViewTextBoxCell();
                }
            }
        }

        private void cmbUserName_DataSourceChanged(object sender, EventArgs e)
        {
            (cmbUserName.DataSource as 销售管理.DAL.DataSetUsers.T_UsersDataTable).AddT_UsersRow("", "", "", "", "", "", "", 0, 0);
        }

        private void cmbPromary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPromary.SelectedIndex != -1)
            {
                var mTable = new T_CityTableAdapter().GetDataByProID((long)cmbPromary.SelectedValue);
                cmbCity.DisplayMember = "cityName";
                cmbCity.ValueMember = "ID";
                cmbCity.DataSource = mTable;
            }
            else
            {
                cmbCity.DataSource = null;
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
