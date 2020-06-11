using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SensenCategoryList
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryName")] 
        public string? @categoryName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("frontendId")] 
        public int? @frontendId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("backendId")] 
        public int? @backendId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("plotform")] 
        [MaxLength(1)] 
        public string? @plotform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("mainCategory")] 
        public string? @mainCategory   { get; set; }
}
}
