using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class QueueTicket
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 訂單編號 
        /// </summary> 
        [Column("OrderId")] 
        public long @OrderId   { get; set; }
        ///<summary> 
        /// 訂單項次 
        /// </summary> 
        [Column("ItemId")] 
        public int @ItemId   { get; set; }
        ///<summary> 
        /// 訂單來源平台(1:UMall 2:ETMall) 
        /// </summary> 
        [Column("Platform")] 
        public int? @Platform   { get; set; }
        ///<summary> 
        /// 訂單類別(僅限電子票卷  1008:墨攻商品 1013:聯強票卷 1018:展碁票卷 1020:智冠) 
        /// </summary> 
        [Column("ProductType")] 
        public int? @ProductType   { get; set; }
        ///<summary> 
        /// 票卷類別(2:墨攻商品 3:聯強票卷 4:展碁票卷 5:智冠) 
        /// </summary> 
        [Column("VoucherType")] 
        public int? @VoucherType   { get; set; }
        ///<summary> 
        /// 核銷編號 
        /// </summary> 
        [Column("VoucherNumber")] 
        public string? @VoucherNumber   { get; set; }
        ///<summary> 
        /// 票券編號 
        /// </summary> 
        [Column("VoucherPath")] 
        public string? @VoucherPath   { get; set; }
        ///<summary> 
        /// 是否取票(0:未取票 1:取票中 2:已取票 3:不再取票) 
        /// </summary> 
        [Column("IsGet")] 
        public int? @IsGet   { get; set; }
        ///<summary> 
        /// 取票訊息 
        /// </summary> 
        [Column("Message")] 
        public string? @Message   { get; set; }
        ///<summary> 
        /// 取票次數 
        /// </summary> 
        [Column("Count")] 
        public int? @Count   { get; set; }
        ///<summary> 
        /// 來源(1:Job 定期觸發 2:B2C 同步量API) 
        /// </summary> 
        [Column("Source")] 
        public int? @Source   { get; set; }
        ///<summary> 
        /// 最後取票時間 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 修改人員姓名 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 新增時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 新增人員姓名 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PID")] 
        public long? @PID   { get; set; }
}
}
