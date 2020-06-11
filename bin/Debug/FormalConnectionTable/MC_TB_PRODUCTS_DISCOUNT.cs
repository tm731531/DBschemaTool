using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MC_TB_PRODUCTS_DISCOUNT
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
        [Column("GOOD_ID")] 
        public int @GOOD_ID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DISCOUNT_VALUE")] 
        [MaxLength(250)] 
        public string @DISCOUNT_VALUE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MOBI_DISCOUNT_VALUE")] 
        [MaxLength(250)] 
        public string? @MOBI_DISCOUNT_VALUE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IS_SHOW_DISCOUNT")] 
        [MaxLength(10)] 
        public string @IS_SHOW_DISCOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("END_DATE")] 
        [MaxLength(20)] 
        public string? @END_DATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
