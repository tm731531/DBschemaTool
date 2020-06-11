using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProdSpecKeyinLog
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LogID")] 
        [Key] 
        public int @LogID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UserID")] 
        public int @UserID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(200)] 
        public string @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EventType")] 
        [MaxLength(200)] 
        public string @EventType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Event")] 
        [MaxLength(4000)] 
        public string @Event   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UserIP")] 
        [MaxLength(200)] 
        public string @UserIP   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EventDate")] 
        public DateTime @EventDate   { get; set; }
}
}
