using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class UserActionLog
{
        ///<summary> 
        /// PK（GUID） 
        /// </summary> 
        [Column("ID")] 
        public Guid @ID   { get; set; }
        ///<summary> 
        /// 用戶ID（User.ID） 
        /// </summary> 
        [Column("ID_User")] 
        public long? @ID_User   { get; set; }
        ///<summary> 
        /// 用戶AccountName（User.AccountName） 
        /// </summary> 
        [Column("AccountName_User")] 
        [MaxLength(256)] 
        public string? @AccountName_User   { get; set; }
        ///<summary> 
        /// B2B子帳號之母帳號的AccountName 
        /// </summary> 
        [Column("ID_VendorParent_User")] 
        [MaxLength(100)] 
        public string? @ID_VendorParent_User   { get; set; }
        ///<summary> 
        /// 用戶行為時間 
        /// </summary> 
        [Column("ActionOn")] 
        public DateTime? @ActionOn   { get; set; }
        ///<summary> 
        /// 哪一個網站的Action。如：B2B、B2E、Redeem。 
        /// </summary> 
        [Column("ActionSite")] 
        [MaxLength(20)] 
        public string? @ActionSite   { get; set; }
        ///<summary> 
        /// 用戶行為代碼，前兩碼是網站類型，後4碼是行為 
        /// </summary> 
        [Column("ActionCode")] 
        [MaxLength(20)] 
        public string? @ActionCode   { get; set; }
        ///<summary> 
        /// 用戶行為名稱 
        /// </summary> 
        [Column("ActionName")] 
        [MaxLength(50)] 
        public string? @ActionName   { get; set; }
        ///<summary> 
        /// 用戶行為是否成功執行完成 
        /// </summary> 
        [Column("IsActionSuccess")] 
        public bool? @IsActionSuccess   { get; set; }
        ///<summary> 
        /// 記錄用戶行為補充資訊。（例如：用戶登入失敗，可以將 Error Exception 記錄在這個欄位） 
        /// </summary> 
        [Column("ActionMessage")] 
        [MaxLength(256)] 
        public string? @ActionMessage   { get; set; }
        ///<summary> 
        /// 用戶瀏覽器User-Agent資訊 
        /// </summary> 
        [Column("UserAgent")] 
        [MaxLength(256)] 
        public string? @UserAgent   { get; set; }
        ///<summary> 
        /// 用戶電腦IP 
        /// </summary> 
        [Column("UserIP")] 
        [MaxLength(15)] 
        public string? @UserIP   { get; set; }
}
}
