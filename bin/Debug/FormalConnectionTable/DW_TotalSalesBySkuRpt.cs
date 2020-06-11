using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class DW_TotalSalesBySkuRpt
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderTime")] 
        public DateTime @orderTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoOrderID")] 
        [MaxLength(60)] 
        public string? @fugoOrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("itemId")] 
        public int? @itemId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoOrderStatusDesc")] 
        [MaxLength(20)] 
        public string? @fugoOrderStatusDesc   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoProductID")] 
        [MaxLength(60)] 
        public string? @fugoProductID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoDeliveryWayDesc")] 
        [MaxLength(20)] 
        public string? @fugoDeliveryWayDesc   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productName")] 
        [MaxLength(500)] 
        public string? @productName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("specificationsName")] 
        [MaxLength(200)] 
        public string? @specificationsName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePrice")] 
        public decimal? @salePrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("costPrice")] 
        public decimal? @costPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("amount")] 
        public int? @amount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoVendorId")] 
        [MaxLength(12)] 
        public string? @fugoVendorId   { get; set; }
}
}
