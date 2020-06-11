using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_SalesMix_Kit_U
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Main_fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @Main_fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Kit_fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @Kit_fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Kit_saleCode")] 
        [MaxLength(40)] 
        public string? @Kit_saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ShipSeq")] 
        public int? @ShipSeq   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("QTY")] 
        public int? @QTY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Cost")] 
        public decimal? @Cost   { get; set; }
}
}
