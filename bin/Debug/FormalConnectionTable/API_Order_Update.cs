using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_Order_Update
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
        [Column("api_order_id")] 
        public long? @api_order_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("buyer_order_id")] 
        [MaxLength(30)] 
        public string? @buyer_order_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("domain_key")] 
        [MaxLength(50)] 
        public string? @domain_key   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("description")] 
        public string? @description   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
}
}
