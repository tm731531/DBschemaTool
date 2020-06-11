using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class AnnouncementPost
{
        ///<summary> 
        /// 唯一鍵 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 公告訊息種類(片語資料庫欄位) 
        /// </summary> 
        [Column("announcementPostType")] 
        [MaxLength(100)] 
        public string @announcementPostType   { get; set; }
        ///<summary> 
        /// 公告訊息主旨 
        /// </summary> 
        [Column("subject")] 
        [MaxLength(200)] 
        public string @subject   { get; set; }
        ///<summary> 
        /// 公告訊息內容 
        /// </summary> 
        [Column("content")] 
        public string? @content   { get; set; }
        ///<summary> 
        /// 是否刪除 
        /// </summary> 
        [Column("hasDeleted")] 
        public bool @hasDeleted   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("creationDate")] 
        public DateTime @creationDate   { get; set; }
        ///<summary> 
        /// 異動人員 
        /// </summary> 
        [Column("lastModifier")] 
        [MaxLength(256)] 
        public string @lastModifier   { get; set; }
        ///<summary> 
        /// 公告異動日期 
        /// </summary> 
        [Column("lastUpdatedTime")] 
        public DateTime @lastUpdatedTime   { get; set; }
        ///<summary> 
        /// 檔案關聯id 
        /// </summary> 
        [Column("id_FileArchive")] 
        public long? @id_FileArchive   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("loginShow")] 
        public byte? @loginShow   { get; set; }
}
}
