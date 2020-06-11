using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class W_TemporaryVendorContact
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 供應商統編 
        /// </summary> 
        [Column("unifiedSerialNumber")] 
        [MaxLength(100)] 
        public string @unifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 聯絡人 
        /// </summary> 
        [Column("contactor")] 
        [MaxLength(100)] 
        public string? @contactor   { get; set; }
        ///<summary> 
        /// 部門 
        /// </summary> 
        [Column("contactorDept")] 
        [MaxLength(100)] 
        public string? @contactorDept   { get; set; }
        ///<summary> 
        /// 電話 
        /// </summary> 
        [Column("contactorTel")] 
        [MaxLength(100)] 
        public string? @contactorTel   { get; set; }
        ///<summary> 
        /// 手機 
        /// </summary> 
        [Column("contactorTel2")] 
        [MaxLength(100)] 
        public string? @contactorTel2   { get; set; }
        ///<summary> 
        /// Email 
        /// </summary> 
        [Column("contactorMail")] 
        public string? @contactorMail   { get; set; }
        ///<summary> 
        /// 刪除戳記 
        /// </summary> 
        [Column("isDelete")] 
        public bool @isDelete   { get; set; }
        ///<summary> 
        /// 建檔日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 建檔人員 
        /// </summary> 
        [Column("create_by")] 
        public long @create_by   { get; set; }
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("modify_on")] 
        public DateTime? @modify_on   { get; set; }
        ///<summary> 
        /// 修改人員 
        /// </summary> 
        [Column("modify_by")] 
        public long? @modify_by   { get; set; }
        ///<summary> 
        /// 刪除日期 
        /// </summary> 
        [Column("delete_on")] 
        public DateTime? @delete_on   { get; set; }
        ///<summary> 
        /// 刪除人員 
        /// </summary> 
        [Column("delete_by")] 
        public long? @delete_by   { get; set; }
}
}
