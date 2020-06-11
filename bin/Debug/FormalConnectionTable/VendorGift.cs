using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VendorGift
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
        [Column("saleCode")] 
        [MaxLength(20)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fr_saleCode")] 
        [MaxLength(20)] 
        public string @fr_saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fr_sort")] 
        public byte @fr_sort   { get; set; }
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
        [Column("id_Vendor")] 
        [MaxLength(50)] 
        public string @id_Vendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte @platform   { get; set; }
}
}
