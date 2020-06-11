using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductTag
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 標籤名稱 
        /// </summary> 
        [Column("tag_name")] 
        [MaxLength(100)] 
        public string @tag_name   { get; set; }
        ///<summary> 
        /// 標籤圖檔路徑 
        /// </summary> 
        [Column("tag_img")] 
        [MaxLength(400)] 
        public string? @tag_img   { get; set; }
        ///<summary> 
        /// 對應到ETMALL.dbo.tb_Product_Banner.BannerID 
        /// </summary> 
        [Column("BannerID")] 
        public long? @BannerID   { get; set; }
}
}
