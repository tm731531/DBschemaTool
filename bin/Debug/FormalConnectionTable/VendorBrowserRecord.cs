using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VendorBrowserRecord
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 廠商id 
        /// </summary> 
        [Column("unifiedSerialNumber")] 
        [MaxLength(100)] 
        public string? @unifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 使用瀏覽器 
        /// </summary> 
        [Column("browser")] 
        [MaxLength(50)] 
        public string? @browser   { get; set; }
        ///<summary> 
        /// 版本 
        /// </summary> 
        [Column("version")] 
        [MaxLength(50)] 
        public string? @version   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createDate")] 
        public DateTime? @createDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("loginSource")] 
        public byte? @loginSource   { get; set; }
}
}
