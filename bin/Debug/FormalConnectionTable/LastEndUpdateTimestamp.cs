using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class LastEndUpdateTimestamp
{
        ///<summary> 
        /// 編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 更新類型 
        /// </summary> 
        [Column("type")] 
        [MaxLength(200)] 
        public string @type   { get; set; }
        ///<summary> 
        /// 上次最後更新時間標誌 
        /// </summary> 
        [Column("previousLatestUpdate")] 
        public long? @previousLatestUpdate   { get; set; }
        ///<summary> 
        /// 富購廠商，商品資料上次更新時間 
        /// </summary> 
        [Column("fugoLatestUpdate")] 
        public DateTime? @fugoLatestUpdate   { get; set; }
}
}
