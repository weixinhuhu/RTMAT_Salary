using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetProductsTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using 销售管理.DAL.DataSetMoneyReturnTableAdapters;
using System.Data.SqlClient;
using 销售管理.日常业务.销售管理功能;

namespace 销售管理.日常业务
{
    public partial class 销售回款录入1 : Form
    {
        public 销售回款录入1()
        {
            InitializeComponent();
        }
        public long mId = -1;
        private long CityId = -1;
        public String CompanyName = "";
        public String Username = "";
        public long SaleDetailsId = -1;


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbUserName.Text))
            {
                toolTip1.Show("请选择销售名称！", cmbUserName, 0, cmbUserName.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(cmbCustomerName.Text.Trim()) == true)
            {
                toolTip1.Show("请选择客户名称！", cmbCustomerName, 0, cmbCustomerName.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(dtpDate1.Text.Trim()) == true)
            {
                toolTip1.Show("请输入回款日期！", dtpDate1, 0, dtpDate1.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtStockOutNo.Text.Trim()) == true)
            {
                toolTip1.Show("请输入回款金额！", txtStockOutNo, 0, txtStockOutNo.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(txtStockOutNo.Text.Trim()) == false)
            {
                toolTip1.Show("请输入正确的回款金额！", txtStockOutNo, 0, txtStockOutNo.Height, 2000);
                return;     
            } 

            T_Customers_MoneyReturnListTableAdapter adapter = new T_Customers_MoneyReturnListTableAdapter();

            int ret = adapter.Insert(cmbUserName.Text, cmbCustomerName.Text, Convert.ToDecimal(txtStockOutNo.Text), dtpDate1.Value,txtNotes.Text.Trim(),"正常",SaleDetailsId);
            if (ret > 0)
            {
                MessageBox.Show("添加成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
                return;
            }
        }

        private void 销售明细维护_Load(object sender, EventArgs e)
        {
            cmbCustomerName.Text = CompanyName;
            cmbUserName.Text = Username;
        }

        public class MyCmbList
        {
            private Int64 mId;
            private string mName;

            public Int64 Id
            {
                set
                {
                    mId = value;
                }
                get
                {
                    return mId;
                }
            }

            public string Name
            {
                set
                {
                    mName = value;
                }
                get
                {
                    return mName;
                }
            }
            public override string ToString()
            {
                return Name;
            }
        }
 
        private void cmbCustomerName_DataSourceChanged(object sender, EventArgs e)
        {
            cmbCustomerName.SelectedIndex = -1;
        }

        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbCustomerName.Text = "";
            Classes.PubClass.CompanyName = "";

            if (cmbUserName.SelectedIndex > -1)
            {
                Classes.PubClass.UserId = (long)cmbUserName.SelectedValue;
                CustomerNameList mForm = new CustomerNameList();
                mForm.ShowDialog();
            }
            
            if(Classes.PubClass.CompanyName!=""){
                cmbCustomerName.Text = Classes.PubClass.CompanyName;
                var table = new T_CustomersTableAdapter().GetDataById((long)Classes.PubClass.CompanyId);
                if (table.Rows.Count > 0)
                {
                    if (((销售管理.DAL.DataSetCustomers.T_CustomersRow)table.Rows[0]).IsCityIDNull() == true)
                    {
                        //MessageBox.Show("请先设置该客户所在地区");
                        //btnSave.Enabled = false;
                    }
                    else btnSave.Enabled = true;
                    CityId = ((销售管理.DAL.DataSetCustomers.T_CustomersRow)table.Rows[0]).IsCityIDNull() == true ? -1 : ((销售管理.DAL.DataSetCustomers.T_CustomersRow)table.Rows[0]).CityID;
                }
                else
                {
                    CityId = -1;
                }        
            }

        }

        private void cmbCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedIndex > -1)
            {
                var table = new T_CustomersTableAdapter().GetDataById((long)cmbCustomerName.SelectedValue);
               
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("-0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (".0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtStockOutNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (".0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
