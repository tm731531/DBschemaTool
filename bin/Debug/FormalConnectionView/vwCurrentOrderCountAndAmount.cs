using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwCurrentOrderCountAndAmount
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderType")] 
        [MaxLength(30)] 
        public string @OrderType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderCount")] 
        public int? @OrderCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderMoneyType")] 
        [MaxLength(31)] 
        public string @OrderMoneyType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderMoneyTotal")] 
        public double? @OrderMoneyTotal   { get; set; }
}
}
