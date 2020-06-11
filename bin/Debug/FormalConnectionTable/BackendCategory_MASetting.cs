using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BackendCategory_MASetting
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_BackendCategory")] 
        public long @id_BackendCategory   { get; set; }
        ///<summary> 
        /// 0: 全通路, 其他同sm.eType 
        /// </summary> 
        [Column("eType")] 
        public byte @eType   { get; set; }
        ///<summary> 
        /// FUGO員編 
        /// </summary> 
        [Column("FugoEmployeeNo")] 
        [MaxLength(6)] 
        public string @FugoEmployeeNo   { get; set; }
        ///<summary> 
        /// 廠商編號 
        /// </summary> 
        [Column("FugoVendorId")] 
        [MaxLength(100)] 
        public string @FugoVendorId   { get; set; }
        ///<summary> 
        /// 狀態(1=啓用/0=停用,預設1) 
        /// </summary> 
        [Column("IsEnable")] 
        public bool @IsEnable   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
}
}
