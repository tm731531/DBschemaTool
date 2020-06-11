using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class TempMA
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryId")] 
        public long @categoryId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryName")] 
        [MaxLength(100)] 
        public string @categoryName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("eType")] 
        [MaxLength(100)] 
        public string @eType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoEmployeeName")] 
        [MaxLength(100)] 
        public string @fugoEmployeeName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoEmployeeNo")] 
        [MaxLength(6)] 
        public string @fugoEmployeeNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoVendorName")] 
        [MaxLength(100)] 
        public string @fugoVendorName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoVendorId")] 
        [MaxLength(100)] 
        public string @fugoVendorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isEnable")] 
        public bool @isEnable   { get; set; }
}
}
