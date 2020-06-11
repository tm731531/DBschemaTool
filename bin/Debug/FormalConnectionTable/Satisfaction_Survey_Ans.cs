using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Satisfaction_Survey_Ans
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
        [Column("id_Survey")] 
        public int @id_Survey   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_Order")] 
        public long @id_Order   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ans")] 
        public int @ans   { get; set; }
}
}
