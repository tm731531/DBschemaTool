using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FrontendProductCategory_SalesMix
{
        ///<summary> 
        /// 主鍵id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// =FrontendProductCategory.seq 
        /// </summary> 
        [Column("category_FrontendProductCategory")] 
        public long @category_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// FK:關聯到SalesMix表的id 
        /// </summary> 
        [Column("sales_SalesMix")] 
        public long @sales_SalesMix   { get; set; }
        ///<summary> 
        /// 分類下所屬的品號順序 
        /// </summary> 
        [Column("salesOrder")] 
        public long @salesOrder   { get; set; }
        ///<summary> 
        /// 最後更新時間戳 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// 是否刪除標誌0：不刪除；1：刪除 
        /// </summary> 
        [Column("isDeleted")] 
        public bool @isDeleted   { get; set; }
        ///<summary> 
        /// 排序權重 
        /// </summary> 
        [Column("position")] 
        public int? @position   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deletionTime")] 
        public DateTime? @deletionTime   { get; set; }
        ///<summary> 
        /// 預設0或null: 次分類, 1: 主分類 
        /// </summary> 
        [Column("isMainCategory")] 
        public byte? @isMainCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createDate")] 
        public DateTime? @createDate   { get; set; }
        ///<summary> 
        /// 測試用 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 1為U-mall, 2為Etmall 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
