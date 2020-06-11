using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwMLDL_20999_FrontendProductCategory
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seq")] 
        public long? @seq   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DEP_PATH")] 
        public string? @DEP_PATH   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryStruct")] 
        public string? @categoryStruct   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DEP_LEVEL")] 
        public int? @DEP_LEVEL   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isLastLevel")] 
        public bool? @isLastLevel   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productCount")] 
        public int? @productCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
