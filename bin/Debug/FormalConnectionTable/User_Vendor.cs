using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class User_Vendor
{
        ///<summary> 
        /// 主鍵id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 用戶帳戶名,FK,關聯到用戶表的accountName 
        /// </summary> 
        [Column("accountName_User")] 
        [MaxLength(256)] 
        public string? @accountName_User   { get; set; }
        ///<summary> 
        /// 供應商代碼，FK，關聯到正式區Vendor表的id 
        /// </summary> 
        [Column("vendorCode_Vendor")] 
        [MaxLength(100)] 
        public string? @vendorCode_Vendor   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
}
}
