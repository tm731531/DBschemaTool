using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Journal_details
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
        [Column("journal_id")] 
        public long @journal_id   { get; set; }
        ///<summary> 
        /// 操作行為,C:新增,U:更新,D:刪除 
        /// </summary> 
        [Column("action")] 
        [MaxLength(1)] 
        public string? @action   { get; set; }
        ///<summary> 
        /// 記錄變更的資料表名稱 
        /// </summary> 
        [Column("table_name")] 
        [MaxLength(100)] 
        public string @table_name   { get; set; }
        ///<summary> 
        /// 記錄變更的資料表Identity欄位值(通常是id) 
        /// </summary> 
        [Column("table_identity")] 
        [MaxLength(100)] 
        public string @table_identity   { get; set; }
        ///<summary> 
        /// 記錄變更的資料表欄位 
        /// </summary> 
        [Column("field")] 
        [MaxLength(100)] 
        public string? @field   { get; set; }
        ///<summary> 
        /// 變更前的值 
        /// </summary> 
        [Column("old_value")] 
        [MaxLength(4000)] 
        public string? @old_value   { get; set; }
        ///<summary> 
        /// 變更後的值 
        /// </summary> 
        [Column("new_value")] 
        [MaxLength(4000)] 
        public string? @new_value   { get; set; }
}
}
