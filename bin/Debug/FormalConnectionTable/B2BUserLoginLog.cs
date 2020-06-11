using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class B2BUserLoginLog
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// User Table 的 id 
        /// </summary> 
        [Column("id_user")] 
        public long? @id_user   { get; set; }
        ///<summary> 
        /// 子帳號 
        /// </summary> 
        [Column("accountName")] 
        [MaxLength(256)] 
        public string? @accountName   { get; set; }
        ///<summary> 
        /// 母帳號 
        /// </summary> 
        [Column("id_vendorParent")] 
        [MaxLength(100)] 
        public string? @id_vendorParent   { get; set; }
        ///<summary> 
        /// 登入時間 
        /// </summary> 
        [Column("LoginInTime")] 
        public DateTime? @LoginInTime   { get; set; }
        ///<summary> 
        /// 是否成功 
        /// </summary> 
        [Column("is_success")] 
        public bool? @is_success   { get; set; }
        ///<summary> 
        /// 瀏覽器資訊(包含裝置) 
        /// </summary> 
        [Column("browser")] 
        [MaxLength(256)] 
        public string? @browser   { get; set; }
        ///<summary> 
        /// 打進來的ip位置 
        /// </summary> 
        [Column("ip")] 
        [MaxLength(50)] 
        public string? @ip   { get; set; }
}
}
