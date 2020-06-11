using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FrontendCategory_ProductTag
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
        [Column("id_frontendCategory")] 
        public long @id_frontendCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_ProductTag")] 
        public long @id_ProductTag   { get; set; }
}
}
