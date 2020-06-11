using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesCTR
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Feature")] 
        [MaxLength(20)] 
        public string? @Feature   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AD")] 
        [MaxLength(20)] 
        public string? @AD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UseTime")] 
        public DateTime? @UseTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_B2BMenubar")] 
        public int? @id_B2BMenubar   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SourceType")] 
        public byte? @SourceType   { get; set; }
}
}
