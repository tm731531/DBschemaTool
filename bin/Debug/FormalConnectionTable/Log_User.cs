using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_User
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accountName")] 
        public string? @accountName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accountPassword")] 
        public string? @accountPassword   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("email")] 
        public string? @email   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("directSuperior")] 
        public string? @directSuperior   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accountType")] 
        public byte? @accountType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("hasLogin")] 
        public bool? @hasLogin   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("effected")] 
        public bool? @effected   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("count")] 
        public long? @count   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("wrongPasswordTimes")] 
        public int? @wrongPasswordTimes   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isChangePassword")] 
        public bool? @isChangePassword   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("enableCode")] 
        public string? @enableCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("userPasswordModifyTime")] 
        public DateTime? @userPasswordModifyTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isLock")] 
        public bool? @isLock   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastLockTime")] 
        public DateTime? @lastLockTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastThreePassword")] 
        public string? @lastThreePassword   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoEmployeeNo")] 
        public string? @fugoEmployeeNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("userPasswordSendTime")] 
        public DateTime? @userPasswordSendTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deputy")] 
        public long? @deputy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("B2BLoginID")] 
        public string? @B2BLoginID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoEmployeeNo2")] 
        public string? @fugoEmployeeNo2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("appDeviceQtyLimits")] 
        public byte @appDeviceQtyLimits   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("userType")] 
        public byte? @userType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("usereType")] 
        public string? @usereType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("workTag")] 
        public string? @workTag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ipList")] 
        public string? @ipList   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UserMobile")] 
        public string? @UserMobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_vendorParent")] 
        public string? @id_vendorParent   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastLoginOn")] 
        public DateTime? @lastLoginOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ip")] 
        public string? @ip   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_action")] 
        [MaxLength(1)] 
        public string? @trg_action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_create_on")] 
        public DateTime @trg_create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        public string? @UpdateUser   { get; set; }
}
}
