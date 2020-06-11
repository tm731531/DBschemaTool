using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwMLDL_20999_SalesMix
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo")] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("eType")] 
        public byte? @eType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_SaleStatus")] 
        public int? @id_SaleStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleStatus")] 
        public string? @saleStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifiedTime_SalesMix")] 
        public DateTime? @lastModifiedTime_SalesMix   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_FrontendProductCategory")] 
        public long? @id_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Platform_FrontendProductCategory_SalesMix")] 
        public byte? @Platform_FrontendProductCategory_SalesMix   { get; set; }
}
}
