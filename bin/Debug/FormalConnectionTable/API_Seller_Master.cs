using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_Seller_Master
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 富購平台(1: U, 2: E, 3:EU) 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 賣家群組(group_id = null 或 空字串 => 非群組, id = group_id => 群組目錄,group_id <> null and group_id <> id 為 群組成員) 
        /// </summary> 
        [Column("group_id")] 
        public long? @group_id   { get; set; }
        ///<summary> 
        /// 賣家名稱 
        /// </summary> 
        [Column("seller_name")] 
        [MaxLength(50)] 
        public string? @seller_name   { get; set; }
        ///<summary> 
        /// 賣家通路 
        /// </summary> 
        [Column("seller_channel")] 
        [MaxLength(20)] 
        public string? @seller_channel   { get; set; }
        ///<summary> 
        /// 富購通路代碼(新立方:21) 
        /// </summary> 
        [Column("multi_saleno_prefix")] 
        [MaxLength(3)] 
        public string? @multi_saleno_prefix   { get; set; }
        ///<summary> 
        /// 富購客代 
        /// </summary> 
        [Column("fugo_customer_id")] 
        public decimal? @fugo_customer_id   { get; set; }
        ///<summary> 
        /// 富購使用者代碼 
        /// </summary> 
        [Column("fugo_createby")] 
        public decimal? @fugo_createby   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sub_channel_id")] 
        public decimal? @sub_channel_id   { get; set; }
        ///<summary> 
        /// 賣家統一編號 
        /// </summary> 
        [Column("USN")] 
        [MaxLength(8)] 
        public string? @USN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_user")] 
        public long? @id_user   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("extend_setting")] 
        public string? @extend_setting   { get; set; }
        ///<summary> 
        /// 顯示於B2E合作廠商通路清單中 
        /// </summary> 
        [Column("is_show")] 
        public bool? @is_show   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("contact_address_id")] 
        public long @contact_address_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("is_cache")] 
        public bool? @is_cache   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("is_use_pan")] 
        public bool? @is_use_pan   { get; set; }
}
}
