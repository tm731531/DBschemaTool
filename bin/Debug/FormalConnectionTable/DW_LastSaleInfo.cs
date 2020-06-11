using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class DW_LastSaleInfo
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
        [Column("companyType")] 
        [MaxLength(10)] 
        public string? @companyType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleno")] 
        [MaxLength(15)] 
        public string? @saleno   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoColorId")] 
        public short? @fugoColorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoStyleId")] 
        public short? @fugoStyleId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoVendorId")] 
        [MaxLength(12)] 
        public string? @fugoVendorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("last3")] 
        public decimal? @last3   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("last7")] 
        public decimal? @last7   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("last14")] 
        public decimal? @last14   { get; set; }
        ///<summary> 
        /// 月銷量 
        /// </summary> 
        [Column("last30")] 
        public decimal? @last30   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
