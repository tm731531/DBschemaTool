using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FrontendProductCategoryHistorySelection
{
        ///<summary> 
        /// 前台分類快取清單 id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 系統使用者 id(包含廠商和B2E系統使用者) 
        /// </summary> 
        [Column("id_User")] 
        public long @id_User   { get; set; }
        ///<summary> 
        /// 系統紀錄時間(包含新增和修改均使用這欄位) 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsMainCategory")] 
        public bool? @IsMainCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("StoreSeq")] 
        public long? @StoreSeq   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SeqFrontendProductCategory")] 
        public long? @SeqFrontendProductCategory   { get; set; }
}
}
