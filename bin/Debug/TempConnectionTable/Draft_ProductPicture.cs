using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Draft_ProductPicture
{
        ///<summary> 
        /// 圖片編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_Draft")] 
        public long @id_Draft   { get; set; }
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
        /// 圖片所屬的品號id或者是商品號Id，Fk,品號id參照FRIMLEC.SalesMix裱中的id列，商品號id參照FRIMLEC.Product中的id列 
        /// </summary> 
        [Column("pictureOwnerId")] 
        public long? @pictureOwnerId   { get; set; }
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
        /// 是否做過縮圖處理 
        /// </summary> 
        [Column("isMiniatureImage")] 
        public int? @isMiniatureImage   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FR_FormalPictureID")] 
        public long? @FR_FormalPictureID   { get; set; }
        ///<summary> 
        /// 修改時間 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime? @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        [MaxLength(100)] 
        public string? @create_by   { get; set; }
}
}
