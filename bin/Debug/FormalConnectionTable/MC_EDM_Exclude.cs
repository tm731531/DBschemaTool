using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MC_EDM_Exclude
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("email")] 
        [MaxLength(100)] 
        public string? @email   { get; set; }
        ///<summary> 
        /// 資料來源 
        /// </summary> 
        [Column("source")] 
        [MaxLength(50)] 
        public string? @source   { get; set; }
        ///<summary> 
        /// 排除原因 
        /// </summary> 
        [Column("reason")] 
        public string? @reason   { get; set; }
        ///<summary> 
        /// 建立者(user.id) 
        /// </summary> 
        [Column("create_by")] 
        public long? @create_by   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
