using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Journals
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 日誌類型,1:商品掛前台分類 
        /// </summary> 
        [Column("type")] 
        public byte @type   { get; set; }
        ///<summary> 
        /// 被記錄的資料,其主要table 
        /// </summary> 
        [Column("journalized_table")] 
        [MaxLength(100)] 
        public string @journalized_table   { get; set; }
        ///<summary> 
        /// 被記錄的資料,其主要table的Identity column 
        /// </summary> 
        [Column("journalized_identity")] 
        [MaxLength(100)] 
        public string @journalized_identity   { get; set; }
        ///<summary> 
        /// 新增這筆記錄的user.id 
        /// </summary> 
        [Column("user_id")] 
        public long @user_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("notes")] 
        [MaxLength(200)] 
        public string? @notes   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("created_on")] 
        public DateTime @created_on   { get; set; }
}
}
