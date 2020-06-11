using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Role_Permission
{
        ///<summary> 
        /// 記錄的id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 角色的名稱，FK，參考Role表的name列 
        /// </summary> 
        [Column("roleName_Role")] 
        [MaxLength(510)] 
        public string @roleName_Role   { get; set; }
        ///<summary> 
        /// 許可權編號，FK，參考Permission表PermissionId列 
        /// </summary> 
        [Column("permissionId_Permission")] 
        [MaxLength(100)] 
        public string @permissionId_Permission   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
}
}
