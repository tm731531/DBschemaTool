using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwx_brandinfo_log
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
        [Column("type")] 
        [MaxLength(20)] 
        public string? @type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("errorMessage")] 
        [MaxLength(2147483647)] 
        public string? @errorMessage   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orginName")] 
        [MaxLength(30)] 
        public string? @orginName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("changeName")] 
        [MaxLength(30)] 
        public string? @changeName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("status")] 
        [MaxLength(10)] 
        public string? @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
