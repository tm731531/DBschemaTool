using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ChatBot_MessageObjectVideo
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public Guid @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SourceName")] 
        [MaxLength(500)] 
        public string @SourceName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SourcePath")] 
        [MaxLength(500)] 
        public string @SourcePath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SourceSize")] 
        public long @SourceSize   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImageName")] 
        [MaxLength(500)] 
        public string? @ImageName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImagePath")] 
        [MaxLength(500)] 
        public string? @ImagePath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImageSize")] 
        public long? @ImageSize   { get; set; }
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
