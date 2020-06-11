using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class PurchaseOrder
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 採購單編號 
        /// </summary> 
        [Column("purchaseOrderNo")] 
        [MaxLength(40)] 
        public string? @purchaseOrderNo   { get; set; }
        ///<summary> 
        /// 採購需求來源1：新商品，2：可接單量 
        /// </summary> 
        [Column("poSource")] 
        public int? @poSource   { get; set; }
        ///<summary> 
        /// 倉庫別 
        /// </summary> 
        [Column("stockID")] 
        [MaxLength(40)] 
        public string? @stockID   { get; set; }
        ///<summary> 
        /// 初次備貨量-供應商 
        /// </summary> 
        [Column("initQty")] 
        public long? @initQty   { get; set; }
        ///<summary> 
        /// 規格 關聯到ProductAccessedNum中的ID 
        /// </summary> 
        [Column("id_ProductAccessedNum")] 
        public long? @id_ProductAccessedNum   { get; set; }
        ///<summary> 
        /// 回復採購量-供應商 
        /// </summary> 
        [Column("confirmPurchaseOrderQty")] 
        public long? @confirmPurchaseOrderQty   { get; set; }
        ///<summary> 
        /// 建議採購量-採購管理員 
        /// </summary> 
        [Column("purchaseOrderQty")] 
        public long? @purchaseOrderQty   { get; set; }
        ///<summary> 
        /// 建議採購量-商企 
        /// </summary> 
        [Column("prePurchaseOrderQty")] 
        public long? @prePurchaseOrderQty   { get; set; }
        ///<summary> 
        /// 建議入庫次數-供應商 
        /// </summary> 
        [Column("toStockTimes")] 
        public int? @toStockTimes   { get; set; }
        ///<summary> 
        /// 建議入庫日(起)-採購管理員 
        /// </summary> 
        [Column("toStockStartDate")] 
        public DateTime? @toStockStartDate   { get; set; }
        ///<summary> 
        /// 建議入庫日(迄)-採購管理員 
        /// </summary> 
        [Column("toStockEndDate")] 
        public DateTime? @toStockEndDate   { get; set; }
        ///<summary> 
        /// 建議入庫日-商企 
        /// </summary> 
        [Column("prePurchaseOrderDate")] 
        public DateTime? @prePurchaseOrderDate   { get; set; }
        ///<summary> 
        /// 可出貨時間-供應商 
        /// </summary> 
        [Column("canDeliveryStockDate")] 
        public DateTime? @canDeliveryStockDate   { get; set; }
        ///<summary> 
        /// refs #1353 登入人員(建立者)  --原資料為:商企 
        /// </summary> 
        [Column("planningStaff")] 
        [MaxLength(100)] 
        public string? @planningStaff   { get; set; }
        ///<summary> 
        /// 接單方式 
        /// </summary> 
        [Column("orderMode")] 
        [MaxLength(40)] 
        public string? @orderMode   { get; set; }
        ///<summary> 
        /// 品號(正式區) 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 品號名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(510)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 供應商代碼 
        /// </summary> 
        [Column("vendorCode")] 
        [MaxLength(40)] 
        public string? @vendorCode   { get; set; }
        ///<summary> 
        /// 供應商名稱 
        /// </summary> 
        [Column("vendorName")] 
        [MaxLength(200)] 
        public string? @vendorName   { get; set; }
        ///<summary> 
        /// 商品規格 
        /// </summary> 
        [Column("productSpec")] 
        public string? @productSpec   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("note")] 
        [MaxLength(200)] 
        public string? @note   { get; set; }
        ///<summary> 
        /// 採購單建立日期 
        /// </summary> 
        [Column("newPurchaseListDate")] 
        public DateTime? @newPurchaseListDate   { get; set; }
        ///<summary> 
        /// refs #1353 登入人員(建立者)  --原資料為:商企id 
        /// </summary> 
        [Column("planningStaffId")] 
        public long? @planningStaffId   { get; set; }
        ///<summary> 
        /// 0：未建立採購單；1：已經建立採購單 
        /// </summary> 
        [Column("setupListFlag")] 
        public int? @setupListFlag   { get; set; }
        ///<summary> 
        /// 流程編號，關聯到暫存區中auditFlowContext 編號id 
        /// </summary> 
        [Column("id_AuditFlowContext")] 
        public long? @id_AuditFlowContext   { get; set; }
        ///<summary> 
        /// 供應商編號 
        /// </summary> 
        [Column("id_User")] 
        public long? @id_User   { get; set; }
        ///<summary> 
        /// 規格方式 1.依商品本身 2.依規格數量 
        /// </summary> 
        [Column("productSpecMode")] 
        [MaxLength(60)] 
        public string? @productSpecMode   { get; set; }
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
        /// 採購單狀態 
        /// </summary> 
        [Column("orderStatus")] 
        public int? @orderStatus   { get; set; }
        ///<summary> 
        /// 富購倉庫別ID(參照FugoWarehouse id欄位) 
        /// </summary> 
        [Column("fugoWarehouseID")] 
        public long? @fugoWarehouseID   { get; set; }
        ///<summary> 
        /// 工作流申請類型（枚舉參考ApplicationType的value值） 
        /// </summary> 
        [Column("applicationType")] 
        [MaxLength(100)] 
        public string? @applicationType   { get; set; }
        ///<summary> 
        /// 審核當時的可接單量(ProductAccessedNum.accessedNum)，審核提報修改時才會有值。 
        /// </summary> 
        [Column("fugoAccessedNum")] 
        public int @fugoAccessedNum   { get; set; }
        ///<summary> 
        /// 備貨方式, 現貨:1001, 預購:1002 
        /// </summary> 
        [Column("stockType")] 
        public int? @stockType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
