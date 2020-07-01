using System;
using 销售管理.DAL.DataSetGiftStockOutTableAdapters;
using 销售管理.DAL.DataSetMealsTableAdapters;

namespace 销售管理.BLL
{
    public  class Sa
    {
        public static int GetGiftLeaderUnAuditCount()
        {
            //using (T_GiftStockOutTableAdapter ad = new T_GiftStockOutTableAdapter())
            //{
            //    return Convert.ToInt32(ad.GetLeaderUnAuditCount());
            //}
            return 0;
        }

        public static int GetMealLeaderUnAuditCount()
        {
            using (T_MealsTableAdapter ad = new T_MealsTableAdapter())
            {
                return Convert.ToInt32(ad.GetLeaderUnAuditCount());
            }
            
        }

        public static int GetNoTicketUnFAuditCount()
        {
          string  sql= @"SELECT count(Id) FROM  T_NoTicket where P2='未复核' AND P1='正常'";
          return Convert.ToInt32(Common.SqlHelper.ExecuteScalar(sql));
        }
        public static int GetNoTicketUnAuditCount()
        {
            string sql = @"SELECT count(Id) FROM  T_NoTicket where status='未审批' AND P1='正常'";
            return Convert.ToInt32(Common.SqlHelper.ExecuteScalar(sql));
        }




    }
}
