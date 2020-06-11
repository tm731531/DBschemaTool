using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductAdDetail_Category
{
        ///<summary> 
        /// 識別碼(PK) 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 前台分類ID (FK: formal.FrontendProductCategory.id) 
        /// </summary> 
        [Column("id_FrontendProductCategory")] 
        public long @id_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 商品頁廣告編號 (FK: formal.ProductAdHeader.id) 
        /// </summary> 
        [Column("id_ProductAdHeader")] 
        public long @id_ProductAdHeader   { get; set; }
}
}
