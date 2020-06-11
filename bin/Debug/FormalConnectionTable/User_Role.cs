using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class User_Role
{
        ///<summary> 
        /// 記錄的編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 用戶的帳號,FK,參考User表accountName列 
        /// </summary> 
        [Column("accountName_User")] 
        [MaxLength(256)] 
        public string @accountName_User   { get; set; }
        ///<summary> 
        /// 角色的名稱，FK,參考Role表的name列 
        /// </summary> 
        [Column("roleName_Role")] 
        [MaxLength(100)] 
        public string @roleName_Role   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
}
}
