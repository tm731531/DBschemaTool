using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class RedAPITrace
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// API名稱 
        /// </summary> 
        [Column("APIName")] 
        [MaxLength(50)] 
        public string? @APIName   { get; set; }
        ///<summary> 
        /// 搜尋關鍵字 
        /// </summary> 
        [Column("SearchKey")] 
        [MaxLength(50)] 
        public string? @SearchKey   { get; set; }
        ///<summary> 
        /// API Request 
        /// </summary> 
        [Column("RequestJson")] 
        [MaxLength(2000)] 
        public string? @RequestJson   { get; set; }
        ///<summary> 
        /// 追蹤紀錄 
        /// </summary> 
        [Column("TraceMessage")] 
        [MaxLength(2000)] 
        public string? @TraceMessage   { get; set; }
        ///<summary> 
        /// API Response 
        /// </summary> 
        [Column("ResponseJson")] 
        [MaxLength(2000)] 
        public string? @ResponseJson   { get; set; }
        ///<summary> 
        /// 回傳代碼 
        /// </summary> 
        [Column("ResultCode")] 
        [MaxLength(4)] 
        public string? @ResultCode   { get; set; }
        ///<summary> 
        /// 回傳訊息 
        /// </summary> 
        [Column("ResultMessage")] 
        [MaxLength(2000)] 
        public string? @ResultMessage   { get; set; }
        ///<summary> 
        /// 新增時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
}
}
