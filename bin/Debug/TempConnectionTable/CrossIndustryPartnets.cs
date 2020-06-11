using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class CrossIndustryPartnets
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
        [Column("VendorCode")] 
        [MaxLength(50)] 
        public string @VendorCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorUriName")] 
        [MaxLength(50)] 
        public string @VendorUriName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoCustID")] 
        public int @FugoCustID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UnifiedSerialNumber")] 
        [MaxLength(8)] 
        public string? @UnifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Enable")] 
        public bool @Enable   { get; set; }
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
