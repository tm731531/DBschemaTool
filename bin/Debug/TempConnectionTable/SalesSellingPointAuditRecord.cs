using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SalesSellingPointAuditRecord
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 商品編號 
        /// </summary> 
        [Column("id_product")] 
        public long @id_product   { get; set; }
        ///<summary> 
        /// 銷售賣點內文 
        /// </summary> 
        [Column("SellingPointContent")] 
        [MaxLength(2500)] 
        public string @SellingPointContent   { get; set; }
        ///<summary> 
        /// 審核關卡 
        /// </summary> 
        [Column("AuditStep")] 
        public int @AuditStep   { get; set; }
        ///<summary> 
        /// 審核狀態 
        /// </summary> 
        [Column("AuditResult")] 
        [MaxLength(60)] 
        public string @AuditResult   { get; set; }
        ///<summary> 
        /// 駁回原因 
        /// </summary> 
        [Column("RejectReason")] 
        [MaxLength(2000)] 
        public string? @RejectReason   { get; set; }
        ///<summary> 
        /// 建立者 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 審核時間 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
}
}
