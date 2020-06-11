using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Vendor_APIList
{
        ///<summary> 
        /// PK，流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// Vendor 統編 
        /// </summary> 
        [Column("VendorUnifiedSerialNumber")] 
        [MaxLength(100)] 
        public string @VendorUnifiedSerialNumber   { get; set; }
        ///<summary> 
        /// ApiList 的Id 
        /// </summary> 
        [Column("id_APIList")] 
        public long @id_APIList   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
        ///<summary> 
        /// 建立人員 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
}
}
