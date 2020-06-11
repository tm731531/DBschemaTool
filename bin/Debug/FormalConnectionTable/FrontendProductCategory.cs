using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FrontendProductCategory
{
        ///<summary> 
        /// pk 
        /// </summary> 
        [Column("seq")] 
        public long @seq   { get; set; }
        ///<summary> 
        /// 平台唯一Id(在platform有條件時，是唯一值。如platform=1) 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 0:一般商品.1:任選商品 
        /// </summary> 
        [Column("type")] 
        public bool @type   { get; set; }
        ///<summary> 
        /// 名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(100)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 順序 
        /// </summary> 
        [Column("seqNo")] 
        public long @seqNo   { get; set; }
        ///<summary> 
        /// 父類別Id 
        /// </summary> 
        [Column("parentCategoryId")] 
        public long @parentCategoryId   { get; set; }
        ///<summary> 
        /// 是否為最後一層分類 
        /// </summary> 
        [Column("isLastLevel")] 
        public bool @isLastLevel   { get; set; }
        ///<summary> 
        /// 上架時間(新增或異動時需為當下時刻+20分) 
        /// </summary> 
        [Column("onlineTime")] 
        public DateTime? @onlineTime   { get; set; }
        ///<summary> 
        /// 下架時間(新增或異動時不可小於下架時間及過去) 
        /// </summary> 
        [Column("offlineTime")] 
        public DateTime? @offlineTime   { get; set; }
        ///<summary> 
        /// 狀態：上架中 已刪除 未上架 0 
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
        /// 最低件數 
        /// </summary> 
        [Column("minAcount")] 
        public int? @minAcount   { get; set; }
        ///<summary> 
        /// 最低金額 
        /// </summary> 
        [Column("minSum")] 
        public decimal? @minSum   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 分類所屬商品企劃 
        /// </summary> 
        [Column("product_planning_staff_User")] 
        public long? @product_planning_staff_User   { get; set; }
        ///<summary> 
        /// 分類所屬營業主管 
        /// </summary> 
        [Column("business_director_User")] 
        public long? @business_director_User   { get; set; }
        ///<summary> 
        /// 分類所屬業務代表 
        /// </summary> 
        [Column("business_delegate_User")] 
        public long? @business_delegate_User   { get; set; }
        ///<summary> 
        /// GD=新品至舊品,D=價格高至低,A=價格低至高,SD=暢銷指數高至低 
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
        /// 分類預設圖片 
        /// </summary> 
        [Column("defaultAdvertisementPicture")] 
        [MaxLength(200)] 
        public string? @defaultAdvertisementPicture   { get; set; }
        ///<summary> 
        /// 商品館小圖示 
        /// </summary> 
        [Column("defaultShopPicture")] 
        [MaxLength(200)] 
        public string? @defaultShopPicture   { get; set; }
        ///<summary> 
        /// 商品館Css圖檔 
        /// </summary> 
        [Column("shopCss")] 
        [MaxLength(40)] 
        public string? @shopCss   { get; set; }
        ///<summary> 
        /// 關鍵字 
        /// </summary> 
        [Column("keywords")] 
        [MaxLength(100)] 
        public string? @keywords   { get; set; }
        ///<summary> 
        /// 短敘述 
        /// </summary> 
        [Column("shortDescription")] 
        [MaxLength(1400)] 
        public string? @shortDescription   { get; set; }
        ///<summary> 
        /// 1商品分類；2推薦品牌 (U只用在大分類 E用在區分版面的上下位置, 此欄位跟任選設定無關) 
        /// </summary> 
        [Column("categoryType")] 
        public int? @categoryType   { get; set; }
        ///<summary> 
        /// 前臺分類連結網址 
        /// </summary> 
        [Column("categoryLink")] 
        [MaxLength(500)] 
        public string? @categoryLink   { get; set; }
        ///<summary> 
        /// 商品屬性編號 外鍵 (LAB 資料不多) 
        /// </summary> 
        [Column("id_ProductProperty")] 
        public long? @id_ProductProperty   { get; set; }
        ///<summary> 
        /// 價格上限 
        /// </summary> 
        [Column("salePriceCap")] 
        public decimal? @salePriceCap   { get; set; }
        ///<summary> 
        /// 價格下限 
        /// </summary> 
        [Column("salePriceFloor")] 
        public decimal? @salePriceFloor   { get; set; }
        ///<summary> 
        /// 搜尋關鍵字 
        /// </summary> 
        [Column("searchKeywords")] 
        [MaxLength(100)] 
        public string? @searchKeywords   { get; set; }
        ///<summary> 
        /// 最後修改此前台分類的使用者 
        /// </summary> 
        [Column("lastUpdatedAccountName_User")] 
        [MaxLength(256)] 
        public string? @lastUpdatedAccountName_User   { get; set; }
        ///<summary> 
        /// 最後修改此前台分類的時間 
        /// </summary> 
        [Column("lastUpdatedTime")] 
        public DateTime? @lastUpdatedTime   { get; set; }
        ///<summary> 
        /// 前臺分類結構，(?-?-?-?)格式 
        /// </summary> 
        [Column("categoryStruct")] 
        [MaxLength(500)] 
        public string? @categoryStruct   { get; set; }
        ///<summary> 
        /// 前臺分類結構-根結點 (單一數字) 
        /// </summary> 
        [Column("categoryRoot")] 
        [MaxLength(500)] 
        public string? @categoryRoot   { get; set; }
        ///<summary> 
        /// 前台分類-大分類 (單一數字) 
        /// </summary> 
        [Column("categoryFirst")] 
        [MaxLength(500)] 
        public string? @categoryFirst   { get; set; }
        ///<summary> 
        /// 前台分類-中分類 (單一數字) 
        /// </summary> 
        [Column("categorySecond")] 
        [MaxLength(500)] 
        public string? @categorySecond   { get; set; }
        ///<summary> 
        /// 前台分類-小分類 (單一數字) 
        /// </summary> 
        [Column("categoryThird")] 
        [MaxLength(500)] 
        public string? @categoryThird   { get; set; }
        ///<summary> 
        /// 商品分類年齡分級(E: Everyone 一般商品, 每個人都可購買,A: Adult 成人商品 ) 
        /// </summary> 
        [Column("categoryAgeRating")] 
        [MaxLength(2)] 
        public string @categoryAgeRating   { get; set; }
        ///<summary> 
        /// 資料版本 
        /// </summary> 
        [Column("ver")] 
        public int @ver   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("columnLength")] 
        public int @columnLength   { get; set; }
        ///<summary> 
        /// 館頁LandingPage版型0=舊館, 1=品牌旗艦館, 2=一般館 
        /// </summary> 
        [Column("CategoryPlate")] 
        public int @CategoryPlate   { get; set; }
        ///<summary> 
        /// 大分類版型 1.品牌旗艦(繼承) 2.商品分類 3.推薦品牌 
        /// </summary> 
        [Column("CategoryPlate_sub")] 
        public int @CategoryPlate_sub   { get; set; }
        ///<summary> 
        /// 商品列表數：0=0品, 1=5品一排, 2=10品2排, 3=15品3排, 4=20品4排, 5=25品5排, 6=30品6排, 7=35品7排, 8=40品8排 
        /// </summary> 
        [Column("ProductRowCount")] 
        public int @ProductRowCount   { get; set; }
        ///<summary> 
        /// 商品數量 
        /// </summary> 
        [Column("productCount")] 
        public int? @productCount   { get; set; }
        ///<summary> 
        /// 1:U 2:E 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 小網連結 
        /// </summary> 
        [Column("categoryLink_mweb")] 
        [MaxLength(500)] 
        public string? @categoryLink_mweb   { get; set; }
        ///<summary> 
        /// APP連結 
        /// </summary> 
        [Column("categoryLink_app")] 
        [MaxLength(500)] 
        public string? @categoryLink_app   { get; set; }
        ///<summary> 
        /// 強調顯示 0:不啟用 1:款式1 2:款式2 3:款式3 
        /// </summary> 
        [Column("hotFlag")] 
        public byte? @hotFlag   { get; set; }
        ///<summary> 
        /// 醫療器材 
        /// </summary> 
        [Column("mediFlag")] 
        public bool? @mediFlag   { get; set; }
        ///<summary> 
        /// 18歲限制商品(ex:小說, PS電玩) 
        /// </summary> 
        [Column("violetFlag")] 
        public bool? @violetFlag   { get; set; }
        ///<summary> 
        /// 保存期限 
        /// </summary> 
        [Column("keepFlag")] 
        public bool? @keepFlag   { get; set; }
        ///<summary> 
        /// 品牌設定 
        /// </summary> 
        [Column("brandFlag")] 
        public bool? @brandFlag   { get; set; }
        ///<summary> 
        /// 隱藏分類 
        /// </summary> 
        [Column("hideFlag")] 
        public bool? @hideFlag   { get; set; }
        ///<summary> 
        /// 提供專區入口 
        /// </summary> 
        [Column("hideToEntrance")] 
        public bool? @hideToEntrance   { get; set; }
        ///<summary> 
        /// 商品從搜尋引擎剔除 
        /// </summary> 
        [Column("hideToSearchEnging")] 
        public bool? @hideToSearchEnging   { get; set; }
        ///<summary> 
        /// 18禁(成人商品) 
        /// </summary> 
        [Column("adultFlag")] 
        public bool? @adultFlag   { get; set; }
        ///<summary> 
        /// 國際條碼 
        /// </summary> 
        [Column("EANCodeFlag")] 
        public bool? @EANCodeFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("iconPath")] 
        [MaxLength(100)] 
        public string? @iconPath   { get; set; }
        ///<summary> 
        /// APP分類名稱 
        /// </summary> 
        [Column("shortName")] 
        [MaxLength(20)] 
        public string? @shortName   { get; set; }
        ///<summary> 
        /// Google分析對應編號 
        /// </summary> 
        [Column("GoogleProductCategory")] 
        public int? @GoogleProductCategory   { get; set; }
        ///<summary> 
        /// 可使用之規格表ID 
        /// </summary> 
        [Column("FormIDs")] 
        [MaxLength(200)] 
        public string? @FormIDs   { get; set; }
        ///<summary> 
        /// 東宇分潤門檻 
        /// </summary> 
        [Column("EShareBoarder")] 
        public decimal? @EShareBoarder   { get; set; }
        ///<summary> 
        /// 東宇的分潤比例 
        /// </summary> 
        [Column("EShareRatio")] 
        public decimal? @EShareRatio   { get; set; }
        ///<summary> 
        /// 網頁標籤 
        /// </summary> 
        [Column("PageTitle")] 
        [MaxLength(400)] 
        public string? @PageTitle   { get; set; }
        ///<summary> 
        /// 商品註解顯示文案類型 1:醫療, 2:廢四機回收, 4:食品, 8:歡樂旅行社股份有限公司(此為複選 ex: 1+2 欄位值會儲存為3) 
        /// </summary> 
        [Column("DeclareTextType")] 
        public byte? @DeclareTextType   { get; set; }
        ///<summary> 
        /// 是否不做GSA(Google Search Analytics) 
        /// </summary> 
        [Column("GSAExclude")] 
        public bool @GSAExclude   { get; set; }
}
}
