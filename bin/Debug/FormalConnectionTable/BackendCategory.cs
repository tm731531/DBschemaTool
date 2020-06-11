using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BackendCategory
{
        ///<summary> 
        /// 後臺商品分類代碼 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 父目錄Id 關聯到本裱中的id 
        /// </summary> 
        [Column("parentCategoryId")] 
        public long @parentCategoryId   { get; set; }
        ///<summary> 
        /// ONE： 大類  TWO： 中類 THREE： 小類 
        /// </summary> 
        [Column("rank")] 
        [MaxLength(20)] 
        public string? @rank   { get; set; }
        ///<summary> 
        /// 類別名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(510)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 類別圖片位址 
        /// </summary> 
        [Column("defaultPicturePath")] 
        [MaxLength(510)] 
        public string? @defaultPicturePath   { get; set; }
        ///<summary> 
        /// 商開(作廢)(改看BackendCategory_Authority.AuthorityType=0) 
        /// </summary> 
        [Column("product_Development_staff")] 
        public long? @product_Development_staff   { get; set; }
        ///<summary> 
        /// 商企(作廢)(改看BackendCategory_Authority.AuthorityType=3) 
        /// </summary> 
        [Column("product_Planning_staff")] 
        public long? @product_Planning_staff   { get; set; }
        ///<summary> 
        /// 營業主管(作廢)(改看BackendCategory_Authority.AuthorityType=1) 
        /// </summary> 
        [Column("business_Director")] 
        public long? @business_Director   { get; set; }
        ///<summary> 
        /// 行企主管(作廢) 
        /// </summary> 
        [Column("marketing_Planning_Director")] 
        public long? @marketing_Planning_Director   { get; set; }
        ///<summary> 
        /// 後臺分類順序 
        /// </summary> 
        [Column("categoryOrder")] 
        public int? @categoryOrder   { get; set; }
        ///<summary> 
        /// 狀態標示：0，未刪除，1，已刪除 
        /// </summary> 
        [Column("status")] 
        public long @status   { get; set; }
        ///<summary> 
        /// 紅利折抵上限 
        /// </summary> 
        [Column("bonusLimitRate")] 
        public decimal? @bonusLimitRate   { get; set; }
        ///<summary> 
        /// 稅率 
        /// </summary> 
        [Column("taxRate")] 
        public decimal? @taxRate   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 稅率種類：0內含，1外加，2免稅 
        /// </summary> 
        [Column("taxType")] 
        [MaxLength(2)] 
        public string? @taxType   { get; set; }
        ///<summary> 
        /// 退換貨天數 
        /// </summary> 
        [Column("appreciationPeriod")] 
        public int? @appreciationPeriod   { get; set; }
        ///<summary> 
        /// 參照（六碼數字） 
        /// </summary> 
        [Column("referenceNumber")] 
        [MaxLength(20)] 
        public string? @referenceNumber   { get; set; }
        ///<summary> 
        /// 備註：富購建立人員 
        /// </summary> 
        [Column("remark")] 
        public long? @remark   { get; set; }
        ///<summary> 
        /// 毛利率限制 
        /// </summary> 
        [Column("grossProfit")] 
        public decimal? @grossProfit   { get; set; }
        ///<summary> 
        /// 毛利額限制 
        /// </summary> 
        [Column("grossMargin")] 
        public decimal? @grossMargin   { get; set; }
        ///<summary> 
        /// 是否可使用富購折價券 
        /// </summary> 
        [Column("isfugoCouponUsable")] 
        public bool @isfugoCouponUsable   { get; set; }
        ///<summary> 
        /// 是否套用分期限制規則 
        /// </summary> 
        [Column("hasInstallmentConstraint")] 
        public bool @hasInstallmentConstraint   { get; set; }
        ///<summary> 
        /// 商品行政(U_MA)user.fugoEmployeeNo 
        /// </summary> 
        [Column("productAdmin")] 
        [MaxLength(40)] 
        public string? @productAdmin   { get; set; }
        ///<summary> 
        /// 是否可以使用折扣金(0:不可用,1:可用) 
        /// </summary> 
        [Column("shoppingPointUpperBound")] 
        public decimal @shoppingPointUpperBound   { get; set; }
        ///<summary> 
        /// 商品行政(E_MA)user.fugoEmployeeNo 
        /// </summary> 
        [Column("productAdmin2")] 
        [MaxLength(40)] 
        public string? @productAdmin2   { get; set; }
        ///<summary> 
        /// 電視毛利率限制(含型錄, IB/OB) 
        /// </summary> 
        [Column("grossProfitTV")] 
        public decimal? @grossProfitTV   { get; set; }
        ///<summary> 
        /// 電視毛利額限制(含型錄, IB/OB) 
        /// </summary> 
        [Column("grossMarginTV")] 
        public decimal? @grossMarginTV   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossProfitTVS")] 
        public decimal? @grossProfitTVS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossMarginTVS")] 
        public decimal? @grossMarginTVS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("limiteGrossProfit")] 
        public decimal? @limiteGrossProfit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("limiteStockQty")] 
        public int? @limiteStockQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("upperLimitStockQty")] 
        public int? @upperLimitStockQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CanUseDiscount")] 
        public bool? @CanUseDiscount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FormIDs")] 
        [MaxLength(200)] 
        public string? @FormIDs   { get; set; }
}
}
