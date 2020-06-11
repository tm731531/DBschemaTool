using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class AutoPriceChange_Kit
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 主商品變價提報ID(SalesMixApplication.Id) 
        /// </summary> 
        [Column("Main_SMAId")] 
        public long @Main_SMAId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Main_fugoSaleNo")] 
        [MaxLength(60)] 
        public string @Main_fugoSaleNo   { get; set; }
        ///<summary> 
        /// 子商品變價提報ID(SalesMixApplication.Id) 
        /// </summary> 
        [Column("Kit_SMAId")] 
        public long @Kit_SMAId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Kit_fugoSaleNo")] 
        [MaxLength(60)] 
        public string @Kit_fugoSaleNo   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
}
}
