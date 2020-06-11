using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Gift
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 主商品銷編 
        /// </summary> 
        [Column("FugoSaleNo_Main")] 
        [MaxLength(20)] 
        public string? @FugoSaleNo_Main   { get; set; }
        ///<summary> 
        /// 贈品銷編 
        /// </summary> 
        [Column("FugoSaleNo_Gift")] 
        [MaxLength(20)] 
        public string? @FugoSaleNo_Gift   { get; set; }
        ///<summary> 
        /// 建檔日期 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 建檔人員姓名 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
}
}
