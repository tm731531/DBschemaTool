using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_ProductSpec
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
        [Column("SpecValueID")] 
        [MaxLength(21)] 
        public string? @SpecValueID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SpecName")] 
        [MaxLength(200)] 
        public string? @SpecName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SpecValue")] 
        public string? @SpecValue   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsEnabled")] 
        public bool? @IsEnabled   { get; set; }
}
}
