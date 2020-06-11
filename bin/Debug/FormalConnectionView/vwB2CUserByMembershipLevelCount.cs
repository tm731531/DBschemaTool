using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwB2CUserByMembershipLevelCount
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MemInfo")] 
        [MaxLength(15)] 
        public string? @MemInfo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("StatusInfo")] 
        [MaxLength(8)] 
        public string? @StatusInfo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SMSInfo")] 
        [MaxLength(19)] 
        public string? @SMSInfo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MemCount")] 
        public int? @MemCount   { get; set; }
}
}
