using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesMix
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 網站編號 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 商品短敍述（供應商） 
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
        /// 後臺產品分類(FRI_FORMAL.BackendCategory.id) 
        /// </summary> 
        [Column("categoryId")] 
        public long? @categoryId   { get; set; }
        ///<summary> 
        /// 品號名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(510)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 商品屬性編號 外鍵(1:一般商品, 2:加價購, 3:競標(KIT), 4:任選, 5:預購, 6:贈品, 7:團購, 8:集購, 9:E購物車加價購, 10.低溫冷藏(已不用), 11.兌點商品) 
        /// </summary> 
        [Column("id_ProductProperty")] 
        public long? @id_ProductProperty   { get; set; }
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
        /// 預購商品相關(0:預計出貨日 1: 訂單成立後幾日)(借位) 
        /// </summary> 
        [Column("statusId")] 
        public int? @statusId   { get; set; }
        ///<summary> 
        /// 市價 
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
        /// 上架保留  1 ：是  0：否 
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
        /// 商品分期設定: 1:分一期(等同不可分期),3:可分三期,6:可分六期,12:可分十二期 
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
        /// 是否可用紅利購買(vwx_productsaleinfo.bonuspayment) 
        /// </summary> 
        [Column("canBuyByProfit")] 
        public byte? @canBuyByProfit   { get; set; }
        ///<summary> 
        /// 現金賬戶購買 
        /// </summary> 
        [Column("canBuyByAccount")] 
        public byte? @canBuyByAccount   { get; set; }
        ///<summary> 
        /// 關聯電視商品 
        /// </summary> 
        [Column("searchKeyword")] 
        public string? @searchKeyword   { get; set; }
        ///<summary> 
        /// 單獨出貨： 1  ；不可單獨出貨：0 
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
        /// 配送方式 1:庫送  2:指送(廠送) 3:到廠取貨 4.特約 
        /// </summary> 
        [Column("deliveryWay")] 
        [MaxLength(60)] 
        public string? @deliveryWay   { get; set; }
        ///<summary> 
        /// 配送類型. 1:一般  4:超商取貨 
        /// </summary> 
        [Column("deliveryType")] 
        [MaxLength(60)] 
        public string? @deliveryType   { get; set; }
        ///<summary> 
        /// 長(包裝) 
        /// </summary> 
        [Column("packingLength")] 
        public decimal? @packingLength   { get; set; }
        ///<summary> 
        /// 寬(包裝) 
        /// </summary> 
        [Column("packingWidth")] 
        public decimal? @packingWidth   { get; set; }
        ///<summary> 
        /// 高(包裝) 
        /// </summary> 
        [Column("packingHeight")] 
        public decimal? @packingHeight   { get; set; }
        ///<summary> 
        /// 離島 
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
        /// 店長推薦 
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
        /// 供應商代碼(Vendor.id) 
        /// </summary> 
        [Column("vendorCode_Vendor")] 
        [MaxLength(100)] 
        public string? @vendorCode_Vendor   { get; set; }
        ///<summary> 
        /// 品號狀態:可銷售/銷售不可/暫下架 
        /// </summary> 
        [Column("saleStatus")] 
        [MaxLength(400)] 
        public string? @saleStatus   { get; set; }
        ///<summary> 
        /// 是否已經分類（前臺）,0:未分類； 1：已分類 
        /// </summary> 
        [Column("isFrontedCategory")] 
        public bool? @isFrontedCategory   { get; set; }
        ///<summary> 
        /// 最後修改人 
        /// </summary> 
        [Column("lastModifier")] 
        [MaxLength(300)] 
        public string? @lastModifier   { get; set; }
        ///<summary> 
        /// 0：表示品號處於正常狀態 
        /// 1： 表示品號處於供應商修改商品審核流程中 
        /// </summary> 
        [Column("isFlow")] 
        public int? @isFlow   { get; set; }
        ///<summary> 
        /// 更改合作關係前的商品狀態 
        /// </summary> 
        [Column("statusBeforeModify")] 
        [MaxLength(400)] 
        public string? @statusBeforeModify   { get; set; }
        ///<summary> 
        /// 重量(公克)(包裝) 
        /// </summary> 
        [Column("weight")] 
        public decimal? @weight   { get; set; }
        ///<summary> 
        /// 折抵上限 
        /// </summary> 
        [Column("bonusLimitRate")] 
        public decimal? @bonusLimitRate   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
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
        /// 供應商合作關係變更時間 
        /// </summary> 
        [Column("relationshipModifyTime")] 
        public DateTime? @relationshipModifyTime   { get; set; }
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
        /// 新品提報採購flag 
        /// </summary> 
        [Column("isNewSalesMix")] 
        public bool? @isNewSalesMix   { get; set; }
        ///<summary> 
        /// 銷售名稱 
        /// </summary> 
        [Column("saleName")] 
        [MaxLength(510)] 
        public string? @saleName   { get; set; }
        ///<summary> 
        /// userId，FK，關聯到正式區User表中的Id 
        /// </summary> 
        [Column("id_User")] 
        public long? @id_User   { get; set; }
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
        /// 信用卡分期期數 
        /// </summary> 
        [Column("installmentNo")] 
        [MaxLength(60)] 
        public string? @installmentNo   { get; set; }
        ///<summary> 
        /// 商品開發(User.fugoEmployeeNo2) 
        /// </summary> 
        [Column("productDevelopmentStaff")] 
        [MaxLength(40)] 
        public string @productDevelopmentStaff   { get; set; }
        ///<summary> 
        /// 商品行政(=BackendCategory.productadmin) 
        /// </summary> 
        [Column("productAdmin")] 
        [MaxLength(40)] 
        public string? @productAdmin   { get; set; }
        ///<summary> 
        /// 銷售狀態 id,關聯SaleStatus id欄位(2:銷售不可 3: 巳下巿 4: 可銷售 
        /// </summary> 
        [Column("id_SaleStatus")] 
        public int? @id_SaleStatus   { get; set; }
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
        /// 富購更新標誌（1更新0未更新） 
        /// </summary> 
        [Column("isFugoUpdate")] 
        public int? @isFugoUpdate   { get; set; }
        ///<summary> 
        /// 商企贈品描述 
        /// </summary> 
        [Column("presentDescriptionPlanner")] 
        public string? @presentDescriptionPlanner   { get; set; }
        ///<summary> 
        /// 商企注意事項 
        /// </summary> 
        [Column("attentionItemPlanner")] 
        public string? @attentionItemPlanner   { get; set; }
        ///<summary> 
        /// 從富購過來後是否從暫存區更新過前臺分類 
        /// </summary> 
        [Column("isUpdateFrontendCategory")] 
        public bool? @isUpdateFrontendCategory   { get; set; }
        ///<summary> 
        /// 富購公司別, 1001森森  1004歡樂旅行社; 東森2011  歡樂旅行社 2010 
        /// </summary> 
        [Column("fugoCompanyId")] 
        public int? @fugoCompanyId   { get; set; }
        ///<summary> 
        /// 是否從B2B提報的商品：0否；1是 
        /// </summary> 
        [Column("isB2BProduct")] 
        public bool? @isB2BProduct   { get; set; }
        ///<summary> 
        /// 標識商品是否被供應商或商開維護過：0否；1是 
        /// </summary> 
        [Column("isB2BModified")] 
        public bool? @isB2BModified   { get; set; }
        ///<summary> 
        /// 可否使用積分 
        /// </summary> 
        [Column("canBuyByIntegral")] 
        public bool? @canBuyByIntegral   { get; set; }
        ///<summary> 
        /// 富購合約編號 
        /// </summary> 
        [Column("fugoContractNo")] 
        [MaxLength(50)] 
        public string? @fugoContractNo   { get; set; }
        ///<summary> 
        /// 更新商品時記錄來自暫存區品號表SalesMixApplication.id 
        /// </summary> 
        [Column("updFromSMA_id")] 
        public long? @updFromSMA_id   { get; set; }
        ///<summary> 
        /// 銷售副標文字 
        /// </summary> 
        [Column("SalesSubtitle")] 
        [MaxLength(510)] 
        public string? @SalesSubtitle   { get; set; }
        ///<summary> 
        /// 商品年齡分級(E: Everyone 一般商品, 每個人都可購買,A: Adult 成人商品 ) 
        /// </summary> 
        [Column("ageRating")] 
        [MaxLength(2)] 
        public string @ageRating   { get; set; }
        ///<summary> 
        /// 是否可使用富購折價券 
        /// </summary> 
        [Column("isfugoCouponUsable")] 
        public bool @isfugoCouponUsable   { get; set; }
        ///<summary> 
        /// 富購國內外旅遊商品, 所使用的旅遊商品使用期限(可不填寫) 
        /// </summary> 
        [Column("expirationDate")] 
        public DateTime? @expirationDate   { get; set; }
        ///<summary> 
        /// 1001 一般商品 1002 低溫冷藏 1003 吊掛商品 1004 旅遊商品 1005 國內旅遊 1006 國外旅遊 1007 贈品 1008 汽機車商品 1011 低溫冷凍 
        /// </summary> 
        [Column("fugoItemType")] 
        [MaxLength(4)] 
        public string? @fugoItemType   { get; set; }
        ///<summary> 
        /// 商品是否開放語音系統接單屬性, 一般商品預設為可, 任選商品預設為不可語音接單 
        /// </summary> 
        [Column("fugoIvrOrder")] 
        public bool @fugoIvrOrder   { get; set; }
        ///<summary> 
        /// 商品是否開放電行人員接單屬性, 一般商品預設為可, 任選商品設為不可透過電行接單 
        /// </summary> 
        [Column("fugoAgentOrder")] 
        public bool @fugoAgentOrder   { get; set; }
        ///<summary> 
        /// 第一次上架時間 
        /// </summary> 
        [Column("firstSaleTime")] 
        public DateTime? @firstSaleTime   { get; set; }
        ///<summary> 
        /// 最近修改日期 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime? @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 快速到貨 (0, 1) 
        /// </summary> 
        [Column("isExpressProduct")] 
        public bool @isExpressProduct   { get; set; }
        ///<summary> 
        /// 是否為可海外訂購之商品 
        /// </summary> 
        [Column("isInternationalShipping")] 
        public bool @isInternationalShipping   { get; set; }
        ///<summary> 
        /// 折扣金/回饋金折抵上限 (已停用) 
        /// </summary> 
        [Column("shoppingPointUpperBound")] 
        public decimal @shoppingPointUpperBound   { get; set; }
        ///<summary> 
        /// 商品頁屬性設定： 0=不顯示折價券及小幫手, 1=顯示折價券及小幫手 
        /// </summary> 
        [Column("showSaleTipIcon")] 
        public int @showSaleTipIcon   { get; set; }
        ///<summary> 
        /// 行銷活動, 0:無(表示無設定行銷屬性) 1:集購 2:好康 3:1點抵1元 4:(前台自訂排除)  5:(前台自訂:ESH限定商品) 6:全家合作 
        /// </summary> 
        [Column("marketingProperty")] 
        public int @marketingProperty   { get; set; }
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
        /// 備註(fugo:WEBPRODUCTDESC) 
        /// </summary> 
        [Column("note")] 
        public string? @note   { get; set; }
        ///<summary> 
        /// 上架時間(tb_prodicts_forbw_temp.onboard_date) 
        /// </summary> 
        [Column("onShelf")] 
        public DateTime? @onShelf   { get; set; }
        ///<summary> 
        /// 下架時間(tb_prodicts_forbw_temp.enddatetime) 
        /// </summary> 
        [Column("offShelf")] 
        public DateTime? @offShelf   { get; set; }
        ///<summary> 
        /// 紙箱編號 
        /// </summary> 
        [Column("boxNo")] 
        public short? @boxNo   { get; set; }
        ///<summary> 
        /// 包裝方式: 1001 制式紙箱, 1002 裸品, 1003 木箱, 1004 鐵箱, 1005 原箱包裝 
        /// </summary> 
        [Column("packType")] 
        public short? @packType   { get; set; }
        ///<summary> 
        /// 預購商品(1=是; 0=否) 
        /// </summary> 
        [Column("isPreorder")] 
        public byte? @isPreorder   { get; set; }
        ///<summary> 
        /// 預計出貨日 
        /// </summary> 
        [Column("preorderShipDate")] 
        public DateTime? @preorderShipDate   { get; set; }
        ///<summary> 
        /// 訂單成立後?天出貨 
        /// </summary> 
        [Column("preorderShipDays")] 
        public int? @preorderShipDays   { get; set; }
        ///<summary> 
        /// FUGO建立商品的時間 
        /// </summary> 
        [Column("fugoCreatedDate")] 
        public DateTime? @fugoCreatedDate   { get; set; }
        ///<summary> 
        /// 0否 , 1是 (對應富購airlimit，意義相反要注意) 
        /// </summary> 
        [Column("isAirlift")] 
        public byte? @isAirlift   { get; set; }
        ///<summary> 
        /// 保留 
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
        /// 1為U-mall, 2為Etmall, 3為EU 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 保留 
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
        /// =E.SalesMix.fugoProductID 
        /// </summary> 
        [Column("fugoProductID2")] 
        [MaxLength(60)] 
        public string? @fugoProductID2   { get; set; }
        ///<summary> 
        /// =E.SalesMix.fugoMultiSaleNo 
        /// </summary> 
        [Column("fugoMultiSaleNo2")] 
        public int? @fugoMultiSaleNo2   { get; set; }
        ///<summary> 
        /// =E.SalesMix.salePriceTaxType 
        /// </summary> 
        [Column("salePriceTaxType2")] 
        [MaxLength(60)] 
        public string? @salePriceTaxType2   { get; set; }
        ///<summary> 
        /// =E.SalesMix.salePriceTax 
        /// </summary> 
        [Column("salePriceTax2")] 
        public decimal? @salePriceTax2   { get; set; }
        ///<summary> 
        /// =E.SalesMix.grossProfitNoTax 
        /// </summary> 
        [Column("grossProfitNoTax2")] 
        public decimal? @grossProfitNoTax2   { get; set; }
        ///<summary> 
        /// =E.SalesMix.grossMarginNoTax 
        /// </summary> 
        [Column("grossMarginNoTax2")] 
        public decimal? @grossMarginNoTax2   { get; set; }
        ///<summary> 
        /// =E.SalesMix.isPreorder 
        /// </summary> 
        [Column("isPreorder2")] 
        public byte? @isPreorder2   { get; set; }
        ///<summary> 
        /// =E.SalesMix.preorderShipDate 
        /// </summary> 
        [Column("preorderShipDate2")] 
        public DateTime? @preorderShipDate2   { get; set; }
        ///<summary> 
        /// E快速到貨 (0, 1) =E.SalesMix.isExpressProduct 
        /// </summary> 
        [Column("isExpressProduct2")] 
        public bool? @isExpressProduct2   { get; set; }
        ///<summary> 
        /// 網路操作 eType in (1,7,9,10) 電視操作 eType in (2,4,5,8) 1:網路商品 2:電視商品 4:型錄商品 5:OB商品 7:兌點商品 8:IB商品 9:藥妝店 10:電子票券(詳細請參考:PhraseLibrary.groupName = 'eType') 
        /// </summary> 
        [Column("eType")] 
        public byte? @eType   { get; set; }
        ///<summary> 
        /// UI是否可體驗(勾了就會填不可體驗的文字) 
        /// </summary> 
        [Column("experienceweb")] 
        [MaxLength(800)] 
        public string? @experienceweb   { get; set; }
        ///<summary> 
        /// 特約文件:1001 索取戒圍卡,1002 索取手圍卡,1003 索取戒圍卡+手圍卡,0000 不寄送,NULL  非特約商品此欄未啟用 
        /// </summary> 
        [Column("docType")] 
        [MaxLength(4)] 
        public string? @docType   { get; set; }
        ///<summary> 
        /// 複製來源網編 
        /// </summary> 
        [Column("formerSaleCode")] 
        [MaxLength(200)] 
        public string? @formerSaleCode   { get; set; }
        ///<summary> 
        /// Y=網路, 行動, 兌點；N=電視, OB, IB, ECTV；C=型錄；D=直播商品(電視提報) 
        /// </summary> 
        [Column("CWProduct")] 
        [MaxLength(1)] 
        public string? @CWProduct   { get; set; }
        ///<summary> 
        /// =..= 
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
        /// 裸長 
        /// </summary> 
        [Column("nakedLength")] 
        public decimal? @nakedLength   { get; set; }
        ///<summary> 
        /// 裸寬 
        /// </summary> 
        [Column("nakedWidth")] 
        public decimal? @nakedWidth   { get; set; }
        ///<summary> 
        /// 裸高 
        /// </summary> 
        [Column("nakedHeight")] 
        public decimal? @nakedHeight   { get; set; }
        ///<summary> 
        /// 裸重 
        /// </summary> 
        [Column("nakedWeight")] 
        public decimal? @nakedWeight   { get; set; }
        ///<summary> 
        /// 1001	新品類 1002	新品 1003	舊品重組 1004	關渡商品 1005	ECTV 1006	包檔商品 1007	珠寶專案商品 1008	墨攻商品 1009	年菜親取 1010	分次配送 1011	東源宅配 1012	東森超值券 1013	聯強 1014	醫美電子票券 1022	草莓網商品 
        /// </summary> 
        [Column("productType")] 
        public int? @productType   { get; set; }
        ///<summary> 
        /// 醫療器材 
        /// </summary> 
        [Column("mediFactor")] 
        public byte? @mediFactor   { get; set; }
        ///<summary> 
        /// 18歲限制商品 
        /// </summary> 
        [Column("violetFactor")] 
        public byte? @violetFactor   { get; set; }
        ///<summary> 
        /// 保存期限 
        /// </summary> 
        [Column("keepFactor")] 
        public int? @keepFactor   { get; set; }
        ///<summary> 
        /// 保存期限單位(日,月,季,年) 
        /// </summary> 
        [Column("keepUnit")] 
        [MaxLength(10)] 
        public string? @keepUnit   { get; set; }
        ///<summary> 
        /// 品牌 
        /// </summary> 
        [Column("brandFactor")] 
        public int? @brandFactor   { get; set; }
        ///<summary> 
        /// 開賣日期(tb_prodicts_forbw_temp.canbuytime) 
        /// </summary> 
        [Column("actualShelf")] 
        public DateTime? @actualShelf   { get; set; }
        ///<summary> 
        /// =backendcategory.shoppingPointUpperBound=etmallet1.dbo.tb_products.discountable 
        /// </summary> 
        [Column("CanUseDiscount")] 
        public bool? @CanUseDiscount   { get; set; }
        ///<summary> 
        /// 是否要做信託(墨攻) 
        /// </summary> 
        [Column("needsTrust")] 
        [MaxLength(1)] 
        public string? @needsTrust   { get; set; }
        ///<summary> 
        /// 無量通路恢復有量 U:1,E:2,EU:3 
        /// </summary> 
        [Column("tozero_restore")] 
        public byte? @tozero_restore   { get; set; }
        ///<summary> 
        /// 商品是否可在B2C搜尋(0: 可，1: 不可) 
        /// </summary> 
        [Column("noFollow")] 
        public bool @noFollow   { get; set; }
        ///<summary> 
        /// 系統來源 1-> b2b web,2-> b2b api,3-> b2b excel 
        /// </summary> 
        [Column("sys_source")] 
        public byte? @sys_source   { get; set; }
        ///<summary> 
        /// 東源宅安的富購分類細規格 
        /// </summary> 
        [Column("detailSpecID")] 
        public int? @detailSpecID   { get; set; }
        ///<summary> 
        /// 東森幣取得匯率 
        /// </summary> 
        [Column("getEHSDRate")] 
        public decimal? @getEHSDRate   { get; set; }
        ///<summary> 
        /// 可取得的東森幣 
        /// </summary> 
        [Column("getEHSDValue")] 
        public int? @getEHSDValue   { get; set; }
        ///<summary> 
        /// 東森幣使用上限比率 
        /// </summary> 
        [Column("useEHSDRate")] 
        public decimal? @useEHSDRate   { get; set; }
        ///<summary> 
        /// 可折抵的東森幣上限 
        /// </summary> 
        [Column("useEHSDValue")] 
        public int? @useEHSDValue   { get; set; }
        ///<summary> 
        /// 不提供給google搜尋的商品(票券/交通工具/監視器...等) 
        /// </summary> 
        [Column("GSAExclude")] 
        public bool @GSAExclude   { get; set; }
        ///<summary> 
        /// [Flag] 使用特殊價格(1: 啟用員工價, 2: 啟用福委價,3:全部啟用) 
        /// </summary> 
        [Column("useSpecialPrice")] 
        public byte @useSpecialPrice   { get; set; }
        ///<summary> 
        /// 商品Flag設定-(0: 未設定, 1: 易碎品 ;2:直播; 上限設定為255) 
        /// </summary> 
        [Column("ProductFlag")] 
        public int @ProductFlag   { get; set; }
}
}
