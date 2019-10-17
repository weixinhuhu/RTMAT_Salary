
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetEmployCardRecordTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 考勤档案维护 : 销售管理.UserControlBase
    {

        public 考勤档案维护()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            this.openFileDialog1.Filter = "*.xls;*.xlsx|*.xls;*.xlsx";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileNames.Length == 0)
            {
                MessageBox.Show("请选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DataTable table = Classes.ExcelDeport.ImportFromExcel(openFileDialog1.FileName, "Sheet1", 0);
            ds.Tables.Add(table);
            dgv1.DataSource = ds.Tables[0];
            DataGridViewColumn c = new DataGridViewColumn();
            lbcount.Text = "待导入数据条数： "+ dgv1.RowCount+"条";
        }


        private void 考勤档案维护_Load(object sender, EventArgs e)
        {

        }



        private void btnExcel_Click(object sender, EventArgs e)
        {
            Classes.ExcelDeport.Deport1(dgv1, 2);
        }




        private void Button1_Click(object sender, EventArgs e)
        {
            String CardNum;
            int ret;

            //判断数据源有无数据
            if (dgv1.RowCount == 0)
            {
                 MessageBox.Show("无数据导入！");
                return;
            }

            Cursor = Cursors.WaitCursor;

            ////删除历史数据
            //try
            //{
            //    ret = new EmployCardRecordTableAdapter().DeleteQuery();
            //}
            //catch (Exception)
            //{
            //    Cursor = Cursors.Default;
            //    MessageBox.Show("数据库操作异常！");
            //}


            foreach (DataGridViewRow mRow in dgv1.Rows)
            {
                if (mRow.Cells[0].Value.ToString().Length > 22)
                {
                    try
                    {
                        CardNum = mRow.Cells[0].Value.ToString().Substring(0, 8);
                        DateTime dt = Convert.ToDateTime(mRow.Cells[0].Value.ToString().Substring(10, 4) + "-" +
                            mRow.Cells[0].Value.ToString().Substring(14, 2) + "-" +
                            mRow.Cells[0].Value.ToString().Substring(16, 2) + " " +
                            mRow.Cells[0].Value.ToString().Substring(18, 2) + ":" +
                            mRow.Cells[0].Value.ToString().Substring(20, 2) + ":" +
                            mRow.Cells[0].Value.ToString().Substring(22, 2));
                        ret = new EmployCardRecordTableAdapter().Insert(CardNum, dt, DateTime.Now, DateTime.Now);

                    }
                    catch (Exception)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("解析异常，请核实数据！错误行数： " + mRow);
                    }
                }
            }
            Cursor = Cursors.Default;
            MessageBox.Show("原始数据导入成功！", "共导入数据 " + dgv1.RowCount + "条");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string mSql;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            mSql = @"SELECT B.EmployId '员工编号',
                           B.EmployName '员工姓名',
	                       A.EmployCardNum '员工卡号',
                           CONVERT(CHAR(10), A.EmployRecord, 120) '日期',
                          MIN(A.EmployRecord) '上班时间' ,
	                      MAX(A.EmployRecord) '下班时间'      
                    FROM dbo.EmployCardRecord A
                        LEFT JOIN dbo.EmployInfo B
                            ON A.EmployCardNum = B.EmployCardNum                              
                    Where B.EmployId<>''  ";

            if (TxtEmployName.Text.Trim() != "")
            {

                mSql += " And B.EmployName= '" + TxtEmployName.Text.Trim() + "'";
            }

            if (TxtEmployId.Text.Trim() != "")
            {
                mSql += " And B.EmployId='" + TxtEmployId.Text.Trim() + "'";

            }

            if (dtpStart.Checked == true)
            {
                mSql += " AND A.EmployRecord BETWEEN '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
            }

            mSql += @" GROUP BY B.EmployId,
                             B.EmployName,
		                     A.EmployCardNum,
                             CONVERT(CHAR(10), A.EmployRecord, 120)
                             ORDER BY CONVERT(CHAR(10), A.EmployRecord, 120) DESC";

            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();

            try
            {
                adapter.Fill(mTable);
                dgv1.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("无数据返回！");
                    Cursor = Cursors.Default;
                    return;
                }
                lbcount.Text = "查询数据共：" + dgv1.RowCount + "条";
                Cursor = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Cursor = Cursors.Default;
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string mSql, mSql1;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            mSql = @"SELECT CONVERT(CHAR(10), A.EmployRecord, 120) '日期',
                            A.EmployCardNum '员工卡号',
                            B.EmployId '员工编号',
                            B.EmployName '员工姓名',	                                           
                          MIN(A.EmployRecord) '签卡时间' 	                         
                    FROM dbo.EmployCardRecord A
                        LEFT JOIN dbo.EmployInfo B
                            ON A.EmployCardNum = B.EmployCardNum                              
                    Where B.EmployId<>''  ";
            mSql1 = @" UNION ALL SELECT CONVERT(CHAR(10), A.EmployRecord, 120) '日期',
                            A.EmployCardNum '员工卡号',
                            B.EmployId '员工编号',
                            B.EmployName '员工姓名',
                          MAX(A.EmployRecord) '签卡时间'                       
                    FROM dbo.EmployCardRecord A
                        LEFT JOIN dbo.EmployInfo B
                            ON A.EmployCardNum = B.EmployCardNum                              
                    Where B.EmployId<>''  ";

            if (TxtEmployName.Text.Trim() != "")
            {

                mSql += " And B.EmployName= '" + TxtEmployName.Text.Trim() + "'";
                mSql1 += " And B.EmployName= '" + TxtEmployName.Text.Trim() + "'";
            }

            if (TxtEmployId.Text.Trim() != "")
            {
                mSql += " And B.EmployId='" + TxtEmployId.Text.Trim() + "'";
                mSql1 += " And B.EmployId='" + TxtEmployId.Text.Trim() + "'";
            }

            if (dtpStart.Checked == true)
            {
                mSql += " AND A.EmployRecord BETWEEN '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

                mSql1 += " AND A.EmployRecord BETWEEN '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";

            }

            mSql += @" GROUP BY B.EmployId,
                             B.EmployName,
		                     A.EmployCardNum,
                             CONVERT(CHAR(10), A.EmployRecord, 120)";
            mSql1 += @" GROUP BY B.EmployId,
                             B.EmployName,
		                     A.EmployCardNum,
                             CONVERT(CHAR(10), A.EmployRecord, 120)
                             ORDER BY CONVERT(CHAR(10), A.EmployRecord, 120) DESC";

            SqlDataAdapter adapter = new SqlDataAdapter(mSql + mSql1, conn);
            DataTable mTable = new DataTable();

            try
            {
                adapter.Fill(mTable);
                dgv1.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("无数据返回！");
                    Cursor = Cursors.Default;
                    return;
                }
                lbcount.Text = "查询数据共：" + dgv1.RowCount + "条";
                Cursor = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Cursor = Cursors.Default;
            }
        }

        private void DtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
