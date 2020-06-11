using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductAdDetail_SalesMix
{
        ///<summary> 
        /// 識別碼(PK) 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 商品品號 (FK: formal.SalesMix.saleCode) 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 商品頁廣告編號 (FK: formal.ProductAdHeader.id) 
        /// </summary> 
        [Column("id_ProductAdHeader")] 
        public long @id_ProductAdHeader   { get; set; }
}
}
