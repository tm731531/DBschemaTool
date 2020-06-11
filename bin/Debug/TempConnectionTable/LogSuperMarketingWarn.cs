using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class LogSuperMarketingWarn
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 富購銷售編號 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 富購商品編號 
        /// </summary> 
        [Column("fugoProductID")] 
        [MaxLength(60)] 
        public string? @fugoProductID   { get; set; }
        ///<summary> 
        /// 銷售名稱 
        /// </summary> 
        [Column("saleName")] 
        [MaxLength(510)] 
        public string? @saleName   { get; set; }
        ///<summary> 
        /// 售價 
        /// </summary> 
        [Column("salePrice")] 
        public decimal? @salePrice   { get; set; }
        ///<summary> 
        /// 開發來源代碼 
        /// </summary> 
        [Column("eType")] 
        public byte? @eType   { get; set; }
        ///<summary> 
        /// 富構商品屬性 
        /// </summary> 
        [Column("fugoItemType")] 
        [MaxLength(4)] 
        public string? @fugoItemType   { get; set; }
        ///<summary> 
        /// 品號狀態 
        /// </summary> 
        [Column("saleStatus")] 
        [MaxLength(400)] 
        public string? @saleStatus   { get; set; }
        ///<summary> 
        /// 商品開發 
        /// </summary> 
        [Column("productDevelopmentStaff")] 
        [MaxLength(40)] 
        public string? @productDevelopmentStaff   { get; set; }
        ///<summary> 
        /// 供應商代碼(Vendor.id) 
        /// </summary> 
        [Column("vendorCode_Vendor")] 
        [MaxLength(100)] 
        public string? @vendorCode_Vendor   { get; set; }
        ///<summary> 
        /// 配送方式代碼 
        /// </summary> 
        [Column("deliveryWay")] 
        [MaxLength(10)] 
        public string? @deliveryWay   { get; set; }
        ///<summary> 
        /// 包裝方式代碼 
        /// </summary> 
        [Column("packType")] 
        [MaxLength(10)] 
        public string? @packType   { get; set; }
        ///<summary> 
        /// 長 
        /// </summary> 
        [Column("packingLength")] 
        public decimal? @packingLength   { get; set; }
        ///<summary> 
        /// 寬 
        /// </summary> 
        [Column("packingWidth")] 
        public decimal? @packingWidth   { get; set; }
        ///<summary> 
        /// 高 
        /// </summary> 
        [Column("packingHeight")] 
        public decimal? @packingHeight   { get; set; }
        ///<summary> 
        /// 重量(公克) 
        /// </summary> 
        [Column("weight")] 
        public decimal? @weight   { get; set; }
        ///<summary> 
        /// 商品Flag設定(是否易碎品) 
        /// </summary> 
        [Column("ProductFlag")] 
        public int? @ProductFlag   { get; set; }
        ///<summary> 
        /// 警示訊息 
        /// </summary> 
        [Column("warnMessage")] 
        [MaxLength(1000)] 
        public string? @warnMessage   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
        ///<summary> 
        /// 當前方法類別命名空間名稱 
        /// </summary> 
        [Column("CurrentInfo")] 
        [MaxLength(1000)] 
        public string? @CurrentInfo   { get; set; }
        ///<summary> 
        /// 上一層方法類別命名空間名稱 
        /// </summary> 
        [Column("ParentInfo")] 
        [MaxLength(1000)] 
        public string? @ParentInfo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsNew")] 
        public bool? @IsNew   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CanCOD")] 
        [MaxLength(10)] 
        public string? @CanCOD   { get; set; }
}
}
