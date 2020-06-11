using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ChatBot_MemberRelation
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public Guid @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MemberId")] 
        public Guid @MemberId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RelationSource")] 
        public int @RelationSource   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RelationId")] 
        [MaxLength(100)] 
        public string @RelationId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Alive")] 
        public int @Alive   { get; set; }
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
