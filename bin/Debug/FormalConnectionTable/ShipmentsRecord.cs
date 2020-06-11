using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ShipmentsRecord
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderID")] 
        public int @OrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ItemID")] 
        public byte @ItemID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SaleNo")] 
        [MaxLength(20)] 
        public string @SaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SaleName")] 
        [MaxLength(200)] 
        public string? @SaleName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DeliveryOrderID")] 
        [MaxLength(20)] 
        public string @DeliveryOrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ExDeliveryOrderID")] 
        [MaxLength(20)] 
        public string? @ExDeliveryOrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoVendorID")] 
        [MaxLength(10)] 
        public string? @FugoVendorID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Update_on")] 
        public DateTime? @Update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
}
}
