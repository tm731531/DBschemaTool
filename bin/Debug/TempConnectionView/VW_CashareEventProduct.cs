using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class VW_CashareEventProduct
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
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RatioEvent")] 
        public decimal @RatioEvent   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ExpirationDate")] 
        public DateTime? @ExpirationDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EventRule")] 
        [MaxLength(2000)] 
        public string? @EventRule   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductType")] 
        public int? @ProductType   { get; set; }
}
}
