using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Draft_Product
{
        ///<summary> 
        /// 商品編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_Draft")] 
        public long @id_Draft   { get; set; }
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
        /// 產品特徵(特色) 
        /// </summary> 
        [Column("productCharacteristics")] 
        public string? @productCharacteristics   { get; set; }
        ///<summary> 
        /// 商品規格 
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
        /// 接單方式: 1.依庫存 2.依採購 
        /// </summary> 
        [Column("orderMode")] 
        [MaxLength(40)] 
        public string? @orderMode   { get; set; }
        ///<summary> 
        /// 業務代表-商品特色 
        /// </summary> 
        [Column("productCharacteristicsOutPlanner")] 
        public string? @productCharacteristicsOutPlanner   { get; set; }
        ///<summary> 
        /// 商品規格方式，注釋：1.依商品本身 2.依規格數量 
        /// </summary> 
        [Column("productSpecMode")] 
        [MaxLength(60)] 
        public string? @productSpecMode   { get; set; }
        ///<summary> 
        /// 商企注意事項 
        /// </summary> 
        [Column("productNotesPlanner")] 
        public string? @productNotesPlanner   { get; set; }
        ///<summary> 
        /// 商企商品規格 
        /// </summary> 
        [Column("productSpecPlanner")] 
        public string? @productSpecPlanner   { get; set; }
        ///<summary> 
        /// 配件說明 
        /// </summary> 
        [Column("accessory")] 
        public string? @accessory   { get; set; }
        ///<summary> 
        /// 使用方法 
        /// </summary> 
        [Column("useMethod")] 
        public string? @useMethod   { get; set; }
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
        [Column("FormID")] 
        public int? @FormID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductSpecOld")] 
        public string? @ProductSpecOld   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductSpecID")] 
        public int? @ProductSpecID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductSpecJson")] 
        public string? @ProductSpecJson   { get; set; }
}
}
