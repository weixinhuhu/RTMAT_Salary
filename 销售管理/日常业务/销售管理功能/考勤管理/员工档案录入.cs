using System;
using System.Data;
using System.Windows.Forms;
using 销售管理.DAL.DataSetEmployInfoTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 员工档案录入 : Form
    {
        public 员工档案录入()
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
            int ret = 0;

            if (mId == -1)
            {
                ret = new EmployInfoTableAdapter().Insert(TxtEmployId.Text.Trim(),TxtEmployName.Text.Trim(),TxtEmployCarfNum.Text,TxtEmployDepartment.Text,"正常", DateTime.Now, DateTime.Now);

            }
            else
            {
               ret = new EmployInfoTableAdapter().UpdateQueryById(TxtEmployId.Text.Trim(), TxtEmployName.Text.Trim(), TxtEmployCarfNum.Text, TxtEmployDepartment.Text, DateTime.Now, Convert.ToInt32(mId));
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

        private void 员工档案录入_Load(object sender, EventArgs e)
        {
            if (mId == -1)
            {
            }
            else
            {
                DataTable dt = new DataTable();
                dt = new EmployInfoTableAdapter().GetDataById(Convert.ToInt32(mId));

                if (dt.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetEmployInfo.EmployInfoRow)dt.Rows[0];
                    TxtEmployId.Text = mRow.EmployId.Replace(" ","");
                    TxtEmployName.Text = mRow.EmployName.Replace(" ", "");
                    TxtEmployCarfNum.Text = mRow.EmployCardNum.Replace(" ", "");
                    TxtEmployDepartment.Text = mRow.EmployCardDepartment.Replace(" ", "");
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

            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtSumMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("-0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
