//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 销售管理.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DaInvoice
    {
        public DaInvoice()
        {
            this.VcNum = "";
            this.VcUnit = "";
            this.NumCount = 0m;
            this.MonPrice = 0m;
            this.MonSumNoTax = 0m;
            this.MonSum = 0m;
        }
    
        public int IntID { get; set; }
        public string VcNum { get; set; }
        public string VcUnit { get; set; }
        public decimal NumCount { get; set; }
        public decimal MonPrice { get; set; }
        public decimal MonSumNoTax { get; set; }
        public decimal MonSum { get; set; }
        public int IntStatus { get; set; }
        public string VcRemark { get; set; }
        public System.DateTime DtCreate { get; set; }
        public long IntEmpNum { get; set; }
        public int IntGoodsID { get; set; }
        public int IntContractGoodsID { get; set; }
        public string VcStockInNo { get; set; }
    
        public virtual T_Users T_Users { get; set; }
        public virtual DaGoods DaGood { get; set; }
        public virtual DaContractGood DaContractGood { get; set; }
        public virtual ZdInvoiceStatu ZdInvoiceStatu { get; set; }
    }
}
