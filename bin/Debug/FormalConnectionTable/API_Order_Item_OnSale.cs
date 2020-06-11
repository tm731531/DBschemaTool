using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_Order_Item_OnSale
{
        ///<summary> 
        /// 流水號 
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
        /// 賣家通路別 
        /// </summary> 
        [Column("seller_channel")] 
        [MaxLength(20)] 
        public string? @seller_channel   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seller_sale_price")] 
        public decimal? @seller_sale_price   { get; set; }
        ///<summary> 
        /// 賣家成本(批發價) 
        /// </summary> 
        [Column("seller_cost")] 
        public decimal? @seller_cost   { get; set; }
        ///<summary> 
        /// 銷售編號 
        /// </summary> 
        [Column("saleno")] 
        [MaxLength(15)] 
        public string? @saleno   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salecode")] 
        [MaxLength(15)] 
        public string? @salecode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("original_cost_rate")] 
        public decimal? @original_cost_rate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("is_deleted")] 
        public bool? @is_deleted   { get; set; }
        ///<summary> 
        /// 賣家配送方式 
        /// </summary> 
        [Column("seller_delivery_way")] 
        [MaxLength(5)] 
        public string? @seller_delivery_way   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("delete_on")] 
        public DateTime? @delete_on   { get; set; }
        ///<summary> 
        /// 更新時間 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("cache_on")] 
        public DateTime? @cache_on   { get; set; }
}
}
