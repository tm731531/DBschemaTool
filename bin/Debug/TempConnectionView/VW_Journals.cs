using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class VW_Journals
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("journal_id")] 
        public long @journal_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("type")] 
        public byte @type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("journalized_table")] 
        [MaxLength(100)] 
        public string @journalized_table   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("journalized_identity")] 
        [MaxLength(100)] 
        public string @journalized_identity   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("notes")] 
        [MaxLength(200)] 
        public string? @notes   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        [MaxLength(200)] 
        public string @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("created_on")] 
        public DateTime @created_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("journal_detail_id")] 
        public long @journal_detail_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("action")] 
        [MaxLength(4)] 
        public string? @action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("table_name")] 
        [MaxLength(100)] 
        public string @table_name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("table_identity")] 
        [MaxLength(100)] 
        public string @table_identity   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("field")] 
        [MaxLength(100)] 
        public string? @field   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("old_value")] 
        [MaxLength(4000)] 
        public string? @old_value   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("new_value")] 
        [MaxLength(4000)] 
        public string? @new_value   { get; set; }
}
}
