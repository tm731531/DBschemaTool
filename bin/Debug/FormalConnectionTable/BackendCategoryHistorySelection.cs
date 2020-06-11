using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BackendCategoryHistorySelection
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_Vendor")] 
        [MaxLength(100)] 
        public string? @id_Vendor   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_BackendCategory")] 
        public long? @id_BackendCategory   { get; set; }
        ///<summary> 
        /// 對應富購員編，非User流水號 
        /// </summary> 
        [Column("id_PM")] 
        public long? @id_PM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("eType")] 
        public byte? @eType   { get; set; }
}
}
