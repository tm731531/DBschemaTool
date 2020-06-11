using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_IncreasePurchase_U
{
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
        [Column("seq")] 
        public int @seq   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendor")] 
        [MaxLength(50)] 
        public string @vendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
