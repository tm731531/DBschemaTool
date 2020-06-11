using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwVendorStatusAndProduct
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TotalVendor")] 
        public int? @TotalVendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OpenVendor")] 
        public int? @OpenVendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EnableVendor")] 
        public int? @EnableVendor   { get; set; }
}
}
