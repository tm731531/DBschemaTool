using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SensenTfidfGrade
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("word")] 
        [MaxLength(100)] 
        public string? @word   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryIdDic")] 
        public string? @categoryIdDic   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("plotform")] 
        [MaxLength(1)] 
        public string? @plotform   { get; set; }
}
}
