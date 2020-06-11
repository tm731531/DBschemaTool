using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BlackAddr
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 住址 
        /// </summary> 
        [Column("Addr")] 
        [MaxLength(100)] 
        public string? @Addr   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createdDate")] 
        public DateTime? @createdDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createdUser")] 
        [MaxLength(100)] 
        public string? @createdUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDelete")] 
        public bool @isDelete   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("modifyDate")] 
        public DateTime? @modifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("modifyUser")] 
        [MaxLength(100)] 
        public string? @modifyUser   { get; set; }
}
}
