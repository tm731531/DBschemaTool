using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Product
{
        ///<summary> 
        /// 商品編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 商品碼 
        /// </summary> 
        [Column("productCode")] 
        [MaxLength(40)] 
        public string? @productCode   { get; set; }
        ///<summary> 
        /// 商品名稱 
        /// </summary> 
        [Column("productName")] 
        [MaxLength(500)] 
        public string? @productName   { get; set; }
        ///<summary> 
        /// 商品特色 
        /// </summary> 
        [Column("productCharacteristics")] 
        public string? @productCharacteristics   { get; set; }
        ///<summary> 
        /// 商品規格(富購:PURPOSE) 
        /// </summary> 
        [Column("productSpec")] 
        public string? @productSpec   { get; set; }
        ///<summary> 
        /// 注意事項 
        /// </summary> 
        [Column("productNotes")] 
        public string? @productNotes   { get; set; }
        ///<summary> 
        /// 版本碼 
        /// </summary> 
        [Column("versionCode")] 
        public double? @versionCode   { get; set; }
        ///<summary> 
        /// 商品碼狀態 
        /// </summary> 
        [Column("productStatus")] 
        public int? @productStatus   { get; set; }
        ///<summary> 
        /// 建議成本 
        /// </summary> 
        [Column("proposedCost")] 
        public double? @proposedCost   { get; set; }
        ///<summary> 
        /// 接單方式:1-依庫存(VWXIT_PURCHASEORDER的PURCHASESTATUSNM為採購巳入庫時才會有量)，2-依採購(未入庫前的量皆依提報量為主，不用管入庫狀態) 
        /// </summary> 
        [Column("orderMode")] 
        [MaxLength(40)] 
        public string? @orderMode   { get; set; }
        ///<summary> 
        /// 最後更新時間 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 業務代表-商品特色 
        /// </summary> 
        [Column("productCharacteristicsOutPlanner")] 
        public string? @productCharacteristicsOutPlanner   { get; set; }
        ///<summary> 
        /// 庫存計量方式，注釋：1.依商品本身 2.依規格數量 
        /// </summary> 
        [Column("productSpecMode")] 
        [MaxLength(60)] 
        public string? @productSpecMode   { get; set; }
        ///<summary> 
        /// 使用方法 
        /// </summary> 
        [Column("useMethod")] 
        public string? @useMethod   { get; set; }
        ///<summary> 
        /// 配件說明 
        /// </summary> 
        [Column("accessory")] 
        public string? @accessory   { get; set; }
        ///<summary> 
        /// 商企商品規格(BR for b2e) 
        /// </summary> 
        [Column("productSpecPlanner")] 
        public string? @productSpecPlanner   { get; set; }
        ///<summary> 
        /// 商企商品特色 
        /// </summary> 
        [Column("productCharacteristicsPlanner")] 
        public string? @productCharacteristicsPlanner   { get; set; }
        ///<summary> 
        /// 商企注意事項 
        /// </summary> 
        [Column("productNotesPlanner")] 
        public string? @productNotesPlanner   { get; set; }
        ///<summary> 
        /// 商企使用方法 
        /// </summary> 
        [Column("useMethodPlanner")] 
        public string? @useMethodPlanner   { get; set; }
        ///<summary> 
        /// 商企配件說明 
        /// </summary> 
        [Column("accessoryPlanner")] 
        public string? @accessoryPlanner   { get; set; }
        ///<summary> 
        /// 是否更新富購到網站商品短敘述（true為更新） 
        /// </summary> 
        [Column("isChangePrdDesPlanner")] 
        public bool? @isChangePrdDesPlanner   { get; set; }
        ///<summary> 
        /// 是否更新富購到網站商品特色（true為更新） 
        /// </summary> 
        [Column("isChangeProductCharacteristics")] 
        public bool? @isChangeProductCharacteristics   { get; set; }
        ///<summary> 
        /// 是否更新富購到網站商品規格（true為更新） 
        /// </summary> 
        [Column("isChangeProductSpec")] 
        public bool? @isChangeProductSpec   { get; set; }
        ///<summary> 
        /// 是否更新富購到網站注意事項（true為更新） 
        /// </summary> 
        [Column("isChangeProductNotes")] 
        public bool? @isChangeProductNotes   { get; set; }
        ///<summary> 
        /// 是否更新富購到網站使用說明（true為更新） 
        /// </summary> 
        [Column("isChangeUseMethod")] 
        public bool? @isChangeUseMethod   { get; set; }
        ///<summary> 
        /// 是否更新富購到網站配件說明（true為更新） 
        /// </summary> 
        [Column("isChangeAccessory")] 
        public bool? @isChangeAccessory   { get; set; }
        ///<summary> 
        /// 是否更新富購到網站贈品說明（true為更新） 
        /// </summary> 
        [Column("isChangePresentDescription")] 
        public bool? @isChangePresentDescription   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 使用哪個規格表 (mongo: PordSpecFormCache、sqlserver: ProdSpecFormNew) 
        /// </summary> 
        [Column("FormID")] 
        public int? @FormID   { get; set; }
        ///<summary> 
        /// 舊有規格內容 
        /// </summary> 
        [Column("ProductSpecOld")] 
        public string? @ProductSpecOld   { get; set; }
        ///<summary> 
        /// 使用的規格表內容 (mongo:FormalPordSpecFormInfo 欄位 ID) 
        /// </summary> 
        [Column("ProductSpecID")] 
        public int? @ProductSpecID   { get; set; }
        ///<summary> 
        /// 提供給B2C規格表內容 
        /// </summary> 
        [Column("ProductSpecJson")] 
        public string? @ProductSpecJson   { get; set; }
}
}
