using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class CurrentAuditLevel
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salesMixType")] 
        public int @salesMixType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sequenceNO")] 
        public int @sequenceNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("auditRole")] 
        [MaxLength(150)] 
        public string @auditRole   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("currentStep")] 
        public int @currentStep   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rejectStep")] 
        public int @rejectStep   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("nextStep")] 
        public int @nextStep   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("description")] 
        [MaxLength(100)] 
        public string @description   { get; set; }
}
}
