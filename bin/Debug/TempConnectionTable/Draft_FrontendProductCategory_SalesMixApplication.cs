using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Draft_FrontendProductCategory_SalesMixApplication
{
        ///<summary> 
        /// 主鍵 
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
        /// 外鍵 對應到正式區FrontendProductCategory中的欄位Id 
        /// </summary> 
        [Column("category_FrontendProductCategory")] 
        public long? @category_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 外鍵 關聯到暫存區中的SalesMixApplication表中的id 
        /// </summary> 
        [Column("sales_SalesMix")] 
        public long? @sales_SalesMix   { get; set; }
        ///<summary> 
        /// 商品順序 
        /// </summary> 
        [Column("salesOrder")] 
        public int? @salesOrder   { get; set; }
        ///<summary> 
        /// 時間戳 
        /// </summary> 
        [Column("lastUpdated")] 
        public long? @lastUpdated   { get; set; }
        ///<summary> 
        /// 預設0或null: 次分類, 1: 主分類 
        /// </summary> 
        [Column("isMainCategory")] 
        public byte? @isMainCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
