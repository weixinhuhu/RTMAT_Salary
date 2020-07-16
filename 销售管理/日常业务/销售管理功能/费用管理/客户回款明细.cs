using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common;

namespace 销售管理.日常业务.销售管理功能
{
    public partial class 客户回款明细 : Form
    {
        public long SaleDetailsId = -1;
        public 客户回款明细()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product3List_Load(object sender, EventArgs e)
        {
            string mSql;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            mSql = @"SELECT id, CompanyName,ReturnMoney,Notes,ReturnDate FROM dbo.T_Customers_MoneyReturnList
                    WHERE Status='正常' AND SaleDetailsId= "+SaleDetailsId ;
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvMoneyReturnList.DataSource = mTable;             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Classes.PubClass.Product3Name ="";
             Classes.PubClass.Product3Id = 0;
            Close();
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMoneyReturnList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {               
                if (e.ColumnIndex == dgvMoneyReturnList.Columns["ColDel"].Index)//删除
                {
                    if (MessageBox.Show("确认要删除该条记录吗?", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string mSql = string.Format("UPDATE T_Customers_MoneyReturnList SET Status = '{0}'  WHERE Id = {1}", "删除", Convert.ToInt64(dgvMoneyReturnList.Rows[e.RowIndex].Cells["id"].Value));
                        int ret = SqlHelper.ExecuteNonQuery(mSql);
                        if (ret > 0)
                        {
                            MessageBox.Show("删除成功!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                        }
                    }
                }
            }
        }
    }
}
