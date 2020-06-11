using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vw_MC_SEARCH_FRONTEND_CATEGORY_STATUS
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
        [Column("fc_id")] 
        public long? @fc_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("status")] 
        [MaxLength(5)] 
        public string? @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("rn")] 
        public long? @rn   { get; set; }
}
}
