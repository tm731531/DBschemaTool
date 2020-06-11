using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class VendorAutoApprovedList
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 使用者流水號，對應 User.id 
        /// </summary> 
        [Column("id_User")] 
        public long? @id_User   { get; set; }
        ///<summary> 
        /// 公司統一編號，對應 Vendor.unifiedSerialNumber 
        /// </summary> 
        [Column("companySerialNumber")] 
        [MaxLength(100)] 
        public string? @companySerialNumber   { get; set; }
        ///<summary> 
        /// 新品提報是否自動核可(1是 0否) 
        /// </summary> 
        [Column("isNew")] 
        public byte? @isNew   { get; set; }
        ///<summary> 
        /// 商品修改是否自動核可(1是 0否) 
        /// </summary> 
        [Column("isModify")] 
        public byte? @isModify   { get; set; }
        ///<summary> 
        /// 商品變價是否自動核可(1是 0否) 
        /// </summary> 
        [Column("isChangePrice")] 
        public byte? @isChangePrice   { get; set; }
        ///<summary> 
        /// 商品變量是否自動核可(1是 0否) 
        /// </summary> 
        [Column("isNumberAdd")] 
        public byte? @isNumberAdd   { get; set; }
        ///<summary> 
        /// web閳道是否自動核可(1是 0否) 
        /// </summary> 
        [Column("isWeb")] 
        public byte? @isWeb   { get; set; }
        ///<summary> 
        /// 建檔時間 
        /// </summary> 
        [Column("createDate")] 
        public DateTime? @createDate   { get; set; }
        ///<summary> 
        /// 建檔人員，對應User.id 
        /// </summary> 
        [Column("createUserNo")] 
        public long? @createUserNo   { get; set; }
        ///<summary> 
        /// 修改時間 
        /// </summary> 
        [Column("modifyDate")] 
        public DateTime? @modifyDate   { get; set; }
        ///<summary> 
        /// 修改人員 
        /// </summary> 
        [Column("modifyUserNo")] 
        public long? @modifyUserNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isNumberReduce")] 
        public long? @isNumberReduce   { get; set; }
}
}
