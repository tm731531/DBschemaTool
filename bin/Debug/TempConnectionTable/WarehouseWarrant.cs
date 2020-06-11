using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class WarehouseWarrant
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("remark")] 
        public string? @remark   { get; set; }
        ///<summary> 
        /// 採購單編號 關聯到PurchaseOrder的採購單編號 
        /// </summary> 
        [Column("purchaseOrderNo_PurchaseOrder")] 
        [MaxLength(40)] 
        public string? @purchaseOrderNo_PurchaseOrder   { get; set; }
        ///<summary> 
        /// 入庫單編號 
        /// </summary> 
        [Column("warehouseWarrantNo")] 
        [MaxLength(40)] 
        public string? @warehouseWarrantNo   { get; set; }
        ///<summary> 
        /// 入庫單來源1:為新商品，2：可接單量，3：為富購 
        /// </summary> 
        [Column("sourceType")] 
        public int? @sourceType   { get; set; }
        ///<summary> 
        /// 實際到貨數量 
        /// </summary> 
        [Column("realQty")] 
        public long? @realQty   { get; set; }
        ///<summary> 
        /// 實際入庫日期 
        /// </summary> 
        [Column("realToStockDate")] 
        public DateTime? @realToStockDate   { get; set; }
        ///<summary> 
        /// 驗收入庫數量 
        /// </summary> 
        [Column("receivingQty")] 
        public long? @receivingQty   { get; set; }
        ///<summary> 
        /// 驗收失敗數量 
        /// </summary> 
        [Column("receivingFailQty")] 
        public long? @receivingFailQty   { get; set; }
        ///<summary> 
        /// 預計入庫日期 
        /// </summary> 
        [Column("poToStockDate")] 
        public DateTime? @poToStockDate   { get; set; }
        ///<summary> 
        /// 預計入庫數量 
        /// </summary> 
        [Column("poQty")] 
        public long? @poQty   { get; set; }
        ///<summary> 
        /// 富購送貨單號 
        /// </summary> 
        [Column("fuGouDiveryNum")] 
        public long? @fuGouDiveryNum   { get; set; }
        ///<summary> 
        /// 實際到貨日期 
        /// </summary> 
        [Column("realArriveDate")] 
        public DateTime? @realArriveDate   { get; set; }
        ///<summary> 
        /// 是否已轉富購Flag 
        /// </summary> 
        [Column("isSwitchFuGou")] 
        public bool? @isSwitchFuGou   { get; set; }
        ///<summary> 
        /// 富購交易序號 
        /// </summary> 
        [Column("tradeNumber")] 
        public long? @tradeNumber   { get; set; }
        ///<summary> 
        /// 已加庫存 
        /// </summary> 
        [Column("isAddStock")] 
        public bool? @isAddStock   { get; set; }
        ///<summary> 
        /// 已加可 
        /// </summary> 
        [Column("isAddAccessNum")] 
        public bool? @isAddAccessNum   { get; set; }
        ///<summary> 
        /// 富購採購單號 
        /// </summary> 
        [Column("fugoPurchaseID")] 
        public long? @fugoPurchaseID   { get; set; }
        ///<summary> 
        /// 富購收貨人 
        ///  
        /// </summary> 
        [Column("fugoContactPerson")] 
        [MaxLength(60)] 
        public string? @fugoContactPerson   { get; set; }
        ///<summary> 
        /// 富購收貨人電話 
        /// </summary> 
        [Column("fugoContactPhoneNO")] 
        [MaxLength(32)] 
        public string? @fugoContactPhoneNO   { get; set; }
        ///<summary> 
        /// 富購收貨人地址 
        ///  
        /// </summary> 
        [Column("fugoContactAddress")] 
        [MaxLength(1024)] 
        public string? @fugoContactAddress   { get; set; }
        ///<summary> 
        /// 入庫單編號(來源) 
        /// </summary> 
        [Column("warehouseWarrantNoSource")] 
        [MaxLength(40)] 
        public string? @warehouseWarrantNoSource   { get; set; }
        ///<summary> 
        /// 已扣可接單量 
        /// </summary> 
        [Column("isDeductAccessNumber")] 
        public bool? @isDeductAccessNumber   { get; set; }
        ///<summary> 
        /// 實際回傳代碼 
        /// </summary> 
        [Column("returnCode")] 
        public int? @returnCode   { get; set; }
        ///<summary> 
        /// 實際回傳值 
        /// </summary> 
        [Column("returnMsg")] 
        [MaxLength(2000)] 
        public string? @returnMsg   { get; set; }
}
}
