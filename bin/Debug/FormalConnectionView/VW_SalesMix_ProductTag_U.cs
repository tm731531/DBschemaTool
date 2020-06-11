using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_SalesMix_ProductTag_U
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_salesMix")] 
        public long @id_salesMix   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_ProductTag")] 
        public long @id_ProductTag   { get; set; }
}
}
