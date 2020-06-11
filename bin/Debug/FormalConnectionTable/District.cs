using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class District
{
        ///<summary> 
        /// 主鍵：區的行政代碼 
        /// </summary> 
        [Column("id")] 
        [MaxLength(12)] 
        public string @id   { get; set; }
        ///<summary> 
        /// 縣，區名 
        /// </summary> 
        [Column("districtName")] 
        [MaxLength(120)] 
        public string? @districtName   { get; set; }
        ///<summary> 
        /// 城市id，FK，關聯到City表的id 
        /// </summary> 
        [Column("cityId_City")] 
        [MaxLength(12)] 
        public string? @cityId_City   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isExpressArea")] 
        public bool @isExpressArea   { get; set; }
}
}
