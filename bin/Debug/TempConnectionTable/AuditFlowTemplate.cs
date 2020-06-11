using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class AuditFlowTemplate
{
        ///<summary> 
        /// workflow範本主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 工作流物件種類 
        /// </summary> 
        [Column("applicationType")] 
        [MaxLength(100)] 
        public string @applicationType   { get; set; }
        ///<summary> 
        /// 工作流範本設計者，關聯到User裱中的name 
        /// </summary> 
        [Column("designer_User")] 
        [MaxLength(100)] 
        public string? @designer_User   { get; set; }
        ///<summary> 
        /// 工作流範本創建時間 
        /// </summary> 
        [Column("createdTime")] 
        public DateTime @createdTime   { get; set; }
        ///<summary> 
        /// 工作流範本最近更新時間 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 工作流範本生效時間 
        /// </summary> 
        [Column("effectiveTime")] 
        public DateTime? @effectiveTime   { get; set; }
        ///<summary> 
        /// 0:無效 1 有效 
        /// </summary> 
        [Column("effected")] 
        public byte @effected   { get; set; }
        ///<summary> 
        /// 對工作流程範本的描述 
        /// </summary> 
        [Column("description")] 
        public string? @description   { get; set; }
}
}
