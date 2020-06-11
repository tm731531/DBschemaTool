using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ETU_Redirection_Master
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
        [Column("user_type")] 
        [MaxLength(50)] 
        public string? @user_type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(50)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("url_root")] 
        [MaxLength(50)] 
        public string? @url_root   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("memo")] 
        public string? @memo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("url_from_max_length")] 
        public byte? @url_from_max_length   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
}
}
