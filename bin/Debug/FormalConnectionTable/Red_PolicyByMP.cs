using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Red_PolicyByMP
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 商企(=FRI_FORMAL.User.id) 
        /// </summary> 
        [Column("MP")] 
        public long? @MP   { get; set; }
        ///<summary> 
        /// 商開(=FRI_FORMAL.User.id) 
        /// </summary> 
        [Column("MD")] 
        public long? @MD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
}
}
