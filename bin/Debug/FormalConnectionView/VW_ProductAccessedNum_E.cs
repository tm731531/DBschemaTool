using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_ProductAccessedNum_E
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
        [Column("productSpec")] 
        [MaxLength(100)] 
        public string? @productSpec   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accessedNum")] 
        public int @accessedNum   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("alertNum")] 
        public long? @alertNum   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isShow")] 
        public byte? @isShow   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_Product")] 
        public long? @id_Product   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("initQty")] 
        public long? @initQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canDeliveryStockDate")] 
        public DateTime? @canDeliveryStockDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("purchaseQty")] 
        public long? @purchaseQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("stockID")] 
        [MaxLength(40)] 
        public string? @stockID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderQty")] 
        public long? @orderQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shippedQty")] 
        public long? @shippedQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("actualStockQty")] 
        public long? @actualStockQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("stockQty")] 
        public int @stockQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("colorId")] 
        public long? @colorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("styleId")] 
        public long? @styleId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoProductPN")] 
        [MaxLength(50)] 
        public string? @fugoProductPN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EANcode")] 
        [MaxLength(16)] 
        public string? @EANcode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createon")] 
        public DateTime? @createon   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("num_u")] 
        public int? @num_u   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("num_e")] 
        public int? @num_e   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("stockQty_E")] 
        public int? @stockQty_E   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("colorName")] 
        [MaxLength(100)] 
        public string? @colorName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("styleName")] 
        [MaxLength(100)] 
        public string? @styleName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_fugoColor")] 
        public int? @id_fugoColor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_fugoStyle")] 
        public int? @id_fugoStyle   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorUsable")] 
        public bool? @vendorUsable   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sort")] 
        public int? @sort   { get; set; }
}
}
