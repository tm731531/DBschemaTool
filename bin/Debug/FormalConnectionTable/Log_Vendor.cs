using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_Vendor
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [MaxLength(100)] 
        public string? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shortName")] 
        public string? @shortName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("unifiedSerialNumber")] 
        public string? @unifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("capitalization")] 
        public decimal? @capitalization   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastTurnover")] 
        public decimal? @lastTurnover   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("foundingDate")] 
        public DateTime? @foundingDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("homePage")] 
        public string? @homePage   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("responsibleOfficer")] 
        public string? @responsibleOfficer   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("country")] 
        public string? @country   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companyPhone")] 
        public string? @companyPhone   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companyFax")] 
        public string? @companyFax   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractor")] 
        public string? @contractor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractorPosition")] 
        public string? @contractorPosition   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractorPhone")] 
        public string? @contractorPhone   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractorMobile")] 
        public string? @contractorMobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractorFax")] 
        public string? @contractorFax   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractorAttentions")] 
        public string? @contractorAttentions   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productMainCategory")] 
        public long? @productMainCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("assignedMD")] 
        public long? @assignedMD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactEmail")] 
        public string? @contactEmail   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companyProfile")] 
        public string? @companyProfile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companyProfile1DocPath")] 
        public string? @companyProfile1DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companyProfile2DocPath")] 
        public string? @companyProfile2DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companyProfile3DocPath")] 
        public string? @companyProfile3DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companyProfile4DocPath")] 
        public string? @companyProfile4DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companyProfile5DocPath")] 
        public string? @companyProfile5DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productProfile")] 
        public string? @productProfile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productProfile1DocPath")] 
        public string? @productProfile1DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productProfile2DocPath")] 
        public string? @productProfile2DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productProfile3DocPath")] 
        public string? @productProfile3DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productProfile4DocPath")] 
        public string? @productProfile4DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productProfile5DocPath")] 
        public string? @productProfile5DocPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("paymentAccountName")] 
        public string? @paymentAccountName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("paymentAccountNo")] 
        public string? @paymentAccountNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("paymentBank")] 
        public long? @paymentBank   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("paymentCondition")] 
        public long? @paymentCondition   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("paymentWay")] 
        public long? @paymentWay   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("financialContactor")] 
        public string? @financialContactor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("financialContactorMobile")] 
        public string? @financialContactorMobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("financialContactorSex")] 
        public string? @financialContactorSex   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("financialOfficeFax")] 
        public string? @financialOfficeFax   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("financialOfficePhone")] 
        public string? @financialOfficePhone   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("logisticsContactor")] 
        public string? @logisticsContactor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("logisticsContactorMobile")] 
        public string? @logisticsContactorMobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("logisticsContactorSex")] 
        public string? @logisticsContactorSex   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("logisticsOfficeFax")] 
        public string? @logisticsOfficeFax   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("logisticsOfficePhone")] 
        public string? @logisticsOfficePhone   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("businessAddressId")] 
        public long? @businessAddressId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("invoiceDeliveryAddressId")] 
        public long? @invoiceDeliveryAddressId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shipmentAddress1Id")] 
        public long? @shipmentAddress1Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shipmentAddress2Id")] 
        public long? @shipmentAddress2Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("responsibleOfficerSex")] 
        public string? @responsibleOfficerSex   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractorSex")] 
        public string? @contractorSex   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("agreementNumber")] 
        public string? @agreementNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("agreementStartingTime")] 
        public DateTime? @agreementStartingTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("startingEndingTime")] 
        public DateTime? @startingEndingTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("agreementRatifier")] 
        public long? @agreementRatifier   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorState")] 
        public string? @vendorState   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("stateChangeNote")] 
        public string? @stateChangeNote   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment1")] 
        public bool? @attachment1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment2")] 
        public bool? @attachment2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment3")] 
        public bool? @attachment3   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment4")] 
        public bool? @attachment4   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment5")] 
        public bool? @attachment5   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment6")] 
        public bool? @attachment6   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment7")] 
        public bool? @attachment7   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment8")] 
        public bool? @attachment8   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("registerAddressId")] 
        public long? @registerAddressId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("applicationDate")] 
        public DateTime? @applicationDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("relationshipModifyTime")] 
        public DateTime? @relationshipModifyTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoVendorId")] 
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
        /// 
        /// </summary> 
        [Column("fugoVendorId2")] 
        public string? @fugoVendorId2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorState2")] 
        public string? @vendorState2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contractorAttentions2")] 
        public string? @contractorAttentions2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("agreementNumber2")] 
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
        public string? @stateChangeNote2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
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
        public string? @eTypeGroup   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("auditTypeGroup")] 
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
        public string? @contactEmail1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactEmail2")] 
        public string? @contactEmail2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactPerson")] 
        public string? @contactPerson   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactPerson1")] 
        public string? @contactPerson1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contactPerson2")] 
        public string? @contactPerson2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("cmobilePhone1")] 
        public string? @cmobilePhone1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("cmobilePhone2")] 
        public string? @cmobilePhone2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shipDays")] 
        public string? @shipDays   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ipList")] 
        public string? @ipList   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ApiPermissionType")] 
        public byte? @ApiPermissionType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorRoleType")] 
        public byte? @VendorRoleType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorRoleGroup")] 
        public string? @VendorRoleGroup   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_action")] 
        [MaxLength(1)] 
        public string? @trg_action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_create_on")] 
        public DateTime @trg_create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SubUserUpLimit")] 
        public int? @SubUserUpLimit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ApiSecureKey")] 
        public string? @ApiSecureKey   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VerifyMode")] 
        public byte? @VerifyMode   { get; set; }
}
}
