using System;

using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetAdvertisingFeeTableAdapters;
using System.Data;

namespace 销售管理.日常业务
{
    public partial class 广告宣传费用录入 : Form
    {
        public 广告宣传费用录入()
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
           
            if (string.IsNullOrEmpty(dtpDate1.Text.Trim()) == true)
            {
                toolTip1.Show("请输入分摊日期！", dtpDate1, 0, dtpDate1.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(TxtProjectName.Text.Trim()) == true)
            {
                toolTip1.Show("请输入费用说明！", TxtProjectName, 0, TxtProjectName.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(TxtSumMoney.Text.Trim()) == true)
            {
                toolTip1.Show("请输入分摊金额！", TxtSumMoney, 0, TxtSumMoney.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(TxtSumMoney.Text.Trim()) == false)
            {
                toolTip1.Show("请输入正确的分摊金额！", TxtSumMoney, 0, TxtSumMoney.Height, 2000);
                return;     
            }

            int ret = 0;
            if (mId == -1)
            {
                 ret = new T_AdvertisingFeeTableAdapter().Insert((long)cmbUserName.SelectedValue, TxtProjectName.Text, Convert.ToDecimal(TxtSumMoney.Text), dtpDate1.Value.Date);
            }
            else
            {
                 ret = new T_AdvertisingFeeTableAdapter().UpdateById((long)cmbUserName.SelectedValue, TxtProjectName.Text, Convert.ToDecimal(TxtSumMoney.Text), dtpDate1.Value.Date, mId);
            }

            if (ret > 0)
            {
                MessageBox.Show("保存成功");
                btnSave.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("保持失败");
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
                dt = new T_AdvertisingFeeTableAdapter().GetDataById(mId);
                if (dt.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetAdvertisingFee.T_AdvertisingFeeRow)dt.Rows[0];
                    cmbUserName.SelectedValue = mRow.UserName;
                    TxtProjectName.Text = mRow.ProjectName.ToString();                 
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

        private void TxtSumMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (".0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
