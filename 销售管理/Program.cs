using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using 销售管理.DAL.DataSetT_UpdateTableAdapters;

namespace 销售管理
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //获取连接字符串
            Common.SqlConnectionSet.SetConnStr("DBInfo.xml");
          
        if (Common.SqlHelper.TestDB() == 0)
            {
                //检查本程序是否有更新
                Version sVer = new Version(Convert.ToString(new T_UpdateTableAdapter().GetMaxVer()));
                Version mVer = Assembly.GetExecutingAssembly().GetName().Version;
                if (sVer > mVer)
                {
                    System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "升级.exe");
                    return;
                }
                //更新本程序以外的其它文件
                var mFilesTable = new T_UpdateTableAdapter().GetOtherProgramMaxVer();
                foreach (DAL.DataSetT_Update.T_UpdateRow mFile in mFilesTable.Rows)
                {
                    byte[] bFile;
                    string mPath;                   
                    bFile = mFile.Content;
                    if (string.IsNullOrEmpty(mFile.Dir) == false)
                    {
                        mPath = AppDomain.CurrentDomain.BaseDirectory + mFile.Dir + "\\" + mFile.ProgramName;
                    }
                    else
                    {
                        mPath = AppDomain.CurrentDomain.BaseDirectory + mFile.ProgramName;
                    }
                    if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + mFile.Dir) == false)
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + mFile.Dir);
                    }
                    try
                    {
                        using (FileStream fs = new FileStream(mPath, FileMode.Create))
                        {

                            fs.Write(bFile, 0, bFile.Length);
                            fs.Close();
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                Application.Run(new LoginForm1());
            }
            else
            {
                MessageBox.Show("数据库连接失败！请重新选择数据库源");        
                Application.Run(new LoginForm1());
            }    
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hwnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern long GetWindowLong(IntPtr hwnd, int nIndex);
        private const int SW_SHOWNOACTIVATE = 4;
        const int GWL_STYLE = -16;
        const long WS_MINIMIZE = 0x20000000L;
    }
}
