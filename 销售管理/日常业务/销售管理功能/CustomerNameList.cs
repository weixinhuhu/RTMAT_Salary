using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 销售管理.日常业务.销售管理功能
{
    public partial class CustomerNameList : Form
    {
        public CustomerNameList()
        {
            InitializeComponent();
        }

        private void CustomerNameList_Load(object sender, EventArgs e)
        {
            string mSql;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            mSql = @"select CompanyName,id from dbo.T_Customers where OperName =" + Classes.PubClass.UserId;          
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvCustomerName.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mSql;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            mSql = @"select CompanyName,Id from dbo.T_Customers where OperName =" + Classes.PubClass.UserId + " and CompanyName like '%" + TxtCustomerName.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvCustomerName.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classes.PubClass.CompanyName = "";
            Classes.PubClass.CompanyId = 0;
            Close();
        }

        private void dgvCustomerName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.PubClass.CompanyId = 0;
            if (e.RowIndex > -1) {
                Classes.PubClass.CompanyName =Convert.ToString(dgvCustomerName.Rows[e.RowIndex].Cells["CompanyName"].Value);
                Classes.PubClass.CompanyId = Convert.ToInt64(dgvCustomerName.Rows[e.RowIndex].Cells["id"].Value);
                Close();
            }   
        }
    }
}
