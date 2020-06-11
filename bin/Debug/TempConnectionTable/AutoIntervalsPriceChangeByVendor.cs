using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class AutoIntervalsPriceChangeByVendor
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 銷售品號 FK: FRI_FORMAL_UAT.SalesMix.saleCode 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(10)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 變價後的資料異動->FK 關聯到 FRI_MLEC.SalesMixApplication.id 
        /// </summary> 
        [Column("id_salesMixApplication_new")] 
        public long @id_salesMixApplication_new   { get; set; }
        ///<summary> 
        /// 恢復原價後的資料異動->FK 關聯到 FRI_MLEC.SalesMixApplication.id 
        /// </summary> 
        [Column("id_salesMixApplication_initial")] 
        public long @id_salesMixApplication_initial   { get; set; }
        ///<summary> 
        /// 開始日期 
        /// </summary> 
        [Column("dateStart")] 
        public DateTime @dateStart   { get; set; }
        ///<summary> 
        /// 結束日期 
        /// </summary> 
        [Column("dateEnd")] 
        public DateTime @dateEnd   { get; set; }
        ///<summary> 
        /// 每個星期幾，例: 每個星期一~五=> "1,2,3,4,5"，週日為0，以下類推，並以『,』相隔，若無此限制則設為空字串 
        /// </summary> 
        [Column("dayOfWeek")] 
        [MaxLength(13)] 
        public string? @dayOfWeek   { get; set; }
        ///<summary> 
        /// 開始時間 
        /// </summary> 
        [Column("timeStart")] 
        [MaxLength(8)] 
        public string @timeStart   { get; set; }
        ///<summary> 
        /// 結束時間 
        /// </summary> 
        [Column("timeEnd")] 
        [MaxLength(8)] 
        public string @timeEnd   { get; set; }
        ///<summary> 
        /// 是否跨日 
        /// </summary> 
        [Column("isCrossDay")] 
        public bool @isCrossDay   { get; set; }
        ///<summary> 
        /// 狀態：0待審核 1核可 2已變價 3駁回 4取消 5JOB失敗 6已結束 
        /// </summary> 
        [Column("status")] 
        public byte @status   { get; set; }
        ///<summary> 
        /// 下次執行時間 
        /// </summary> 
        [Column("nextExecuteTime")] 
        public DateTime? @nextExecuteTime   { get; set; }
        ///<summary> 
        /// 建立者 
        /// </summary> 
        [Column("createUser")] 
        public long @createUser   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 修改者 
        /// </summary> 
        [Column("lastUpdateUser")] 
        public long? @lastUpdateUser   { get; set; }
        ///<summary> 
        /// 修改時間 
        /// </summary> 
        [Column("lastUpdateTime")] 
        public DateTime? @lastUpdateTime   { get; set; }
}
}
