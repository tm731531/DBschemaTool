using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class fJob
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("smId")] 
        public long? @smId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("smaId")] 
        public long? @smaId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salesMixType")] 
        public byte @salesMixType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("status")] 
        public byte @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        public long @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoMsg")] 
        [MaxLength(2000)] 
        public string? @fugoMsg   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("notes")] 
        [MaxLength(250)] 
        public string? @notes   { get; set; }
}
}
