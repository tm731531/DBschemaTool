using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_Order_Item
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 平台(1: UMall, 2: ETMall) 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("api_order_id")] 
        public long? @api_order_id   { get; set; }
        ///<summary> 
        /// 買家訂單編號 
        /// </summary> 
        [Column("buyer_order_id")] 
        [MaxLength(30)] 
        public string? @buyer_order_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("buyer_item_id")] 
        [MaxLength(20)] 
        public string? @buyer_item_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("buyer_store_id")] 
        [MaxLength(20)] 
        public string? @buyer_store_id   { get; set; }
        ///<summary> 
        /// 商品銷售編號 
        /// </summary> 
        [Column("item_saleno")] 
        [MaxLength(15)] 
        public string? @item_saleno   { get; set; }
        ///<summary> 
        /// 商品名稱 
        /// </summary> 
        [Column("item_name")] 
        [MaxLength(500)] 
        public string? @item_name   { get; set; }
        ///<summary> 
        /// 商品規格編號 
        /// </summary> 
        [Column("item_sku_id")] 
        public long? @item_sku_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("item_sku_name")] 
        [MaxLength(50)] 
        public string? @item_sku_name   { get; set; }
        ///<summary> 
        /// 商品購買數量 
        /// </summary> 
        [Column("item_amount")] 
        public byte? @item_amount   { get; set; }
        ///<summary> 
        /// 商品售價 
        /// </summary> 
        [Column("item_price")] 
        public decimal? @item_price   { get; set; }
        ///<summary> 
        /// 商品折扣金額 
        /// </summary> 
        [Column("item_discount_fee")] 
        public decimal? @item_discount_fee   { get; set; }
        ///<summary> 
        /// 實際購買金額 
        /// </summary> 
        [Column("item_total_fee")] 
        public decimal? @item_total_fee   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("item_seller_cost")] 
        public decimal? @item_seller_cost   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("item_order_status")] 
        [MaxLength(30)] 
        public string? @item_order_status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugo_order_id")] 
        public long? @fugo_order_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugo_item_no")] 
        [MaxLength(4)] 
        public string? @fugo_item_no   { get; set; }
        ///<summary> 
        /// 備註(英數上限60個字,中文30個字) 
        /// </summary> 
        [Column("memo")] 
        [MaxLength(60)] 
        public string? @memo   { get; set; }
        ///<summary> 
        /// 更新日期 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
