using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class DW_SalesStatistics
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("companytype")] 
        [MaxLength(10)] 
        public string @companytype   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("last3d")] 
        public int? @last3d   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("last7d")] 
        public int? @last7d   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("last14d")] 
        public int? @last14d   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("modifiedDate")] 
        public DateTime? @modifiedDate   { get; set; }
}
}
