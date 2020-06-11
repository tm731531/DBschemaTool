using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SocialOrder
{
        ///<summary> 
        /// 流水號;自動編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 關聯流水號;(=SocialMember.id) 
        /// </summary> 
        [Column("id_SocialMember")] 
        public long? @id_SocialMember   { get; set; }
        ///<summary> 
        /// 社交電商種類;1: 網連通->tbx_025.OrderSource=2001 or null 2:購享賺->tbx_025.OrderSource=2002 
        /// </summary> 
        [Column("SocialType")] 
        public byte? @SocialType   { get; set; }
        ///<summary> 
        /// 訂單編號;TBX_025.ORDERID 
        /// </summary> 
        [Column("OrderID")] 
        public int @OrderID   { get; set; }
        ///<summary> 
        /// 項次編號;TBX_025.ITEMID 
        /// </summary> 
        [Column("ItemID")] 
        public byte @ItemID   { get; set; }
        ///<summary> 
        /// 訂單成立日期;時分秒  從TBX_025取得 
        /// </summary> 
        [Column("OrderDate")] 
        public DateTime @OrderDate   { get; set; }
        ///<summary> 
        /// 富購銷編;TBX_025.SALENO 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 銷售名稱;TBX_025.SALENAME 
        /// </summary> 
        [Column("SaleName")] 
        [MaxLength(500)] 
        public string @SaleName   { get; set; }
        ///<summary> 
        /// 1001 新品類 1002 新品 1003 舊品重組 1004 關渡商品 1005 ECTV 1006 包檔商品 1007 珠寶專案商品 1008 墨攻商品 1009 年菜親取 1010 分次配送 1011 東源宅配 1012 東森超值券 1013 聯強 1014 醫美電子票券 
        /// </summary> 
        [Column("ProductType")] 
        public int? @ProductType   { get; set; }
        ///<summary> 
        /// 訂單項次數量;永遠為1 
        /// </summary> 
        [Column("Quantity")] 
        public byte @Quantity   { get; set; }
        ///<summary> 
        /// 商品售出的前台主分類;TBX_025.FRONTENDID 
        /// </summary> 
        [Column("FrontendID")] 
        public int @FrontendID   { get; set; }
        ///<summary> 
        /// 商品售價（紅字）;TBX_025.SALEPRICE 
        /// </summary> 
        [Column("SalePrice")] 
        public decimal @SalePrice   { get; set; }
        ///<summary> 
        /// 訂單項次售價(發票金額);TBX_025.ORDERAMOUNT 
        /// </summary> 
        [Column("OrderPrice")] 
        public decimal? @OrderPrice   { get; set; }
        ///<summary> 
        /// 訂單項次成本;TBX_025.COST 
        /// </summary> 
        [Column("OrderCost")] 
        public decimal @OrderCost   { get; set; }
        ///<summary> 
        /// 常規適用分潤毛利級距;TBX_025.ESHAREBOARDER 
        /// </summary> 
        [Column("ShareBoarder")] 
        public decimal? @ShareBoarder   { get; set; }
        ///<summary> 
        /// 常規分潤比例;TBX_025.ESHARERATIO 
        /// </summary> 
        [Column("ShareRatio")] 
        public decimal @ShareRatio   { get; set; }
        ///<summary> 
        /// 關聯流水號;(SocialEventProduct.id) 
        /// </summary> 
        [Column("id_SocialEventProduct")] 
        public long? @id_SocialEventProduct   { get; set; }
        ///<summary> 
        /// 商品特殊分潤比例; SocialEventProduct.RatioEvent 
        /// </summary> 
        [Column("RatioEventProduct")] 
        public decimal @RatioEventProduct   { get; set; }
        ///<summary> 
        /// 購買人東購客代;TBX_025.WEBCUSTID 
        /// </summary> 
        [Column("BuyerETMallCustomerID")] 
        public int? @BuyerETMallCustomerID   { get; set; }
        ///<summary> 
        /// 導購人東購客代;TBX_025.IDESTORENUMBER 
        /// </summary> 
        [Column("ShareETMallCustomerID")] 
        public int? @ShareETMallCustomerID   { get; set; }
        ///<summary> 
        /// 分潤轉換的匯率;TBX_025.ORDERPVRATE，購享賺為1 
        /// </summary> 
        [Column("SocialRate")] 
        public decimal @SocialRate   { get; set; }
        ///<summary> 
        /// 扣除營銷的比例;Ex: 0.7 (營銷自留0.3) 
        /// </summary> 
        [Column("SPRateAll")] 
        public decimal @SPRateAll   { get; set; }
        ///<summary> 
        /// 第一階分潤比例;算出第1階的分潤金額B [B]=Rounddown(SPAmount*SPRateAll*SPRateLevel1,0) 
        /// </summary> 
        [Column("SPRateLevel1")] 
        public decimal @SPRateLevel1   { get; set; }
        ///<summary> 
        /// 訂單分潤金額;訂單分潤金額=向東購請款金額  先特殊OrderPrice*EventRatio 再常規OrderPrice*ShareRatio 小數點無條件捨去取整數 
        /// </summary> 
        [Column("SPAmount")] 
        public decimal @SPAmount   { get; set; }
        ///<summary> 
        /// 第一階分潤B（代算）;算出第1階的分潤金額B [B]=Rounddown(SPAmount*SPRateAll*SPRateLevel1,0) 
        /// </summary> 
        [Column("SPLevel1")] 
        public decimal @SPLevel1   { get; set; }
        ///<summary> 
        /// 推薦或導購碼; 
        /// </summary> 
        [Column("SocialCode")] 
        [MaxLength(50)] 
        public string? @SocialCode   { get; set; }
        ///<summary> 
        /// 購買人的社交電商代碼;(=tb_CUSTOMER_OAUTH.CUST_ACCT_ID_ENCODE) 
        /// </summary> 
        [Column("BuyerEncodeID")] 
        public decimal? @BuyerEncodeID   { get; set; }
        ///<summary> 
        /// 分潤店主的社交電商代碼;(=tb_CUSTOMER_OAUTH.CUST_ACCT_ID_ENCODE) 
        /// </summary> 
        [Column("ShareEncodeID")] 
        public decimal? @ShareEncodeID   { get; set; }
        ///<summary> 
        /// 訂單狀態;訂單狀態 1有效 2無效（含取消,銷退） 由排程1更新，當ShareConfirmDate有值時不可更新2 (要Alert) 
        /// </summary> 
        [Column("OrderStatus")] 
        [MaxLength(4)] 
        public string? @OrderStatus   { get; set; }
        ///<summary> 
        /// 訂單配確日期;來自F_ORDER.Receiveddate，含時分秒，一經寫入就不再更改 
        /// </summary> 
        [Column("OrderReceivedDate")] 
        public DateTime? @OrderReceivedDate   { get; set; }
        ///<summary> 
        /// 可分潤註記日期;由排程執行後寫入，含時分秒  OrderStatus=1 & OrderReceivedDate大於15天時才可回壓作業日期getdate() 
        /// </summary> 
        [Column("ShareConfirmDate")] 
        public DateTime? @ShareConfirmDate   { get; set; }
        ///<summary> 
        /// 修改日期;新增時為NULL 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 修改人員;新增時為NULL 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 建立日期;預設getdate() 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 建立人員;程式/JOB/API名稱，若是人工操作則以redmine單號記錄之 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
}
}
