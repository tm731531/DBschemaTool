using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreOrderTemp
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderID")] 
        public int @OrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ItemID")] 
        public byte @ItemID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderDate")] 
        public DateTime @OrderDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public int @FugoCustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SaleName")] 
        [MaxLength(500)] 
        public string @SaleName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Quantity")] 
        public byte @Quantity   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FrontendID")] 
        public int @FrontendID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareBoarder")] 
        public decimal? @EShareBoarder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EshareRatio")] 
        public decimal @EshareRatio   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SalePrice")] 
        public decimal @SalePrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderPrice")] 
        public decimal? @OrderPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CostPrice")] 
        public decimal @CostPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderPVRate")] 
        public decimal @OrderPVRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public int @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreNo")] 
        [MaxLength(15)] 
        public string @EStoreNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ShareETMallCustomerID")] 
        public int @ShareETMallCustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreWishJoin")] 
        [MaxLength(50)] 
        public string? @EStoreWishJoin   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ETMallCustomerIDMobile")] 
        [MaxLength(15)] 
        public string? @ETMallCustomerIDMobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareURL")] 
        [MaxLength(500)] 
        public string? @EShareURL   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderMargin")] 
        public decimal? @OrderMargin   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderProfit")] 
        public decimal? @OrderProfit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderProfitShare")] 
        public decimal? @OrderProfitShare   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderPV")] 
        public decimal? @OrderPV   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderStatus")] 
        [MaxLength(4)] 
        public string? @OrderStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderProcessDate")] 
        public DateTime? @OrderProcessDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderBillingNo")] 
        public int? @OrderBillingNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderReturnStatus")] 
        [MaxLength(4)] 
        public string? @OrderReturnStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderRuturnDate")] 
        public DateTime? @OrderRuturnDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderReturnProcessDate")] 
        public DateTime? @OrderReturnProcessDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderReturnBillingNo")] 
        public int? @OrderReturnBillingNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderReturnPV")] 
        public decimal? @OrderReturnPV   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public int @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyUser")] 
        public int @LastModifyUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_EStoreEventProduct")] 
        public long? @id_EStoreEventProduct   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderSource")] 
        public byte? @OrderSource   { get; set; }
}
}
