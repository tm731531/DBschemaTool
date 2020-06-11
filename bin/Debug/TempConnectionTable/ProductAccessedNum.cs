using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ProductAccessedNum
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 規格 
        /// </summary> 
        [Column("productSpec")] 
        [MaxLength(100)] 
        public string? @productSpec   { get; set; }
        ///<summary> 
        /// 可接單量 
        /// </summary> 
        [Column("accessedNum")] 
        public long? @accessedNum   { get; set; }
        ///<summary> 
        /// 安全警示量 
        /// </summary> 
        [Column("alertNum")] 
        public long? @alertNum   { get; set; }
        ///<summary> 
        /// 是否露出 0：不露出    1：露出 
        /// </summary> 
        [Column("isShow")] 
        public byte? @isShow   { get; set; }
        ///<summary> 
        /// FK 品號編號嗎 關聯到Product中的主鍵id 
        /// </summary> 
        [Column("id_Product")] 
        public long? @id_Product   { get; set; }
        ///<summary> 
        /// 初次供貨量 
        /// </summary> 
        [Column("initQty")] 
        public long? @initQty   { get; set; }
        ///<summary> 
        /// 可出貨時間 
        /// </summary> 
        [Column("canDeliveryStockDate")] 
        public DateTime? @canDeliveryStockDate   { get; set; }
        ///<summary> 
        /// 採購數量 
        /// </summary> 
        [Column("purchaseQty")] 
        public long? @purchaseQty   { get; set; }
        ///<summary> 
        /// 倉庫別 
        /// </summary> 
        [Column("stockID")] 
        [MaxLength(40)] 
        public string? @stockID   { get; set; }
        ///<summary> 
        /// 訂單數量 
        /// </summary> 
        [Column("orderQty")] 
        public long? @orderQty   { get; set; }
        ///<summary> 
        /// 已出貨數量 
        /// </summary> 
        [Column("shippedQty")] 
        public long? @shippedQty   { get; set; }
        ///<summary> 
        /// 實際庫存數量 
        /// </summary> 
        [Column("actualStockQty")] 
        public long? @actualStockQty   { get; set; }
        ///<summary> 
        /// 庫存數量 
        /// </summary> 
        [Column("stockQty")] 
        public long? @stockQty   { get; set; }
        ///<summary> 
        /// 顏色id 
        /// </summary> 
        [Column("colorId")] 
        public long? @colorId   { get; set; }
        ///<summary> 
        /// 款式id 
        /// </summary> 
        [Column("styleId")] 
        public long? @styleId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("returnCode")] 
        public int? @returnCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("returnMsg")] 
        [MaxLength(200)] 
        public string? @returnMsg   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoProductPN")] 
        [MaxLength(50)] 
        public string? @fugoProductPN   { get; set; }
        ///<summary> 
        /// 國際條碼 
        /// </summary> 
        [Column("EANcode")] 
        [MaxLength(16)] 
        public string? @EANcode   { get; set; }
        ///<summary> 
        /// 新品提報時,E和U可以不同的初次備貨量：在U時qty2指E的初次備貨量；在E時qty2指U的初次備貨量 
        /// </summary> 
        [Column("qty2")] 
        public int? @qty2   { get; set; }
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
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
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
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(100)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 無可接單量日期(當可接單為0時->註記日期, 當可接單量大於0時->更新為null) 
        /// </summary> 
        [Column("toZeroDate")] 
        public DateTime? @toZeroDate   { get; set; }
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
}
}
