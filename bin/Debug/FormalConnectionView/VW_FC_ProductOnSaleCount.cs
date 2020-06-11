using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_FC_ProductOnSaleCount
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fc_seq")] 
        public long @fc_seq   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("status")] 
        [MaxLength(60)] 
        public string @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("oldProductCount")] 
        public int? @oldProductCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("newProductCount")] 
        public int @newProductCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isUpdate")] 
        public int @isUpdate   { get; set; }
}
}
