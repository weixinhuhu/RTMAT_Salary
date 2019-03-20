using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class CommonClass
    {
       

        public static string ConnStr;
        public static string SqlConnStr;
        public static string EFConnStr;
        
        //public static string gCardType = "CPU 卡(3DES)";        

        //登录
        public static string OperatorID = "0";
        public static int OperatorType;

        public static List<int> UserRightList = new List<int>();

        //销售回款管理 公司名称
        public static String CompanyName;

        public struct SttUser
        {
            public static string sUserID = "";
            public static string sUserName = "";
            public static Int32 iLevel = 0;
            public static bool blSuperUser = false;
        }
        public struct SttDb
        {
            /// <summary>
            /// -2:不支持; -1:未知; 0:Access; 1:SQLServer;
            /// </summary>
            public static Int32 iDBType = -1; //
            public static string sDbInfo = "";//用于显示在状态栏；
            public static string sDataSource = "";
            public static string sUserID = "";
            public static string sUserPass = "";
        }

        public struct SttIC
        {
            public static Int32 iCardType = -1;
        }

        public static void SetConnStr(string connStr,string sqlConnStr,string efConnStr)
        {
            ConnStr = connStr;
            SqlConnStr = sqlConnStr;
            EFConnStr = efConnStr;
            Common.Properties.Settings.Default.ConnectionString = connStr;
            
        }

       

    }
}
