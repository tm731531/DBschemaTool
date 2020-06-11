using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class City
{
        ///<summary> 
        /// 主鍵：地級市的行政編號 
        /// </summary> 
        [Column("id")] 
        [MaxLength(12)] 
        public string @id   { get; set; }
        ///<summary> 
        /// 地級市名 
        /// </summary> 
        [Column("cityName")] 
        [MaxLength(100)] 
        public string? @cityName   { get; set; }
        ///<summary> 
        /// FK：，關聯到Province表的id 
        /// </summary> 
        [Column("provinceId_Province")] 
        [MaxLength(12)] 
        public string? @provinceId_Province   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CityCode")] 
        [MaxLength(2)] 
        public string? @CityCode   { get; set; }
}
}
