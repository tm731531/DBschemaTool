using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProfitSettingOfVendor
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
        [Column("vendorCode_Vendor")] 
        [MaxLength(100)] 
        public string @vendorCode_Vendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryId")] 
        public long @categoryId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossProfitTVS")] 
        public decimal @grossProfitTVS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("grossMarginTVS")] 
        public decimal @grossMarginTVS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        public long @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_by")] 
        public long? @update_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
}
}
