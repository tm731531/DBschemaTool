using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_GIFT_E
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo_Main")] 
        [MaxLength(20)] 
        public string? @FugoSaleNo_Main   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo_Gift")] 
        [MaxLength(20)] 
        public string? @FugoSaleNo_Gift   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PickUpperLimit")] 
        public byte? @PickUpperLimit   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
}
}
