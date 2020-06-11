using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MC_EmployeeSpecialPrice
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
        [Column("saleno")] 
        [MaxLength(50)] 
        public string? @saleno   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("employeePrice")] 
        public int? @employeePrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("memo")] 
        [MaxLength(50)] 
        public string? @memo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
