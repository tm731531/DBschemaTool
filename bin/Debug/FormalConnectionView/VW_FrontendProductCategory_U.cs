using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_FrontendProductCategory_U
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("type")] 
        public bool @type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(100)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seqNo")] 
        public long @seqNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("parentCategoryId")] 
        public long @parentCategoryId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isLastLevel")] 
        public bool @isLastLevel   { get; set; }
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
        [MaxLength(60)] 
        public string @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("creator_User")] 
        public long? @creator_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("minAcount")] 
        public int? @minAcount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("minSum")] 
        public decimal? @minSum   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("product_planning_staff_User")] 
        public long? @product_planning_staff_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("business_director_User")] 
        public long? @business_director_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("business_delegate_User")] 
        public long? @business_delegate_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm1")] 
        [MaxLength(60)] 
        public string? @sortTerm1   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm2")] 
        [MaxLength(60)] 
        public string? @sortTerm2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm3")] 
        [MaxLength(60)] 
        public string? @sortTerm3   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm4")] 
        [MaxLength(60)] 
        public string? @sortTerm4   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sortTerm5")] 
        [MaxLength(60)] 
        public string? @sortTerm5   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("defaultAdvertisementPicture")] 
        [MaxLength(200)] 
        public string? @defaultAdvertisementPicture   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("defaultShopPicture")] 
        [MaxLength(200)] 
        public string? @defaultShopPicture   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shopCss")] 
        [MaxLength(40)] 
        public string? @shopCss   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("keywords")] 
        [MaxLength(100)] 
        public string? @keywords   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shortDescription")] 
        [MaxLength(1400)] 
        public string? @shortDescription   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryType")] 
        public int? @categoryType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryLink")] 
        [MaxLength(500)] 
        public string? @categoryLink   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_ProductProperty")] 
        public long? @id_ProductProperty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePriceCap")] 
        public decimal? @salePriceCap   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePriceFloor")] 
        public decimal? @salePriceFloor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("searchKeywords")] 
        [MaxLength(100)] 
        public string? @searchKeywords   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdatedAccountName_User")] 
        [MaxLength(256)] 
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
        [MaxLength(500)] 
        public string? @categoryStruct   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryRoot")] 
        [MaxLength(500)] 
        public string? @categoryRoot   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryFirst")] 
        [MaxLength(500)] 
        public string? @categoryFirst   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categorySecond")] 
        [MaxLength(500)] 
        public string? @categorySecond   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryThird")] 
        [MaxLength(500)] 
        public string? @categoryThird   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryAgeRating")] 
        [MaxLength(2)] 
        public string @categoryAgeRating   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ver")] 
        public int @ver   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("columnLength")] 
        public int @columnLength   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CategoryPlate")] 
        public int @CategoryPlate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CategoryPlate_sub")] 
        public int @CategoryPlate_sub   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductRowCount")] 
        public int @ProductRowCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productCount")] 
        public int? @productCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryLink_mweb")] 
        [MaxLength(500)] 
        public string? @categoryLink_mweb   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryLink_app")] 
        [MaxLength(500)] 
        public string? @categoryLink_app   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hotFlag")] 
        public byte? @hotFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("mediFlag")] 
        public bool? @mediFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("violetFlag")] 
        public bool? @violetFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("keepFlag")] 
        public bool? @keepFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("brandFlag")] 
        public bool? @brandFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hideFlag")] 
        public bool? @hideFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hideToEntrance")] 
        public bool? @hideToEntrance   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hideToSearchEnging")] 
        public bool? @hideToSearchEnging   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("adultFlag")] 
        public bool? @adultFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EANCodeFlag")] 
        public bool? @EANCodeFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("iconPath")] 
        [MaxLength(4000)] 
        public string? @iconPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shortName")] 
        [MaxLength(20)] 
        public string? @shortName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GoogleProductCategory")] 
        public int? @GoogleProductCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareBoarder")] 
        public decimal? @EShareBoarder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareRatio")] 
        public decimal? @EShareRatio   { get; set; }
}
}
