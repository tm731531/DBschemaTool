using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class LogPresentDescription
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 富購銷售編號 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 銷售名稱 
        /// </summary> 
        [Column("saleName")] 
        [MaxLength(510)] 
        public string? @saleName   { get; set; }
        ///<summary> 
        /// 供應商代碼(Vendor.id) 
        /// </summary> 
        [Column("vendorCode_Vendor")] 
        [MaxLength(100)] 
        public string? @vendorCode_Vendor   { get; set; }
        ///<summary> 
        /// 商品開發(User.fugoEmployeeNo2) 
        /// </summary> 
        [Column("productDevelopmentStaff")] 
        [MaxLength(40)] 
        public string? @productDevelopmentStaff   { get; set; }
        ///<summary> 
        /// 贈品敍述 
        /// </summary> 
        [Column("presentDescription")] 
        public string? @presentDescription   { get; set; }
        ///<summary> 
        /// 寫入時間 
        /// </summary> 
        [Column("createDate")] 
        public DateTime? @createDate   { get; set; }
        ///<summary> 
        /// 錯誤型別 1:錯誤贈品長度檢核 2 :富購贈品欄位不同 
        /// </summary> 
        [Column("warningType")] 
        public int? @warningType   { get; set; }
}
}
