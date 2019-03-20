using System;
using System.Data;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUserSalaryTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.日常业务.销售管理功能;

namespace 销售管理.日常业务
{
    public partial class 薪资录入 : Form
    {
        public 薪资录入()
        {
            InitializeComponent();
        }
        public long mId = -1;
        

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
                toolTip1.Show("请输入工资发放时间！", dtpDate1, 0, dtpDate1.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(Txt1.Text.Trim()) == true)
            {
                toolTip1.Show("请输入"+lb1.Text, Txt1, 0, Txt1.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(Txt1.Text.Trim()) == false)
            {
                toolTip1.Show(lb1.Text+"输入不合法", Txt1, 0, Txt1.Height, 2000);
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

            if (string.IsNullOrEmpty(Txt3.Text.Trim()) == true)
            {
                toolTip1.Show("请输入" + lb3.Text, Txt3, 0, Txt1.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(Txt3.Text.Trim()) == false)
            {
                toolTip1.Show(lb3.Text + "输入不合法", Txt3, 0, Txt3.Height, 2000);
                return;
            }

            if (string.IsNullOrEmpty(Txt4.Text.Trim()) == true)
            {
                toolTip1.Show("请输入" + lb4.Text, Txt4, 0, Txt4.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(Txt4.Text.Trim()) == false)
            {
                toolTip1.Show(lb4.Text + "输入不合法", Txt1, 0, Txt4.Height, 2000);
                return;
            }

            if (string.IsNullOrEmpty(Txt5.Text.Trim()) == true)
            {
                toolTip1.Show("请输入" + lb5.Text, Txt5, 0, Txt5.Height, 2000);
                return;
            }
            if (Classes.PubClass.IsDecimalSign(Txt5.Text.Trim()) == false)
            {
                toolTip1.Show(lb5.Text + "输入不合法", Txt5, 0, Txt5.Height, 2000);
                return;
            }

            int ret = 0;

            if (mId == -1)
            {
                 ret = new T_UserSalaryTableAdapter().Insert1((long)cmbUserName.SelectedValue, Convert.ToDecimal(Txt1.Text), Convert.ToDecimal(Txt2.Text), Convert.ToDecimal(Txt3.Text), Convert.ToDecimal(Txt4.Text), Convert.ToDecimal(Txt5.Text), Convert.ToDecimal(TxtSumMoney.Text), dtpDate1.Value.Date);
            }
            else
            {
                ret = new T_UserSalaryTableAdapter().UpdateById((long)cmbUserName.SelectedValue, Convert.ToDecimal(Txt1.Text), Convert.ToDecimal(Txt2.Text), Convert.ToDecimal(Txt3.Text), Convert.ToDecimal(Txt4.Text), Convert.ToDecimal(Txt5.Text), Convert.ToDecimal(TxtSumMoney.Text), dtpDate1.Value.Date,mId);
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
            }else
            {
                DataTable dt = new DataTable();
                dt = new T_UserSalaryTableAdapter().GetDataById(mId);

                if (dt.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetUserSalary.T_UserSalaryRow)dt.Rows[0];

                    cmbUserName.SelectedValue = mRow.UserName;                
                    dtpDate1.Value = mRow.SalaryDate;
                    Txt1.Text = mRow.Price1.ToString("0.00");
                    Txt2.Text = mRow.Price2.ToString("0.00");
                    Txt3.Text = mRow.Price3.ToString("0.00");
                    Txt4.Text = mRow.Price4.ToString("0.00");
                    Txt5.Text = mRow.Price5.ToString("0.00");
                    TxtSumMoney.Text = mRow.SumMoney.ToString("0.00");
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

      
      
    
        private void cmbCustomerName_DataSourceChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            Classes.PubClass.CompanyName = "";

            if (cmbUserName.SelectedIndex > -1)
            {
                Classes.PubClass.UserId = (long)cmbUserName.SelectedValue;
                CustomerNameList mForm = new CustomerNameList();
                mForm.ShowDialog();
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

        private void Txt3_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (".0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (".0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Txt4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt1_TextChanged(object sender, EventArgs e)
        {
            Decimal price1, price2, price3, price4, price5;
            if (Decimal.TryParse(Txt1.Text, out price1) == true && Decimal.TryParse(Txt2.Text, out price2) == true && Decimal.TryParse(Txt3.Text, out price3) == true && Decimal.TryParse(Txt4.Text, out price4) == true && Decimal.TryParse(Txt5.Text, out price5) == true)
            {
                TxtSumMoney.Text = (price1 + price2 + price3 + price4 + price5).ToString("0.00");
            }
        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {
            Decimal price1, price2, price3, price4, price5;
            if (Decimal.TryParse(Txt1.Text, out price1) == true && Decimal.TryParse(Txt2.Text, out price2) == true && Decimal.TryParse(Txt3.Text, out price3) == true && Decimal.TryParse(Txt4.Text, out price4) == true && Decimal.TryParse(Txt5.Text, out price5) == true)
            {
                TxtSumMoney.Text = (price1 + price2 + price3 + price4 + price5).ToString("0.00");
            }
        }

        private void Txt3_TextChanged(object sender, EventArgs e)
        {
            Decimal price1, price2, price3, price4, price5;
            if (Decimal.TryParse(Txt1.Text, out price1) == true && Decimal.TryParse(Txt2.Text, out price2) == true && Decimal.TryParse(Txt3.Text, out price3) == true && Decimal.TryParse(Txt4.Text, out price4) == true && Decimal.TryParse(Txt5.Text, out price5) == true)
            {
                TxtSumMoney.Text = (price1 + price2 + price3 + price4 + price5).ToString("0.00");
            }
        }

        private void Txt4_TextChanged(object sender, EventArgs e)
        {
            Decimal price1, price2, price3, price4, price5;
            if (Decimal.TryParse(Txt1.Text, out price1) == true && Decimal.TryParse(Txt2.Text, out price2) == true && Decimal.TryParse(Txt3.Text, out price3) == true && Decimal.TryParse(Txt4.Text, out price4) == true && Decimal.TryParse(Txt5.Text, out price5) == true)
            {
                TxtSumMoney.Text = (price1 + price2 + price3 + price4 + price5).ToString("0.00");
            }
        }

        private void Txt5_TextChanged(object sender, EventArgs e)
        {
            Decimal price1, price2, price3, price4, price5;
            if (Decimal.TryParse(Txt1.Text, out price1) == true && Decimal.TryParse(Txt2.Text, out price2) == true && Decimal.TryParse(Txt3.Text, out price3) == true && Decimal.TryParse(Txt4.Text, out price4) == true && Decimal.TryParse(Txt5.Text, out price5) == true)
            {
                TxtSumMoney.Text = (price1 + price2 + price3 + price4 + price5).ToString("0.00");
            }
        }

        private void TxtSumMoney_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
       
    }

