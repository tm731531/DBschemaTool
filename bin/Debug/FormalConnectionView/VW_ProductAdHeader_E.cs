using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_ProductAdHeader_E
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
        [Column("startTime")] 
        public DateTime @startTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("endTime")] 
        public DateTime @endTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("title")] 
        [MaxLength(200)] 
        public string? @title   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("comment")] 
        [MaxLength(200)] 
        public string? @comment   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("imagePath")] 
        [MaxLength(510)] 
        public string? @imagePath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("imageLinkUrl")] 
        [MaxLength(510)] 
        public string? @imageLinkUrl   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("adScope")] 
        public int @adScope   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_User")] 
        public long @id_User   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastUpdateTime")] 
        public DateTime @lastUpdateTime   { get; set; }
}
}
