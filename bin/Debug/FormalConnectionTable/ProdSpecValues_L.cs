using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProdSpecValues_L
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(20)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductSpecID")] 
        public int? @ProductSpecID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SpecID")] 
        public int? @SpecID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SpecName")] 
        [MaxLength(200)] 
        public string? @SpecName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ValueID")] 
        public int? @ValueID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ValueName")] 
        public string? @ValueName   { get; set; }
}
}
