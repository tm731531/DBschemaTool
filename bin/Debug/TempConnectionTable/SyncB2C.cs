using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SyncB2C
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
        [Column("functionItem")] 
        [MaxLength(30)] 
        public string @functionItem   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("status")] 
        public byte @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(100)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("syncB2CTime")] 
        public DateTime? @syncB2CTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime? @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("little_e")] 
        public byte? @little_e   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("notes")] 
        [MaxLength(300)] 
        public string? @notes   { get; set; }
        ///<summary> 
        /// 可否打RMQ(0 : 不打MQ, 1: 可打MQ) 
        /// </summary> 
        [Column("IsSyncEnabled")] 
        public bool @IsSyncEnabled   { get; set; }
}
}
