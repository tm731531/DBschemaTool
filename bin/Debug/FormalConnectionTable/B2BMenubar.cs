using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class B2BMenubar
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("level")] 
        public int? @level   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(200)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("url")] 
        public string? @url   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isFunction")] 
        public bool? @isFunction   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("functionName")] 
        public string? @functionName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("webGroup")] 
        public byte? @webGroup   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDelete")] 
        public bool? @isDelete   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("parentId")] 
        public int? @parentId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sort")] 
        public int? @sort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDeputy")] 
        public bool? @isDeputy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
