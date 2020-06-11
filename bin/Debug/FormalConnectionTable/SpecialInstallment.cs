using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SpecialInstallment
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 商品銷編 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(20)] 
        public string @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 銀行代碼(ex:中信: 822) 
        /// </summary> 
        [Column("BankCode")] 
        [MaxLength(8)] 
        public string @BankCode   { get; set; }
        ///<summary> 
        /// 銀行分期設定-(0: 未設定, 1: 1期, 2: 3期, 4: 6期, 8: 9期, 16: 12期, 32: 24期, 64: 30期, 128: 36期) 上限:255 
        /// </summary> 
        [Column("InstallmentFlag")] 
        public int @InstallmentFlag   { get; set; }
        ///<summary> 
        /// 修改人員姓名 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
        ///<summary> 
        /// 建檔人員姓名 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 建檔日期 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
}
}
