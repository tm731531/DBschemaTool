using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class UserActivityLog
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 操作業務物件(商品,會員或訂單資料) 
        /// </summary> 
        [Column("domainName")] 
        [MaxLength(100)] 
        public string @domainName   { get; set; }
        ///<summary> 
        /// 操作業務物件唯一鍵 
        /// </summary> 
        [Column("domainKey")] 
        [MaxLength(40)] 
        public string? @domainKey   { get; set; }
        ///<summary> 
        /// 操作業務物件中的變動數值(商品,會員或訂單資料) 
        /// </summary> 
        [Column("domainContent")] 
        public  @domainContent   { get; set; }
        ///<summary> 
        /// 使用者帳號 
        /// </summary> 
        [Column("accountName_User")] 
        [MaxLength(256)] 
        public string @accountName_User   { get; set; }
        ///<summary> 
        /// 記錄操作者的真實IP 
        /// </summary> 
        [Column("ip")] 
        [MaxLength(100)] 
        public string @ip   { get; set; }
        ///<summary> 
        /// 記錄操作時間 
        /// </summary> 
        [Column("activityTime")] 
        public DateTime @activityTime   { get; set; }
}
}
