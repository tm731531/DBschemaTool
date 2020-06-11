using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class BookingPriceChange
{
        ///<summary> 
        /// 預約變價流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 群組編號(預約變價無用途，單純記錄批次執行的所有銷編會相同) 
        /// </summary> 
        [Column("GroupId")] 
        public long @GroupId   { get; set; }
        ///<summary> 
        /// 啟動變價時間 
        /// </summary> 
        [Column("StartChangeTime")] 
        public DateTime @StartChangeTime   { get; set; }
        ///<summary> 
        /// 網站編號 
        /// </summary> 
        [Column("SaleCode")] 
        [MaxLength(40)] 
        public string @SaleCode   { get; set; }
        ///<summary> 
        /// 修改市價 
        /// </summary> 
        [Column("NewMarketPrice")] 
        public decimal @NewMarketPrice   { get; set; }
        ///<summary> 
        /// 修改優惠價 
        /// </summary> 
        [Column("NewSalePrice")] 
        public decimal @NewSalePrice   { get; set; }
        ///<summary> 
        /// 修改成本 
        /// </summary> 
        [Column("NewCost")] 
        public decimal @NewCost   { get; set; }
        ///<summary> 
        /// SMA編號(變價送審都會新增一筆SalesMixApplication) 
        /// </summary> 
        [Column("Id_SalesMixApplication")] 
        public long @Id_SalesMixApplication   { get; set; }
        ///<summary> 
        /// 變價狀態 
        /// </summary> 
        [Column("Status")] 
        public byte @Status   { get; set; }
        ///<summary> 
        /// 建檔人員 
        /// </summary> 
        [Column("CreateUser")] 
        public long @CreateUser   { get; set; }
        ///<summary> 
        /// 建檔時間 
        /// </summary> 
        [Column("CreateTime")] 
        public DateTime @CreateTime   { get; set; }
        ///<summary> 
        /// 修改人員 
        /// </summary> 
        [Column("LastUpdateUser")] 
        public long? @LastUpdateUser   { get; set; }
        ///<summary> 
        /// 修改時間 
        /// </summary> 
        [Column("LastUpdateTime")] 
        public DateTime? @LastUpdateTime   { get; set; }
        ///<summary> 
        /// 預約變價編號(刪除對應的流水號) 
        /// </summary> 
        [Column("Id_BookingPriceChange")] 
        public long? @Id_BookingPriceChange   { get; set; }
        ///<summary> 
        /// 註解 
        /// </summary> 
        [Column("Note")] 
        [MaxLength(128)] 
        public string? @Note   { get; set; }
}
}
