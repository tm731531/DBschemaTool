using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Z_ToBeDelete_MarketingEventType
{
        ///<summary> 
        /// 活動類型id 
        /// </summary> 
        [Column("id")] 
        public int @id   { get; set; }
        ///<summary> 
        /// 行銷活動類型描述 
        /// </summary> 
        [Column("description")] 
        [MaxLength(20)] 
        public string @description   { get; set; }
}
}
