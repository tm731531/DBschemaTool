using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesMix_Product
{
        ///<summary> 
        /// 編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 商品組合編號,FK,關聯到表SalesMix中的id 
        /// </summary> 
        [Column("id_SalesMix")] 
        public long? @id_SalesMix   { get; set; }
        ///<summary> 
        /// 商品編號,FK,關聯到表Product中的id 
        /// </summary> 
        [Column("id_Product")] 
        public long? @id_Product   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
}
}
