using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesMix_Link
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 主商商品識別 FK Formal.salesMix.saleCode 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 關聯商品識別 FK Formal.salesMix.saleCode 
        /// </summary> 
        [Column("saleCode_related")] 
        [MaxLength(40)] 
        public string @saleCode_related   { get; set; }
        ///<summary> 
        /// 促銷文案 
        /// </summary> 
        [Column("advertisingCopy")] 
        [MaxLength(200)] 
        public string? @advertisingCopy   { get; set; }
        ///<summary> 
        /// 建立者=活動負責人，FK,關聯到FRI_FORMAL.User.id 
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
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("umallLink")] 
        [MaxLength(1000)] 
        public string? @umallLink   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("etmallLink")] 
        [MaxLength(1000)] 
        public string? @etmallLink   { get; set; }
}
}
