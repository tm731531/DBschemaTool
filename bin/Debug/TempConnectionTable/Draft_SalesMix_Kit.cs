using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Draft_SalesMix_Kit
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
        [Column("Main_fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @Main_fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Kit_fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @Kit_fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Kit_fugoProductId")] 
        [MaxLength(60)] 
        public string? @Kit_fugoProductId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ShipSeq")] 
        public int? @ShipSeq   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("QTY")] 
        public int? @QTY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Cost")] 
        public decimal? @Cost   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SupplierId")] 
        [MaxLength(6)] 
        public string? @SupplierId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id_Draft")] 
        public long? @Id_Draft   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FromOn")] 
        public DateTime? @FromOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateBy")] 
        [MaxLength(50)] 
        public string? @CreateBy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyBy")] 
        [MaxLength(50)] 
        public string? @ModifyBy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyOn")] 
        public DateTime? @ModifyOn   { get; set; }
}
}
