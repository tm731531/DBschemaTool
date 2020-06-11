using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class PurchaseOrderRpt
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 富購採購單編號 
        /// </summary> 
        [Column("purchaseOrderNo")] 
        [MaxLength(40)] 
        public string? @purchaseOrderNo   { get; set; }
        ///<summary> 
        /// 富購商品編號 
        /// </summary> 
        [Column("fugoProductID")] 
        [MaxLength(60)] 
        public string? @fugoProductID   { get; set; }
        ///<summary> 
        /// 富購商品名稱 
        /// </summary> 
        [Column("productName")] 
        [MaxLength(500)] 
        public string? @productName   { get; set; }
        ///<summary> 
        /// 顏色 
        /// </summary> 
        [Column("colorId")] 
        public long? @colorId   { get; set; }
        ///<summary> 
        /// 顏色名稱 
        /// </summary> 
        [Column("fugoColorName")] 
        [MaxLength(200)] 
        public string? @fugoColorName   { get; set; }
        ///<summary> 
        /// 款式 
        /// </summary> 
        [Column("styleId")] 
        public long? @styleId   { get; set; }
        ///<summary> 
        /// 款式名稱 
        /// </summary> 
        [Column("fugoStyleName")] 
        [MaxLength(200)] 
        public string? @fugoStyleName   { get; set; }
        ///<summary> 
        /// 採購單數量 
        /// </summary> 
        [Column("purchaseOrderQty")] 
        public long? @purchaseOrderQty   { get; set; }
        ///<summary> 
        /// 入庫單入庫數量 
        /// </summary> 
        [Column("warrantQty")] 
        public long? @warrantQty   { get; set; }
        ///<summary> 
        /// 採購單狀態編號 
        /// </summary> 
        [Column("purchaseStatusId")] 
        [MaxLength(4)] 
        public string? @purchaseStatusId   { get; set; }
        ///<summary> 
        /// 採購單狀態名稱 
        /// </summary> 
        [Column("purchaseStatusName")] 
        [MaxLength(40)] 
        public string? @purchaseStatusName   { get; set; }
        ///<summary> 
        /// 採購單建立日期 
        /// </summary> 
        [Column("poCreationDate")] 
        public DateTime? @poCreationDate   { get; set; }
        ///<summary> 
        /// 採購單變更日期 
        /// </summary> 
        [Column("poModifiedDate")] 
        public DateTime? @poModifiedDate   { get; set; }
        ///<summary> 
        /// 備貨方式, 現貨:1001, 預購:1002 
        /// </summary> 
        [Column("stockType")] 
        public int? @stockType   { get; set; }
        ///<summary> 
        /// 預計入庫日 
        /// </summary> 
        [Column("canDeliveryStockDate")] 
        public DateTime? @canDeliveryStockDate   { get; set; }
}
}
