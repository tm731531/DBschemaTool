using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VendorWarehouse
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// HEDI流水編號/超取母代碼 
        /// </summary> 
        [Column("MerchantID")] 
        [MaxLength(30)] 
        public string @MerchantID   { get; set; }
        ///<summary> 
        /// HEDI廠代/超取子代碼 
        /// </summary> 
        [Column("SetVat")] 
        [MaxLength(30)] 
        public string @SetVat   { get; set; }
        ///<summary> 
        /// 物流種類 1：一般 3：冷凍 4：蔬果類 8：冷藏 10：小物 
        /// </summary> 
        [Column("SetClass")] 
        public int @SetClass   { get; set; }
        ///<summary> 
        /// 公司名稱 
        /// </summary> 
        [Column("CompanyName")] 
        [MaxLength(50)] 
        public string @CompanyName   { get; set; }
        ///<summary> 
        /// 統編 
        /// </summary> 
        [Column("SerialNumber")] 
        [MaxLength(8)] 
        public string @SerialNumber   { get; set; }
        ///<summary> 
        /// 倉庫名稱 
        /// </summary> 
        [Column("WarehouseName")] 
        [MaxLength(50)] 
        public string @WarehouseName   { get; set; }
        ///<summary> 
        /// HEDI簽約代碼 
        /// </summary> 
        [Column("SetCG")] 
        [MaxLength(50)] 
        public string @SetCG   { get; set; }
        ///<summary> 
        /// API類型:HEDI:指定竹運出貨/FME:全家常溫/FMF:全家冷凍/HLF:萊爾富冷凍 
        /// </summary> 
        [Column("API_ThirdParty")] 
        [MaxLength(30)] 
        public string @API_ThirdParty   { get; set; }
        ///<summary> 
        /// 0:停用 1:啓用 
        /// </summary> 
        [Column("WareHouseStatus")] 
        public int @WareHouseStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorID")] 
        [MaxLength(10)] 
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
        /// 聯絡人 
        /// </summary> 
        [Column("SetContacter")] 
        [MaxLength(30)] 
        public string? @SetContacter   { get; set; }
        ///<summary> 
        /// 聯絡人E-Mail 
        /// </summary> 
        [Column("ContactEmail")] 
        [MaxLength(300)] 
        public string? @ContactEmail   { get; set; }
        ///<summary> 
        /// 聯絡人電話 
        /// </summary> 
        [Column("ContactPhone")] 
        [MaxLength(20)] 
        public string? @ContactPhone   { get; set; }
        ///<summary> 
        /// API驗證狀態：0:申請/1:合格/2:待驗證/3:不合格 
        /// </summary> 
        [Column("Verified")] 
        public int? @Verified   { get; set; }
        ///<summary> 
        /// 超取退貨地址 
        /// </summary> 
        [Column("Address")] 
        [MaxLength(100)] 
        public string? @Address   { get; set; }
        ///<summary> 
        /// 超取退貨週期 
        /// </summary> 
        [Column("ReturnCycle")] 
        public int? @ReturnCycle   { get; set; }
        ///<summary> 
        /// 超取退貨日 
        /// </summary> 
        [Column("ReturnDay")] 
        public int? @ReturnDay   { get; set; }
        ///<summary> 
        /// 超取退貨貨運公司別 
        /// </summary> 
        [Column("ReturnMode")] 
        public int? @ReturnMode   { get; set; }
        ///<summary> 
        /// 超取其他貨運說明 
        /// </summary> 
        [Column("ReturnModeOther")] 
        [MaxLength(50)] 
        public string? @ReturnModeOther   { get; set; }
        ///<summary> 
        /// 廠商API 回傳Code，全家與萊爾富共用 
        /// </summary> 
        [Column("FamilyReturnCode")] 
        [MaxLength(20)] 
        public string? @FamilyReturnCode   { get; set; }
        ///<summary> 
        /// 廠商API 回傳訊息，全家與萊爾富共用 
        /// </summary> 
        [Column("FamilyReturnMsg")] 
        [MaxLength(200)] 
        public string? @FamilyReturnMsg   { get; set; }
        ///<summary> 
        /// 超取申請者IP 
        /// </summary> 
        [Column("IP")] 
        [MaxLength(20)] 
        public string? @IP   { get; set; }
        ///<summary> 
        /// 超取Step2列印標籤：0:未印/1:已印 
        /// </summary> 
        [Column("IsPrint")] 
        public bool? @IsPrint   { get; set; }
        ///<summary> 
        /// 超取Step3完成確認：0:未確認/1:已確認 
        /// </summary> 
        [Column("Finish")] 
        public bool? @Finish   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ContractAgreementTime")] 
        public DateTime? @ContractAgreementTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ZipCode")] 
        [MaxLength(20)] 
        public string? @ZipCode   { get; set; }
        ///<summary> 
        /// 超取集貨地址 
        /// </summary> 
        [Column("StockAddress")] 
        [MaxLength(100)] 
        public string? @StockAddress   { get; set; }
        ///<summary> 
        /// 超取集貨DC 
        /// </summary> 
        [Column("StockDcNo")] 
        public byte? @StockDcNo   { get; set; }
        ///<summary> 
        /// 超取退貨DC 
        /// </summary> 
        [Column("ReturnDcNo")] 
        public byte? @ReturnDcNo   { get; set; }
        ///<summary> 
        /// 超取廠商非工作日 
        /// </summary> 
        [Column("PrepaidPeriod")] 
        [MaxLength(20)] 
        public string? @PrepaidPeriod   { get; set; }
        ///<summary> 
        /// 東購:2011、新零售:2012 
        /// </summary> 
        [Column("CompanyID")] 
        public int? @CompanyID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
}
}
