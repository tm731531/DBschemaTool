using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class v_BackendCategoryKPIPerson
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_BackendCategory")] 
        public long @id_BackendCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_User")] 
        public long @id_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accountName")] 
        [MaxLength(256)] 
        public string @accountName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoemployeeno2")] 
        [MaxLength(6)] 
        public string? @fugoemployeeno2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdateTime")] 
        public DateTime? @lastUpdateTime   { get; set; }
}
}
