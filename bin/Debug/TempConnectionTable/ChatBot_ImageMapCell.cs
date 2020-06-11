using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ChatBot_ImageMapCell
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public Guid @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Sort")] 
        public int @Sort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImageMapId")] 
        public Guid @ImageMapId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AreaX")] 
        public int @AreaX   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AreaY")] 
        public int @AreaY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AreaWidth")] 
        public int @AreaWidth   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AreaHeight")] 
        public int @AreaHeight   { get; set; }
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
