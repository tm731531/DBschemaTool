using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ZipCode
{
        ///<summary> 
        /// 編號 
        /// </summary> 
        [Column("id")] 
        public int @id   { get; set; }
        ///<summary> 
        /// FK：關聯到District表的id 
        /// </summary> 
        [Column("districtId_District")] 
        [MaxLength(12)] 
        public string @districtId_District   { get; set; }
        ///<summary> 
        /// 郵編 
        /// </summary> 
        [Column("zipCode")] 
        [MaxLength(12)] 
        public string @zipCode   { get; set; }
}
}
