using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_PRODUCTINFO
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SalesMix_Id")] 
        public long @SalesMix_Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("prdDesPlanner")] 
        [MaxLength(1073741823)] 
        public string? @prdDesPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryId")] 
        public long? @categoryId   { get; set; }
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
        [Column("employeePrice")] 
        public decimal? @employeePrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("canBuyByProfit")] 
        public byte? @canBuyByProfit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("searchKeyword")] 
        [MaxLength(1073741823)] 
        public string? @searchKeyword   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deliveryWay")] 
        [MaxLength(60)] 
        public string? @deliveryWay   { get; set; }
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
        [Column("bonusLimitRate")] 
        public decimal? @bonusLimitRate   { get; set; }
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
        [Column("saleName")] 
        [MaxLength(510)] 
        public string? @saleName   { get; set; }
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
        [Column("presentDescriptionPlanner")] 
        [MaxLength(1073741823)] 
        public string? @presentDescriptionPlanner   { get; set; }
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
        [Column("productNotesPlanner")] 
        [MaxLength(1073741823)] 
        public string? @productNotesPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productId")] 
        public long @productId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("useMethodPlanner")] 
        [MaxLength(1073741823)] 
        public string? @useMethodPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accessoryPlanner")] 
        [MaxLength(1073741823)] 
        public string? @accessoryPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productSpecPlanner")] 
        [MaxLength(1073741823)] 
        public string? @productSpecPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderMode")] 
        [MaxLength(40)] 
        public string? @orderMode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ContentData")] 
        public string? @ContentData   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_SaleStatus")] 
        public int? @id_SaleStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SclassCode")] 
        public long @SclassCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MclassCode")] 
        public long @MclassCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LclassCode")] 
        public long @LclassCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoVendorId")] 
        [MaxLength(12)] 
        public string? @fugoVendorId   { get; set; }
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
        [Column("PriceFlag")] 
        public int @PriceFlag   { get; set; }
}
}
