using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class GiftSetting
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
        /// 贈品總數期望值 
        /// </summary> 
        [Column("GiftTotal")] 
        public byte? @GiftTotal   { get; set; }
        ///<summary> 
        /// 贈品可選取上限 
        /// </summary> 
        [Column("PickUpperLimit")] 
        public byte? @PickUpperLimit   { get; set; }
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
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
        ///<summary> 
        /// 修改人員姓名 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
}
}
