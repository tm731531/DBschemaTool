using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class AnyBuyDepartment
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DepartName")] 
        [MaxLength(200)] 
        public string @DepartName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Sort")] 
        public byte @Sort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DepartManager")] 
        [MaxLength(50)] 
        public string @DepartManager   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DepartManagerEmail")] 
        [MaxLength(200)] 
        public string @DepartManagerEmail   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductPlanning")] 
        [MaxLength(100)] 
        public string? @ProductPlanning   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductPlanningEmail")] 
        [MaxLength(500)] 
        public string? @ProductPlanningEmail   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductDevStaff")] 
        [MaxLength(100)] 
        public string? @ProductDevStaff   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductDevStaffEmail")] 
        [MaxLength(500)] 
        public string? @ProductDevStaffEmail   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seq_FrontendProductCategory")] 
        public long? @seq_FrontendProductCategory   { get; set; }
}
}
