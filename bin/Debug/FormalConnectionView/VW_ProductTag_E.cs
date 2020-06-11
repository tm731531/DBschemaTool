using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_ProductTag_E
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
        [Column("tag_name")] 
        [MaxLength(100)] 
        public string @tag_name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("tag_img")] 
        [MaxLength(400)] 
        public string? @tag_img   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BannerID")] 
        public long? @BannerID   { get; set; }
}
}
