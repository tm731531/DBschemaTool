using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_ProductVideo
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
        [Column("path")] 
        [MaxLength(4000)] 
        public string? @path   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sort")] 
        public int? @sort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("cover")] 
        [MaxLength(4000)] 
        public string? @cover   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ownerId")] 
        public long? @ownerId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fileName")] 
        [MaxLength(500)] 
        public string? @fileName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IV_id")] 
        public long? @IV_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_by")] 
        public long? @update_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("azure")] 
        public bool? @azure   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("azurePath")] 
        public string? @azurePath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("azureTime")] 
        public DateTime? @azureTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Vertical")] 
        public bool? @Vertical   { get; set; }
}
}
