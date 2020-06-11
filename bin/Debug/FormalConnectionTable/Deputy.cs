using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Deputy
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// Deputy 
        /// </summary> 
        [Column("userId")] 
        public long @userId   { get; set; }
        ///<summary> 
        /// 代理人userId 
        /// </summary> 
        [Column("deputy")] 
        public long @deputy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        public long @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
}
}
