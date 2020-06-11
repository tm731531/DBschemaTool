using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Province
{
        ///<summary> 
        /// 主鍵:省的行政代碼 
        /// </summary> 
        [Column("id")] 
        [MaxLength(12)] 
        public string @id   { get; set; }
        ///<summary> 
        /// 省名 
        /// </summary> 
        [Column("provinceName")] 
        [MaxLength(80)] 
        public string? @provinceName   { get; set; }
}
}
