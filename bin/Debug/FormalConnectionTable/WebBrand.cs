using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class WebBrand
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
        [Column("brand")] 
        [MaxLength(100)] 
        public string @brand   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("synonym")] 
        [MaxLength(100)] 
        public string? @synonym   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isShow")] 
        public bool @isShow   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        [MaxLength(30)] 
        public string @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_by")] 
        [MaxLength(30)] 
        public string? @update_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("brandMD")] 
        [MaxLength(40)] 
        public string? @brandMD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seq_flagStoreE")] 
        public long? @seq_flagStoreE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seq_flagStoreU")] 
        public long? @seq_flagStoreU   { get; set; }
}
}
