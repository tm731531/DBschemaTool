using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ChatBot_PrefixMessage
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
        [MaxLength(50)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Receiver")] 
        public int @Receiver   { get; set; }
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
        [Column("KeyWord")] 
        [MaxLength(500)] 
        public string @KeyWord   { get; set; }
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
