using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProdSpecAttribute
{
        ///<summary> 
        /// 規格屬性 ID 代碼 
        /// </summary> 
        [Column("AttrID")] 
        [Key] 
        public int @AttrID   { get; set; }
        ///<summary> 
        /// 規格屬性名稱 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(200)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 規格類別 
        /// </summary> 
        [Column("AttrTypeID")] 
        public int @AttrTypeID   { get; set; }
        ///<summary> 
        /// 圖片位置 
        /// </summary> 
        [Column("ImageLocation")] 
        [MaxLength(1000)] 
        public string? @ImageLocation   { get; set; }
        ///<summary> 
        /// 文字或圖片連結 
        /// </summary> 
        [Column("URL")] 
        [MaxLength(200)] 
        public string? @URL   { get; set; }
        ///<summary> 
        /// 色系的 Style 
        /// </summary> 
        [Column("Style")] 
        [MaxLength(20)] 
        public string? @Style   { get; set; }
        ///<summary> 
        /// 排序值 
        /// </summary> 
        [Column("SortValue")] 
        public short? @SortValue   { get; set; }
        ///<summary> 
        /// 啟用規格(0:不啟用, 1:啟用)，當為0時不會在 MongoDb 出現 
        /// </summary> 
        [Column("Active")] 
        public bool @Active   { get; set; }
        ///<summary> 
        /// 和其他規格ID連動(0:不啟用 1:啟用) 
        /// </summary> 
        [Column("Effect")] 
        public bool @Effect   { get; set; }
        ///<summary> 
        /// 當勾選這個規格，其他特定規格欄位不可以勾選，存入不可以勾選的規格 ID清單，用,號分隔 
        /// </summary> 
        [Column("DisableAttrList")] 
        public string? @DisableAttrList   { get; set; }
        ///<summary> 
        /// 當勾選這個規格 ID清單，其他特定規格文字欄位不可以填寫，用,號分隔 
        /// </summary> 
        [Column("DisableTextList")] 
        [MaxLength(2000)] 
        public string? @DisableTextList   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("CreatedDate")] 
        public DateTime @CreatedDate   { get; set; }
        ///<summary> 
        /// 建立人 ID 
        /// </summary> 
        [Column("CreatedUser")] 
        public int @CreatedUser   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 最後修改人 ID 
        /// </summary> 
        [Column("LastModifyUser")] 
        public int @LastModifyUser   { get; set; }
}
}
