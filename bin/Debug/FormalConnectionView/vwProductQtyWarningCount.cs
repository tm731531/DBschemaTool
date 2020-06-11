using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwProductQtyWarningCount
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Item")] 
        [MaxLength(29)] 
        public string @Item   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductNoAccessedNum")] 
        public int? @ProductNoAccessedNum   { get; set; }
}
}
