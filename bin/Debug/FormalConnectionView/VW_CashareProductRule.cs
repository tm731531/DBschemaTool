using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_CashareProductRule
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductSource")] 
        public int? @ProductSource   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProfitLow")] 
        public decimal? @ProfitLow   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProfitHigh")] 
        public decimal? @ProfitHigh   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CashareBoarder")] 
        public decimal? @CashareBoarder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CashareRatio")] 
        public decimal? @CashareRatio   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("eTypes")] 
        [MaxLength(6)] 
        public string @eTypes   { get; set; }
}
}
