using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Draft_SalesMixApplication_ProductTag
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
        [Column("id_Draft")] 
        public long @id_Draft   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_salesMixApplication")] 
        public long? @id_salesMixApplication   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_ProductTag")] 
        public long? @id_ProductTag   { get; set; }
}
}
