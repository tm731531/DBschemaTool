using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FrontendProductCategory_VendorExclude
{
        ///<summary> 
        /// 廠商代碼 
        /// </summary> 
        [Column("id_Vendor")] 
        [MaxLength(100)] 
        public string @id_Vendor   { get; set; }
        ///<summary> 
        /// 前台分類 seq 
        /// </summary> 
        [Column("id_FrontendProductCategory")] 
        public long @id_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
}
}
