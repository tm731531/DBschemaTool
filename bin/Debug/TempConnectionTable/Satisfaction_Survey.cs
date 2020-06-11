using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Satisfaction_Survey
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
        [Column("name")] 
        [MaxLength(1000)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("value")] 
        [MaxLength(100)] 
        public string? @value   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("groupId")] 
        public long? @groupId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("type")] 
        [MaxLength(10)] 
        public string? @type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDelete")] 
        public bool? @isDelete   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("versions")] 
        [MaxLength(10)] 
        public string? @versions   { get; set; }
}
}
