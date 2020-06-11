using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BSC_StorePhoto
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("StoreInformationId")] 
        public int @StoreInformationId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FileName")] 
        [MaxLength(100)] 
        public string @FileName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VirtualPath")] 
        [MaxLength(500)] 
        public string @VirtualPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PhysicalPath")] 
        [MaxLength(500)] 
        public string @PhysicalPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ServerPath")] 
        [MaxLength(500)] 
        public string @ServerPath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Size")] 
        public long @Size   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Sort")] 
        public int @Sort   { get; set; }
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
