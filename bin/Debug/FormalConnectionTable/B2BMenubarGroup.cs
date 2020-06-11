using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class B2BMenubarGroup
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
        [Column("groupName")] 
        [MaxLength(200)] 
        public string? @groupName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("menubarId")] 
        public int? @menubarId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDelete")] 
        public bool? @isDelete   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUser")] 
        [MaxLength(200)] 
        public string? @lastUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdated")] 
        public DateTime? @lastUpdated   { get; set; }
}
}
