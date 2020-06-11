using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Draft_SalesMix_PonintSetup
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// MLEC流水號 
        /// </summary> 
        [Column("id_SalesMix")] 
        public long? @id_SalesMix   { get; set; }
        ///<summary> 
        /// 富購銷售編號 成立品號或修改完成後要回補到MLEC. Salesmix_ponintSetup 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 1 純點數 2點+金，可複選，寫入值ex:1,2 提報後不可改 
        /// </summary> 
        [Column("pointType")] 
        [MaxLength(100)] 
        public string? @pointType   { get; set; }
        ///<summary> 
        /// 純點兌換點數設定 整數數字 (畫面預設值為1元*25) 
        /// </summary> 
        [Column("pointNum1")] 
        public int? @pointNum1   { get; set; }
        ///<summary> 
        /// 點+金兌換點數設定 整數數字 (畫面預設值為1元*25) 
        /// </summary> 
        [Column("pointNum2")] 
        public int? @pointNum2   { get; set; }
        ///<summary> 
        /// 點+金所設定的金額 整數數字 
        /// </summary> 
        [Column("pointPlusMoney")] 
        public int? @pointPlusMoney   { get; set; }
        ///<summary> 
        /// 宜睿設定的卷號 
        /// </summary> 
        [Column("orderNo")] 
        [MaxLength(100)] 
        public string? @orderNo   { get; set; }
        ///<summary> 
        /// 建檔日期時間 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// user.id 
        /// </summary> 
        [Column("create_by")] 
        public int? @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// user.id 
        /// </summary> 
        [Column("update_by")] 
        public int? @update_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_Draft")] 
        public int @id_Draft   { get; set; }
}
}
