using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesMix_Related
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 主商商品識別 FK Formal.salesMix.FugoSaleNo 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 關聯商品識別 FK Formal.salesMix.FugoSaleNo 
        /// </summary> 
        [Column("FugoSaleNo_related")] 
        [MaxLength(60)] 
        public string @FugoSaleNo_related   { get; set; }
        ///<summary> 
        /// 主商商品識別 FK Formal.salesMix.saleCode 
        /// </summary> 
        [Column("SaleCode")] 
        [MaxLength(40)] 
        public string @SaleCode   { get; set; }
        ///<summary> 
        /// 關聯商品識別 FK Formal.salesMix.saleCode 
        /// </summary> 
        [Column("SaleCode_related")] 
        [MaxLength(40)] 
        public string @SaleCode_related   { get; set; }
        ///<summary> 
        /// 關聯商品顯示名稱 
        /// </summary> 
        [Column("AdvertisingContent")] 
        [MaxLength(25)] 
        public string? @AdvertisingContent   { get; set; }
        ///<summary> 
        /// 排序值 
        /// </summary> 
        [Column("Sort")] 
        public byte @Sort   { get; set; }
        ///<summary> 
        /// 建立者=活動負責人 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 最後更新者 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string @ModifyUser   { get; set; }
        ///<summary> 
        /// 最後更新時間 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime @ModifyDate   { get; set; }
}
}
