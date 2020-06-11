using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ProductSpecificationLog
{
        ///<summary> 
        /// 流水號 Id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 富購規格 Id 
        /// </summary> 
        [Column("commonSpecID")] 
        public int? @commonSpecID   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("createTime")] 
        public DateTime? @createTime   { get; set; }
        ///<summary> 
        /// 規格名稱, ex:style, color 
        /// </summary> 
        [Column("specificationsName")] 
        [MaxLength(500)] 
        public string? @specificationsName   { get; set; }
        ///<summary> 
        /// 規格描述, ex:紅色 
        /// </summary> 
        [Column("specificationDescription")] 
        [MaxLength(50)] 
        public string? @specificationDescription   { get; set; }
}
}
