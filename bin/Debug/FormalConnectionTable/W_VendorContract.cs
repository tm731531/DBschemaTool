using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class W_VendorContract
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// W_DailyReport.id 
        /// </summary> 
        [Column("dailyReport_id")] 
        public long @dailyReport_id   { get; set; }
        ///<summary> 
        /// 統一編號 
        /// </summary> 
        [Column("unifiedSerialNumber")] 
        [MaxLength(100)] 
        public string @unifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 廠商名稱 
        /// </summary> 
        [Column("vendorName")] 
        [MaxLength(240)] 
        public string @vendorName   { get; set; }
        ///<summary> 
        /// 廠商狀態 0:開發中, 1:合作中, 2:已中止 
        /// </summary> 
        [Column("vendorType")] 
        public byte @vendorType   { get; set; }
        ///<summary> 
        /// 洽談類型 
        /// </summary> 
        [Column("contactType")] 
        public byte @contactType   { get; set; }
        ///<summary> 
        /// 洽談人員 
        /// </summary> 
        [Column("contact_by")] 
        public long @contact_by   { get; set; }
        ///<summary> 
        /// 洽談日期 
        /// </summary> 
        [Column("contact_on")] 
        public DateTime @contact_on   { get; set; }
        ///<summary> 
        /// 洽談內容 
        /// </summary> 
        [Column("contactMessage")] 
        public string? @contactMessage   { get; set; }
        ///<summary> 
        /// 核閱人 
        /// </summary> 
        [Column("review_by")] 
        public long @review_by   { get; set; }
        ///<summary> 
        /// 核閱日期 
        /// </summary> 
        [Column("review_on")] 
        public DateTime? @review_on   { get; set; }
        ///<summary> 
        /// 核閱內容 
        /// </summary> 
        [Column("reviewMessage")] 
        [MaxLength(1000)] 
        public string? @reviewMessage   { get; set; }
        ///<summary> 
        /// 廠商連絡人 
        /// </summary> 
        [Column("contactor")] 
        [MaxLength(20)] 
        public string? @contactor   { get; set; }
        ///<summary> 
        /// 廠商連絡部門 
        /// </summary> 
        [Column("contactorDept")] 
        [MaxLength(50)] 
        public string? @contactorDept   { get; set; }
        ///<summary> 
        /// 廠商連絡電話 
        /// </summary> 
        [Column("contactorTel")] 
        [MaxLength(100)] 
        public string? @contactorTel   { get; set; }
        ///<summary> 
        /// 廠商連絡電話(手機) 
        /// </summary> 
        [Column("contactorTel2")] 
        [MaxLength(100)] 
        public string? @contactorTel2   { get; set; }
        ///<summary> 
        /// 廠商連絡email 
        /// </summary> 
        [Column("contactorMail")] 
        [MaxLength(100)] 
        public string? @contactorMail   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productCategory")] 
        public byte @productCategory   { get; set; }
}
}
