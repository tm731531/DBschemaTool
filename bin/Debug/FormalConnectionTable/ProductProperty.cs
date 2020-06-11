using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductProperty
{
        ///<summary> 
        /// 屬性Id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 屬性值 (1:一般商品, 2:加價購, 3:競標(KID), 4:任選, 5:預購, 6:贈品, 7:團購, 8:集購, 9:E購物車加價購, 10.低溫冷藏, 11.兌點商品)_ 
        /// </summary> 
        [Column("propertyValue")] 
        [MaxLength(100)] 
        public string? @propertyValue   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
}
}
