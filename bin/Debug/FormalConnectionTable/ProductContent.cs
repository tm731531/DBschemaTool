using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductContent
{
        ///<summary> 
        /// PK 順水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 銷售品號 
        /// </summary> 
        [Column("SalesCode")] 
        [MaxLength(40)] 
        public string @SalesCode   { get; set; }
        ///<summary> 
        /// FK SalesMix.id 
        /// </summary> 
        [Column("id_SalesMix")] 
        public int @id_SalesMix   { get; set; }
        ///<summary> 
        /// 1:商品特色 
        /// </summary> 
        [Column("ContentType")] 
        public int @ContentType   { get; set; }
        ///<summary> 
        /// 文案資料(影像檔存於路徑) 
        /// </summary> 
        [Column("ContentData")] 
        public string @ContentData   { get; set; }
        ///<summary> 
        /// 文案類別 1:標題,2:內文,3:圖檔 
        /// </summary> 
        [Column("ContentClass")] 
        public int @ContentClass   { get; set; }
        ///<summary> 
        /// 是否刪除 
        /// </summary> 
        [Column("IsDelete")] 
        public bool @IsDelete   { get; set; }
        ///<summary> 
        /// 是否更新 
        /// </summary> 
        [Column("IsUpdate")] 
        public bool @IsUpdate   { get; set; }
        ///<summary> 
        /// 是否啟用 (B2B:新品為:1,舊品為0;B2E:編修中為0,確認送出為1) 
        /// </summary> 
        [Column("IsEnabled")] 
        public bool @IsEnabled   { get; set; }
        ///<summary> 
        /// 排序 
        /// </summary> 
        [Column("ContentOrder")] 
        public int @ContentOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(40)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime @ModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(40)] 
        public string @ModifyUser   { get; set; }
        ///<summary> 
        /// FOR B2E,B2B 對應使用 
        /// </summary> 
        [Column("Guid")] 
        [MaxLength(50)] 
        public string @Guid   { get; set; }
        ///<summary> 
        /// Css類別 
        /// </summary> 
        [Column("CssClass")] 
        [MaxLength(40)] 
        public string? @CssClass   { get; set; }
        ///<summary> 
        /// 最後更新時間戳記 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
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
