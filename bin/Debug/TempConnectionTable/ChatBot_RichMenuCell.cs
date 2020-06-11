using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ChatBot_RichMenuCell
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public Guid @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RichMenuId")] 
        public Guid @RichMenuId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Sort")] 
        public int @Sort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ActionType")] 
        public int @ActionType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ActionContent")] 
        [MaxLength(500)] 
        public string @ActionContent   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Remark")] 
        [MaxLength(500)] 
        public string? @Remark   { get; set; }
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
