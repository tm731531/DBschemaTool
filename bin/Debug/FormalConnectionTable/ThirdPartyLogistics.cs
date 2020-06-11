using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ThirdPartyLogistics
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 第三方物流公司(HCT:新竹物流, MAPLE:便利帶, HEDI:新竹物流, POST:中華郵政, TCAT:統一速達) 
        /// </summary> 
        [Column("API_ThirdParty")] 
        [MaxLength(50)] 
        public string @API_ThirdParty   { get; set; }
        ///<summary> 
        /// 訂單編號 
        /// </summary> 
        [Column("OrderID")] 
        public int @OrderID   { get; set; }
        ///<summary> 
        /// 訂單項次 
        /// </summary> 
        [Column("ItemID")] 
        public int @ItemID   { get; set; }
        ///<summary> 
        /// 併單序號 
        /// </summary> 
        [Column("CombinedOrderID")] 
        public int? @CombinedOrderID   { get; set; }
        ///<summary> 
        /// 銷售編號 
        /// </summary> 
        [Column("SaleNO")] 
        [MaxLength(40)] 
        public string? @SaleNO   { get; set; }
        ///<summary> 
        /// 商品編號 
        /// </summary> 
        [Column("ProductID")] 
        [MaxLength(40)] 
        public string @ProductID   { get; set; }
        ///<summary> 
        /// 收件人姓名 
        /// </summary> 
        [Column("Consignee")] 
        [MaxLength(50)] 
        public string? @Consignee   { get; set; }
        ///<summary> 
        /// 收件人手機 
        /// </summary> 
        [Column("Contactnumber")] 
        [MaxLength(50)] 
        public string? @Contactnumber   { get; set; }
        ///<summary> 
        /// 收件人地址 
        /// </summary> 
        [Column("DelveryAddressnm")] 
        [MaxLength(400)] 
        public string? @DelveryAddressnm   { get; set; }
        ///<summary> 
        /// 1：一般(FugoItemType=1001) 
        /// 2：票券(新竹物流不顯示) 
        /// 3：冷凍(FugoItemType=1011) 
        /// 4：蔬果類 
        /// 8：冷藏(FugoItemType=1002) 
        /// 10：小物 
        ///  
        /// </summary> 
        [Column("DeliveryType")] 
        public int? @DeliveryType   { get; set; }
        ///<summary> 
        /// 出貨倉庫(HEDI用) 
        /// </summary> 
        [Column("VendorWarehouse")] 
        public int? @VendorWarehouse   { get; set; }
        ///<summary> 
        /// 寄送備註 
        /// </summary> 
        [Column("DeliveryMemo")] 
        public string? @DeliveryMemo   { get; set; }
        ///<summary> 
        /// 訂單重量(公克)(HEDI用) 
        /// </summary> 
        [Column("Weight")] 
        [MaxLength(20)] 
        public string? @Weight   { get; set; }
        ///<summary> 
        /// 保值金額/運送保險金額(預設為0)(HEDI用) 
        /// </summary> 
        [Column("Safety")] 
        public decimal @Safety   { get; set; }
        ///<summary> 
        /// 配送單號(API回傳配送單號) 
        /// </summary> 
        [Column("DeliveryOrderId")] 
        [MaxLength(50)] 
        public string? @DeliveryOrderId   { get; set; }
        ///<summary> 
        /// 下載序號(API回傳配送單下載序號) 
        /// </summary> 
        [Column("DownloadNO")] 
        [MaxLength(50)] 
        public string? @DownloadNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorID")] 
        [MaxLength(20)] 
        public string @VendorID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Update_By")] 
        [MaxLength(10)] 
        public string @Update_By   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Update_on")] 
        public DateTime @Update_on   { get; set; }
        ///<summary> 
        /// 交易編號 
        /// </summary> 
        [Column("SetNo")] 
        [MaxLength(20)] 
        public string? @SetNo   { get; set; }
        ///<summary> 
        /// 商品資料(例:商品名稱(顏色/款式)_數量) 
        /// </summary> 
        [Column("OrderProduct")] 
        [MaxLength(100)] 
        public string? @OrderProduct   { get; set; }
        ///<summary> 
        /// 通知司機(0：不通知(預設) 1：通知) 
        /// </summary> 
        [Column("NotifyType")] 
        public int? @NotifyType   { get; set; }
        ///<summary> 
        /// 配送狀態(0:未壓狀態 1:出貨進行中 2:出貨完成 3:配送確認 4:配送終止 9:在B2B之外系統壓掉了 10:廠商手動修改貨運公司) 
        /// </summary> 
        [Column("ShipStatus")] 
        public int? @ShipStatus   { get; set; }
        ///<summary> 
        /// 自訂供應商編號 
        /// </summary> 
        [Column("SetVat")] 
        [MaxLength(30)] 
        public string? @SetVat   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Verified")] 
        public int? @Verified   { get; set; }
        ///<summary> 
        /// 是否通知司機(主要)(0:否 1:通知) 
        /// </summary> 
        [Column("CDisType")] 
        public bool? @CDisType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoVendorId")] 
        public int? @FugoVendorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Platform")] 
        public int? @Platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FreightCompany")] 
        public int? @FreightCompany   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FailTimes")] 
        public int? @FailTimes   { get; set; }
}
}
