using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_VENDOR_E
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendor_id")] 
        [MaxLength(12)] 
        public string? @vendor_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendor_name")] 
        [MaxLength(240)] 
        public string @vendor_name   { get; set; }
}
}
