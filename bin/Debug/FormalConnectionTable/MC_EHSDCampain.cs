using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MC_EHSDCampain
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 活動名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(50)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("start_time")] 
        public DateTime? @start_time   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("end_time")] 
        public DateTime? @end_time   { get; set; }
        ///<summary> 
        /// 執行方式;0: 準備中,1: 活動開始, 2: 活動結束, 3:活動結束(二次更新) 
        /// </summary> 
        [Column("run_type")] 
        public byte @run_type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        [MaxLength(50)] 
        public string? @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
}
}
