using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class InvoiceDonated
{
        ///<summary> 
        /// 富購捐贈對象代碼 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 富購捐贈對象名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(200)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 受贈單位的愛心碼 (電子發票) 
        /// </summary> 
        [Column("lovecode")] 
        [MaxLength(40)] 
        public string? @lovecode   { get; set; }
}
}
