using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductAdHeader
{
        ///<summary> 
        /// 識別碼(PK) 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 上線時間 
        /// </summary> 
        [Column("startTime")] 
        public DateTime @startTime   { get; set; }
        ///<summary> 
        /// 下線時間 
        /// </summary> 
        [Column("endTime")] 
        public DateTime @endTime   { get; set; }
        ///<summary> 
        /// 標題 
        /// </summary> 
        [Column("title")] 
        [MaxLength(200)] 
        public string? @title   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("comment")] 
        [MaxLength(200)] 
        public string? @comment   { get; set; }
        ///<summary> 
        /// 圖檔路徑 
        /// </summary> 
        [Column("imagePath")] 
        [MaxLength(510)] 
        public string? @imagePath   { get; set; }
        ///<summary> 
        /// 圖檔連結 
        /// </summary> 
        [Column("imageLinkUrl")] 
        [MaxLength(510)] 
        public string? @imageLinkUrl   { get; set; }
        ///<summary> 
        /// 0=依商品清單匯入、1=依分類設定 
        /// </summary> 
        [Column("adScope")] 
        public int @adScope   { get; set; }
        ///<summary> 
        /// 修改人 
        /// </summary> 
        [Column("id_User")] 
        public long @id_User   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("lastUpdateTime")] 
        public DateTime @lastUpdateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
}
}
