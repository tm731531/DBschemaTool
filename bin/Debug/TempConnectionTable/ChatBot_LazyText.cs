using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ChatBot_LazyText
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public Guid @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PortalId")] 
        public Guid @PortalId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(100)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DayFlag")] 
        public int @DayFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("StartHour")] 
        public int @StartHour   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EndHour")] 
        public int @EndHour   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("StartDateTime")] 
        public DateTime @StartDateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EndDateTime")] 
        public DateTime @EndDateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Alive")] 
        public bool @Alive   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Enabled")] 
        public bool @Enabled   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Creater")] 
        [MaxLength(50)] 
        public string @Creater   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateTime")] 
        public DateTime @CreateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Editer")] 
        [MaxLength(50)] 
        public string? @Editer   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EditTime")] 
        public DateTime? @EditTime   { get; set; }
}
}
