using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_ZipCode
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
        [Column("county_township")] 
        [MaxLength(15)] 
        public string? @county_township   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("zip_code")] 
        [MaxLength(5)] 
        public string? @zip_code   { get; set; }
}
}
