using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreBilling
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// EStoreBillingSetup 裡面的ID編號 
        /// </summary> 
        [Column("id_EStoreBillingSetup")] 
        public int @id_EStoreBillingSetup   { get; set; }
        ///<summary> 
        /// 店主代碼 
        /// </summary> 
        [Column("id_EStoreMember")] 
        public int @id_EStoreMember   { get; set; }
        ///<summary> 
        /// 本期銷售總額 
        /// </summary> 
        [Column("OrderAmount")] 
        public decimal? @OrderAmount   { get; set; }
        ///<summary> 
        /// 本期銷退總額 
        /// </summary> 
        [Column("OrderReturnAmount")] 
        public decimal? @OrderReturnAmount   { get; set; }
        ///<summary> 
        /// 本期銷售淨額=OrderAmount-OrderReturnAmount 
        /// </summary> 
        [Column("OrderAmountNet")] 
        public decimal? @OrderAmountNet   { get; set; }
        ///<summary> 
        /// 本期PV 
        /// </summary> 
        [Column("PVAmount")] 
        public decimal? @PVAmount   { get; set; }
        ///<summary> 
        /// 本期PV沖帳 
        /// </summary> 
        [Column("PVReturnAmount")] 
        public decimal? @PVReturnAmount   { get; set; }
        ///<summary> 
        /// PV加給 
        /// </summary> 
        [Column("PVPlus")] 
        public decimal? @PVPlus   { get; set; }
        ///<summary> 
        /// PV淨值=PVAmount-PVReturnAmount+PVPlus 
        /// </summary> 
        [Column("PVNet")] 
        public decimal? @PVNet   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public int @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyUser")] 
        public int @LastModifyUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CashBackAmount")] 
        public int? @CashBackAmount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DividedRate")] 
        public decimal? @DividedRate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CashBackAmountNet")] 
        public int? @CashBackAmountNet   { get; set; }
}
}
