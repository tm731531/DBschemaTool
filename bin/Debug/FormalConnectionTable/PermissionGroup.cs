using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class PermissionGroup
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 群組名稱，B2E Menu 第一層選單名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(200)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 排序 
        /// </summary> 
        [Column("seq")] 
        public int? @seq   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("created_on")] 
        public DateTime @created_on   { get; set; }
        ///<summary> 
        /// 建立者 
        /// </summary> 
        [Column("created_by")] 
        public int? @created_by   { get; set; }
        ///<summary> 
        /// icon 的 Class名稱 
        /// </summary> 
        [Column("icon")] 
        public string? @icon   { get; set; }
}
}
