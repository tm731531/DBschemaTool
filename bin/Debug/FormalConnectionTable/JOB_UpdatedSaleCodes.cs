using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class JOB_UpdatedSaleCodes
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("JOB_Updated_Id")] 
        public int @JOB_Updated_Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SaleCode")] 
        [MaxLength(40)] 
        public string @SaleCode   { get; set; }
}
}
