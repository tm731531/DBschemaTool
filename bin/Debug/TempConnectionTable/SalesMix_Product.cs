using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
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
        /// FK商品組合編號,關聯到表SalesMix中的id 
        /// </summary> 
        [Column("id_SalesMix")] 
        public long? @id_SalesMix   { get; set; }
        ///<summary> 
        /// FK 品編號，關聯到表Product中的id 
        /// </summary> 
        [Column("id_Product")] 
        public long? @id_Product   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
}
}
