using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ShopeeProduct
{
        ///<summary> 
        /// 商品ID 
        /// </summary> 
        [Column("ItemId")] 
        public long @ItemId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string @FugoSaleNo   { get; set; }
        ///<summary> 
        /// Shopee's unique identifier for a shop. 
        /// </summary> 
        [Column("ShopId")] 
        public long @ShopId   { get; set; }
        ///<summary> 
        /// An item SKU (stock keeping unit) is an identifier defined by a seller, sometimes called parent SKU. Item SKU can be assigned to an item in Shopee Listings. 
        /// </summary> 
        [Column("ItemSku")] 
        [MaxLength(60)] 
        public string? @ItemSku   { get; set; }
        ///<summary> 
        /// Enumerated type that defines the current status of the item. Applicable values: NORMAL, DELETED, UNLIST and BANNED. 
        /// </summary> 
        [Column("Status")] 
        [MaxLength(20)] 
        public string? @Status   { get; set; }
        ///<summary> 
        /// Name of the item in local language. 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(510)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// Description of the item in local language. 
        /// </summary> 
        [Column("Description")] 
        public string @Description   { get; set; }
        ///<summary> 
        /// The three-digit code representing the currency unit used for the item in Shopee Listings. 
        /// </summary> 
        [Column("Currency")] 
        [MaxLength(20)] 
        public string? @Currency   { get; set; }
        ///<summary> 
        /// This is to indicate whether the item has variation(s). 
        /// </summary> 
        [Column("HasVariation")] 
        public byte? @HasVariation   { get; set; }
        ///<summary> 
        /// The current price of the item in the listing currency.If item is in promotion, this value is discount price. 
        /// </summary> 
        [Column("Price")] 
        public decimal @Price   { get; set; }
        ///<summary> 
        /// The current stock quantity of the item. 
        /// </summary> 
        [Column("Stock")] 
        public int? @Stock   { get; set; }
        ///<summary> 
        /// Timestamp that indicates the date and time that the item was created. 
        /// </summary> 
        [Column("CreateTime")] 
        public int? @CreateTime   { get; set; }
        ///<summary> 
        /// Timestamp that indicates the last time that there was a change in value of the item, such as price/stock change. 
        /// </summary> 
        [Column("UpdateTime")] 
        public int? @UpdateTime   { get; set; }
        ///<summary> 
        /// the net weight of this item, the unit is KG. 
        /// </summary> 
        [Column("Weight")] 
        public decimal? @Weight   { get; set; }
        ///<summary> 
        /// Could call shopee.item.GetCategories to get category detail.Related to result.categories.category_id 
        /// </summary> 
        [Column("Id_ShopeeProductCategory")] 
        public long @Id_ShopeeProductCategory   { get; set; }
        ///<summary> 
        /// The original price of the item in the listing currency. 
        /// </summary> 
        [Column("OriginalPrice")] 
        public decimal? @OriginalPrice   { get; set; }
        ///<summary> 
        /// The sales volume of item. 
        /// </summary> 
        [Column("Sales")] 
        public int? @Sales   { get; set; }
        ///<summary> 
        /// The page view of item. 
        /// </summary> 
        [Column("Views")] 
        public int? @Views   { get; set; }
        ///<summary> 
        /// The conllection number of item. 
        /// </summary> 
        [Column("Likes")] 
        public int? @Likes   { get; set; }
        ///<summary> 
        /// The length of package for this single item, the unit is CM 
        /// </summary> 
        [Column("PackageLength")] 
        public int? @PackageLength   { get; set; }
        ///<summary> 
        /// The width of package for this single item, the unit is CM 
        /// </summary> 
        [Column("PackageWidth")] 
        public int? @PackageWidth   { get; set; }
        ///<summary> 
        /// The height of package for this single item, the unit is CM 
        /// </summary> 
        [Column("PackageHeight")] 
        public int? @PackageHeight   { get; set; }
        ///<summary> 
        /// The guaranteed days to ship orders. For pre-order, please input value from 7 to 30; for non pre-order, please exclude this field and it will default to the respective standard per your shop location.(e.g. 3 for CrossBorder) 
        /// </summary> 
        [Column("DaysToShip")] 
        public int? @DaysToShip   { get; set; }
        ///<summary> 
        /// The rating star scores of this item. 
        /// </summary> 
        [Column("RatingStar")] 
        public decimal? @RatingStar   { get; set; }
        ///<summary> 
        /// Count of comments for the item. 
        /// </summary> 
        [Column("CmtCount")] 
        public int? @CmtCount   { get; set; }
        ///<summary> 
        /// This indicates whether the item is secondhand. 
        /// </summary> 
        [Column("Condition")] 
        [MaxLength(20)] 
        public string? @Condition   { get; set; }
        ///<summary> 
        /// The ID of discount activity the item is currently in. One item can only have one discount at a time. discount_id will be 0 if the item has no discount applied, or item has variation. 
        /// </summary> 
        [Column("DiscountId")] 
        public int? @DiscountId   { get; set; }
        ///<summary> 
        /// Use this field to identify whether the item is pre-order. Applicable value: true/false. 
        /// </summary> 
        [Column("IsPreorder")] 
        public byte? @IsPreorder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreatedDate")] 
        public DateTime? @CreatedDate   { get; set; }
}
}
