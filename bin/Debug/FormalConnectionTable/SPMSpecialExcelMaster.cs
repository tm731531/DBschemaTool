using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SPMSpecialExcelMaster
{
        ///<summary> 
        /// PK流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// Vendor廠商統編 
        /// </summary> 
        [Column("VendorUnifiedSerialNumber")] 
        [MaxLength(100)] 
        public string @VendorUnifiedSerialNumber   { get; set; }
        ///<summary> 
        /// Excel檔案名稱 
        /// </summary> 
        [Column("FileName")] 
        [MaxLength(60)] 
        public string @FileName   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
        ///<summary> 
        /// EDI文件類型，目前define在enum上面 
        /// </summary> 
        [Column("Type")] 
        [MaxLength(10)] 
        public string @Type   { get; set; }
        ///<summary> 
        /// 檔案存放NAS路徑 
        /// </summary> 
        [Column("FilePath")] 
        [MaxLength(200)] 
        public string @FilePath   { get; set; }
}
}
