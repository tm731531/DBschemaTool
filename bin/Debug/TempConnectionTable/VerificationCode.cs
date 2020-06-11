using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class VerificationCode
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Type")] 
        public int @Type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Code")] 
        [MaxLength(50)] 
        public string @Code   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AssistCode")] 
        [MaxLength(50)] 
        public string? @AssistCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Source")] 
        [MaxLength(50)] 
        public string @Source   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Used")] 
        public bool @Used   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Enabled")] 
        public bool @Enabled   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
}
}
