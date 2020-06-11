using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class NLog_Error
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LogId")] 
        [Key] 
        public int @LogId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ThreadId")] 
        public int @ThreadId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MachineName")] 
        [MaxLength(255)] 
        public string @MachineName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LogName")] 
        [MaxLength(255)] 
        public string @LogName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LogLevel")] 
        [MaxLength(5)] 
        public string @LogLevel   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LogMessage")] 
        public string @LogMessage   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CallSite")] 
        [MaxLength(1024)] 
        public string @CallSite   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Exception")] 
        [MaxLength(1024)] 
        public string @Exception   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Stacktrace")] 
        [MaxLength(1024)] 
        public string @Stacktrace   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDateTime")] 
        public DateTime @CreateDateTime   { get; set; }
}
}
