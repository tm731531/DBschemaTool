using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SerialNumber
{
        ///<summary> 
        /// 編號id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 供應商代碼 
        /// </summary> 
        [Column("vendorCode")] 
        [MaxLength(40)] 
        public string? @vendorCode   { get; set; }
        ///<summary> 
        /// 合約編號 
        /// </summary> 
        [Column("agreementNumber")] 
        [MaxLength(40)] 
        public string? @agreementNumber   { get; set; }
        ///<summary> 
        /// 商品碼 
        /// </summary> 
        [Column("productCode")] 
        [MaxLength(40)] 
        public string? @productCode   { get; set; }
        ///<summary> 
        /// 正式區銷售品號 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 臨時區銷售品號 
        /// </summary> 
        [Column("tempSaleCode")] 
        [MaxLength(40)] 
        public string? @tempSaleCode   { get; set; }
        ///<summary> 
        /// 採購單編號 
        /// </summary> 
        [Column("purchaseOrderNo")] 
        [MaxLength(40)] 
        public string? @purchaseOrderNo   { get; set; }
        ///<summary> 
        /// 會員訂單編號 
        /// </summary> 
        [Column("memberOrderId")] 
        [MaxLength(60)] 
        public string? @memberOrderId   { get; set; }
        ///<summary> 
        /// 供應商訂單編號 
        /// </summary> 
        [Column("vendorOrderId")] 
        [MaxLength(60)] 
        public string? @vendorOrderId   { get; set; }
        ///<summary> 
        /// 客訴案件編號 
        /// </summary> 
        [Column("customerComplaintId")] 
        [MaxLength(60)] 
        public string? @customerComplaintId   { get; set; }
        ///<summary> 
        /// 入庫單編號 
        /// </summary> 
        [Column("warehouseWarrantNo")] 
        [MaxLength(40)] 
        public string? @warehouseWarrantNo   { get; set; }
        ///<summary> 
        /// 折價券編號 
        /// </summary> 
        [Column("couponNo")] 
        [MaxLength(40)] 
        public string? @couponNo   { get; set; }
        ///<summary> 
        /// 對帳資料編號 
        ///  
        /// </summary> 
        [Column("reconciliationID")] 
        [MaxLength(40)] 
        public string? @reconciliationID   { get; set; }
        ///<summary> 
        /// 對帳明細編號 
        /// </summary> 
        [Column("reconciliationDetailID")] 
        [MaxLength(40)] 
        public string? @reconciliationDetailID   { get; set; }
        ///<summary> 
        /// 贈品主編號 
        /// </summary> 
        [Column("giftParentID")] 
        [MaxLength(40)] 
        public string? @giftParentID   { get; set; }
        ///<summary> 
        /// 贈品編號 
        /// </summary> 
        [Column("giftID")] 
        [MaxLength(40)] 
        public string? @giftID   { get; set; }
        ///<summary> 
        /// 行銷活動代碼 
        /// </summary> 
        [Column("marketingEventCode")] 
        [MaxLength(40)] 
        public string? @marketingEventCode   { get; set; }
        ///<summary> 
        /// 項次編號（信用卡訂單標誌） 
        /// </summary> 
        [Column("itemNo")] 
        [MaxLength(20)] 
        public string? @itemNo   { get; set; }
        ///<summary> 
        /// 支付寶付款流水號 
        /// </summary> 
        [Column("alipayNumber")] 
        [MaxLength(10)] 
        public string? @alipayNumber   { get; set; }
        ///<summary> 
        /// 項次編號（促銷活動） 
        /// </summary> 
        [Column("campaignCode")] 
        [MaxLength(10)] 
        public string? @campaignCode   { get; set; }
}
}
