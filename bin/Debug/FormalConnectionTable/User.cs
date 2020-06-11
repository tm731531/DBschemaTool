using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class User
{
        ///<summary> 
        /// 用戶編號id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 用戶帳號。(如果是B2B用戶，則對應到 vendor.id 欄位) 
        /// </summary> 
        [Column("accountName")] 
        [MaxLength(256)] 
        public string @accountName   { get; set; }
        ///<summary> 
        /// 用戶密碼 
        /// </summary> 
        [Column("accountPassword")] 
        [MaxLength(256)] 
        public string @accountPassword   { get; set; }
        ///<summary> 
        /// 用戶的名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(200)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 郵箱 
        /// </summary> 
        [Column("email")] 
        [MaxLength(256)] 
        public string @email   { get; set; }
        ///<summary> 
        /// 直屬(user.accountName) 
        /// </summary> 
        [Column("directSuperior")] 
        [MaxLength(400)] 
        public string? @directSuperior   { get; set; }
        ///<summary> 
        /// 帳戶類型。 
        /// 1：B2B 廠商（搭配 id_vendorParent 欄位，id_vendorParent 是 Null 表示是 B2B 母廠商帳號，id_vendorParent 不是 Null 表示是 B2B 子廠商帳號）； 
        /// 2：B2E 用戶； 
        /// 3：API/JOB。 
        /// </summary> 
        [Column("accountType")] 
        public byte? @accountType   { get; set; }
        ///<summary> 
        /// 判斷是否已登陸 
        /// </summary> 
        [Column("hasLogin")] 
        public bool @hasLogin   { get; set; }
        ///<summary> 
        /// 判斷是否有效(1有效，0無效) 
        /// </summary> 
        [Column("effected")] 
        public bool @effected   { get; set; }
        ///<summary> 
        /// 記錄登陸次數 
        /// </summary> 
        [Column("count")] 
        public long? @count   { get; set; }
        ///<summary> 
        /// 用戶登錄失敗次數 
        /// </summary> 
        [Column("wrongPasswordTimes")] 
        public int @wrongPasswordTimes   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 是否強制修改密碼 1為強制修改 
        /// </summary> 
        [Column("isChangePassword")] 
        public bool? @isChangePassword   { get; set; }
        ///<summary> 
        /// 帳號啟用碼 
        /// </summary> 
        [Column("enableCode")] 
        [MaxLength(240)] 
        public string? @enableCode   { get; set; }
        ///<summary> 
        /// 密碼最後修改時間 
        /// </summary> 
        [Column("userPasswordModifyTime")] 
        public DateTime? @userPasswordModifyTime   { get; set; }
        ///<summary> 
        /// 帳號是否鎖定,1:鎖定 
        /// </summary> 
        [Column("isLock")] 
        public bool? @isLock   { get; set; }
        ///<summary> 
        /// 上次帳號鎖定時間 
        /// </summary> 
        [Column("lastLockTime")] 
        public DateTime? @lastLockTime   { get; set; }
        ///<summary> 
        /// 前三次密碼集合（用;分割）例如***;***;*** 
        /// </summary> 
        [Column("lastThreePassword")] 
        [MaxLength(512)] 
        public string? @lastThreePassword   { get; set; }
        ///<summary> 
        /// 富購員工編號 (VWXIT_EMPLOYEE.EmployeeNo) 
        /// </summary> 
        [Column("fugoEmployeeNo")] 
        [MaxLength(6)] 
        public string? @fugoEmployeeNo   { get; set; }
        ///<summary> 
        /// 密碼發送日期 
        /// </summary> 
        [Column("userPasswordSendTime")] 
        public DateTime? @userPasswordSendTime   { get; set; }
        ///<summary> 
        /// 巳作廢(請參考deputy資料表) 
        /// </summary> 
        [Column("deputy")] 
        public long? @deputy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("B2BLoginID")] 
        [MaxLength(50)] 
        public string? @B2BLoginID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoEmployeeNo2")] 
        [MaxLength(6)] 
        public string? @fugoEmployeeNo2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 申請使用行動裝置數量限制 
        /// </summary> 
        [Column("appDeviceQtyLimits")] 
        public byte @appDeviceQtyLimits   { get; set; }
        ///<summary> 
        /// 0: 未設定  1:網路User, 2:電視User 
        /// </summary> 
        [Column("userType")] 
        public byte? @userType   { get; set; }
        ///<summary> 
        /// 屬哪一線別的開發來源(=eType) 
        /// </summary> 
        [Column("usereType")] 
        [MaxLength(2)] 
        public string? @usereType   { get; set; }
        ///<summary> 
        /// C是館長，B1是B2B的一般，B2是B2B票券 
        /// </summary> 
        [Column("workTag")] 
        [MaxLength(100)] 
        public string? @workTag   { get; set; }
        ///<summary> 
        /// RepApi-B2C網站帳號(userforweb) 
        /// </summary> 
        [Column("ipList")] 
        [MaxLength(200)] 
        public string? @ipList   { get; set; }
        ///<summary> 
        /// 手機 
        /// </summary> 
        [Column("UserMobile")] 
        [MaxLength(100)] 
        public string? @UserMobile   { get; set; }
        ///<summary> 
        /// 子帳號的母公司id = user.AccountName 
        /// </summary> 
        [Column("id_vendorParent")] 
        [MaxLength(100)] 
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
        [MaxLength(100)] 
        public string? @ip   { get; set; }
        ///<summary> 
        /// 用戶建立時間。(2019/10/14增加此欄位) 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
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
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
}
}
