using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class W_DailyReport
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 類型 
        /// </summary> 
        [Column("reportType")] 
        public short @reportType   { get; set; }
        ///<summary> 
        /// 報告人 
        /// </summary> 
        [Column("report_by")] 
        public long @report_by   { get; set; }
        ///<summary> 
        /// 報告日期 
        /// </summary> 
        [Column("report_on")] 
        public DateTime @report_on   { get; set; }
        ///<summary> 
        /// 報告內容 
        /// </summary> 
        [Column("reportMessage")] 
        public string? @reportMessage   { get; set; }
        ///<summary> 
        /// 核閱人 
        /// </summary> 
        [Column("review_by")] 
        public long? @review_by   { get; set; }
        ///<summary> 
        /// 核閱日期 
        /// </summary> 
        [Column("review_on")] 
        public DateTime? @review_on   { get; set; }
        ///<summary> 
        /// 核閱內容 
        /// </summary> 
        [Column("reviewMessage")] 
        [MaxLength(1000)] 
        public string? @reviewMessage   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 狀態 0:未核閱, 1:已核閱 
        /// </summary> 
        [Column("status")] 
        public byte @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rank")] 
        [MaxLength(1)] 
        public string? @rank   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("edit_on")] 
        public DateTime? @edit_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("review2_by")] 
        public long? @review2_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("review2_on")] 
        public DateTime? @review2_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("reviewMessage2")] 
        public string? @reviewMessage2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rank2")] 
        [MaxLength(1)] 
        public string? @rank2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("review3_by")] 
        public long? @review3_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("review3_on")] 
        public DateTime? @review3_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("reviewMessage3")] 
        public string? @reviewMessage3   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rank3")] 
        [MaxLength(1)] 
        public string? @rank3   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("review4_by")] 
        public long? @review4_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("review4_on")] 
        public DateTime? @review4_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("reviewMessage4")] 
        public string? @reviewMessage4   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rank4")] 
        [MaxLength(1)] 
        public string? @rank4   { get; set; }
}
}
