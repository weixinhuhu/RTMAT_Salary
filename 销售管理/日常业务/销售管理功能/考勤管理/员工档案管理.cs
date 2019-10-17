using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetUsersTableAdapters;
using Common;
using 销售管理.DAL.DataSetPromaryTableAdapters;
namespace 销售管理.日常业务
{
    public partial class 员工档案管理 : 销售管理.UserControlBase
    {
        public 员工档案管理()
        {
            InitializeComponent();
        }

        private void 员工档案管理_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            员工档案录入 mForm = new 员工档案录入();        
            mForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvEmployInfo.EndEdit();
        }

        private void dgvContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                      员工档案录入 mForm = new 员工档案录入();
                        mForm.mId = Convert.ToInt64(dgvEmployInfo.Rows[e.RowIndex].Cells["ID"].Value);
                        mForm.ShowDialog();                   
                }              
                }
            }

        private void Button1_Click(object sender, EventArgs e)
        {
            string mSql;
            mSql = @"SELECT a.Id,
                           a.EmployId ,
                           a.EmployName ,
                           a.EmployCardNum,
                           a.EmployCardDepartment
                    FROM dbo.EmployInfo a
                    WHERE 1=1";

            if (TxtEmployName.Text.Trim() != "")
            {
                mSql += " and EmployName like '%" + TxtEmployName.Text.Trim() + "%'";
            }
            if (TxtEmployId.Text.Trim() != "")
            {
                mSql += " and EmployId like '%" + TxtEmployId.Text.Trim() + "%'";
            }
            if (TxtEmployCardNum.Text.Trim() != "")
            {
                mSql += " and EmployCardNum like '%" + TxtEmployCardNum.Text.Trim() + "%'";
            }

            try
            {
                DataTable mTable = SqlHelper.GetData(mSql);
                dgvEmployInfo.DataSource = mTable;
                if ((dgvEmployInfo.DataSource as DataTable).Rows.Count < 0)
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
    }  
}
