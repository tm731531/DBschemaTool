using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class TicketRecycling
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 回收票券編號 
        /// </summary> 
        [Column("TokenNo")] 
        [MaxLength(200)] 
        public string @TokenNo   { get; set; }
        ///<summary> 
        /// 兌換東森幣枚數 
        /// </summary> 
        [Column("Money")] 
        public int @Money   { get; set; }
        ///<summary> 
        /// 回收兌換票券資訊(Json格式) 
        /// </summary> 
        [Column("RecyclingJson")] 
        [MaxLength(1000)] 
        public string? @RecyclingJson   { get; set; }
        ///<summary> 
        /// 對應的前台客代 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public int? @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 對應的富購客代 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public int? @FugoCustomerID   { get; set; }
        ///<summary> 
        /// B2C回應票券資訊(Json格式) 
        /// </summary> 
        [Column("ETMallResponsJson")] 
        [MaxLength(1000)] 
        public string? @ETMallResponsJson   { get; set; }
        ///<summary> 
        /// 呼叫富構加給東森幣資訊(Json格式) 
        /// </summary> 
        [Column("FugoRequestJson")] 
        [MaxLength(1000)] 
        public string? @FugoRequestJson   { get; set; }
        ///<summary> 
        /// 富構回應加給東森幣資訊(Json格式) 
        /// </summary> 
        [Column("FugoResponseJson")] 
        [MaxLength(1000)] 
        public string? @FugoResponseJson   { get; set; }
        ///<summary> 
        /// 是否已兌換(0:未兌換成功 1:已兌換成功) 
        /// </summary> 
        [Column("IsRecycling")] 
        public bool @IsRecycling   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RecyclingMessage")] 
        [MaxLength(200)] 
        public string? @RecyclingMessage   { get; set; }
        ///<summary> 
        /// 東森幣兌換紀錄(公用紀錄表) 
        /// </summary> 
        [Column("id_MemberTransEHSD")] 
        public long? @id_MemberTransEHSD   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
        ///<summary> 
        /// 建立者 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 來源IP 
        /// </summary> 
        [Column("CreateIP")] 
        [MaxLength(50)] 
        public string? @CreateIP   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 最後修改者 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateIP")] 
        [MaxLength(50)] 
        public string? @UpdateIP   { get; set; }
}
}
