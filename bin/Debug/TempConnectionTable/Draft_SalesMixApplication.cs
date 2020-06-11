using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Draft_SalesMixApplication
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_Draft")] 
        public long @id_Draft   { get; set; }
        ///<summary> 
        /// 銷售品號 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(100)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 商品短敍述(供應商) 
        /// </summary> 
        [Column("prdDesVendor")] 
        public string? @prdDesVendor   { get; set; }
        ///<summary> 
        /// 商品短敍述（商企） 
        /// </summary> 
        [Column("prdDesPlanner")] 
        public string? @prdDesPlanner   { get; set; }
        ///<summary> 
        /// 商品短敍述（外部商企） 
        /// </summary> 
        [Column("prdDesOutPlanner")] 
        public string? @prdDesOutPlanner   { get; set; }
        ///<summary> 
        /// 後臺產品分類 
        /// </summary> 
        [Column("categoryId")] 
        public long? @categoryId   { get; set; }
        ///<summary> 
        /// FK工作流上下文 關聯到暫存區AuditFlowContext裱中的auditFlowContextId 
        /// </summary> 
        [Column("id_AuditFlowContext")] 
        public long? @id_AuditFlowContext   { get; set; }
        ///<summary> 
        /// 申請類型，枚舉 
        /// </summary> 
        [Column("applicationType")] 
        [MaxLength(510)] 
        public string? @applicationType   { get; set; }
        ///<summary> 
        /// 品號名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(510)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 商品屬性編號 外鍵FK 關聯到表Pro 
        /// </summary> 
        [Column("id_ProductProperty")] 
        public int? @id_ProductProperty   { get; set; }
        ///<summary> 
        /// 開始銷售時間 
        /// </summary> 
        [Column("beginSaleTime")] 
        public DateTime? @beginSaleTime   { get; set; }
        ///<summary> 
        /// 銷售結束時間 
        /// </summary> 
        [Column("endSaleTime")] 
        public DateTime? @endSaleTime   { get; set; }
        ///<summary> 
        /// 0:預購商品(一) / 1: 預購商品(二) 
        /// </summary> 
        [Column("statusId")] 
        public int? @statusId   { get; set; }
        ///<summary> 
        /// 市場價格 
        /// </summary> 
        [Column("marketPrice")] 
        public decimal? @marketPrice   { get; set; }
        ///<summary> 
        /// 售價 
        /// </summary> 
        [Column("salePrice")] 
        public decimal? @salePrice   { get; set; }
        ///<summary> 
        /// 成本價 
        /// </summary> 
        [Column("costPrice")] 
        public decimal? @costPrice   { get; set; }
        ///<summary> 
        /// 毛利額 (含稅) 
        /// </summary> 
        [Column("grossMargin")] 
        public decimal? @grossMargin   { get; set; }
        ///<summary> 
        /// 毛利率（含稅） 
        /// </summary> 
        [Column("grossProfit")] 
        public decimal? @grossProfit   { get; set; }
        ///<summary> 
        /// 贈品敍述 
        /// </summary> 
        [Column("presentDescription")] 
        public string? @presentDescription   { get; set; }
        ///<summary> 
        /// 上架狀態 1;上架 0;暫下架 
        /// </summary> 
        [Column("shelveId")] 
        public int? @shelveId   { get; set; }
        ///<summary> 
        /// 上架保留   1 ：是     0：否 
        /// </summary> 
        [Column("shelveReservation")] 
        public int? @shelveReservation   { get; set; }
        ///<summary> 
        /// 可否退貨 
        /// </summary> 
        [Column("canReturn")] 
        public byte? @canReturn   { get; set; }
        ///<summary> 
        /// 可否換貨 
        /// </summary> 
        [Column("canChange")] 
        public byte? @canChange   { get; set; }
        ///<summary> 
        /// 分付票期 
        /// </summary> 
        [Column("paymentPeriod")] 
        public int? @paymentPeriod   { get; set; }
        ///<summary> 
        /// 1： 分期設定 0：不可分期 ；  其他數位為可分期 
        /// </summary> 
        [Column("installmentSetting")] 
        public int? @installmentSetting   { get; set; }
        ///<summary> 
        /// 進貨稅別 
        /// </summary> 
        [Column("shipmentTaxType")] 
        public int? @shipmentTaxType   { get; set; }
        ///<summary> 
        /// 是否開發票 
        /// </summary> 
        [Column("isReceipt")] 
        public byte? @isReceipt   { get; set; }
        ///<summary> 
        /// 員工價格 
        /// </summary> 
        [Column("employeePrice")] 
        public decimal? @employeePrice   { get; set; }
        ///<summary> 
        /// 銷售獎勵金 
        /// </summary> 
        [Column("saleBonus")] 
        public decimal? @saleBonus   { get; set; }
        ///<summary> 
        /// 紅利購買 
        /// </summary> 
        [Column("canBuyByProfit")] 
        public byte? @canBuyByProfit   { get; set; }
        ///<summary> 
        /// 現金賬戶購買 
        /// </summary> 
        [Column("canBuyByAccount")] 
        public byte? @canBuyByAccount   { get; set; }
        ///<summary> 
        /// 商品搜索關鍵字 
        /// </summary> 
        [Column("searchKeyword")] 
        public string? @searchKeyword   { get; set; }
        ///<summary> 
        /// 1：單獨出貨 0：否 
        /// </summary> 
        [Column("canIndependentShipment")] 
        public byte? @canIndependentShipment   { get; set; }
        ///<summary> 
        /// 0:預購商品（一） 
        /// </summary> 
        [Column("preBuyPrdOne")] 
        [MaxLength(100)] 
        public string? @preBuyPrdOne   { get; set; }
        ///<summary> 
        /// 1: 預購商品(二) 
        /// </summary> 
        [Column("preBuyPrdTwo")] 
        [MaxLength(100)] 
        public string? @preBuyPrdTwo   { get; set; }
        ///<summary> 
        /// 配送方式 1:庫送 2：指送（廠送） 
        /// </summary> 
        [Column("deliveryWay")] 
        [MaxLength(60)] 
        public string? @deliveryWay   { get; set; }
        ///<summary> 
        /// 配送類型. 1:一般   2:便利袋  3:一般AND便利袋   4:冷藏 5:冷凍 
        /// </summary> 
        [Column("deliveryType")] 
        [MaxLength(60)] 
        public string? @deliveryType   { get; set; }
        ///<summary> 
        /// 長 
        /// </summary> 
        [Column("packingLength")] 
        public decimal? @packingLength   { get; set; }
        ///<summary> 
        /// 寬 
        /// </summary> 
        [Column("packingWidth")] 
        public decimal? @packingWidth   { get; set; }
        ///<summary> 
        /// 高度 
        /// </summary> 
        [Column("packingHeight")] 
        public decimal? @packingHeight   { get; set; }
        ///<summary> 
        /// 離島配送 1:可 0：不可 
        /// </summary> 
        [Column("outIslandDeliever")] 
        public byte? @outIslandDeliever   { get; set; }
        ///<summary> 
        /// 附加運費 
        /// </summary> 
        [Column("additionalFreight")] 
        public double? @additionalFreight   { get; set; }
        ///<summary> 
        /// 配送注意事項 
        /// </summary> 
        [Column("deliveryAttentions")] 
        [MaxLength(510)] 
        public string? @deliveryAttentions   { get; set; }
        ///<summary> 
        /// 館長推薦（供應商） 
        /// </summary> 
        [Column("recommendationDescription")] 
        public string? @recommendationDescription   { get; set; }
        ///<summary> 
        /// 館長推薦（商企） 
        /// </summary> 
        [Column("recommendationDescriptionPlanner")] 
        public string? @recommendationDescriptionPlanner   { get; set; }
        ///<summary> 
        /// 館長推薦（外部商企） 
        /// </summary> 
        [Column("recommendationDescriptionOutPlanner")] 
        public string? @recommendationDescriptionOutPlanner   { get; set; }
        ///<summary> 
        /// 商品規格 
        /// </summary> 
        [Column("productSpecification")] 
        public string? @productSpecification   { get; set; }
        ///<summary> 
        /// 注意事項 
        /// </summary> 
        [Column("attentionItem")] 
        public string? @attentionItem   { get; set; }
        ///<summary> 
        /// 發送時間 
        /// </summary> 
        [Column("sendTime")] 
        public DateTime? @sendTime   { get; set; }
        ///<summary> 
        /// 供應商編號，關聯到中的Vendor中的id 
        /// </summary> 
        [Column("vendorCode_Vendor")] 
        [MaxLength(100)] 
        public string? @vendorCode_Vendor   { get; set; }
        ///<summary> 
        /// 最後修改人 
        /// </summary> 
        [Column("lastModifier")] 
        [MaxLength(300)] 
        public string? @lastModifier   { get; set; }
        ///<summary> 
        /// 商品文件申請類別， 0: 新商品提報, 1：修改商品 (不含:成本及分期設定)**停用**, 2：修改商品 (含: 成本及分期設定)**停用**, 3：B2E主管修改商品(無變價功能), 4：B2E營業主管商品變價, 5：B2B修改商品(無變價功能), 6：B2B商品變價 
        /// </summary> 
        [Column("salesMixType")] 
        public byte? @salesMixType   { get; set; }
        ///<summary> 
        /// FK，正式區中的商品品號Id 關聯到正式區SalesMix表中的id 
        /// </summary> 
        [Column("id_SalesMix")] 
        public long? @id_SalesMix   { get; set; }
        ///<summary> 
        /// 操作狀態，枚舉如下 
        /// isDraft=草稿狀態 
        /// isNotDraft=非草稿狀態 
        /// isDevelopmentStaffReject=商開駁回狀態 
        /// isVendorReject=供應商取消（退件）狀態 
        /// </summary> 
        [Column("auditStatus")] 
        [MaxLength(200)] 
        public string? @auditStatus   { get; set; }
        ///<summary> 
        /// 關聯到正式區User裱中的Id 
        /// </summary> 
        [Column("id_User")] 
        public long? @id_User   { get; set; }
        ///<summary> 
        /// 重量 
        /// </summary> 
        [Column("weight")] 
        public decimal? @weight   { get; set; }
        ///<summary> 
        /// 折抵上限 
        /// </summary> 
        [Column("bonusLimitRate")] 
        public decimal? @bonusLimitRate   { get; set; }
        ///<summary> 
        /// 售價稅率類別 枚舉類型 
        /// 銷售價格外加稅率類別： 
        /// SalePriceInAddtionTax 
        /// 銷售價格內含稅率類別： 
        /// SalePriceIncludeTax 
        /// 銷售價格免稅率類別： 
        /// SalePriceFreeTax 
        /// </summary> 
        [Column("salePriceTaxType")] 
        [MaxLength(60)] 
        public string? @salePriceTaxType   { get; set; }
        ///<summary> 
        /// 售價稅率 
        /// </summary> 
        [Column("salePriceTax")] 
        public decimal? @salePriceTax   { get; set; }
        ///<summary> 
        /// 成本價稅率類別 枚舉類型 
        /// 成本價格外加稅率類別： 
        /// CostPriceInAddtionTax 
        /// 成本價格內含稅率類別： 
        /// CostPriceIncludeTax 
        /// 成本價格免稅率類別： 
        /// CostPriceFreeTax 
        /// </summary> 
        [Column("costPriceTaxType")] 
        [MaxLength(60)] 
        public string? @costPriceTaxType   { get; set; }
        ///<summary> 
        /// 成本價稅率 
        /// </summary> 
        [Column("costPriceTax")] 
        public decimal? @costPriceTax   { get; set; }
        ///<summary> 
        /// 毛利率（未稅） 
        /// </summary> 
        [Column("grossProfitNoTax")] 
        public decimal? @grossProfitNoTax   { get; set; }
        ///<summary> 
        /// 毛利額 (未稅) 
        /// </summary> 
        [Column("grossMarginNoTax")] 
        public decimal? @grossMarginNoTax   { get; set; }
        ///<summary> 
        /// 回饋紅利 
        /// </summary> 
        [Column("giftBonus")] 
        public decimal? @giftBonus   { get; set; }
        ///<summary> 
        /// 鑒賞期 
        /// </summary> 
        [Column("appricationPeriod")] 
        public long? @appricationPeriod   { get; set; }
        ///<summary> 
        /// 品號狀態: 可銷售/銷售不可 
        /// </summary> 
        [Column("saleStatus")] 
        [MaxLength(400)] 
        public string? @saleStatus   { get; set; }
        ///<summary> 
        /// 商品狀態，SaleStatus id欄位 
        /// </summary> 
        [Column("id_saleStatus")] 
        public int? @id_saleStatus   { get; set; }
        ///<summary> 
        /// 商企商品規格 
        /// </summary> 
        [Column("productSpecificationPlanner")] 
        public string? @productSpecificationPlanner   { get; set; }
        ///<summary> 
        /// 商企注意事項 
        /// </summary> 
        [Column("attentionItemPlanner")] 
        public string? @attentionItemPlanner   { get; set; }
        ///<summary> 
        /// 信用卡分期期數 
        /// </summary> 
        [Column("installmentNo")] 
        [MaxLength(60)] 
        public string? @installmentNo   { get; set; }
        ///<summary> 
        /// 富購商品編號 
        /// </summary> 
        [Column("fugoProductID")] 
        [MaxLength(60)] 
        public string? @fugoProductID   { get; set; }
        ///<summary> 
        /// 富購銷售編號 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 富購多重碼 
        /// </summary> 
        [Column("fugoMultiSaleNo")] 
        public int? @fugoMultiSaleNo   { get; set; }
        ///<summary> 
        /// 是否轉富購訂單, null:未成立採購單、未成立入庫單, 0:已建立採購單、已建立入庫單, 1:採購單已送至富購 
        /// </summary> 
        [Column("isSwitchFuGou")] 
        public bool? @isSwitchFuGou   { get; set; }
        ///<summary> 
        /// 合約編號 
        /// </summary> 
        [Column("agreementNumber")] 
        [MaxLength(100)] 
        public string? @agreementNumber   { get; set; }
        ///<summary> 
        /// 富購回傳代碼 
        /// </summary> 
        [Column("returnCode")] 
        public int? @returnCode   { get; set; }
        ///<summary> 
        /// 富購回傳信息 
        /// </summary> 
        [Column("returnMsg")] 
        [MaxLength(2000)] 
        public string? @returnMsg   { get; set; }
        ///<summary> 
        /// 可否使用積分購買 
        /// </summary> 
        [Column("canBuyByIntegral")] 
        public bool? @canBuyByIntegral   { get; set; }
        ///<summary> 
        /// 是否商品來自 Excel 匯入 
        /// </summary> 
        [Column("isImprotedFromExcel")] 
        public bool? @isImprotedFromExcel   { get; set; }
        ///<summary> 
        /// 匯入Excel檔案名稱 
        /// </summary> 
        [Column("excelFileName")] 
        [MaxLength(100)] 
        public string? @excelFileName   { get; set; }
        ///<summary> 
        /// 商品年齡分級(E: Everyone 一般商品, 每個人都可購買,A: Adult 成人商品 ) 
        /// </summary> 
        [Column("ageRating")] 
        [MaxLength(2)] 
        public string? @ageRating   { get; set; }
        ///<summary> 
        /// 富購商品類型,富購一般商品,國內外旅遊商品, 1001:一般商品,100x:國內旅遊商品,100x:國外旅遊商品 (依環境有所區別) 
        /// </summary> 
        [Column("fugoItemType")] 
        [MaxLength(4)] 
        public string? @fugoItemType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("expirationDate")] 
        public DateTime? @expirationDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isfugoCouponUsable")] 
        public bool? @isfugoCouponUsable   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleName")] 
        [MaxLength(510)] 
        public string? @saleName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productDevelopmentStaff")] 
        [MaxLength(40)] 
        public string? @productDevelopmentStaff   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoIvrOrder")] 
        public bool? @fugoIvrOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoAgentOrder")] 
        public bool? @fugoAgentOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isExpressProduct")] 
        public bool? @isExpressProduct   { get; set; }
        ///<summary> 
        /// 銷售副標文字 
        /// </summary> 
        [Column("SalesSubtitle")] 
        [MaxLength(510)] 
        public string? @SalesSubtitle   { get; set; }
        ///<summary> 
        /// 商品頁屬性設定： 0=不顯示折價券及小幫手, 1=顯示折價券及小幫手 
        /// </summary> 
        [Column("showSaleTipIcon")] 
        public int? @showSaleTipIcon   { get; set; }
        ///<summary> 
        /// 行銷活動, 0:無(表示無設定行銷屬性) 1:集購 2:好康 
        /// </summary> 
        [Column("marketingProperty")] 
        public int? @marketingProperty   { get; set; }
        ///<summary> 
        /// 0或null: 表示參加, 1: 表示不參加 
        /// </summary> 
        [Column("notApplyToMarketingEvent")] 
        public byte? @notApplyToMarketingEvent   { get; set; }
        ///<summary> 
        /// 可否使用貨到付款0：不可；1：可以 
        /// </summary> 
        [Column("canUseCOD")] 
        public bool? @canUseCOD   { get; set; }
        ///<summary> 
        /// 相關字號&專利 
        /// </summary> 
        [Column("patentNo")] 
        public string? @patentNo   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("note")] 
        public string? @note   { get; set; }
        ///<summary> 
        /// 上架時間 
        /// </summary> 
        [Column("onShelf")] 
        public DateTime? @onShelf   { get; set; }
        ///<summary> 
        /// 下架時間 
        /// </summary> 
        [Column("offShelf")] 
        public DateTime? @offShelf   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("boxNo")] 
        public short? @boxNo   { get; set; }
        ///<summary> 
        /// 包裝方式: 1001 制式紙箱, 1002 裸品, 1003 木箱, 1004 鐵箱, 1005 原箱包裝 
        /// </summary> 
        [Column("packType")] 
        public short? @packType   { get; set; }
        ///<summary> 
        /// 是否為可海外訂購之商品 
        /// </summary> 
        [Column("isInternationalShipping")] 
        public bool? @isInternationalShipping   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isPreorder")] 
        public byte? @isPreorder   { get; set; }
        ///<summary> 
        /// 預計入庫日 
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
        /// 累點比率, 一般是1 可依據商品分類及商品另做設定 
        /// </summary> 
        [Column("GETPOINTRATE")] 
        public decimal? @GETPOINTRATE   { get; set; }
        ///<summary> 
        /// 累點點數, 該商品最多可得點數 
        /// </summary> 
        [Column("GETPOINT")] 
        public int? @GETPOINT   { get; set; }
        ///<summary> 
        /// 兌點比率, 0.5代表本商品可用上限率50% 
        /// </summary> 
        [Column("USEPOINTRATE")] 
        public decimal? @USEPOINTRATE   { get; set; }
        ///<summary> 
        /// 兌點點數, 該商品可使用最多兌點數 
        /// </summary> 
        [Column("USEPOINT")] 
        public int? @USEPOINT   { get; set; }
        ///<summary> 
        /// 是否兌點專區商品, 1:Y, 0:N 
        /// </summary> 
        [Column("ISPOINTAREA")] 
        public byte? @ISPOINTAREA   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_saleMixApplication")] 
        public long? @id_saleMixApplication   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platForm")] 
        public byte? @platForm   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("priceFlag")] 
        public int? @priceFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
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
        [Column("preorderShipDate2")] 
        public DateTime? @preorderShipDate2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isExpressProduct2")] 
        public bool? @isExpressProduct2   { get; set; }
        ///<summary> 
        /// 1:網路商品 2:電視商品 3:ECTV 
        /// </summary> 
        [Column("eType")] 
        public byte? @eType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("experienceweb")] 
        [MaxLength(800)] 
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
        /// (作廢)改由CanUseDiscount取代 
        /// </summary> 
        [Column("shoppingPointUpperBound")] 
        public decimal? @shoppingPointUpperBound   { get; set; }
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
        [Column("isB2BProduct")] 
        public bool? @isB2BProduct   { get; set; }
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
        [Column("needsTrust")] 
        [MaxLength(1)] 
        public string? @needsTrust   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("tozero_restore")] 
        public byte? @tozero_restore   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("noFollow")] 
        public bool @noFollow   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sys_source")] 
        public byte? @sys_source   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("detailSpecID")] 
        public int? @detailSpecID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GSAExclude")] 
        public bool @GSAExclude   { get; set; }
        ///<summary> 
        /// 商品Flag設定-(0: 未設定, 1: 易碎品 ;上限設定為255) 
        /// </summary> 
        [Column("ProductFlag")] 
        public int @ProductFlag   { get; set; }
}
}
