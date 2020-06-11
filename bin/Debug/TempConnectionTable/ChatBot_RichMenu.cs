using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ChatBot_RichMenu
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public Guid @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RichMenuLindId")] 
        [MaxLength(50)] 
        public string? @RichMenuLindId   { get; set; }
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
        [Column("Receiver")] 
        public int @Receiver   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ChatBarText")] 
        [MaxLength(14)] 
        public string @ChatBarText   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TemplateType")] 
        public int @TemplateType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImageName")] 
        [MaxLength(500)] 
        public string @ImageName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImagePath")] 
        [MaxLength(500)] 
        public string @ImagePath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImagePhysicalPath")] 
        [MaxLength(500)] 
        public string? @ImagePhysicalPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImageSize")] 
        public long @ImageSize   { get; set; }
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
        [Column("Remark")] 
        [MaxLength(500)] 
        public string? @Remark   { get; set; }
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
