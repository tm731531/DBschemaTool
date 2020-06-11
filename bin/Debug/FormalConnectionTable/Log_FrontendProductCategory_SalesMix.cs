using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_FrontendProductCategory_SalesMix
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("category_FrontendProductCategory")] 
        public long? @category_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sales_SalesMix")] 
        public long? @sales_SalesMix   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salesOrder")] 
        public long? @salesOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDeleted")] 
        public bool? @isDeleted   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("position")] 
        public int? @position   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deletionTime")] 
        public DateTime? @deletionTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isMainCategory")] 
        public byte? @isMainCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createDate")] 
        public DateTime? @createDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_action")] 
        [MaxLength(1)] 
        public string? @trg_action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_create_on")] 
        public DateTime @trg_create_on   { get; set; }
}
}
