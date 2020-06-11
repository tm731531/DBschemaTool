using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwx_brandinfo
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
        [Column("brand_id")] 
        public int @brand_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(30)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDelete")] 
        public bool @isDelete   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
}
}
