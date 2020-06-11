using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class OrderPostponedTag
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderId")] 
        [MaxLength(10)] 
        public string @orderId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("itemId")] 
        [MaxLength(4)] 
        public string @itemId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productId")] 
        [MaxLength(7)] 
        public string @productId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("remindTimes")] 
        public byte @remindTimes   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("reply")] 
        [MaxLength(50)] 
        public string? @reply   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("status")] 
        [MaxLength(1)] 
        public string @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("reply_date")] 
        [MaxLength(10)] 
        public string? @reply_date   { get; set; }
}
}
