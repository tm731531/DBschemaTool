using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Bank
{
        ///<summary> 
        /// 自動編號 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 銀行名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(400)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// true:資料已作廢, 視同實際從 table  中刪除此筆 record 
        /// </summary> 
        [Column("isDeleted")] 
        public bool? @isDeleted   { get; set; }
        ///<summary> 
        /// 銀行代碼 
        /// </summary> 
        [Column("code")] 
        [MaxLength(200)] 
        public string? @code   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌[lastUpdated] 
        /// </summary> 
        [Column("lastUpdated")] 
        public long? @lastUpdated   { get; set; }
}
}
