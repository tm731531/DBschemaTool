using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesMixTV
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
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 銷售賣點內文 
        /// </summary> 
        [Column("SellingPointContent")] 
        [MaxLength(2500)] 
        public string @SellingPointContent   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
}
}
