using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class AuditFlowContext
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 當前步驟編號，關聯到AuditStep裱中的sequenceNO 
        /// </summary> 
        [Column("currentStepNO_AuditStep")] 
        public int @currentStepNO_AuditStep   { get; set; }
        ///<summary> 
        /// 當前流程中的第幾步，是個步驟記錄器 
        /// </summary> 
        [Column("currentRecordNO")] 
        public int @currentRecordNO   { get; set; }
        ///<summary> 
        /// 當前用戶編號,Fk,關聯到正式區User表的id欄位 
        /// </summary> 
        [Column("currentAuditorId_AuditStep")] 
        public long? @currentAuditorId_AuditStep   { get; set; }
        ///<summary> 
        /// 當前步驟描述： 
        /// 0從下一步返回這一步 
        /// 1順利進入這一步 
        /// </summary> 
        [Column("isReturnedFromNextStep")] 
        public byte? @isReturnedFromNextStep   { get; set; }
        ///<summary> 
        /// 當前狀態 
        /// UNDERWAY審核中, 
        /// FINISHED審核完畢 
        /// </summary> 
        [Column("auditState")] 
        [MaxLength(100)] 
        public string? @auditState   { get; set; }
        ///<summary> 
        /// 是否已審核通過 
        /// </summary> 
        [Column("approved")] 
        [MaxLength(20)] 
        public string? @approved   { get; set; }
        ///<summary> 
        /// 範本的id,FK,關聯到臨時區AuditFlowTemplate中的id欄位 
        /// </summary> 
        [Column("id_AuditFlowTemplate")] 
        public long? @id_AuditFlowTemplate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
}
}
