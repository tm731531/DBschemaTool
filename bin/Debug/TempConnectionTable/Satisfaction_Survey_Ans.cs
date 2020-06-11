using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Satisfaction_Survey_Ans
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
        [Column("userId")] 
        public long? @userId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("questionId")] 
        public int? @questionId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ans")] 
        [MaxLength(256)] 
        public string? @ans   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sendTime")] 
        public DateTime? @sendTime   { get; set; }
}
}
