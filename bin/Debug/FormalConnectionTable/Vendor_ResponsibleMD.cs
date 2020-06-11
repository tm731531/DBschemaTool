using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Vendor_ResponsibleMD
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// Vendor.id 
        /// </summary> 
        [Column("id_Vendor")] 
        [MaxLength(100)] 
        public string @id_Vendor   { get; set; }
        ///<summary> 
        /// 使用者識別碼 FK Formal.User.id 
        /// </summary> 
        [Column("id_MD")] 
        public long @id_MD   { get; set; }
        ///<summary> 
        /// 建立者，FK,關聯到FRI_FORMAL.User.id 
        /// </summary> 
        [Column("createUser")] 
        public long @createUser   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 最後更新者，FK,關聯到FRI_FORMAL.User.id 
        /// </summary> 
        [Column("lastUpdateUser")] 
        public long? @lastUpdateUser   { get; set; }
        ///<summary> 
        /// 最後更新時間 
        /// </summary> 
        [Column("lastUpdateTime")] 
        public DateTime? @lastUpdateTime   { get; set; }
}
}
