using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ShopeeCategory_ShopeeShopCategory
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public Guid @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id_ShopeeCategory")] 
        public long @Id_ShopeeCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id_ShopeeShopCategory")] 
        public long @Id_ShopeeShopCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public long? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
}
}
