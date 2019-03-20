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
    public partial class 客户回款明细 : Form
    {
        public 客户回款明细()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product3List_Load(object sender, EventArgs e)
        {
            //string mSql;
            //SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            //mSql = @"SELECT Name,id  FROM dbo.T_Products WHERE ParentId=" + Classes.PubClass.Product2Id;
            //SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            //DataTable mTable = new DataTable();
            //try
            //{
            //    adapter.Fill(mTable);
            //    dgvProduct.DataSource = mTable;
            //    if (mTable.Rows.Count < 1)
            //    {
            //        MessageBox.Show("没有记录");
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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
    }
}
