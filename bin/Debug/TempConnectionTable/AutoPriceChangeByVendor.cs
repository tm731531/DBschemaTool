using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class AutoPriceChangeByVendor
{
        ///<summary> 
        /// 識別碼 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 分組識別變價區間(起~迄)(存啟動時間那一筆的 AutoPriceChangeByVendor.id ) 
        /// </summary> 
        [Column("groupId")] 
        public long @groupId   { get; set; }
        ///<summary> 
        /// 啟動變價時間 
        /// </summary> 
        [Column("startChangeTime")] 
        public DateTime @startChangeTime   { get; set; }
        ///<summary> 
        /// 銷售品號 FK: FRI_FORMAL.SalesMix.saleCode 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 預定變價後的市價 
        /// </summary> 
        [Column("newMarketPrice")] 
        public decimal @newMarketPrice   { get; set; }
        ///<summary> 
        /// 預定變價後的售價 
        /// </summary> 
        [Column("newSalePrice")] 
        public decimal @newSalePrice   { get; set; }
        ///<summary> 
        /// 預定變價後的成本 
        /// </summary> 
        [Column("newCost")] 
        public decimal @newCost   { get; set; }
        ///<summary> 
        /// 變價後的資料異動->FK 關聯到 FRI_MLEC.SalesMixApplication.id 
        /// </summary> 
        [Column("id_salesMixApplication")] 
        public long @id_salesMixApplication   { get; set; }
        ///<summary> 
        /// 狀態：0尚未啟動變價 1已啟動變價 3駁回 
        /// </summary> 
        [Column("status")] 
        public int @status   { get; set; }
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
        /// 帶狀變價的 ID 值，區分資料來源為帶狀變價或區間變價 
        /// </summary> 
        [Column("id_autoIntervalsPriceChangeByVendor")] 
        public long? @id_autoIntervalsPriceChangeByVendor   { get; set; }
}
}
