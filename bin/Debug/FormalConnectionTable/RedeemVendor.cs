using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class RedeemVendor
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 廠商編號(vendor.id) 
        /// </summary> 
        [Column("VendorId")] 
        [MaxLength(100)] 
        public string @VendorId   { get; set; }
        ///<summary> 
        /// 公司統一編號(vendor.unifiedSerialNumber) 
        /// </summary> 
        [Column("UnifiedSerialNumber")] 
        [MaxLength(100)] 
        public string? @UnifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 廠商墨攻核銷代碼(由墨攻提供) 
        /// </summary> 
        [Column("RedeemIdentity")] 
        [MaxLength(50)] 
        public string @RedeemIdentity   { get; set; }
        ///<summary> 
        /// 廠商墨攻金鑰(由墨攻提供) 
        /// </summary> 
        [Column("RedeemFlatFormId")] 
        [MaxLength(150)] 
        public string @RedeemFlatFormId   { get; set; }
        ///<summary> 
        /// 新增時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
        ///<summary> 
        /// 新增者 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
}
}
