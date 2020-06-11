using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class PhraseLibrary
{
        ///<summary> 
        /// 編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 群組編碼 
        /// </summary> 
        [Column("groupName")] 
        [MaxLength(50)] 
        public string @groupName   { get; set; }
        ///<summary> 
        /// 項目名稱 
        /// </summary> 
        [Column("itemName")] 
        [MaxLength(100)] 
        public string @itemName   { get; set; }
        ///<summary> 
        /// 項目值 
        /// </summary> 
        [Column("itemValue")] 
        [MaxLength(1000)] 
        public string @itemValue   { get; set; }
        ///<summary> 
        /// 項目顯示文字 
        /// </summary> 
        [Column("itemDisplayValue")] 
        [MaxLength(50)] 
        public string? @itemDisplayValue   { get; set; }
        ///<summary> 
        /// 是否為預設值 
        /// </summary> 
        [Column("isDefault")] 
        public bool @isDefault   { get; set; }
        ///<summary> 
        /// 是否關閉 
        /// </summary> 
        [Column("isDisabled")] 
        public bool @isDisabled   { get; set; }
        ///<summary> 
        /// 是否用於CACHE區資料庫 
        /// </summary> 
        [Column("isNeedsToCache")] 
        public bool @isNeedsToCache   { get; set; }
        ///<summary> 
        /// 排序 
        /// </summary> 
        [Column("sortNum")] 
        public int @sortNum   { get; set; }
        ///<summary> 
        /// 父節點 
        /// </summary> 
        [Column("parentId")] 
        public int @parentId   { get; set; }
        ///<summary> 
        /// 修改時間 
        /// </summary> 
        [Column("modifyDate")] 
        public DateTime? @modifyDate   { get; set; }
        ///<summary> 
        /// 修改者 
        /// </summary> 
        [Column("modifyUser")] 
        [MaxLength(50)] 
        public string? @modifyUser   { get; set; }
        ///<summary> 
        /// 註記 
        /// </summary> 
        [Column("remark")] 
        public string? @remark   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createDate")] 
        public DateTime? @createDate   { get; set; }
}
}
