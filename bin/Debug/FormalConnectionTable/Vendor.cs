using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Vendor
{
        ///<summary> 
        /// 供應商代碼(User.accountName) 
        /// </summary> 
        [Column("id")] 
        [MaxLength(100)] 
        public string @id   { get; set; }
        ///<summary> 
        /// 公司名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(240)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 公司 
        /// </summary> 
        [Column("shortName")] 
        [MaxLength(100)] 
        public string? @shortName   { get; set; }
        ///<summary> 
        /// 公司統一編號 
        /// </summary> 
        [Column("unifiedSerialNumber")] 
        [MaxLength(100)] 
        public string @unifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 資本額 
        /// </summary> 
        [Column("capitalization")] 
        public decimal @capitalization   { get; set; }
        ///<summary> 
        /// 去年營業額 
        /// </summary> 
        [Column("lastTurnover")] 
        public decimal? @lastTurnover   { get; set; }
        ///<summary> 
        /// 公司成立日期 
        /// </summary> 
        [Column("foundingDate")] 
        public DateTime? @foundingDate   { get; set; }
        ///<summary> 
        /// 公司主頁 
        /// </summary> 
        [Column("homePage")] 
        [MaxLength(100)] 
        public string? @homePage   { get; set; }
        ///<summary> 
        /// 負責人 
        /// </summary> 
        [Column("responsibleOfficer")] 
        [MaxLength(100)] 
        public string @responsibleOfficer   { get; set; }
        ///<summary> 
        /// 所屬國別 
        /// </summary> 
        [Column("country")] 
        [MaxLength(100)] 
        public string? @country   { get; set; }
        ///<summary> 
        /// 公司電話 
        /// </summary> 
        [Column("companyPhone")] 
        [MaxLength(200)] 
        public string @companyPhone   { get; set; }
        ///<summary> 
        /// 公司傳真 
        /// </summary> 
        [Column("companyFax")] 
        [MaxLength(200)] 
        public string @companyFax   { get; set; }
        ///<summary> 
        /// 業務承辦人 
        /// </summary> 
        [Column("contractor")] 
        [MaxLength(100)] 
        public string? @contractor   { get; set; }
        ///<summary> 
        /// 業務承辦人職稱 
        /// </summary> 
        [Column("contractorPosition")] 
        [MaxLength(100)] 
        public string? @contractorPosition   { get; set; }
        ///<summary> 
        /// 業務承辦人電話 
        /// </summary> 
        [Column("contractorPhone")] 
        [MaxLength(200)] 
        public string? @contractorPhone   { get; set; }
        ///<summary> 
        /// 業務承辦人手機 
        /// </summary> 
        [Column("contractorMobile")] 
        [MaxLength(200)] 
        public string? @contractorMobile   { get; set; }
        ///<summary> 
        /// 業務承辦人傳真 
        /// </summary> 
        [Column("contractorFax")] 
        [MaxLength(200)] 
        public string? @contractorFax   { get; set; }
        ///<summary> 
        /// 聯絡事項 
        /// </summary> 
        [Column("contractorAttentions")] 
        [MaxLength(200)] 
        public string? @contractorAttentions   { get; set; }
        ///<summary> 
        /// 主產品分類，FK，參照BackendCategory表的rank列 
        /// </summary> 
        [Column("productMainCategory")] 
        public long? @productMainCategory   { get; set; }
        ///<summary> 
        /// 合約授權MD，FK，參照User表的userName列 
        /// </summary> 
        [Column("assignedMD")] 
        public long @assignedMD   { get; set; }
        ///<summary> 
        /// 業務承辦人郵箱 
        /// </summary> 
        [Column("contactEmail")] 
        [MaxLength(200)] 
        public string? @contactEmail   { get; set; }
        ///<summary> 
        /// 公司簡介 
        /// </summary> 
        [Column("companyProfile")] 
        [MaxLength(10)] 
        public string? @companyProfile   { get; set; }
        ///<summary> 
        /// 公司附件1 
        /// </summary> 
        [Column("companyProfile1DocPath")] 
        public string? @companyProfile1DocPath   { get; set; }
        ///<summary> 
        /// 公司附件2 
        /// </summary> 
        [Column("companyProfile2DocPath")] 
        public string? @companyProfile2DocPath   { get; set; }
        ///<summary> 
        /// 公司附件3 
        /// </summary> 
        [Column("companyProfile3DocPath")] 
        public string? @companyProfile3DocPath   { get; set; }
        ///<summary> 
        /// 公司附件4 
        /// </summary> 
        [Column("companyProfile4DocPath")] 
        public string? @companyProfile4DocPath   { get; set; }
        ///<summary> 
        /// 公司附件5 
        /// </summary> 
        [Column("companyProfile5DocPath")] 
        public string? @companyProfile5DocPath   { get; set; }
        ///<summary> 
        /// 產品簡介 
        /// </summary> 
        [Column("productProfile")] 
        [MaxLength(10)] 
        public string? @productProfile   { get; set; }
        ///<summary> 
        /// 產品附件1 
        /// </summary> 
        [Column("productProfile1DocPath")] 
        public string? @productProfile1DocPath   { get; set; }
        ///<summary> 
        /// 產品附件2 
        /// </summary> 
        [Column("productProfile2DocPath")] 
        public string? @productProfile2DocPath   { get; set; }
        ///<summary> 
        /// 產品附件3 
        /// </summary> 
        [Column("productProfile3DocPath")] 
        public string? @productProfile3DocPath   { get; set; }
        ///<summary> 
        /// 產品附件4 
        /// </summary> 
        [Column("productProfile4DocPath")] 
        public string? @productProfile4DocPath   { get; set; }
        ///<summary> 
        /// 產品附件5 
        /// </summary> 
        [Column("productProfile5DocPath")] 
        public string? @productProfile5DocPath   { get; set; }
        ///<summary> 
        /// 付款帳戶名稱 
        /// </summary> 
        [Column("paymentAccountName")] 
        [MaxLength(200)] 
        public string? @paymentAccountName   { get; set; }
        ///<summary> 
        /// 付款帳號 
        /// </summary> 
        [Column("paymentAccountNo")] 
        [MaxLength(200)] 
        public string @paymentAccountNo   { get; set; }
        ///<summary> 
        /// 付款銀行，FK，關聯到Bank表的id 
        /// </summary> 
        [Column("paymentBank")] 
        public long @paymentBank   { get; set; }
        ///<summary> 
        /// 付款條件，FK，關聯到PaymentCondition表的id 
        /// </summary> 
        [Column("paymentCondition")] 
        public long? @paymentCondition   { get; set; }
        ///<summary> 
        /// 付款方式，FK，關聯到PaymentMethod表的id 
        /// </summary> 
        [Column("paymentWay")] 
        public long? @paymentWay   { get; set; }
        ///<summary> 
        /// 財務聯絡人 
        /// </summary> 
        [Column("financialContactor")] 
        [MaxLength(200)] 
        public string? @financialContactor   { get; set; }
        ///<summary> 
        /// 財務聯絡人手機 
        /// </summary> 
        [Column("financialContactorMobile")] 
        [MaxLength(200)] 
        public string? @financialContactorMobile   { get; set; }
        ///<summary> 
        /// 財務聯絡人性別 
        /// </summary> 
        [Column("financialContactorSex")] 
        [MaxLength(100)] 
        public string? @financialContactorSex   { get; set; }
        ///<summary> 
        /// 財務聯絡人傳真 
        /// </summary> 
        [Column("financialOfficeFax")] 
        [MaxLength(200)] 
        public string? @financialOfficeFax   { get; set; }
        ///<summary> 
        /// 財務聯絡人辦公電話 
        /// </summary> 
        [Column("financialOfficePhone")] 
        [MaxLength(200)] 
        public string? @financialOfficePhone   { get; set; }
        ///<summary> 
        /// 物流聯絡人 
        /// </summary> 
        [Column("logisticsContactor")] 
        [MaxLength(200)] 
        public string? @logisticsContactor   { get; set; }
        ///<summary> 
        /// 物流聯絡人手機 
        /// </summary> 
        [Column("logisticsContactorMobile")] 
        [MaxLength(100)] 
        public string? @logisticsContactorMobile   { get; set; }
        ///<summary> 
        /// 物流聯絡人性別 
        /// </summary> 
        [Column("logisticsContactorSex")] 
        [MaxLength(100)] 
        public string? @logisticsContactorSex   { get; set; }
        ///<summary> 
        /// 物流聯絡人傳真 
        /// </summary> 
        [Column("logisticsOfficeFax")] 
        [MaxLength(200)] 
        public string? @logisticsOfficeFax   { get; set; }
        ///<summary> 
        /// 物流聯絡人辦公電話 
        /// </summary> 
        [Column("logisticsOfficePhone")] 
        [MaxLength(200)] 
        public string? @logisticsOfficePhone   { get; set; }
        ///<summary> 
        /// 營業地址,FK,參照Address表中的addressId列 
        /// </summary> 
        [Column("businessAddressId")] 
        public long? @businessAddressId   { get; set; }
        ///<summary> 
        /// 發票配送地址,FK,參照Address表中的addressId列 
        /// </summary> 
        [Column("invoiceDeliveryAddressId")] 
        public long? @invoiceDeliveryAddressId   { get; set; }
        ///<summary> 
        /// 出貨地址1,FK,參照Address表中的addressId列 
        /// </summary> 
        [Column("shipmentAddress1Id")] 
        public long? @shipmentAddress1Id   { get; set; }
        ///<summary> 
        /// 出貨地址2,FK,參照Address表中的addressId列 
        /// </summary> 
        [Column("shipmentAddress2Id")] 
        public long? @shipmentAddress2Id   { get; set; }
        ///<summary> 
        /// 負責人性別 
        /// </summary> 
        [Column("responsibleOfficerSex")] 
        [MaxLength(20)] 
        public string? @responsibleOfficerSex   { get; set; }
        ///<summary> 
        /// 業務承辦人性別 
        /// </summary> 
        [Column("contractorSex")] 
        [MaxLength(20)] 
        public string? @contractorSex   { get; set; }
        ///<summary> 
        /// 合約編號 
        /// </summary> 
        [Column("agreementNumber")] 
        [MaxLength(100)] 
        public string? @agreementNumber   { get; set; }
        ///<summary> 
        /// 合約生效日期 
        /// </summary> 
        [Column("agreementStartingTime")] 
        public DateTime? @agreementStartingTime   { get; set; }
        ///<summary> 
        /// 合約結束日期 
        /// </summary> 
        [Column("startingEndingTime")] 
        public DateTime? @startingEndingTime   { get; set; }
        ///<summary> 
        /// 核准人，FK，參照User表的userName列 
        /// </summary> 
        [Column("agreementRatifier")] 
        public long? @agreementRatifier   { get; set; }
        ///<summary> 
        /// 供應商合作狀態:cooperating:合作中；terminate:終止合作；suspend：暫停合作。 
        /// </summary> 
        [Column("vendorState")] 
        [MaxLength(100)] 
        public string? @vendorState   { get; set; }
        ///<summary> 
        /// 供應商合作關係變更說明 
        /// </summary> 
        [Column("stateChangeNote")] 
        [MaxLength(200)] 
        public string? @stateChangeNote   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 增補協議書 
        /// </summary> 
        [Column("attachment1")] 
        public bool? @attachment1   { get; set; }
        ///<summary> 
        /// 近半年401表 
        /// </summary> 
        [Column("attachment2")] 
        public bool? @attachment2   { get; set; }
        ///<summary> 
        /// 營利事業登記證、公司執照、存摺之影本 
        /// </summary> 
        [Column("attachment3")] 
        public bool? @attachment3   { get; set; }
        ///<summary> 
        /// 負責人身份證影本 
        /// </summary> 
        [Column("attachment4")] 
        public bool? @attachment4   { get; set; }
        ///<summary> 
        /// 新供應商檢核表 
        /// </summary> 
        [Column("attachment5")] 
        public bool? @attachment5   { get; set; }
        ///<summary> 
        /// 保證票10萬元 
        /// </summary> 
        [Column("attachment6")] 
        public bool? @attachment6   { get; set; }
        ///<summary> 
        /// 系統設定服務費1000元 
        /// </summary> 
        [Column("attachment7")] 
        public bool? @attachment7   { get; set; }
        ///<summary> 
        /// 公服部報告 
        /// </summary> 
        [Column("attachment8")] 
        public bool? @attachment8   { get; set; }
        ///<summary> 
        /// 登記地址，FK,參照Address表中的addressId列 
        /// </summary> 
        [Column("registerAddressId")] 
        public long? @registerAddressId   { get; set; }
        ///<summary> 
        /// 廠商申請日期 
        /// </summary> 
        [Column("applicationDate")] 
        public DateTime? @applicationDate   { get; set; }
        ///<summary> 
        /// 合作關係變更時間 
        /// </summary> 
        [Column("relationshipModifyTime")] 
        public DateTime? @relationshipModifyTime   { get; set; }
        ///<summary> 
        /// 來源於富購介面的供應商代號 U平台 
        /// </summary> 
        [Column("fugoVendorId")] 
        [MaxLength(12)] 
        public string? @fugoVendorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createDate")] 
        public DateTime? @createDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 來源於富購介面的供應商代號 E平台 
        /// </summary> 
        [Column("fugoVendorId2")] 
        [MaxLength(12)] 
        public string? @fugoVendorId2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorState2")] 
        [MaxLength(100)] 
        public string? @vendorState2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractorAttentions2")] 
        [MaxLength(200)] 
        public string? @contractorAttentions2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("agreementNumber2")] 
        [MaxLength(100)] 
        public string? @agreementNumber2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("agreementStartingTime2")] 
        public DateTime? @agreementStartingTime2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("startingEndingTime2")] 
        public DateTime? @startingEndingTime2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("agreementRatifier2")] 
        public long? @agreementRatifier2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("stateChangeNote2")] 
        [MaxLength(200)] 
        public string? @stateChangeNote2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        [MaxLength(100)] 
        public string? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isSurvey")] 
        public bool? @isSurvey   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("eTypeGroup")] 
        [MaxLength(100)] 
        public string? @eTypeGroup   { get; set; }
        ///<summary> 
        /// 作業型態 
        /// </summary> 
        [Column("auditTypeGroup")] 
        [MaxLength(100)] 
        public string? @auditTypeGroup   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsTokenPass")] 
        public bool? @IsTokenPass   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactEmail1")] 
        [MaxLength(200)] 
        public string? @contactEmail1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactEmail2")] 
        [MaxLength(200)] 
        public string? @contactEmail2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactPerson")] 
        [MaxLength(100)] 
        public string? @contactPerson   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactPerson1")] 
        [MaxLength(100)] 
        public string? @contactPerson1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactPerson2")] 
        [MaxLength(100)] 
        public string? @contactPerson2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("cmobilePhone1")] 
        [MaxLength(200)] 
        public string? @cmobilePhone1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("cmobilePhone2")] 
        [MaxLength(200)] 
        public string? @cmobilePhone2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shipDays")] 
        [MaxLength(100)] 
        public string? @shipDays   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ipList")] 
        [MaxLength(1000)] 
        public string? @ipList   { get; set; }
        ///<summary> 
        /// 早期api權限使用，目前已無使用 
        /// </summary> 
        [Column("ApiPermissionType")] 
        public byte? @ApiPermissionType   { get; set; }
        ///<summary> 
        /// 可否同步富購(僅1可) 
        /// </summary> 
        [Column("VendorRoleType")] 
        public byte @VendorRoleType   { get; set; }
        ///<summary> 
        /// 廠商角色(設定，依逗號分隔) 
        /// </summary> 
        [Column("VendorRoleGroup")] 
        [MaxLength(100)] 
        public string? @VendorRoleGroup   { get; set; }
        ///<summary> 
        /// 可啟用的子帳號數量上限 
        /// </summary> 
        [Column("SubUserUpLimit")] 
        public int? @SubUserUpLimit   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 建立人員 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 修改人員 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ApiSecureKey")] 
        [MaxLength(32)] 
        public string? @ApiSecureKey   { get; set; }
        ///<summary> 
        /// 驗証方式 (1為token 值, 2為二階驗證) 
        /// </summary> 
        [Column("VerifyMode")] 
        public byte? @VerifyMode   { get; set; }
}
}
