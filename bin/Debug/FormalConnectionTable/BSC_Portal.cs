using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BSC_Portal
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AreaName")] 
        [MaxLength(50)] 
        public string @AreaName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RoleId")] 
        public int @RoleId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SupplierCode")] 
        public int? @SupplierCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LogoURI")] 
        [MaxLength(500)] 
        public string @LogoURI   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(50)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AccountName")] 
        [MaxLength(50)] 
        public string? @AccountName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PermissionName")] 
        [MaxLength(100)] 
        public string? @PermissionName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PermissionGroupId")] 
        public int? @PermissionGroupId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Remark")] 
        [MaxLength(500)] 
        public string? @Remark   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Enabled")] 
        public bool @Enabled   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Creater")] 
        [MaxLength(50)] 
        public string @Creater   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateTime")] 
        public DateTime @CreateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Editer")] 
        [MaxLength(50)] 
        public string? @Editer   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EditTime")] 
        public DateTime? @EditTime   { get; set; }
}
}
