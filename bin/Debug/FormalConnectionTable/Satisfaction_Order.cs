using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Satisfaction_Order
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
        [Column("orderID")] 
        [MaxLength(60)] 
        public string @orderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("itemID")] 
        public int @itemID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoProductID")] 
        [MaxLength(60)] 
        public string @fugoProductID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorId")] 
        [MaxLength(100)] 
        public string @vendorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderDate")] 
        public DateTime @orderDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        [MaxLength(10)] 
        public string @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salesMixID")] 
        public long @salesMixID   { get; set; }
}
}
