using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class tmp_CHANGE_VALUE
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_SMA")] 
        public long? @id_SMA   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FormID")] 
        public int? @FormID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SpecID")] 
        public int? @SpecID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ValueID")] 
        public int? @ValueID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ValueName")] 
        public string? @ValueName   { get; set; }
}
}
