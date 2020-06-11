using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductAccessedNum
{
        ///<summary> 
        /// 主鍵id 
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
        /// 品號編號碼，FK，關聯到Product中的主鍵id 
        /// </summary> 
        [Column("id_Product")] 
        public long? @id_Product   { get; set; }
        ///<summary> 
        /// 最後更新時間 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
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
        /// 倉庫類別 
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
        /// 顏色id 商品規格表id 
        /// </summary> 
        [Column("colorId")] 
        public long? @colorId   { get; set; }
        ///<summary> 
        /// 款式id 商品規格id 
        /// </summary> 
        [Column("styleId")] 
        public long? @styleId   { get; set; }
        ///<summary> 
        /// 商品料號 
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
        /// 
        /// </summary> 
        [Column("createon")] 
        public DateTime? @createon   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 可接單量 for umall 
        /// </summary> 
        [Column("num_u")] 
        public int? @num_u   { get; set; }
        ///<summary> 
        /// 可接單量 for ETMall 
        /// </summary> 
        [Column("num_e")] 
        public int? @num_e   { get; set; }
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
        /// 是否斷碼 
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
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
}
}
