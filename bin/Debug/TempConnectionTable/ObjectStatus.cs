using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ObjectStatus
{
        ///<summary> 
        /// 物件狀態ID 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 物件的狀態 
        /// </summary> 
        [Column("status")] 
        [MaxLength(200)] 
        public string? @status   { get; set; }
        ///<summary> 
        /// 所屬類別 
        /// </summary> 
        [Column("category")] 
        [MaxLength(300)] 
        public string? @category   { get; set; }
}
}
