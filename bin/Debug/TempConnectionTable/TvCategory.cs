using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class TvCategory
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 後台分類代碼(BackendCategory.id) 
        /// </summary> 
        [Column("categoryId")] 
        public long @categoryId   { get; set; }
        ///<summary> 
        /// 存的是seq(FrontendProductCategory.seq) 
        /// </summary> 
        [Column("frontendProductCategoryId")] 
        public long @frontendProductCategoryId   { get; set; }
        ///<summary> 
        /// 是否設定為商品前台主分類 
        /// </summary> 
        [Column("isMainCategory")] 
        public byte? @isMainCategory   { get; set; }
        ///<summary> 
        /// 平台(1:UMALL 2:ETMALL) 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 建立者 
        /// </summary> 
        [Column("create_by")] 
        public long @create_by   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_by")] 
        public long? @update_by   { get; set; }
}
}
