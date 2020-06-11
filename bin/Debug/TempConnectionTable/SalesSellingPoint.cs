using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SalesSellingPoint
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// MongoDB(Mall->Product-) 提報編號 
        /// </summary> 
        [Column("id_product")] 
        public long @id_product   { get; set; }
        ///<summary> 
        /// 商品編號 
        /// </summary> 
        [Column("FugoProductID")] 
        [MaxLength(60)] 
        public string? @FugoProductID   { get; set; }
        ///<summary> 
        /// 建立者 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 送審時間 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// EJob 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
        ///<summary> 
        /// 商品編號傳回時間 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
}
}
