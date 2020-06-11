using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Log_CashBackOrder
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_EStoreOrder")] 
        public int? @id_EStoreOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderID")] 
        public int? @OrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ItemID")] 
        public int? @ItemID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo")] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderPrice")] 
        public int? @OrderPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CashBackOrderProfitShare")] 
        public int? @CashBackOrderProfitShare   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_CashBackBillingSetup")] 
        public long? @id_CashBackBillingSetup   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_EStoreBillingSetup")] 
        public long? @id_EStoreBillingSetup   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CashBackImportDate")] 
        public DateTime? @CashBackImportDate   { get; set; }
        ///<summary> 
        /// 
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
        public string? @UpdateUser   { get; set; }
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
}
}
