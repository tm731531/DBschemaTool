using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ProductProperty
{
        ///<summary> 
        /// 商品屬性id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 屬性值 
        /// </summary> 
        [Column("propertyValue")] 
        [MaxLength(100)] 
        public string? @propertyValue   { get; set; }
}
}
