using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;

using System.Data;

namespace 销售管理.Classes
{
    static class ExcelDeport
    {
        static public int Deport(System.Windows.Forms.DataGridView mView,string outName)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;

                //DataGridView mView = dgvReport;

                //添加标头
                IRow mRow = mSheet.CreateRow(0);
                for (i = 0; i <= mView.Columns.Count - 1; i++)
                {
                    mCell = mRow.CreateCell(i);
                    mCell.SetCellValue(mView.Columns[i].HeaderText);
                    mCell.CellStyle = styleRight;
                }
                //添加内容

                for (i = 1; i <= mView.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i);
                    for (j = 0; j <= mView.Columns.Count - 1; j++)
                    {
                        mCell = mRow.CreateCell(j);
                        mCell.SetCellType(NPOI.SS.UserModel.CellType.String);

                        mCell.SetCellValue(Convert.ToString(mView.Rows[i - 1].Cells[j].Value.ToString()));
                        mCell.CellStyle = styleRight;

                    }
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = outName+ "-" + DateTime.Now.ToString("yyyyMMddhhmmss");
                if (mDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream mFile = mDialog.OpenFile();
                    mWorkbook.Write(mFile);
                    mFile.Close();
                    MessageBox.Show("保存成功！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return 0;
        }

        static public int Deport(System.Windows.Forms.DataGridView mView, int startIndex)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;
                int x = 0;
                //DataGridView mView = dgvReport;

                //添加标头
                IRow mRow = mSheet.CreateRow(0);
                for (i = startIndex; i <= mView.Columns.Count - 1; i++)
                {
                    if (mView.Columns[i].Visible == true)
                    {
                        mCell = mRow.CreateCell(x);
                        x++;
                        mCell.SetCellValue(mView.Columns[i].HeaderText);
                        mCell.CellStyle = styleRight;
                    }
                }
                //添加内容

                for (i = 1; i <= mView.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i);
                    x = 0;
                    for (j = startIndex; j <= mView.Columns.Count - 1; j++)
                    {
                        if (mView.Columns[j].Visible == true)
                        {
                            mCell = mRow.CreateCell(x);
                            x++;
                            if (Classes.PubFunc.IsNumber(Convert.ToString(mView.Rows[i - 1].Cells[j].Value)) == true)
                            {
                                mCell.SetCellValue(Convert.ToDouble(mView.Rows[i - 1].Cells[j].Value));
                            }
                            else
                            {
                                mCell.SetCellValue(Convert.ToString(mView.Rows[i - 1].Cells[j].Value));
                            }
                            mCell.CellStyle = styleRight;
                        }

                    }
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = "导出数据-" + DateTime.Now.ToString("yyyyMMddhhmmss");
                if (mDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream mFile = mDialog.OpenFile();
                    mWorkbook.Write(mFile);
                    mFile.Close();
                    MessageBox.Show("保存成功！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return 0;
        }

        static public int Deport1(System.Windows.Forms.DataGridView mView, int startIndex)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;
                int x = 0;
                //DataGridView mView = dgvReport;

                //添加标头
                IRow mRow = mSheet.CreateRow(0);
                for (i = startIndex; i <= mView.Columns.Count - 1; i++)
                {
                    if (mView.Columns[i].Visible == true)
                    {
                        mCell = mRow.CreateCell(x);
                        x++;
                        mCell.SetCellValue(mView.Columns[i].HeaderText);
                        mCell.CellStyle = styleRight;
                    }
                }
                //添加内容

                for (i = 1; i <= mView.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i);
                    x = 0;
                    for (j = startIndex; j <= mView.Columns.Count - 1; j++)
                    {
                        if (mView.Columns[j].Visible == true)
                        {
                            mCell = mRow.CreateCell(x);

                            x++;

                            if (j <= mView.Columns.Count - 2)
                            {
                                mCell.SetCellValue(Convert.ToString(mView.Rows[i - 1].Cells[j].Value.ToString().Replace(" ","" )));
                            }
                            else
                            {
                                mCell.SetCellValue(Convert.ToString(mView.Rows[i - 1].Cells[j].Value));
                            }

                            mCell.CellStyle = styleRight;
                        }

                    }
                }
                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = "导出数据-" + DateTime.Now.ToString("yyyyMMddhhmmss");
                if (mDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream mFile = mDialog.OpenFile();
                    mWorkbook.Write(mFile);
                    mFile.Close();
                    MessageBox.Show("保存成功！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return 0;
        }


        static public int InvoiceDeport(System.Windows.Forms.DataGridView mView)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                styleRight.WrapText = true;
                ICell mCell;
                int i;


                //添加标头
                IRow mRow = mSheet.CreateRow(0);

                int m = 0;
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("公司名称");
                mSheet.SetDefaultColumnStyle(m, styleRight);//设置样式
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("总金额");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("发票类型");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("开票日期");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("商品名称");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("单价");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("数量");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("金额");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                //添加内容
                int mExcelRowCount = 1;
                for (i = 0; i <= mView.RowCount - 1; i++)
                {
                    if (Convert.ToBoolean(mView.Rows[i].Cells["ColCombine"].Value) == true)
                    {
                        mRow = mSheet.CreateRow(mExcelRowCount++);
                        string InvoiceContent = string.Empty;
                        //公司名称
                        mCell = mRow.CreateCell(0);
                        mCell.SetCellValue(Convert.ToString(mView.Rows[i].Cells["customerNameDataGridViewTextBoxColumn"].Value));
                        //总金额
                        mCell = mRow.CreateCell(1);
                        mCell.SetCellValue(Convert.ToString(mView.Rows[i].Cells["invoiceMoneyDataGridViewTextBoxColumn"].Value));
                        //发票类型
                        mCell = mRow.CreateCell(2);
                        mCell.SetCellValue(Convert.ToString(mView.Rows[i].Cells["invoiceTypeDataGridViewTextBoxColumn"].Value));
                        //开票日期
                        mCell = mRow.CreateCell(3);
                        mCell.SetCellValue(Convert.ToString(mView.Rows[i].Cells["invoiceDateDataGridViewTextBoxColumn"].Value));
                        //开票内容
                        InvoiceContent = Convert.ToString(mView.Rows[i].Cells["invoiceContentDataGridViewTextBoxColumn"].Value);
                        string[] contents = System.Text.RegularExpressions.Regex.Split(InvoiceContent, "!#!");
                        for (int n = 0; n < contents.Length - 3; n += 4)
                        {
                            mCell = mRow.CreateCell(4);
                            mCell.SetCellValue(contents[n]);
                            mCell = mRow.CreateCell(5);
                            mCell.SetCellValue(contents[n + 1]);
                            mCell = mRow.CreateCell(6);
                            mCell.SetCellValue(contents[n + 2]);
                            mCell = mRow.CreateCell(7);
                            mCell.SetCellValue(contents[n + 3]);

                            if (n < contents.Length - 7) mRow = mSheet.CreateRow(mExcelRowCount++);
                        }
                        mSheet.CreateRow(mExcelRowCount++);
                    }
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = "开票-" + DateTime.Now.ToString("yyyyMMddhhmmss");
                if (mDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream mFile = mDialog.OpenFile();
                    mWorkbook.Write(mFile);
                    mFile.Close();
                    MessageBox.Show("保存成功！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return 0;
        }
        /// <summary>
        /// 判断是否为兼容模式
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static bool GetIsCompatible(string filePath)
        {
            return filePath.EndsWith(".xls", StringComparison.OrdinalIgnoreCase);
        }



        /// <summary>
        /// 创建工作薄
        /// </summary>
        /// <param name="isCompatible"></param>
        /// <returns></returns>
        private static IWorkbook CreateWorkbook(bool isCompatible)
        {
            if (isCompatible)
            {
                return new HSSFWorkbook();
            }
            else
            {
                return new HSSFWorkbook();
            }
        }

        /// <summary>
        /// 创建工作薄(依据文件流)
        /// </summary>
        /// <param name="isCompatible"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        private static IWorkbook CreateWorkbook(bool isCompatible, Stream stream)
        {
            if (isCompatible)
            {
                return new HSSFWorkbook(stream);
            }
            else
            {
                return new HSSFWorkbook(stream);
            }
        }


        /// <summary>
        /// 从工作表中生成DataTable
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="headerRowIndex"></param>
        /// <returns></returns>
        private static DataTable GetDataTableFromSheet(ISheet sheet, int headerRowIndex)
        {
            DataTable table = new DataTable();

            IRow headerRow = sheet.GetRow(headerRowIndex);
            try
            {
                int cellCount = headerRow.LastCellNum;

                for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                {
                    //调用GetCellValue()函数
                    ICell cells = headerRow.GetCell(i); //一个单元格
                    string GCV = GetCellValue(cells);

                    if (GCV == null || GCV.Trim() == "")
                    {
                        // 如果遇到第一个空列，则不再继续向后读取
                        cellCount = i + 1;
                        break;

                    }
                    DataColumn column = new DataColumn(GCV);
                    table.Columns.Add(column);

                }

                for (int i = (headerRowIndex + 1); i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);

                    //调用GetCellValue()函数
                    ICell cell = row.Cells[0]; //一个单元格
                    string GC = GetCellValue(cell);

                    // if (row != null && !string.IsNullOrEmpty(row.Cells[0].StringCellValue))
                    if (row != null && !string.IsNullOrEmpty(GC))
                    {
                        DataRow dataRow = table.NewRow();

                        for (int j = row.FirstCellNum; j < cellCount; j++)
                        {
                            if (row.GetCell(j) != null)
                            {

                                //调用GetCellValue()函数
                                ICell cells = row.GetCell(j); //一个单元格
                                string GCV = GetCellValue(cells);
                                dataRow[j] = GCV.ToString();

                                // dataRow[j] = row.GetCell(j).ToString();
                            }
                        }

                        table.Rows.Add(dataRow);
                    }
                }
            }
            catch
            {
                MessageBox.Show("文件内容格式不对!\n\n存在空内容或者列名相同\n\n请重新选择", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return table;
        }


        #region 公共导入方法

        /// <summary>
        /// 由Excel导入DataTable
        /// </summary>
        /// <param name="excelFileStream">Excel文件流</param>
        /// <param name="sheetName">Excel工作表名称</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <param name="isCompatible">是否为兼容模式</param>
        /// <returns>DataTable</returns>
        public static DataTable ImportFromExcel(Stream excelFileStream, string sheetName, int headerRowIndex, bool isCompatible)
        {
            IWorkbook workbook = CreateWorkbook(isCompatible, excelFileStream);
            ISheet sheet = null;
            int sheetIndex = -1;
            if (int.TryParse(sheetName, out sheetIndex))
            {
                sheet = workbook.GetSheetAt(sheetIndex);
            }
            else
            {
                sheet = workbook.GetSheet(sheetName);
            }

            DataTable table = GetDataTableFromSheet(sheet, headerRowIndex);

            excelFileStream.Close();
            workbook = null;
            sheet = null;
            return table;
        }

        /// <summary>
        /// 由Excel导入DataTable
        /// </summary>
        /// <param name="excelFilePath">Excel文件路径，为物理路径。</param>
        /// <param name="sheetName">Excel工作表名称</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <returns>DataTable</returns>
        public static DataTable ImportFromExcel(string excelFilePath, string sheetName, int headerRowIndex)
        {

            try
            {
                using (FileStream stream = System.IO.File.OpenRead(excelFilePath))
                {
                    bool isCompatible = GetIsCompatible(excelFilePath);
                    return ImportFromExcel(stream, sheetName, headerRowIndex, isCompatible);
                }
            }
            catch
            {
                MessageBox.Show("请关闭文件,再导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataTable DT = new DataTable();
                return DT;

            }

        }

        /// <summary>
        /// 由Excel导入DataSet，如果有多个工作表，则导入多个DataTable
        /// </summary>
        /// <param name="excelFileStream">Excel文件流</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <param name="isCompatible">是否为兼容模式</param>
        /// <returns>DataSet</returns>
        public static DataSet ImportFromExcel(Stream excelFileStream, int headerRowIndex, bool isCompatible)
        {
            DataSet ds = new DataSet();
            IWorkbook workbook = CreateWorkbook(isCompatible, excelFileStream);
            for (int i = 0; i < workbook.NumberOfSheets; i++)
            {
                ISheet sheet = workbook.GetSheetAt(i);
                DataTable table = GetDataTableFromSheet(sheet, headerRowIndex);
                ds.Tables.Add(table);
            }

            excelFileStream.Close();
            workbook = null;

            return ds;
        }

        /// <summary>
        /// 由Excel导入DataSet，如果有多个工作表，则导入多个DataTable
        /// </summary>
        /// <param name="excelFilePath">Excel文件路径，为物理路径。</param>
        /// <param name="headerRowIndex">Excel表头行索引</param>
        /// <returns>DataSet</returns>
        public static DataSet ImportFromExcel(string excelFilePath, int headerRowIndex)
        {
            try
            {
                using (FileStream stream = System.IO.File.OpenRead(excelFilePath))
                {
                    bool isCompatible = GetIsCompatible(excelFilePath);
                    return ImportFromExcel(stream, headerRowIndex, isCompatible);
                }
            }
            catch
            {
                MessageBox.Show("请关闭文件,再导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }
        }

        #endregion


        #region 数值转换string
        private static string GetCellValue(ICell cell)
        {
            if (cell == null)
                return string.Empty;
            switch (cell.CellType)
            {
                case CellType.Blank: //空数据类型 这里类型注意一下，不同版本NPOI大小写可能不一样,有的版本是Blank（首字母大写)
                    return string.Empty;
                case CellType.Boolean: //bool类型
                    return cell.BooleanCellValue.ToString();
                case CellType.Error:
                    return cell.ErrorCellValue.ToString();
                case CellType.Numeric: //数字类型
                    if (NPOI.HSSF.UserModel.HSSFDateUtil.IsCellDateFormatted(cell))//日期类型
                    {
                        return cell.DateCellValue.ToString();
                    }
                    else //其它数字
                    {
                        return cell.NumericCellValue.ToString();
                    }
                case CellType.Unknown: //无法识别类型
                default: //默认类型
                    return cell.ToString();//
                case CellType.String: //string 类型
                    return cell.StringCellValue;
                case CellType.Formula: //带公式类型
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);
                        e.EvaluateInCell(cell);
                        return cell.ToString();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString();
                    }
            }
        }
        #endregion

    }


}
