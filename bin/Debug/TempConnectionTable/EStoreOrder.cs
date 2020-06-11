using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreOrder
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 富購訂單編號 
        /// </summary> 
        [Column("OrderID")] 
        public int @OrderID   { get; set; }
        ///<summary> 
        /// 富購訂單項次 
        /// </summary> 
        [Column("ItemID")] 
        public byte @ItemID   { get; set; }
        ///<summary> 
        /// 訂單成立日期(時分秒) 
        /// </summary> 
        [Column("OrderDate")] 
        public DateTime @OrderDate   { get; set; }
        ///<summary> 
        /// 購買人富購客代 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public int @FugoCustomerID   { get; set; }
        ///<summary> 
        /// 商品富購銷編 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 商品銷售名稱 
        /// </summary> 
        [Column("SaleName")] 
        [MaxLength(500)] 
        public string @SaleName   { get; set; }
        ///<summary> 
        /// 商品數量，目前都是1 
        /// </summary> 
        [Column("Quantity")] 
        public byte @Quantity   { get; set; }
        ///<summary> 
        /// 商品的前台主分類 
        /// </summary> 
        [Column("FrontendID")] 
        public int @FrontendID   { get; set; }
        ///<summary> 
        /// 前台主分類的分潤門檻 
        /// </summary> 
        [Column("EShareBoarder")] 
        public decimal? @EShareBoarder   { get; set; }
        ///<summary> 
        /// 前台主分類的分潤比例 
        /// </summary> 
        [Column("EshareRatio")] 
        public decimal @EshareRatio   { get; set; }
        ///<summary> 
        /// 商品頁銷售金額(優惠價) 
        /// </summary> 
        [Column("SalePrice")] 
        public decimal @SalePrice   { get; set; }
        ///<summary> 
        /// 結帳發票金額 
        /// </summary> 
        [Column("OrderPrice")] 
        public decimal? @OrderPrice   { get; set; }
        ///<summary> 
        /// 成本金額 
        /// </summary> 
        [Column("CostPrice")] 
        public decimal @CostPrice   { get; set; }
        ///<summary> 
        /// 當下的東宇PV匯率, 目前是0.022222 
        /// </summary> 
        [Column("OrderPVRate")] 
        public decimal @OrderPVRate   { get; set; }
        ///<summary> 
        /// 購買人的前台客代 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public int @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 分潤的店主手機 
        /// </summary> 
        [Column("EStoreNo")] 
        [MaxLength(15)] 
        public string @EStoreNo   { get; set; }
        ///<summary> 
        /// 分潤的店主前台客代 
        /// </summary> 
        [Column("ShareETMallCustomerID")] 
        public int @ShareETMallCustomerID   { get; set; }
        ///<summary> 
        /// 是否願意加入東宇 
        /// </summary> 
        [Column("EStoreWishJoin")] 
        [MaxLength(50)] 
        public string? @EStoreWishJoin   { get; set; }
        ///<summary> 
        /// 願意加入的購買人手機 
        /// </summary> 
        [Column("ETMallCustomerIDMobile")] 
        [MaxLength(15)] 
        public string? @ETMallCustomerIDMobile   { get; set; }
        ///<summary> 
        /// 踩的分潤商品銷編；分享的店主客代 
        /// </summary> 
        [Column("EShareURL")] 
        [MaxLength(500)] 
        public string? @EShareURL   { get; set; }
        ///<summary> 
        /// 商品毛利 
        /// </summary> 
        [Column("OrderMargin")] 
        public decimal? @OrderMargin   { get; set; }
        ///<summary> 
        /// 商品毛利率 
        /// </summary> 
        [Column("OrderProfit")] 
        public decimal? @OrderProfit   { get; set; }
        ///<summary> 
        /// 東宇分潤金額 
        /// </summary> 
        [Column("OrderProfitShare")] 
        public decimal? @OrderProfitShare   { get; set; }
        ///<summary> 
        /// 分潤金額換算的PV值 
        /// </summary> 
        [Column("OrderPV")] 
        public decimal? @OrderPV   { get; set; }
        ///<summary> 
        /// 訂單狀態 
        /// </summary> 
        [Column("OrderStatus")] 
        [MaxLength(4)] 
        public string? @OrderStatus   { get; set; }
        ///<summary> 
        /// 訂單歸帳處理日期(有值代表已歸帳) 
        /// </summary> 
        [Column("OrderProcessDate")] 
        public DateTime? @OrderProcessDate   { get; set; }
        ///<summary> 
        /// 已結帳的帳單id 
        /// </summary> 
        [Column("OrderBillingNo")] 
        public int? @OrderBillingNo   { get; set; }
        ///<summary> 
        /// 退貨狀態 
        /// </summary> 
        [Column("OrderReturnStatus")] 
        [MaxLength(4)] 
        public string? @OrderReturnStatus   { get; set; }
        ///<summary> 
        /// 退貨更新日期 
        /// </summary> 
        [Column("OrderRuturnDate")] 
        public DateTime? @OrderRuturnDate   { get; set; }
        ///<summary> 
        /// 訂單銷退歸帳處理日期(有值代表已歸帳) 
        /// </summary> 
        [Column("OrderReturnProcessDate")] 
        public DateTime? @OrderReturnProcessDate   { get; set; }
        ///<summary> 
        /// 訂單銷退的歸帳id 
        /// </summary> 
        [Column("OrderReturnBillingNo")] 
        public int? @OrderReturnBillingNo   { get; set; }
        ///<summary> 
        /// 訂單銷退應退的PV值 
        /// </summary> 
        [Column("OrderReturnPV")] 
        public decimal? @OrderReturnPV   { get; set; }
        ///<summary> 
        /// 建檔日期 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 建檔人員 
        /// </summary> 
        [Column("CreateUser")] 
        public int @CreateUser   { get; set; }
        ///<summary> 
        /// 最後更新日期 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 最後更新人員 
        /// </summary> 
        [Column("LastModifyUser")] 
        public int @LastModifyUser   { get; set; }
        ///<summary> 
        /// 對應的特殊分潤商品序號 EStoreEventProduct 
        /// </summary> 
        [Column("id_EStoreEventProduct")] 
        public long? @id_EStoreEventProduct   { get; set; }
        ///<summary> 
        /// 訂單來源(1:東森 2:草莓網 3:台灣票券網 4:券集商城 5:美麗站長 ) 
        /// </summary> 
        [Column("OrderSource")] 
        public byte? @OrderSource   { get; set; }
}
}
