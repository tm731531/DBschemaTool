using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Log_EStoreMember
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public int? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreNumber")] 
        public string? @EStoreNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Name")] 
        public string? @Name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Mobile")] 
        public string? @Mobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Email")] 
        public string? @Email   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreEnrollDate")] 
        public DateTime? @EStoreEnrollDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public long? @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ETMallCustVerifyCheckDate")] 
        public DateTime? @ETMallCustVerifyCheckDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreStatus")] 
        public string? @EStoreStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public long? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime? @LastModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyUser")] 
        public long? @LastModifyUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreType")] 
        public long? @EStoreType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreReferrerMobile")] 
        public string? @EStoreReferrerMobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RecruitFrom")] 
        public long? @RecruitFrom   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public long? @FugoCustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreReferrerID")] 
        public string? @EStoreReferrerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreRole")] 
        public int? @EStoreRole   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RoleOn")] 
        public DateTime? @RoleOn   { get; set; }
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
}
}
