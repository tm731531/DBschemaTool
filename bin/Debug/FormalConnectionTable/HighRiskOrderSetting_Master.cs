using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class HighRiskOrderSetting_Master
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
        [Column("Created")] 
        public DateTime? @Created   { get; set; }
}
}
