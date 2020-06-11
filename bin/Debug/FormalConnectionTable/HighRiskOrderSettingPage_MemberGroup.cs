using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class HighRiskOrderSettingPage_MemberGroup
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Detail_ID")] 
        public long? @Detail_ID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Level")] 
        [MaxLength(10)] 
        public string? @Level   { get; set; }
}
}
