using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SubTitleEventRunItem
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 對應SubTitleEventSetup的ID 
        /// </summary> 
        [Column("id_SubTitleEventSetup")] 
        public long? @id_SubTitleEventSetup   { get; set; }
        ///<summary> 
        /// 商品銷編 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(20)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 活動/回復副標文案 
        /// </summary> 
        [Column("SubTitle")] 
        [MaxLength(510)] 
        public string? @SubTitle   { get; set; }
        ///<summary> 
        /// 開始或結束（回復）時間(排程跑RunType=1要D; RunType=2要D) 
        /// </summary> 
        [Column("ScheduleDate")] 
        public DateTime? @ScheduleDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EndDate")] 
        public DateTime? @EndDate   { get; set; }
        ///<summary> 
        /// 副標執行種類(1是活動副標 2是商品回復副標) 
        /// </summary> 
        [Column("RunType")] 
        public byte? @RunType   { get; set; }
        ///<summary> 
        /// 排程執行更新的時間，到毫秒(UI顯示時到秒) 
        /// </summary> 
        [Column("RunDate")] 
        public DateTime? @RunDate   { get; set; }
        ///<summary> 
        /// N排程未執行 Y排程已執行 D刪除 E錯誤 
        /// </summary> 
        [Column("RunStatus")] 
        [MaxLength(1)] 
        public string? @RunStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 請填執行排程的名稱 
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
        /// 請填執行排程的名稱或修改的使用者姓名(可從UI修改排程結束日期時) 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
}
}
