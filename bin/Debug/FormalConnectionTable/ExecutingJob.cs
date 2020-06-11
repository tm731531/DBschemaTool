using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ExecutingJob
{
        ///<summary> 
        /// 主鍵id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 排程類型 
        /// </summary> 
        [Column("jobType")] 
        [MaxLength(200)] 
        public string @jobType   { get; set; }
        ///<summary> 
        /// 是否正在執行中 
        /// </summary> 
        [Column("isExecuting")] 
        public bool @isExecuting   { get; set; }
        ///<summary> 
        /// 開始執行時間 
        /// </summary> 
        [Column("startExecuteTime")] 
        public DateTime @startExecuteTime   { get; set; }
        ///<summary> 
        /// 結束執行時間 
        /// </summary> 
        [Column("endExecuteTime")] 
        public DateTime? @endExecuteTime   { get; set; }
        ///<summary> 
        /// 執行程式所在Server的IP 
        /// </summary> 
        [Column("serverIP")] 
        [MaxLength(200)] 
        public string @serverIP   { get; set; }
        ///<summary> 
        /// 當次執行狀態(R:執行中,P:成功執行完畢,F:執行失敗) 
        /// </summary> 
        [Column("ExecutionStatus")] 
        [MaxLength(1)] 
        public string? @ExecutionStatus   { get; set; }
}
}
