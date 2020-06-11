using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreUpdateLog
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreNumber")] 
        [MaxLength(12)] 
        public string? @EStoreNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("updateField")] 
        [MaxLength(20)] 
        public string? @updateField   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("updateBefore")] 
        [MaxLength(200)] 
        public string? @updateBefore   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("updateAfter")] 
        [MaxLength(200)] 
        public string? @updateAfter   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        [MaxLength(20)] 
        public string? @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_EStoreMember")] 
        public int @id_EStoreMember   { get; set; }
}
}
