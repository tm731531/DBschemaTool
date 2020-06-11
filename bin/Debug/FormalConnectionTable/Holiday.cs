using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Holiday
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 假日的日期 
        /// </summary> 
        [Column("date")] 
        public DateTime @date   { get; set; }
        ///<summary> 
        /// 假日的類型: 1 行政院公佈 2:自行設定 
        /// </summary> 
        [Column("type")] 
        public int @type   { get; set; }
        ///<summary> 
        /// 假日名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(50)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 是否假日 
        /// </summary> 
        [Column("isHoliday")] 
        public bool? @isHoliday   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime? @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifier")] 
        [MaxLength(300)] 
        public string? @lastModifier   { get; set; }
}
}
