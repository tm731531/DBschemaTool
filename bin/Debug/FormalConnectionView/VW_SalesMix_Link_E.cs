using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_SalesMix_Link_E
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo_related")] 
        [MaxLength(60)] 
        public string @FugoSaleNo_related   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SaleCode")] 
        [MaxLength(40)] 
        public string @SaleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SaleCode_related")] 
        [MaxLength(40)] 
        public string @SaleCode_related   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("advertisingCopy")] 
        [MaxLength(25)] 
        public string? @advertisingCopy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Sort")] 
        public byte @Sort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createUser")] 
        [MaxLength(50)] 
        public string @createUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastUpdateTime")] 
        public DateTime @LastUpdateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastUpdateUser")] 
        [MaxLength(50)] 
        public string @LastUpdateUser   { get; set; }
}
}
