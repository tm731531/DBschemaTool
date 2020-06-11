using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ETU_Redirection
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 使用者類型 
        /// </summary> 
        [Column("user_type")] 
        [MaxLength(20)] 
        public string? @user_type   { get; set; }
        ///<summary> 
        /// 平台(0:其他,1:U,2:E) 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 短網址名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(50)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("valid_key")] 
        public long? @valid_key   { get; set; }
        ///<summary> 
        /// 短網址 
        /// </summary> 
        [Column("url_from")] 
        [MaxLength(200)] 
        public string? @url_from   { get; set; }
        ///<summary> 
        /// 目的網址 
        /// </summary> 
        [Column("url_to")] 
        public string? @url_to   { get; set; }
        ///<summary> 
        /// 結束時間 
        /// </summary> 
        [Column("end_time")] 
        public DateTime? @end_time   { get; set; }
        ///<summary> 
        /// 累計 
        /// </summary> 
        [Column("acc_count")] 
        public long? @acc_count   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleno")] 
        [MaxLength(20)] 
        public string? @saleno   { get; set; }
        ///<summary> 
        /// 修改人(user.id) 
        /// </summary> 
        [Column("update_by")] 
        public long? @update_by   { get; set; }
        ///<summary> 
        /// 更新日期 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("memo")] 
        [MaxLength(100)] 
        public string? @memo   { get; set; }
        ///<summary> 
        /// 建立人(user.id) 
        /// </summary> 
        [Column("create_by")] 
        public long? @create_by   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
}
}
