using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ExpensiveAlarm
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 通報日期 
        /// </summary> 
        [Column("bulletinTime")] 
        public DateTime? @bulletinTime   { get; set; }
        ///<summary> 
        /// 銷售編號 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 通報平台:1=U-mall,2=ETMall 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 售價 
        /// </summary> 
        [Column("salePrice")] 
        public decimal? @salePrice   { get; set; }
        ///<summary> 
        /// 優惠價 
        /// </summary> 
        [Column("promotionalPrice")] 
        public decimal? @promotionalPrice   { get; set; }
        ///<summary> 
        /// 行銷活動代碼 
        /// </summary> 
        [Column("campaignID")] 
        public long? @campaignID   { get; set; }
        ///<summary> 
        /// 行銷活動名稱 
        /// </summary> 
        [Column("campaignNM")] 
        [MaxLength(60)] 
        public string? @campaignNM   { get; set; }
        ///<summary> 
        /// 客戶會員代碼 
        /// </summary> 
        [Column("customer")] 
        public long? @customer   { get; set; }
        ///<summary> 
        /// 商店名稱 
        /// </summary> 
        [Column("storeName")] 
        [MaxLength(60)] 
        public string? @storeName   { get; set; }
        ///<summary> 
        /// 商店網址 
        /// </summary> 
        [Column("storeAddress")] 
        public string? @storeAddress   { get; set; }
        ///<summary> 
        /// 商店價格 
        /// </summary> 
        [Column("alarmPrice")] 
        public decimal? @alarmPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("customerEmail")] 
        [MaxLength(256)] 
        public string? @customerEmail   { get; set; }
        ///<summary> 
        /// 通報處理:0=未處理,1=跟價,2=下架,3=不跟價 
        /// </summary> 
        [Column("actionType")] 
        public byte? @actionType   { get; set; }
        ///<summary> 
        /// MLEC_SalesMixApplication.id 
        /// </summary> 
        [Column("id_salesMixApplication")] 
        public long? @id_salesMixApplication   { get; set; }
        ///<summary> 
        /// 不跟價的原因說明 
        /// </summary> 
        [Column("result")] 
        [MaxLength(510)] 
        public string? @result   { get; set; }
        ///<summary> 
        /// 廠商處理時間 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 修改人員(Vendor.id) 
        /// </summary> 
        [Column("updateBy")] 
        [MaxLength(100)] 
        public string? @updateBy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sendTime")] 
        public DateTime? @sendTime   { get; set; }
        ///<summary> 
        /// 通報狀態:0=未處理、1=流程結束(待寄送郵件)、2=結案(已寄送), 3=審核中,4=駁回 
        /// </summary> 
        [Column("AlarmStatus")] 
        public byte? @AlarmStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
}
}
