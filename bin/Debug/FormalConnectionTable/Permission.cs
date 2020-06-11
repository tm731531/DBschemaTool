using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Permission
{
        ///<summary> 
        /// 許可權的Id 
        /// </summary> 
        [Column("permissionId")] 
        [MaxLength(100)] 
        public string @permissionId   { get; set; }
        ///<summary> 
        /// 許可權的名稱（中文） 
        /// </summary> 
        [Column("description")] 
        [MaxLength(200)] 
        public string? @description   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PermissionGroupId")] 
        public int? @PermissionGroupId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("url")] 
        public string? @url   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isEnable")] 
        public bool @isEnable   { get; set; }
        ///<summary> 
        /// 排序值 
        /// </summary> 
        [Column("seq")] 
        public int? @seq   { get; set; }
        ///<summary> 
        /// app功能名稱, 長度6個字 
        /// </summary> 
        [Column("appDescription")] 
        [MaxLength(6)] 
        public string? @appDescription   { get; set; }
        ///<summary> 
        /// app功能連結網址 
        /// </summary> 
        [Column("appUrl")] 
        public string? @appUrl   { get; set; }
        ///<summary> 
        /// 功能型態, 1: 網站使用, 2: APP使用, 3: 網站+APP 使用, 4:不顯示出來 
        /// </summary> 
        [Column("type")] 
        public byte? @type   { get; set; }
}
}
