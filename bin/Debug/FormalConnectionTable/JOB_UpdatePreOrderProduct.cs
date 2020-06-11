using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class JOB_UpdatePreOrderProduct
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// 生效日 
        /// </summary> 
        [Column("Effective")] 
        public DateTime? @Effective   { get; set; }
        ///<summary> 
        /// 是否為預購 
        /// </summary> 
        [Column("IsPreOrder")] 
        public bool? @IsPreOrder   { get; set; }
        ///<summary> 
        /// 預購方式 
        /// </summary> 
        [Column("StatusID")] 
        public int? @StatusID   { get; set; }
        ///<summary> 
        /// 預計出貨日 
        /// </summary> 
        [Column("ShippingDate")] 
        public DateTime? @ShippingDate   { get; set; }
        ///<summary> 
        /// 訂單成立後X日出貨 
        /// </summary> 
        [Column("AfterOrderDay")] 
        public int? @AfterOrderDay   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreatedUser")] 
        public long? @CreatedUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Created")] 
        public DateTime? @Created   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Updated")] 
        public DateTime? @Updated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsComplete")] 
        public bool? @IsComplete   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ReturnMsg")] 
        [MaxLength(50)] 
        public string? @ReturnMsg   { get; set; }
}
}
