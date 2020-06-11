using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class AuditStep
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 工作流範本編號,FK,參照AuditFlowTemplate表中的id列 
        /// </summary> 
        [Column("id_AuditFlowTemplate")] 
        public long @id_AuditFlowTemplate   { get; set; }
        ///<summary> 
        /// 範本的每個工作流程的編號 
        /// </summary> 
        [Column("sequenceNO")] 
        public int @sequenceNO   { get; set; }
        ///<summary> 
        /// 執行此流程所應有的群組 
        /// </summary> 
        [Column("auditRole")] 
        [MaxLength(510)] 
        public string @auditRole   { get; set; }
        ///<summary> 
        /// 進入此步驟的狀態ID,關聯到ObjectStatus裱中的Id 
        /// </summary> 
        [Column("appStateFromPreviousStep_ObjectStatus")] 
        public long? @appStateFromPreviousStep_ObjectStatus   { get; set; }
        ///<summary> 
        /// 由上一步返回的狀態ID 關聯到ObjectStatus裱中的Id 
        /// </summary> 
        [Column("appStateFromNextStep_ObjectStatus")] 
        public long? @appStateFromNextStep_ObjectStatus   { get; set; }
        ///<summary> 
        /// 針對此流程步驟的描述 
        /// </summary> 
        [Column("description")] 
        [MaxLength(510)] 
        public string? @description   { get; set; }
        ///<summary> 
        /// 外部程式 
        /// </summary> 
        [Column("externalProgram")] 
        [MaxLength(510)] 
        public string? @externalProgram   { get; set; }
        ///<summary> 
        /// 逾期天數 
        /// </summary> 
        [Column("dueTime")] 
        public int? @dueTime   { get; set; }
        ///<summary> 
        /// Email通知信物件 
        /// </summary> 
        [Column("ccList")] 
        [MaxLength(510)] 
        public string? @ccList   { get; set; }
        ///<summary> 
        /// 人員分配策略 
        /// 後臺分類策略:BACKEND_CATEGORY_BASED_ASSIGN_STRATEGY; 
        /// 供應商分配策略:VENDOR_BASED_ASSIGN_STRATEGY; 
        /// 指派人員策略:AUDITOR_ASSIGN_STRATEGY 
        /// </summary> 
        [Column("auditorAssignStrategy")] 
        [MaxLength(510)] 
        public string? @auditorAssignStrategy   { get; set; }
        ///<summary> 
        /// 流程狀態: INITIAL_STEP:審核通過;NORMAL_STEP:處理中;FINAL_STEP:駁回 
        /// </summary> 
        [Column("stepType")] 
        [MaxLength(40)] 
        public string? @stepType   { get; set; }
}
}
