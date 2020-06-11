using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwOrderByPaymentTypeCount
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("paymentName")] 
        [MaxLength(500)] 
        public string? @paymentName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("installmentNo")] 
        public int? @installmentNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrdCount")] 
        public int? @OrdCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrdAmount")] 
        public double? @OrdAmount   { get; set; }
}
}
