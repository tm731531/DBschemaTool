using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class W_DailyReport_Attachment
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// W_DailyReport.id 
        /// </summary> 
        [Column("dailyReport_id")] 
        public long @dailyReport_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("attachment")] 
        [MaxLength(500)] 
        public string? @attachment   { get; set; }
        ///<summary> 
        /// 類型 
        /// </summary> 
        [Column("type")] 
        public byte? @type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("vendorContract_id")] 
        public long? @vendorContract_id   { get; set; }
}
}
