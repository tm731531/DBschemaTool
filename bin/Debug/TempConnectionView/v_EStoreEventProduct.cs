using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class v_EStoreEventProduct
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
        [Column("FugoSaleno")] 
        [MaxLength(60)] 
        public string? @FugoSaleno   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareRatioEvent")] 
        public decimal @EShareRatioEvent   { get; set; }
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
