using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class queue_ticket
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
        [Column("ticket_type")] 
        [MaxLength(20)] 
        public string? @ticket_type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ticket_no")] 
        [MaxLength(50)] 
        public string? @ticket_no   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("is_processed")] 
        public bool @is_processed   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_by")] 
        [MaxLength(50)] 
        public string? @update_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        [MaxLength(50)] 
        public string? @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
