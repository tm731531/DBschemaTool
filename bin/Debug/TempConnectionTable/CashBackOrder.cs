using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class CashBackOrder
{
        ///<summary> 
        /// UID 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 關連EStoreOrder.ID 
        /// </summary> 
        [Column("id_EStoreOrder")] 
        public int? @id_EStoreOrder   { get; set; }
        ///<summary> 
        /// 訂單編號 
        /// </summary> 
        [Column("OrderID")] 
        public int? @OrderID   { get; set; }
        ///<summary> 
        /// 訂單項次 
        /// </summary> 
        [Column("ItemID")] 
        public int? @ItemID   { get; set; }
        ///<summary> 
        /// 銷售編號 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 訂單金額 
        /// </summary> 
        [Column("OrderPrice")] 
        public int? @OrderPrice   { get; set; }
        ///<summary> 
        /// 返現東購請款金額 
        /// </summary> 
        [Column("CashBackOrderProfitShare")] 
        public int? @CashBackOrderProfitShare   { get; set; }
        ///<summary> 
        /// 返現結帳期別 
        /// </summary> 
        [Column("id_CashBackBillingSetup")] 
        public long? @id_CashBackBillingSetup   { get; set; }
        ///<summary> 
        /// 結帳週期 
        /// </summary> 
        [Column("id_EStoreBillingSetup")] 
        public long? @id_EStoreBillingSetup   { get; set; }
        ///<summary> 
        /// 訂單匯入處理時間 
        /// </summary> 
        [Column("CashBackImportDate")] 
        public DateTime? @CashBackImportDate   { get; set; }
        ///<summary> 
        /// 訂單來源 
        /// </summary> 
        [Column("OrderSource")] 
        public byte? @OrderSource   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
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
