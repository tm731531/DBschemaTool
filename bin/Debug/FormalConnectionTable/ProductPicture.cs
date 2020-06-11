using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductPicture
{
        ///<summary> 
        /// 圖片編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 圖片路徑 
        /// </summary> 
        [Column("picturePath")] 
        [MaxLength(400)] 
        public string? @picturePath   { get; set; }
        ///<summary> 
        /// 圖片順序 
        /// </summary> 
        [Column("pictureSort")] 
        public int? @pictureSort   { get; set; }
        ///<summary> 
        /// 圖片所屬類別 0：商品品號 1：商品碼 
        /// </summary> 
        [Column("pictureCategory")] 
        public byte? @pictureCategory   { get; set; }
        ///<summary> 
        /// SalesMix.id 
        /// </summary> 
        [Column("pictureOwnerId")] 
        public long? @pictureOwnerId   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 標誌上傳的是圖片還是影音檔；0:圖片；1：影音檔 
        /// </summary> 
        [Column("uploadFileType")] 
        public bool? @uploadFileType   { get; set; }
        ///<summary> 
        /// 原圖檔名 
        /// </summary> 
        [Column("fileName")] 
        [MaxLength(100)] 
        public string? @fileName   { get; set; }
        ///<summary> 
        /// 是否進行縮圖處理(0表示沒縮圖，1表示縮圖) 
        /// </summary> 
        [Column("isMiniatureImage")] 
        public int? @isMiniatureImage   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime? @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
}
}
