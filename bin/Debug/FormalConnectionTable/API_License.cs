using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_License
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("forApp")] 
        [MaxLength(20)] 
        public string? @forApp   { get; set; }
        ///<summary> 
        /// User.id 
        /// </summary> 
        [Column("id_user")] 
        public long @id_user   { get; set; }
        ///<summary> 
        /// vendor.id 
        /// </summary> 
        [Column("id_vendor")] 
        [MaxLength(20)] 
        public string? @id_vendor   { get; set; }
        ///<summary> 
        /// Token識別碼 
        /// </summary> 
        [Column("tokenID")] 
        [MaxLength(50)] 
        public string? @tokenID   { get; set; }
        ///<summary> 
        /// 用戶識別碼 
        /// </summary> 
        [Column("clientID")] 
        [MaxLength(50)] 
        public string? @clientID   { get; set; }
        ///<summary> 
        /// 驗證碼 
        /// </summary> 
        [Column("verifyCode")] 
        [MaxLength(8)] 
        public string? @verifyCode   { get; set; }
        ///<summary> 
        /// 密碼錯誤次數 
        /// </summary> 
        [Column("wrongTimes")] 
        public byte @wrongTimes   { get; set; }
        ///<summary> 
        /// 行動電話號碼 
        /// </summary> 
        [Column("phoneNumber")] 
        [MaxLength(20)] 
        public string? @phoneNumber   { get; set; }
        ///<summary> 
        /// 用戶名稱 
        /// </summary> 
        [Column("clientName")] 
        [MaxLength(50)] 
        public string? @clientName   { get; set; }
        ///<summary> 
        /// 驗證碼確認 
        /// </summary> 
        [Column("isConfirm")] 
        public bool? @isConfirm   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("otpKey")] 
        [MaxLength(16)] 
        public string? @otpKey   { get; set; }
        ///<summary> 
        /// 簡訊發送累計 
        /// </summary> 
        [Column("smsSendAccTotal")] 
        public long @smsSendAccTotal   { get; set; }
        ///<summary> 
        /// 目前簡訊發送次數 
        /// </summary> 
        [Column("smsSendTimes")] 
        public int @smsSendTimes   { get; set; }
        ///<summary> 
        /// 簡訊發送次數(上限) 
        /// </summary> 
        [Column("smsLimitSendTimes")] 
        public int @smsLimitSendTimes   { get; set; }
        ///<summary> 
        /// 最近一次的簡訊發送日期 
        /// </summary> 
        [Column("smsSendDate")] 
        public DateTime? @smsSendDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("email")] 
        [MaxLength(200)] 
        public string? @email   { get; set; }
        ///<summary> 
        /// new=新增,underway=流程中,approved=批准, deleted=巳刪除 
        /// </summary> 
        [Column("status")] 
        [MaxLength(15)] 
        public string? @status   { get; set; }
        ///<summary> 
        /// 更新日期 
        /// </summary> 
        [Column("updateDate")] 
        public DateTime? @updateDate   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("createDate")] 
        public DateTime @createDate   { get; set; }
}
}
