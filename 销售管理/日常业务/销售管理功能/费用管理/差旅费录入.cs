using System;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using 销售管理.DAL.DataSetTravelExpensesTableAdapters;
using 销售管理.日常业务.销售管理功能;
using System.Data;

namespace 销售管理.日常业务
{
    public partial class 差旅费录入 : Form
    {
        public 差旅费录入()
        {
            InitializeComponent();
        }
        public long mId = -1;
        private long ProductId = -1;
        private long CityId = -1;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedIndex == -1)
            {
                toolTip1.Show("请选择销售名称！", cmbUserName, 0, cmbUserName.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(cmbCustomerName.Text.Trim()) == true)
            {
                toolTip1.Show("请选择客户名称！", cmbCustomerName, 0, cmbCustomerName.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(Txt1.Text.Trim()) == true)
            {
                toolTip1.Show("请输入" + lb1.Text, Txt1, 0, Txt1.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(Txt1.Text.Trim()) == false)
            {
                toolTip1.Show(lb1.Text + "输入不合法", Txt1, 0, Txt1.Height, 2000);
                return;
            }

            if (string.IsNullOrEmpty(Txt2.Text.Trim()) == true)
            {
                toolTip1.Show("请输入" + lb2.Text, Txt2, 0, Txt2.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(Txt2.Text.Trim()) == false)
            {
                toolTip1.Show(lb2.Text + "输入不合法", Txt2, 0, Txt2.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(TxtSumMoney.Text.Trim()) == true)
            {
                toolTip1.Show("请输入" + lb3.Text, TxtSumMoney, 0, Txt1.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(TxtSumMoney.Text.Trim()) == false)
            {
                toolTip1.Show(lb3.Text + "输入不合法", TxtSumMoney, 0, TxtSumMoney.Height, 2000);
                return;
            }


            int ret = 0;
            if (mId == -1)
            {
                ret = new T_TravelExpensesTableAdapter().Insert((long)cmbUserName.SelectedValue, (long)cmbCustomerName.SelectedValue, TxtPorjectName.Text, Convert.ToDecimal(Txt1.Text), Convert.ToDecimal(Txt2.Text), Convert.ToDecimal(TxtSumMoney.Text), dtpDate1.Value.Date);
            }
            else
            {
                ret = new T_TravelExpensesTableAdapter().UpdateById((long)cmbUserName.SelectedValue, (long)cmbCustomerName.SelectedValue, TxtPorjectName.Text, Convert.ToDecimal(Txt1.Text), Convert.ToDecimal(Txt2.Text), Convert.ToDecimal(TxtSumMoney.Text), dtpDate1.Value.Date,mId);
            }

            if (ret > 0)
            {
                MessageBox.Show("保存成功");
                btnSave.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("保存失败");
                return;
            }
        }

        private void 销售明细维护_Load(object sender, EventArgs e)
        {    
            //获取销售名单
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "id";
            cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
            cmbUserName.SelectedIndex = -1;

            if (mId == -1)
            {
            }
            else
            {
                DataTable dt = new DataTable();
                dt = new T_TravelExpensesTableAdapter().GetDataById(mId);
                if (dt.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetTravelExpenses.T_TravelExpensesRow)dt.Rows[0];

                    cmbUserName.SelectedValue = mRow.UserName;
                    cmbCustomerName.SelectedValue = mRow.CustomerName;                      
                    TxtPorjectName.Text = mRow.ProjectName.ToString();                 
                    Txt1.Text = mRow.Price1.ToString("0.00");
                    Txt2.Text = mRow.Price2.ToString("0.00");                               
                    TxtSumMoney.Text = mRow.SumMoney.ToString("0.00");
                    dtpDate1.Value = mRow.SalaryDate;
                }
            }
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


        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbCustomerName.DataSource = null;
            if (cmbUserName.SelectedIndex > -1)
            {
                cmbCustomerName.DisplayMember = "CompanyName";
                cmbCustomerName.ValueMember = "id";
                cmbCustomerName.DataSource = new T_CustomersTableAdapter().GetDataByUserId((long)cmbUserName.SelectedValue);
                cmbCustomerName.SelectedIndex = -1;
            }
        }

        private void cmbCustomerName_DataSourceChanged(object sender, EventArgs e)
        {
            cmbCustomerName.SelectedIndex = -1;
        }

        private void cmbCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
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

        

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtStockOutNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {
            Decimal price1, price2;
            if (Decimal.TryParse(Txt1.Text, out price1) == true && Decimal.TryParse(Txt2.Text, out price2) == true)
            {
                TxtSumMoney.Text = (price1 + price2).ToString("0.00");
            }
        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {
            Decimal price1, price2;
            if (Decimal.TryParse(Txt1.Text, out price1) == true && Decimal.TryParse(Txt2.Text, out price2) == true)
            {
                TxtSumMoney.Text = (price1 + price2).ToString("0.00");
            }
        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (".0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (".0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtSumMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (".0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
