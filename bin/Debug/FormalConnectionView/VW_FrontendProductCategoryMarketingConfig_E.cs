using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_FrontendProductCategoryMarketingConfig_E
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_FrontendProductCategory")] 
        public long @id_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_MarketingEventType")] 
        public int @id_MarketingEventType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("purchasedQTYLowerBound")] 
        public int? @purchasedQTYLowerBound   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("purchasedQTYUpperBound")] 
        public int? @purchasedQTYUpperBound   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("purchasedAMTLowerBound")] 
        public decimal? @purchasedAMTLowerBound   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("purchasedAMTUpperBound")] 
        public decimal? @purchasedAMTUpperBound   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("comment")] 
        [MaxLength(100)] 
        public string? @comment   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdateTime")] 
        public DateTime @lastUpdateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifier")] 
        [MaxLength(300)] 
        public string @lastModifier   { get; set; }
}
}
