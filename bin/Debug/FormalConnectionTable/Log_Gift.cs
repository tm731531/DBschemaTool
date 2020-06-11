using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_Gift
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo_Main")] 
        public string? @FugoSaleNo_Main   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoSaleNo_Gift")] 
        public string? @FugoSaleNo_Gift   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_action")] 
        [MaxLength(1)] 
        public string? @trg_action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_create_on")] 
        public DateTime @trg_create_on   { get; set; }
}
}
