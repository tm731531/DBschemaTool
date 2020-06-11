using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_ProductAccessedNum
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productSpec")] 
        public string? @productSpec   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accessedNum")] 
        public long? @accessedNum   { get; set; }
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
        public long? @stockQty   { get; set; }
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
        public string? @fugoProductPN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EANcode")] 
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
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("colorName")] 
        public string? @colorName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("styleName")] 
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
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("toZeroDate")] 
        public DateTime? @toZeroDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_action")] 
        [MaxLength(1)] 
        public string? @trg_action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_create_on")] 
        public DateTime @trg_create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AttrID1")] 
        public int? @AttrID1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AttrID2")] 
        public int? @AttrID2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SpecID1")] 
        public int? @SpecID1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SpecID2")] 
        public int? @SpecID2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        public string? @UpdateUser   { get; set; }
}
}
