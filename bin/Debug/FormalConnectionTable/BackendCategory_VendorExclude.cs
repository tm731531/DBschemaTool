using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BackendCategory_VendorExclude
{
        ///<summary> 
        /// 後台分類 id 
        /// </summary> 
        [Column("id_BackendCategory")] 
        public long @id_BackendCategory   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
}
}
