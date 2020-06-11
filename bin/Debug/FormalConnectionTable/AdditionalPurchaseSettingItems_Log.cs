using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class AdditionalPurchaseSettingItems_Log
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("additionalPurchaseSettingLogID")] 
        public int @additionalPurchaseSettingLogID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("limiteCount")] 
        public int @limiteCount   { get; set; }
}
}
