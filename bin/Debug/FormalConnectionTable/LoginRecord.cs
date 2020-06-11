using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class LoginRecord
{
        ///<summary> 
        /// 記錄編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 用戶帳號,FK,參考User表accountName列 
        /// </summary> 
        [Column("accountName")] 
        [MaxLength(256)] 
        public string @accountName   { get; set; }
        ///<summary> 
        /// 登錄時間 
        /// </summary> 
        [Column("time")] 
        public DateTime @time   { get; set; }
        ///<summary> 
        /// 登錄機器地址 
        /// </summary> 
        [Column("IP")] 
        [MaxLength(100)] 
        public string @IP   { get; set; }
        ///<summary> 
        /// 登錄成功標誌位元(1成功，0失敗) 
        /// </summary> 
        [Column("flag")] 
        public bool @flag   { get; set; }
        ///<summary> 
        /// 最後更新時間戳 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
}
}
