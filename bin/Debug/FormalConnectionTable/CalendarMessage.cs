using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class CalendarMessage
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public Guid @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MessageDate")] 
        public DateTime? @MessageDate   { get; set; }
        ///<summary> 
        /// 1:B2B公告 2:自已定義的訊息公告 
        /// </summary> 
        [Column("MessageType")] 
        public short? @MessageType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Subject")] 
        [MaxLength(200)] 
        public string? @Subject   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AnnouncementPostid")] 
        public long? @AnnouncementPostid   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DisplayOrder")] 
        public short? @DisplayOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateTime")] 
        public DateTime @CreateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyTime")] 
        public DateTime? @LastModifyTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifier")] 
        [MaxLength(50)] 
        public string? @LastModifier   { get; set; }
}
}
