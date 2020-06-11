using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwUcSalesMixWithFrontendCateogry
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleName")] 
        [MaxLength(510)] 
        public string? @saleName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("costPrice")] 
        public decimal? @costPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePrice")] 
        public decimal? @salePrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossMargin")] 
        public decimal? @grossMargin   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossProfit")] 
        public decimal? @grossProfit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorCode_Vendor")] 
        [MaxLength(100)] 
        public string? @vendorCode_Vendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("propertyValue")] 
        [MaxLength(100)] 
        public string? @propertyValue   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorName")] 
        [MaxLength(240)] 
        public string @vendorName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("beginSaleTime")] 
        public DateTime? @beginSaleTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("endSaleTime")] 
        public DateTime? @endSaleTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_SaleStatus")] 
        public int? @id_SaleStatus   { get; set; }
}
}
