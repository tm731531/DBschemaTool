using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class AuditRecord
{
        ///<summary> 
        /// 主鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// FK,關聯到AuditFlowContext中的 id 
        /// </summary> 
        [Column("id_AuditFlowContext")] 
        public long? @id_AuditFlowContext   { get; set; }
        ///<summary> 
        /// 當前是第幾步 
        /// </summary> 
        [Column("squenceNO_AuditStep")] 
        public int @squenceNO_AuditStep   { get; set; }
        ///<summary> 
        /// 歷史記錄描述 
        /// </summary> 
        [Column("description")] 
        [MaxLength(510)] 
        public string? @description   { get; set; }
        ///<summary> 
        /// 當前用戶編號,FK, 關聯到正式區User裱中的id 
        /// </summary> 
        [Column("auditorId_User")] 
        public long? @auditorId_User   { get; set; }
        ///<summary> 
        /// 審核時間 
        /// </summary> 
        [Column("auditTime")] 
        public DateTime @auditTime   { get; set; }
        ///<summary> 
        /// 審核結果 
        /// </summary> 
        [Column("auditResult")] 
        [MaxLength(60)] 
        public string @auditResult   { get; set; }
        ///<summary> 
        /// 審核原因 
        /// </summary> 
        [Column("rejectReason")] 
        [MaxLength(2000)] 
        public string? @rejectReason   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
}
}
