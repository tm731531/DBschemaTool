using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwProductAccessedNum
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productSpec")] 
        [MaxLength(100)] 
        public string? @productSpec   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accessedNum")] 
        public long? @accessedNum   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isShow")] 
        public byte? @isShow   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_Product")] 
        public long? @id_Product   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("initQty")] 
        public long? @initQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("stockQty")] 
        public long? @stockQty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("colorId")] 
        public long? @colorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("styleId")] 
        public long? @styleId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoProductPN")] 
        [MaxLength(50)] 
        public string? @fugoProductPN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EANcode")] 
        [MaxLength(16)] 
        public string? @EANcode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_SalesMix")] 
        public long? @id_SalesMix   { get; set; }
}
}
