using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SocialEventProduct
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 社交電商種類;1: 網連通 2:購享賺 
        /// </summary> 
        [Column("SocialType")] 
        public byte? @SocialType   { get; set; }
        ///<summary> 
        /// 此欄位不使用 
        /// </summary> 
        [Column("ProductType")] 
        public int? @ProductType   { get; set; }
        ///<summary> 
        /// 商品銷編 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 商品特殊分潤比例 
        /// </summary> 
        [Column("RatioEvent")] 
        public decimal @RatioEvent   { get; set; }
        ///<summary> 
        /// 到期日 
        /// </summary> 
        [Column("ExpirationDate")] 
        public DateTime? @ExpirationDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EventRule")] 
        [MaxLength(2000)] 
        public string? @EventRule   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
}
}
