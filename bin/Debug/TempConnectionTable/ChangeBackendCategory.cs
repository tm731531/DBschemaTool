using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ChangeBackendCategory
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 新的富購大分類 
        /// </summary> 
        [Column("BackendCategoryL")] 
        [MaxLength(6)] 
        public string? @BackendCategoryL   { get; set; }
        ///<summary> 
        /// 新的富購中分類 
        /// </summary> 
        [Column("BackendCategoryM")] 
        [MaxLength(6)] 
        public string? @BackendCategoryM   { get; set; }
        ///<summary> 
        /// 新的富購小分類 
        /// </summary> 
        [Column("BackendCategoryS")] 
        [MaxLength(6)] 
        public string? @BackendCategoryS   { get; set; }
        ///<summary> 
        /// 申請人(userid) 
        /// </summary> 
        [Column("applicant")] 
        public long? @applicant   { get; set; }
        ///<summary> 
        /// 申請時間 
        /// </summary> 
        [Column("sendtime")] 
        public DateTime? @sendtime   { get; set; }
        ///<summary> 
        /// 修改時間 
        /// </summary> 
        [Column("lastupdated")] 
        public DateTime? @lastupdated   { get; set; }
        ///<summary> 
        /// 狀態：0預設；1B2E完成；2純U或純E富購成功；3駁回；4Job失敗；5雙富購U成功；6雙富購E成功 
        /// </summary> 
        [Column("status")] 
        public int? @status   { get; set; }
        ///<summary> 
        /// 網站編號 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(10)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("dbType")] 
        public byte @dbType   { get; set; }
}
}
