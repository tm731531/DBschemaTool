using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BackendCategory_Authority
{
        ///<summary> 
        /// 識別碼 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 分類識別碼 FK Formal.BackendCategory.id 
        /// </summary> 
        [Column("id_BackendCategory")] 
        public long @id_BackendCategory   { get; set; }
        ///<summary> 
        /// 使用者類別 0=MD, 1=Manager, 2=MA, 3=MP(商企) 使用者類別 0=MD, 1=Manager, 2=MA, 3=MP(商企), 20=PA(商審人員), 21=PAC(商審委員), 22=OP(維運人員), 23=QC(品質檢查人員),24=一般查詢人員 
        /// </summary> 
        [Column("AuthorityType")] 
        public int @AuthorityType   { get; set; }
        ///<summary> 
        /// 使用者識別碼 FK Formal.User.id 
        /// </summary> 
        [Column("id_User")] 
        public long @id_User   { get; set; }
        ///<summary> 
        /// 狀態 0審核中 1有效帳號 2已離職 3已停權 
        /// </summary> 
        [Column("status")] 
        public int @status   { get; set; }
        ///<summary> 
        /// 建立者=活動負責人，FK,關聯到FRI_FORMAL.User.id 
        /// </summary> 
        [Column("createUser")] 
        public long @createUser   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 最後更新者，FK,關聯到FRI_FORMAL.User.id 
        /// </summary> 
        [Column("lastUpdateUser")] 
        public long? @lastUpdateUser   { get; set; }
        ///<summary> 
        /// 最後更新時間 
        /// </summary> 
        [Column("lastUpdateTime")] 
        public DateTime? @lastUpdateTime   { get; set; }
        ///<summary> 
        /// 1:網路 2:電視 3:ECTV 4:型錄 5:OB 6:行動商務 
        /// </summary> 
        [Column("eType")] 
        public byte @eType   { get; set; }
}
}
