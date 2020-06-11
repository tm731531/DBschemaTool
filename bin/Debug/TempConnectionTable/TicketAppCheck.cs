using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class TicketAppCheck
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
        [Column("ORDERID")] 
        public int @ORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ITEMID")] 
        public int @ITEMID   { get; set; }
        ///<summary> 
        /// 銷售編號(saleno) 
        /// </summary> 
        [Column("ProductSKU")] 
        public int @ProductSKU   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SaleName")] 
        [MaxLength(100)] 
        public string @SaleName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CustID")] 
        public int @CustID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ShortDescription")] 
        [MaxLength(100)] 
        public string? @ShortDescription   { get; set; }
        ///<summary> 
        /// N天發通知 
        /// </summary> 
        [Column("AlertType")] 
        public int? @AlertType   { get; set; }
        ///<summary> 
        /// 票券到期日 
        /// </summary> 
        [Column("DiscountEndDay")] 
        public DateTime? @DiscountEndDay   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreatedDate")] 
        public DateTime? @CreatedDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsSend")] 
        public bool @IsSend   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Email")] 
        [MaxLength(250)] 
        public string? @Email   { get; set; }
}
}
