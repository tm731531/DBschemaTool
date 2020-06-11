using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class CrossIndustryProducts
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
        [Column("SaleName")] 
        [MaxLength(200)] 
        public string @SaleName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ImageUrl")] 
        [MaxLength(200)] 
        public string @ImageUrl   { get; set; }
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
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyUser")] 
        [MaxLength(100)] 
        public string @LastModifyUser   { get; set; }
}
}
