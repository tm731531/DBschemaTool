using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Role
{
        ///<summary> 
        /// 角色的id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 角色的名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(120)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 角色的中文名稱 
        /// </summary> 
        [Column("value")] 
        [MaxLength(240)] 
        public string @value   { get; set; }
        ///<summary> 
        /// 判斷角色是否有效(1有效，0無效) 
        /// </summary> 
        [Column("effected")] 
        public bool @effected   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("enum")] 
        public int? @enum   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("authorityType")] 
        public int? @authorityType   { get; set; }
}
}
