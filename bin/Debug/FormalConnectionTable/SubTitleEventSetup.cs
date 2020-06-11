using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SubTitleEventSetup
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 活動副標文案 
        /// </summary> 
        [Column("SubTitle")] 
        [MaxLength(50)] 
        public string? @SubTitle   { get; set; }
        ///<summary> 
        /// 更新新標題的年月日時分秒 
        /// </summary> 
        [Column("StartDate")] 
        public DateTime? @StartDate   { get; set; }
        ///<summary> 
        /// 回復舊標題的年月日時分秒 
        /// </summary> 
        [Column("EndDate")] 
        public DateTime? @EndDate   { get; set; }
        ///<summary> 
        /// 設定方式: 1是by分類 2是by商品 
        /// </summary> 
        [Column("SetupType")] 
        public byte? @SetupType   { get; set; }
        ///<summary> 
        /// 對應銷售狀態代碼，逗點隔開 
        /// </summary> 
        [Column("SaleStatusList")] 
        [MaxLength(10)] 
        public string? @SaleStatusList   { get; set; }
        ///<summary> 
        /// 0沒勾 1有勾 
        /// </summary> 
        [Column("AuthorizedFlag")] 
        public bool? @AuthorizedFlag   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
}
}
