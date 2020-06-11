using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreMember
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 店主代碼 
        /// </summary> 
        [Column("EStoreNumber")] 
        [MaxLength(12)] 
        public string? @EStoreNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(50)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 電話(手機) 
        /// </summary> 
        [Column("Mobile")] 
        [MaxLength(15)] 
        public string @Mobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Email")] 
        [MaxLength(100)] 
        public string? @Email   { get; set; }
        ///<summary> 
        /// 加入日期 
        /// </summary> 
        [Column("EStoreEnrollDate")] 
        public DateTime? @EStoreEnrollDate   { get; set; }
        ///<summary> 
        /// 東森購物網路客代 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public int? @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 東森購物會員勾稽到的日期 
        /// </summary> 
        [Column("ETMallCustVerifyCheckDate")] 
        public DateTime? @ETMallCustVerifyCheckDate   { get; set; }
        ///<summary> 
        /// 店主狀態（正常/凍結/停權）Y/N/NULL 
        /// </summary> 
        [Column("EStoreStatus")] 
        [MaxLength(1)] 
        public string? @EStoreStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public int @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyUser")] 
        public int @LastModifyUser   { get; set; }
        ///<summary> 
        /// 店主類型(1: 實習店主, 2: 一般店主) 
        /// </summary> 
        [Column("EStoreType")] 
        public byte @EStoreType   { get; set; }
        ///<summary> 
        /// 推薦人手機號碼 
        /// </summary> 
        [Column("EStoreReferrerMobile")] 
        [MaxLength(15)] 
        public string? @EStoreReferrerMobile   { get; set; }
        ///<summary> 
        /// 招募來源 
        /// </summary> 
        [Column("RecruitFrom")] 
        public byte? @RecruitFrom   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public int @FugoCustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreReferrerID")] 
        [MaxLength(20)] 
        public string? @EStoreReferrerID   { get; set; }
        ///<summary> 
        /// 店主專案角色 
        /// </summary> 
        [Column("EStoreRole")] 
        public byte @EStoreRole   { get; set; }
        ///<summary> 
        /// 店主加入時間 
        /// </summary> 
        [Column("RoleOn")] 
        public DateTime? @RoleOn   { get; set; }
}
}
