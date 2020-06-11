using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_SalesMix
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("prdDesVendor")] 
        public string? @prdDesVendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("prdDesPlanner")] 
        public string? @prdDesPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("prdDesOutPlanner")] 
        public string? @prdDesOutPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryId")] 
        public long? @categoryId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(510)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_ProductProperty")] 
        public long? @id_ProductProperty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("beginSaleTime")] 
        public DateTime? @beginSaleTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("endSaleTime")] 
        public DateTime? @endSaleTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("statusId")] 
        public int? @statusId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("marketPrice")] 
        public decimal? @marketPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePrice")] 
        public decimal? @salePrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("costPrice")] 
        public decimal? @costPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossMargin")] 
        public decimal? @grossMargin   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossProfit")] 
        public decimal? @grossProfit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("presentDescription")] 
        public string? @presentDescription   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shelveReservation")] 
        public int? @shelveReservation   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canReturn")] 
        public byte? @canReturn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canChange")] 
        public byte? @canChange   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("paymentPeriod")] 
        public int? @paymentPeriod   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("installmentSetting")] 
        public int? @installmentSetting   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shipmentTaxType")] 
        public int? @shipmentTaxType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isReceipt")] 
        public byte? @isReceipt   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("employeePrice")] 
        public decimal? @employeePrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleBonus")] 
        public decimal? @saleBonus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canBuyByProfit")] 
        public byte? @canBuyByProfit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canBuyByAccount")] 
        public byte? @canBuyByAccount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("searchKeyword")] 
        public string? @searchKeyword   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canIndependentShipment")] 
        public byte? @canIndependentShipment   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("preBuyPrdOne")] 
        [MaxLength(100)] 
        public string? @preBuyPrdOne   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("preBuyPrdTwo")] 
        [MaxLength(100)] 
        public string? @preBuyPrdTwo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deliveryWay")] 
        [MaxLength(60)] 
        public string? @deliveryWay   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deliveryType")] 
        [MaxLength(60)] 
        public string? @deliveryType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("packingLength")] 
        public decimal? @packingLength   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("packingWidth")] 
        public decimal? @packingWidth   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("packingHeight")] 
        public decimal? @packingHeight   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("outIslandDeliever")] 
        public byte? @outIslandDeliever   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("additionalFreight")] 
        public double? @additionalFreight   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deliveryAttentions")] 
        public string? @deliveryAttentions   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("recommendationDescription")] 
        public string? @recommendationDescription   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("recommendationDescriptionPlanner")] 
        public string? @recommendationDescriptionPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("recommendationDescriptionOutPlanner")] 
        public string? @recommendationDescriptionOutPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attentionItem")] 
        public string? @attentionItem   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sendTime")] 
        public DateTime? @sendTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorCode_Vendor")] 
        [MaxLength(100)] 
        public string? @vendorCode_Vendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleStatus")] 
        [MaxLength(400)] 
        public string? @saleStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isFrontedCategory")] 
        public bool? @isFrontedCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifier")] 
        [MaxLength(300)] 
        public string? @lastModifier   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isFlow")] 
        public int? @isFlow   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("statusBeforeModify")] 
        [MaxLength(400)] 
        public string? @statusBeforeModify   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("weight")] 
        public decimal? @weight   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("bonusLimitRate")] 
        public decimal? @bonusLimitRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePriceTaxType")] 
        [MaxLength(60)] 
        public string? @salePriceTaxType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePriceTax")] 
        public decimal? @salePriceTax   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("costPriceTaxType")] 
        [MaxLength(60)] 
        public string? @costPriceTaxType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("costPriceTax")] 
        public decimal? @costPriceTax   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossProfitNoTax")] 
        public decimal? @grossProfitNoTax   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossMarginNoTax")] 
        public decimal? @grossMarginNoTax   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("relationshipModifyTime")] 
        public DateTime? @relationshipModifyTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("giftBonus")] 
        public decimal? @giftBonus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("appricationPeriod")] 
        public long? @appricationPeriod   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isNewSalesMix")] 
        public bool? @isNewSalesMix   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleName")] 
        [MaxLength(510)] 
        public string? @saleName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_User")] 
        public long? @id_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoProductID")] 
        [MaxLength(60)] 
        public string? @fugoProductID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoMultiSaleNo")] 
        public int? @fugoMultiSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("installmentNo")] 
        [MaxLength(60)] 
        public string? @installmentNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productDevelopmentStaff")] 
        [MaxLength(40)] 
        public string @productDevelopmentStaff   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productAdmin")] 
        [MaxLength(40)] 
        public string? @productAdmin   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_SaleStatus")] 
        public int? @id_SaleStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("returnCode")] 
        public int? @returnCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("returnMsg")] 
        [MaxLength(2000)] 
        public string? @returnMsg   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isFugoUpdate")] 
        public int? @isFugoUpdate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("presentDescriptionPlanner")] 
        public string? @presentDescriptionPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attentionItemPlanner")] 
        public string? @attentionItemPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isUpdateFrontendCategory")] 
        public bool? @isUpdateFrontendCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoCompanyId")] 
        public int? @fugoCompanyId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isB2BProduct")] 
        public bool? @isB2BProduct   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isB2BModified")] 
        public bool? @isB2BModified   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canBuyByIntegral")] 
        public bool? @canBuyByIntegral   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoContractNo")] 
        [MaxLength(50)] 
        public string? @fugoContractNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("updFromSMA_id")] 
        public long? @updFromSMA_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SalesSubtitle")] 
        [MaxLength(510)] 
        public string? @SalesSubtitle   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ageRating")] 
        [MaxLength(2)] 
        public string @ageRating   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isfugoCouponUsable")] 
        public bool @isfugoCouponUsable   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("expirationDate")] 
        public DateTime? @expirationDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoItemType")] 
        [MaxLength(4)] 
        public string? @fugoItemType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoIvrOrder")] 
        public bool @fugoIvrOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoAgentOrder")] 
        public bool @fugoAgentOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("firstSaleTime")] 
        public DateTime? @firstSaleTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime? @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isExpressProduct")] 
        public bool @isExpressProduct   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isInternationalShipping")] 
        public bool @isInternationalShipping   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shoppingPointUpperBound")] 
        public decimal @shoppingPointUpperBound   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("showSaleTipIcon")] 
        public int @showSaleTipIcon   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("marketingProperty")] 
        public int @marketingProperty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("notApplyToMarketingEvent")] 
        public byte? @notApplyToMarketingEvent   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canUseCOD")] 
        public bool? @canUseCOD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("patentNo")] 
        public string? @patentNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("note")] 
        public string? @note   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("onShelf")] 
        public DateTime? @onShelf   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("offShelf")] 
        public DateTime? @offShelf   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("boxNo")] 
        public short? @boxNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("packType")] 
        public short? @packType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isPreorder")] 
        public byte? @isPreorder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("preorderShipDate")] 
        public DateTime? @preorderShipDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("preorderShipDays")] 
        public int? @preorderShipDays   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoCreatedDate")] 
        public DateTime? @fugoCreatedDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isAirlift")] 
        public byte? @isAirlift   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo2")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GETPOINTRATE")] 
        public decimal? @GETPOINTRATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GETPOINT")] 
        public int? @GETPOINT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("USEPOINTRATE")] 
        public decimal? @USEPOINTRATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("USEPOINT")] 
        public int? @USEPOINT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ISPOINTAREA")] 
        public byte? @ISPOINTAREA   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_sc")] 
        [MaxLength(40)] 
        public string? @e_sc   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoProductID2")] 
        [MaxLength(60)] 
        public string? @fugoProductID2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoMultiSaleNo2")] 
        public int? @fugoMultiSaleNo2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePriceTaxType2")] 
        [MaxLength(60)] 
        public string? @salePriceTaxType2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePriceTax2")] 
        public decimal? @salePriceTax2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossProfitNoTax2")] 
        public decimal? @grossProfitNoTax2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossMarginNoTax2")] 
        public decimal? @grossMarginNoTax2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isPreorder2")] 
        public byte? @isPreorder2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("preorderShipDate2")] 
        public DateTime? @preorderShipDate2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isExpressProduct2")] 
        public bool? @isExpressProduct2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("eType")] 
        public byte? @eType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("experienceweb")] 
        public string? @experienceweb   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("docType")] 
        [MaxLength(4)] 
        public string? @docType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("formerSaleCode")] 
        [MaxLength(200)] 
        public string? @formerSaleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CWProduct")] 
        [MaxLength(1)] 
        public string? @CWProduct   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fee")] 
        public decimal? @fee   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("feeRate")] 
        public byte? @feeRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AS_ZIPCODE")] 
        [MaxLength(100)] 
        public string? @AS_ZIPCODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AS_ADDRESS")] 
        [MaxLength(100)] 
        public string? @AS_ADDRESS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AL_FLOOR")] 
        public byte? @AL_FLOOR   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AL_ROOM")] 
        public int? @AL_ROOM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rtnContactPerson")] 
        [MaxLength(100)] 
        public string? @rtnContactPerson   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rtnMobilePhone")] 
        [MaxLength(100)] 
        public string? @rtnMobilePhone   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rtnAddressId")] 
        public long? @rtnAddressId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("nakedLength")] 
        public decimal? @nakedLength   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("nakedWidth")] 
        public decimal? @nakedWidth   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("nakedHeight")] 
        public decimal? @nakedHeight   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("nakedWeight")] 
        public decimal? @nakedWeight   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productType")] 
        public int? @productType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("mediFactor")] 
        public byte? @mediFactor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("violetFactor")] 
        public byte? @violetFactor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("keepFactor")] 
        public int? @keepFactor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("keepUnit")] 
        [MaxLength(10)] 
        public string? @keepUnit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("brandFactor")] 
        public int? @brandFactor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("actualShelf")] 
        public DateTime? @actualShelf   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CanUseDiscount")] 
        public bool? @CanUseDiscount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("tozero_restore")] 
        public byte? @tozero_restore   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("needsTrust")] 
        [MaxLength(1)] 
        public string? @needsTrust   { get; set; }
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
        [Column("noFollow")] 
        public bool? @noFollow   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sys_source")] 
        public byte? @sys_source   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("getEHSDRate")] 
        public decimal? @getEHSDRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("getEHSDValue")] 
        public int? @getEHSDValue   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("useEHSDRate")] 
        public decimal? @useEHSDRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("useEHSDValue")] 
        public int? @useEHSDValue   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("detailSpecID")] 
        public int? @detailSpecID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GSAExclude")] 
        public bool? @GSAExclude   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("useSpecialPrice")] 
        public byte? @useSpecialPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductFlag")] 
        public int? @ProductFlag   { get; set; }
}
}
