using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ShopeeShopCategory
{
        ///<summary> 
        /// ShopCategory's unique identifier. 
        /// </summary> 
        [Column("CategoryId")] 
        public long @CategoryId   { get; set; }
        ///<summary> 
        /// ShopCategory's name. 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(100)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// ShopCategory's sort weight. 
        /// </summary> 
        [Column("SortWeight")] 
        public int? @SortWeight   { get; set; }
        ///<summary> 
        /// ShopCategory's status. Applicable values: NORMAL, INACTIVE, DELETED. 
        /// </summary> 
        [Column("Status")] 
        [MaxLength(20)] 
        public string? @Status   { get; set; }
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
