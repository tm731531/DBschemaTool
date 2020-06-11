using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MC_EHSDCampain_BackendCategory
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
        [Column("id_MC_EHSDCampain")] 
        public long? @id_MC_EHSDCampain   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(50)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("bc_id")] 
        public long? @bc_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("restore_getEHSDRate")] 
        public decimal? @restore_getEHSDRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("restore_useEHSDRate")] 
        public decimal? @restore_useEHSDRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("getEHSDRate")] 
        public decimal? @getEHSDRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("useEHSDRate")] 
        public decimal? @useEHSDRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
}
}
