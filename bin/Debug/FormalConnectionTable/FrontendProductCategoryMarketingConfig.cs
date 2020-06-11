using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FrontendProductCategoryMarketingConfig
{
        ///<summary> 
        /// 前台分類行銷活動屬性對應前台分類 seq 欄位 
        /// </summary> 
        [Column("id_FrontendProductCategory")] 
        public long @id_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 行銷活動種類 
        /// </summary> 
        [Column("id_MarketingEventType")] 
        public int @id_MarketingEventType   { get; set; }
        ///<summary> 
        /// 行銷購買數量下限 
        /// </summary> 
        [Column("purchasedQTYLowerBound")] 
        public int? @purchasedQTYLowerBound   { get; set; }
        ///<summary> 
        /// 行銷購買數量上限 
        /// </summary> 
        [Column("purchasedQTYUpperBound")] 
        public int? @purchasedQTYUpperBound   { get; set; }
        ///<summary> 
        /// 行銷購買單價下限 
        /// </summary> 
        [Column("purchasedAMTLowerBound")] 
        public decimal? @purchasedAMTLowerBound   { get; set; }
        ///<summary> 
        /// 行銷購買單價上限 
        /// </summary> 
        [Column("purchasedAMTUpperBound")] 
        public decimal? @purchasedAMTUpperBound   { get; set; }
        ///<summary> 
        /// 相關註記內容 
        /// </summary> 
        [Column("comment")] 
        [MaxLength(100)] 
        public string? @comment   { get; set; }
        ///<summary> 
        /// 異動日期 
        /// </summary> 
        [Column("lastUpdateTime")] 
        public DateTime @lastUpdateTime   { get; set; }
        ///<summary> 
        /// 異動人員 
        /// </summary> 
        [Column("lastModifier")] 
        [MaxLength(300)] 
        public string @lastModifier   { get; set; }
        ///<summary> 
        /// 最後更新時間戳 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
}
}
