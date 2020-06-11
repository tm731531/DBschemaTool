using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreEventProduct
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 銷編 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EShareRatioEvent")] 
        public decimal @EShareRatioEvent   { get; set; }
        ///<summary> 
        /// 
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
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
        ///<summary> 
        /// 類型 1:一般商品/2:美麗站長 
        /// </summary> 
        [Column("ProductType")] 
        public int? @ProductType   { get; set; }
}
}
