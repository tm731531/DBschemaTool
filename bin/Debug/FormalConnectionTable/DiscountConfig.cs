using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class DiscountConfig
{
        ///<summary> 
        /// 主鍵id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 活動代碼，Fk，關聯到MarketingEvevent表的eventCode 
        /// </summary> 
        [Column("eventCode_MarketingEvent")] 
        [MaxLength(100)] 
        public string @eventCode_MarketingEvent   { get; set; }
        ///<summary> 
        /// 枚舉：優惠價等級，折價百分比，折價金額，單品滿額折 
        /// </summary> 
        [Column("discountType")] 
        public int @discountType   { get; set; }
        ///<summary> 
        /// 折價等級 
        /// </summary> 
        [Column("discountGrade")] 
        [MaxLength(40)] 
        public string? @discountGrade   { get; set; }
        ///<summary> 
        /// 折價百分比 
        /// </summary> 
        [Column("discountPercent")] 
        public double? @discountPercent   { get; set; }
        ///<summary> 
        /// 折價金額 
        /// </summary> 
        [Column("discountMoney")] 
        public decimal? @discountMoney   { get; set; }
        ///<summary> 
        /// 購買單品滿多少錢就打相應折扣 
        /// </summary> 
        [Column("puductFull")] 
        public int? @puductFull   { get; set; }
        ///<summary> 
        /// 購買單品滿多少錢就打相應折扣 
        /// </summary> 
        [Column("puductFullAgio")] 
        public int? @puductFullAgio   { get; set; }
        ///<summary> 
        /// 最高不超過這個折扣 
        /// </summary> 
        [Column("puductFullTiptopAgio")] 
        public int? @puductFullTiptopAgio   { get; set; }
        ///<summary> 
        /// 最多購買數量 
        /// </summary> 
        [Column("purchasedQTYUpperBound")] 
        public int? @purchasedQTYUpperBound   { get; set; }
        ///<summary> 
        /// 最少購買數量 
        /// </summary> 
        [Column("purchasedQTYLowerBound")] 
        public int? @purchasedQTYLowerBound   { get; set; }
        ///<summary> 
        /// 付款限制-是否允許使用紅利 
        /// </summary> 
        [Column("isNotAllowedBonus")] 
        public bool? @isNotAllowedBonus   { get; set; }
        ///<summary> 
        /// 付款限制-是否信用卡一次付清 
        /// </summary> 
        [Column("noInstallmentOnCreditCard")] 
        public bool? @noInstallmentOnCreditCard   { get; set; }
        ///<summary> 
        /// 付款限制-用ATM付款 
        /// </summary> 
        [Column("atmAllowed")] 
        public bool? @atmAllowed   { get; set; }
        ///<summary> 
        /// 第M件打折（範圍2-7） 
        /// </summary> 
        [Column("mthDiscount")] 
        public int? @mthDiscount   { get; set; }
        ///<summary> 
        /// 訂單折價百分比限制金額 
        /// </summary> 
        [Column("orderDiscountPercentLimitAmount")] 
        public decimal? @orderDiscountPercentLimitAmount   { get; set; }
        ///<summary> 
        /// 訂單滿額折 
        /// </summary> 
        [Column("orderFullAmountDiscount")] 
        public decimal? @orderFullAmountDiscount   { get; set; }
        ///<summary> 
        /// 折價計算基礎做為限制 (0: 單一帳號 1: 單筆訂單) 
        /// </summary> 
        [Column("discountByOrder")] 
        public bool? @discountByOrder   { get; set; }
}
}
