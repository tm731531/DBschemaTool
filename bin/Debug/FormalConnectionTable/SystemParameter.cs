using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SystemParameter
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 對應碼 
        /// </summary> 
        [Column("name")] 
        [MaxLength(300)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 設定值 
        /// </summary> 
        [Column("value")] 
        [MaxLength(2048)] 
        public string @value   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("reworkTime")] 
        public DateTime? @reworkTime   { get; set; }
        ///<summary> 
        /// 描述 
        /// </summary> 
        [Column("description")] 
        [MaxLength(200)] 
        public string? @description   { get; set; }
        ///<summary> 
        /// 是否加密 
        /// </summary> 
        [Column("isEncrypt")] 
        public bool? @isEncrypt   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
