using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class CrossIndustryProductsLog
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
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsDelete")] 
        public bool @IsDelete   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CrossIndustryPartnetsID")] 
        public long @CrossIndustryPartnetsID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreatedDate")] 
        public DateTime @CreatedDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreatedUser")] 
        [MaxLength(100)] 
        public string @CreatedUser   { get; set; }
}
}
