using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class OkBonUpdateLog
{
        ///<summary> 
        /// 訂單編號 
        /// </summary> 
        [Column("OrderID")] 
        public int? @OrderID   { get; set; }
        ///<summary> 
        /// 項次編號 
        /// </summary> 
        [Column("ItemID")] 
        public int? @ItemID   { get; set; }
        ///<summary> 
        /// 富購客代 
        /// </summary> 
        [Column("CustID")] 
        [MaxLength(20)] 
        public string? @CustID   { get; set; }
        ///<summary> 
        /// 銷售編號 
        /// </summary> 
        [Column("ProductSKU")] 
        [MaxLength(60)] 
        public string? @ProductSKU   { get; set; }
        ///<summary> 
        /// 異動欄位名稱 
        /// </summary> 
        [Column("updateField")] 
        [MaxLength(20)] 
        public string? @updateField   { get; set; }
        ///<summary> 
        /// 修改前資料 
        /// </summary> 
        [Column("updateBefore")] 
        public string? @updateBefore   { get; set; }
        ///<summary> 
        /// 修改後資料 
        /// </summary> 
        [Column("updateAfter")] 
        public string? @updateAfter   { get; set; }
        ///<summary> 
        /// 新增時間 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// 新增者 
        /// </summary> 
        [Column("create_by")] 
        [MaxLength(20)] 
        public string? @create_by   { get; set; }
}
}
