using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_Order_Item_OnSale_SKU
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_api_order_item_onsale")] 
        public long @id_api_order_item_onsale   { get; set; }
        ///<summary> 
        /// 賣家商品規格編號 
        /// </summary> 
        [Column("seller_sku_id")] 
        [MaxLength(50)] 
        public string? @seller_sku_id   { get; set; }
        ///<summary> 
        /// 我們的商品規格編號(pan.id) 
        /// </summary> 
        [Column("sku_id")] 
        public long @sku_id   { get; set; }
        ///<summary> 
        /// 賣家商品名稱 
        /// </summary> 
        [Column("seller_sku_name")] 
        [MaxLength(200)] 
        public string? @seller_sku_name   { get; set; }
        ///<summary> 
        /// 賣家可接單量 
        /// </summary> 
        [Column("seller_accessed_qty")] 
        public int? @seller_accessed_qty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("barcode")] 
        [MaxLength(13)] 
        public string? @barcode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("is_deleted")] 
        public bool? @is_deleted   { get; set; }
}
}
