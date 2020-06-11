using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vw_MC_tb_Search_Product_Priority
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GOOD_ID")] 
        public int? @GOOD_ID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Priority")] 
        public int? @Priority   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Boost_term")] 
        [MaxLength(200)] 
        public string? @Boost_term   { get; set; }
}
}
