using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FugoDetailSpecInfo
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DetailSpecId")] 
        public int @DetailSpecId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DetailSpec")] 
        [MaxLength(200)] 
        public string? @DetailSpec   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SClassCode")] 
        public int? @SClassCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Status")] 
        public int? @Status   { get; set; }
}
}
