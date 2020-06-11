using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class B2CUser
{
        ///<summary> 
        /// 主鍵id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 帳戶 
        /// </summary> 
        [Column("userId")] 
        [MaxLength(100)] 
        public string? @userId   { get; set; }
        ///<summary> 
        /// 密碼 
        /// </summary> 
        [Column("accountPassword")] 
        [MaxLength(50)] 
        public string? @accountPassword   { get; set; }
        ///<summary> 
        /// 電子郵件 
        /// </summary> 
        [Column("email")] 
        [MaxLength(100)] 
        public string? @email   { get; set; }
        ///<summary> 
        /// 會員等級 
        /// </summary> 
        [Column("membershipLevel")] 
        public int? @membershipLevel   { get; set; }
        ///<summary> 
        /// 會員類型-拒往客戶 
        /// </summary> 
        [Column("isRejected")] 
        public bool? @isRejected   { get; set; }
        ///<summary> 
        /// 會員類型-企業會員 
        /// </summary> 
        [Column("isEnterpriseMember")] 
        public bool? @isEnterpriseMember   { get; set; }
        ///<summary> 
        /// 會員類型-社群會員 
        /// </summary> 
        [Column("isCommunityMember")] 
        public bool? @isCommunityMember   { get; set; }
        ///<summary> 
        /// 會員類型-一般會員 
        /// </summary> 
        [Column("isGeneralMember")] 
        public bool? @isGeneralMember   { get; set; }
        ///<summary> 
        /// 通訊位址,FK,參照Address表的id 
        /// </summary> 
        [Column("addressId_Address")] 
        public long? @addressId_Address   { get; set; }
        ///<summary> 
        /// 聯絡電話 
        /// </summary> 
        [Column("localPhone")] 
        [MaxLength(240)] 
        public string? @localPhone   { get; set; }
        ///<summary> 
        /// 聯絡電話_日_分機 
        /// </summary> 
        [Column("localPhoneExt")] 
        [MaxLength(240)] 
        public string? @localPhoneExt   { get; set; }
        ///<summary> 
        /// 聯絡電話_日_區碼 
        /// </summary> 
        [Column("localPhoneArea")] 
        [MaxLength(240)] 
        public string? @localPhoneArea   { get; set; }
        ///<summary> 
        /// 密碼錯誤次數 
        /// </summary> 
        [Column("wrongPasswordTimes")] 
        public int? @wrongPasswordTimes   { get; set; }
        ///<summary> 
        /// 啟用碼 
        /// </summary> 
        [Column("enableCode")] 
        [MaxLength(240)] 
        public string? @enableCode   { get; set; }
        ///<summary> 
        /// 身份證號碼 
        /// </summary> 
        [Column("individualID")] 
        [MaxLength(240)] 
        public string @individualID   { get; set; }
        ///<summary> 
        /// 生日 
        /// </summary> 
        [Column("birthday")] 
        public DateTime? @birthday   { get; set; }
        ///<summary> 
        /// 鎖定 
        /// </summary> 
        [Column("isLocked")] 
        public bool? @isLocked   { get; set; }
        ///<summary> 
        /// 銷退屬性-慣性拒收 
        /// </summary> 
        [Column("inertialReject_Withdrawal")] 
        public int? @inertialReject_Withdrawal   { get; set; }
        ///<summary> 
        /// 銷退屬性-拒收改善 
        /// </summary> 
        [Column("improvementReject_Withdrawal")] 
        public int? @improvementReject_Withdrawal   { get; set; }
        ///<summary> 
        /// 銷退屬性-可能銷退觀察 
        /// </summary> 
        [Column("maybeWithdrawalView_Withdrawal")] 
        public bool? @maybeWithdrawalView_Withdrawal   { get; set; }
        ///<summary> 
        /// 銷退屬性-銷退改善 
        /// </summary> 
        [Column("withdrawalImprovement_Withdrawal")] 
        public int? @withdrawalImprovement_Withdrawal   { get; set; }
        ///<summary> 
        /// 銷退屬性-銷退觀察 
        /// </summary> 
        [Column("withdrawalView_Withdrawal")] 
        public bool? @withdrawalView_Withdrawal   { get; set; }
        ///<summary> 
        /// 銷退屬性-正常 
        /// </summary> 
        [Column("normal_Withdrawal")] 
        public bool? @normal_Withdrawal   { get; set; }
        ///<summary> 
        /// 行動電話 
        /// </summary> 
        [Column("cellPhone")] 
        [MaxLength(240)] 
        public string? @cellPhone   { get; set; }
        ///<summary> 
        /// 姓名 
        /// </summary> 
        [Column("name")] 
        [MaxLength(240)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 性別 1男 2女 
        /// </summary> 
        [Column("gender")] 
        [MaxLength(1)] 
        public string? @gender   { get; set; }
        ///<summary> 
        /// 帳號啟用時間 
        /// </summary> 
        [Column("enableDate")] 
        public DateTime? @enableDate   { get; set; }
        ///<summary> 
        /// 帳號狀態,FK,參照AccountStatusDictionary表的id 
        /// </summary> 
        [Column("enableStatus_AccountStatusDictionary")] 
        public int? @enableStatus_AccountStatusDictionary   { get; set; }
        ///<summary> 
        /// 註冊時間 
        /// </summary> 
        [Column("registerTime")] 
        public DateTime? @registerTime   { get; set; }
        ///<summary> 
        /// 達人等級 
        /// </summary> 
        [Column("masterLevel")] 
        public int? @masterLevel   { get; set; }
        ///<summary> 
        /// 公開昵稱 
        /// </summary> 
        [Column("nickname")] 
        [MaxLength(240)] 
        public string? @nickname   { get; set; }
        ///<summary> 
        /// 婚姻狀況（0未選擇，1已婚，2未婚） 
        /// </summary> 
        [Column("maritalStatus")] 
        public int? @maritalStatus   { get; set; }
        ///<summary> 
        /// 活躍度 
        /// </summary> 
        [Column("activeLevel")] 
        public int? @activeLevel   { get; set; }
        ///<summary> 
        /// B2C會員學歷 
        /// </summary> 
        [Column("educationalBackground")] 
        [MaxLength(200)] 
        public string? @educationalBackground   { get; set; }
        ///<summary> 
        /// B2C會員職業 
        /// </summary> 
        [Column("career")] 
        [MaxLength(200)] 
        public string? @career   { get; set; }
        ///<summary> 
        /// B2C會員年收入 
        /// </summary> 
        [Column("annualIncome")] 
        [MaxLength(200)] 
        public string? @annualIncome   { get; set; }
        ///<summary> 
        /// B2C會員備用電子郵件 
        /// </summary> 
        [Column("spareEmail")] 
        [MaxLength(256)] 
        public string? @spareEmail   { get; set; }
        ///<summary> 
        /// 公司統一編號 
        /// </summary> 
        [Column("unifiedSerialNumber")] 
        [MaxLength(100)] 
        public string? @unifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 公司名稱 
        /// </summary> 
        [Column("companyName")] 
        [MaxLength(200)] 
        public string? @companyName   { get; set; }
        ///<summary> 
        /// 驗證信發送時間 
        /// </summary> 
        [Column("sentMailTime")] 
        public DateTime? @sentMailTime   { get; set; }
        ///<summary> 
        /// 修改後郵件地址 
        /// </summary> 
        [Column("modifiedEmail")] 
        [MaxLength(256)] 
        public string? @modifiedEmail   { get; set; }
        ///<summary> 
        /// 最後更新時間戳 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 發票抬頭 
        /// </summary> 
        [Column("invoiceGain")] 
        [MaxLength(60)] 
        public string? @invoiceGain   { get; set; }
        ///<summary> 
        /// 禁用付款方式——COD 
        /// </summary> 
        [Column("codDisabled")] 
        public bool? @codDisabled   { get; set; }
        ///<summary> 
        /// 禁用付款方式——支付寶 
        /// </summary> 
        [Column("alipayDisabled")] 
        public bool? @alipayDisabled   { get; set; }
        ///<summary> 
        /// 會員備註 
        /// </summary> 
        [Column("notes")] 
        [MaxLength(256)] 
        public string? @notes   { get; set; }
        ///<summary> 
        /// 是否已加入富購會員資訊 
        /// </summary> 
        [Column("isTurnToFuGo")] 
        public bool? @isTurnToFuGo   { get; set; }
        ///<summary> 
        /// 富購客戶編號 
        /// </summary> 
        [Column("fugoCustomerId")] 
        [MaxLength(20)] 
        public string? @fugoCustomerId   { get; set; }
        ///<summary> 
        /// FUGO手機短信驗證碼 
        /// </summary> 
        [Column("fugoSMSNo")] 
        [MaxLength(20)] 
        public string? @fugoSMSNo   { get; set; }
        ///<summary> 
        /// 會員注冊-富購回傳代碼 
        /// </summary> 
        [Column("returnCode")] 
        public int? @returnCode   { get; set; }
        ///<summary> 
        /// 會員注冊-富購回傳信息 
        /// </summary> 
        [Column("returnMsg")] 
        [MaxLength(2000)] 
        public string? @returnMsg   { get; set; }
        ///<summary> 
        /// 富購會員資訊同步時間_登錄時 
        /// </summary> 
        [Column("fugoInfoSyncTime")] 
        public DateTime? @fugoInfoSyncTime   { get; set; }
        ///<summary> 
        /// 會員資訊修改-富購回傳代碼 
        /// </summary> 
        [Column("returnCodeModified")] 
        public int? @returnCodeModified   { get; set; }
        ///<summary> 
        /// 會員資訊修改-富購回傳資訊 
        /// </summary> 
        [Column("returnMsgModified")] 
        [MaxLength(2000)] 
        public string? @returnMsgModified   { get; set; }
        ///<summary> 
        /// 富購會員資訊同步時間-UC11-4 
        /// </summary> 
        [Column("fugoInfoSyncTimeJob")] 
        public DateTime? @fugoInfoSyncTimeJob   { get; set; }
        ///<summary> 
        /// B2CUser會員密碼最後修改時間 
        /// </summary> 
        [Column("userPasswordModifyTime")] 
        public DateTime? @userPasswordModifyTime   { get; set; }
        ///<summary> 
        /// 發票統一編號 
        /// </summary> 
        [Column("invoiceUnifiedCode")] 
        [MaxLength(100)] 
        public string? @invoiceUnifiedCode   { get; set; }
        ///<summary> 
        /// 邀請人id（標識該用戶是由哪個會員id邀請來的） 
        /// </summary> 
        [Column("inviterId")] 
        public long? @inviterId   { get; set; }
        ///<summary> 
        /// 已確認之會員條款版本號(FK：FORMAL.dbo.LegalStatement.id) 
        /// </summary> 
        [Column("id_LegalStatement")] 
        public int? @id_LegalStatement   { get; set; }
        ///<summary> 
        /// 已確認之會員條款日期(FK：FORMAL.dbo.LegalStatement.id) 
        /// </summary> 
        [Column("legalStatementConsentDate")] 
        public DateTime? @legalStatementConsentDate   { get; set; }
        ///<summary> 
        /// 聯名網站名稱(片語資料庫) 
        /// </summary> 
        [Column("brandName")] 
        [MaxLength(20)] 
        public string? @brandName   { get; set; }
        ///<summary> 
        /// 已確認之會員條款版本號UHoliday (FK：FORMAL.dbo.LegalStatement.id) 
        /// </summary> 
        [Column("id_UHolidayLegalStatement")] 
        public int? @id_UHolidayLegalStatement   { get; set; }
        ///<summary> 
        /// 已確認之會員條款版本號UHoliday同意日期 (FK：FORMAL.dbo.LegalStatement.id) 
        /// </summary> 
        [Column("uHLegalStatementConsentDate")] 
        public DateTime? @uHLegalStatementConsentDate   { get; set; }
        ///<summary> 
        /// 行銷追蹤碼 
        /// </summary> 
        [Column("marketingPromotionCode")] 
        [MaxLength(12)] 
        public string? @marketingPromotionCode   { get; set; }
        ///<summary> 
        /// 網站識別代碼(U-Mall or UHoliday) 
        /// </summary> 
        [Column("fugoCompanyId")] 
        public int @fugoCompanyId   { get; set; }
        ///<summary> 
        /// 1:為網購會員 
        /// 2:電視會員3:FB註冊 
        /// </summary> 
        [Column("memberSource")] 
        public int @memberSource   { get; set; }
        ///<summary> 
        /// 剩餘購物金總計 
        /// </summary> 
        [Column("shoppingPointTotal")] 
        public int @shoppingPointTotal   { get; set; }
        ///<summary> 
        /// 導購網站上的使用者 uid 
        /// </summary> 
        [Column("brandUserId")] 
        [MaxLength(100)] 
        public string? @brandUserId   { get; set; }
        ///<summary> 
        /// 從導購網站過來的登入時間 
        /// </summary> 
        [Column("brandRegisterDate")] 
        public DateTime? @brandRegisterDate   { get; set; }
}
}
