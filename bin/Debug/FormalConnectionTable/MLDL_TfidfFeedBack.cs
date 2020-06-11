using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MLDL_TfidfFeedBack
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productName")] 
        [MaxLength(1000)] 
        public string? @productName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryID")] 
        [MaxLength(1000)] 
        public string? @categoryID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryName")] 
        [MaxLength(1000)] 
        public string? @categoryName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("match")] 
        public bool? @match   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        [MaxLength(10)] 
        public string? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createOn")] 
        public DateTime? @createOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accountName")] 
        [MaxLength(256)] 
        public string? @accountName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("unifiedSerialNumber")] 
        [MaxLength(240)] 
        public string? @unifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(20)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isMainCategory")] 
        public bool? @isMainCategory   { get; set; }
}
}
