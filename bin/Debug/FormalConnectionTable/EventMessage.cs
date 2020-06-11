using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class EventMessage
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 提示資訊對應碼 
        /// </summary> 
        [Column("eventId")] 
        [MaxLength(100)] 
        public string @eventId   { get; set; }
        ///<summary> 
        /// 提示資訊 
        /// </summary> 
        [Column("message")] 
        [MaxLength(400)] 
        public string @message   { get; set; }
        ///<summary> 
        /// 提示資訊說明 
        /// </summary> 
        [Column("description")] 
        [MaxLength(200)] 
        public string? @description   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("reworkTime")] 
        public DateTime? @reworkTime   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
