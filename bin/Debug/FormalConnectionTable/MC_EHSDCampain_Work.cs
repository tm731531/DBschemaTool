using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MC_EHSDCampain_Work
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
        [Column("group_id")] 
        public long? @group_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleno")] 
        [MaxLength(20)] 
        public string? @saleno   { get; set; }
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
        [Column("effected_campain_id")] 
        public long? @effected_campain_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        [MaxLength(50)] 
        public string? @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
