using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class CashBackOrderCache
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 店長前台客代 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public int @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 統計區間 
        /// </summary> 
        [Column("SummaryRange")] 
        [MaxLength(30)] 
        public string? @SummaryRange   { get; set; }
        ///<summary> 
        /// 未結帳銷售資料與訂單 
        /// </summary> 
        [Column("JsonContent")] 
        public string? @JsonContent   { get; set; }
        ///<summary> 
        /// 建檔日期 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
        ///<summary> 
        /// 建檔人員 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
}
}
