using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Jo2Go_Detail
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 版本(Jo2Go_Setting.id) 
        /// </summary> 
        [Column("Version")] 
        public long @Version   { get; set; }
        ///<summary> 
        /// 團購數量 
        /// </summary> 
        [Column("Qty")] 
        public int @Qty   { get; set; }
        ///<summary> 
        /// 團購成本 
        /// </summary> 
        [Column("CostPrice")] 
        public decimal? @CostPrice   { get; set; }
}
}
