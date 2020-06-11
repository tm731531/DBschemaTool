using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_USER_E
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("user_id")] 
        [MaxLength(6)] 
        public string? @user_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("user_name")] 
        [MaxLength(200)] 
        public string @user_name   { get; set; }
}
}
