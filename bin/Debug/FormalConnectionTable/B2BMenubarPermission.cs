using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class B2BMenubarPermission
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
        [Column("vendorId")] 
        [MaxLength(100)] 
        public string? @vendorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("menuId")] 
        public int? @menuId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDelete")] 
        public bool? @isDelete   { get; set; }
}
}
