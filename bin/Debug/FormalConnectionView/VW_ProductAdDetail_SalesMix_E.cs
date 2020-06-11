using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_ProductAdDetail_SalesMix_E
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
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_ProductAdHeader")] 
        public long @id_ProductAdHeader   { get; set; }
}
}
