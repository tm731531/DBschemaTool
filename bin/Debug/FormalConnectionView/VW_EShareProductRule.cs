using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_EShareProductRule
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
        [Column("EShareBoarder")] 
        public decimal? @EShareBoarder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareRatio")] 
        public decimal? @EShareRatio   { get; set; }
}
}
