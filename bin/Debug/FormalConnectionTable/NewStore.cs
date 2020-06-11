using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class NewStore
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seq")] 
        public double? @seq   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public double? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("type")] 
        public double? @type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(255)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seqNo")] 
        public double? @seqNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("parentCategoryId")] 
        public double? @parentCategoryId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isLastLevel")] 
        public double? @isLastLevel   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("onlineTime")] 
        public DateTime? @onlineTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("offlineTime")] 
        public DateTime? @offlineTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("status")] 
        [MaxLength(255)] 
        public string? @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("creator_User")] 
        public double? @creator_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("minAcount")] 
        [MaxLength(255)] 
        public string? @minAcount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("minSum")] 
        [MaxLength(255)] 
        public string? @minSum   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdated")] 
        [MaxLength(255)] 
        public string? @lastUpdated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("product_planning_staff_User")] 
        public double? @product_planning_staff_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("business_director_User")] 
        public double? @business_director_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("business_delegate_User")] 
        public double? @business_delegate_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm1")] 
        [MaxLength(255)] 
        public string? @sortTerm1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm2")] 
        public double? @sortTerm2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm3")] 
        public double? @sortTerm3   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm4")] 
        public double? @sortTerm4   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm5")] 
        public double? @sortTerm5   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("defaultAdvertisementPicture")] 
        [MaxLength(255)] 
        public string? @defaultAdvertisementPicture   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("defaultShopPicture")] 
        [MaxLength(255)] 
        public string? @defaultShopPicture   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shopCss")] 
        [MaxLength(255)] 
        public string? @shopCss   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("keywords")] 
        [MaxLength(255)] 
        public string? @keywords   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shortDescription")] 
        [MaxLength(255)] 
        public string? @shortDescription   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryType")] 
        public double? @categoryType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryLink")] 
        [MaxLength(255)] 
        public string? @categoryLink   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_ProductProperty")] 
        public double? @id_ProductProperty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePriceCap")] 
        public double? @salePriceCap   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePriceFloor")] 
        public double? @salePriceFloor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("searchKeywords")] 
        [MaxLength(255)] 
        public string? @searchKeywords   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdatedAccountName_User")] 
        [MaxLength(255)] 
        public string? @lastUpdatedAccountName_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdatedTime")] 
        public DateTime? @lastUpdatedTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryStruct")] 
        [MaxLength(255)] 
        public string? @categoryStruct   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryRoot")] 
        public double? @categoryRoot   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryFirst")] 
        public double? @categoryFirst   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categorySecond")] 
        public double? @categorySecond   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryThird")] 
        public double? @categoryThird   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryAgeRating")] 
        [MaxLength(255)] 
        public string? @categoryAgeRating   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ver")] 
        public double? @ver   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("columnLength")] 
        public double? @columnLength   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CategoryPlate")] 
        public double? @CategoryPlate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CategoryPlate_sub")] 
        public double? @CategoryPlate_sub   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductRowCount")] 
        public double? @ProductRowCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productCount")] 
        public double? @productCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public double? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        [MaxLength(255)] 
        public string? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryLink_mweb")] 
        [MaxLength(255)] 
        public string? @categoryLink_mweb   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryLink_app")] 
        [MaxLength(255)] 
        public string? @categoryLink_app   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hotFlag")] 
        public double? @hotFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("mediFlag")] 
        public double? @mediFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("violetFlag")] 
        public double? @violetFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("keepFlag")] 
        public double? @keepFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("brandFlag")] 
        public double? @brandFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hideFlag")] 
        public double? @hideFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hideToEntrance")] 
        public double? @hideToEntrance   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hideToSearchEnging")] 
        public double? @hideToSearchEnging   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("adultFlag")] 
        [MaxLength(255)] 
        public string? @adultFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EANCodeFlag")] 
        public double? @EANCodeFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("iconPath")] 
        [MaxLength(255)] 
        public string? @iconPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shortName")] 
        [MaxLength(255)] 
        public string? @shortName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GoogleProductCategory")] 
        [MaxLength(255)] 
        public string? @GoogleProductCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FormIDs")] 
        [MaxLength(255)] 
        public string? @FormIDs   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareBoarder")] 
        [MaxLength(255)] 
        public string? @EShareBoarder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareRatio")] 
        [MaxLength(255)] 
        public string? @EShareRatio   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("pageTitle")] 
        [MaxLength(255)] 
        public string? @pageTitle   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DeclareTextType")] 
        public double? @DeclareTextType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GSAExclude")] 
        public double? @GSAExclude   { get; set; }
}
}
