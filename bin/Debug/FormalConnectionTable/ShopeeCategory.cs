using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ShopeeCategory
{
        ///<summary> 
        /// The Identify of each category 
        /// </summary> 
        [Column("CategoryId")] 
        public long @CategoryId   { get; set; }
        ///<summary> 
        /// The Identify of the parent of the category 
        /// </summary> 
        [Column("ParentId")] 
        public long @ParentId   { get; set; }
        ///<summary> 
        /// The name of each category 
        /// </summary> 
        [Column("CategoryName")] 
        [MaxLength(100)] 
        public string @CategoryName   { get; set; }
        ///<summary> 
        /// This is to indicate whether the category has children. Attributes can ONLY be fetched for the category_id WITHOUT children. 
        /// </summary> 
        [Column("HasChildren")] 
        public byte @HasChildren   { get; set; }
        ///<summary> 
        /// The maximum of dts，-1 means no dts. 
        /// </summary> 
        [Column("MinShipLimitsDays")] 
        public int? @MinShipLimitsDays   { get; set; }
        ///<summary> 
        /// The minimum of dts, -1 means no dts. 
        /// </summary> 
        [Column("MaxShipLimitsDays")] 
        public int? @MaxShipLimitsDays   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreatedDate")] 
        public DateTime? @CreatedDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifiedTime")] 
        public DateTime? @LastModifiedTime   { get; set; }
}
}
