using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class sysdiagrams
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(128)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("principal_id")] 
        public int @principal_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("diagram_id")] 
        [Key] 
        public int @diagram_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("version")] 
        public int? @version   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("definition")] 
        public byte[]? @definition   { get; set; }
}
}
