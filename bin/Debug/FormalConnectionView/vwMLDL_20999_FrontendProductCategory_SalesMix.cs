using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwMLDL_20999_FrontendProductCategory_SalesMix
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sales_SalesMix")] 
        public long @sales_SalesMix   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("category_FrontendProductCategory")] 
        public long @category_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isDeleted")] 
        public bool @isDeleted   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isMainCategory")] 
        public byte? @isMainCategory   { get; set; }
}
}
