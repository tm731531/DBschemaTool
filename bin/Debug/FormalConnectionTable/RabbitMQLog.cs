using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class RabbitMQLog
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNos")] 
        public string? @FugoSaleNos   { get; set; }
        ///<summary> 
        /// RedAPI、Publish 
        /// </summary> 
        [Column("Events")] 
        [MaxLength(20)] 
        public string? @Events   { get; set; }
        ///<summary> 
        /// JSON 內容 
        /// </summary> 
        [Column("Data")] 
        public string? @Data   { get; set; }
        ///<summary> 
        /// RMQ RoutingKey 內容 
        /// </summary> 
        [Column("RoutingKey")] 
        [MaxLength(100)] 
        public string? @RoutingKey   { get; set; }
        ///<summary> 
        /// 發送結果(1:成功, 0:失敗) 
        /// </summary> 
        [Column("PublishStatus")] 
        public bool? @PublishStatus   { get; set; }
        ///<summary> 
        /// 所有本地端的 IP 
        /// </summary> 
        [Column("LocalIP")] 
        [MaxLength(100)] 
        public string? @LocalIP   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Memo")] 
        public string? @Memo   { get; set; }
        ///<summary> 
        /// 建立時間, GetDate() 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
}
}
