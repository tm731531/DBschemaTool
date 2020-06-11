using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class CashBackBillingSetup
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 結帳週期 
        /// </summary> 
        [Column("CashBillingNo")] 
        public DateTime? @CashBillingNo   { get; set; }
        ///<summary> 
        /// 帳單年月 
        /// </summary> 
        [Column("id_EStoreBillingSetup")] 
        public long? @id_EStoreBillingSetup   { get; set; }
        ///<summary> 
        /// 結算開始日 
        /// </summary> 
        [Column("StartDate")] 
        public DateTime? @StartDate   { get; set; }
        ///<summary> 
        /// 結算結束日 
        /// </summary> 
        [Column("EndDate")] 
        public DateTime? @EndDate   { get; set; }
        ///<summary> 
        /// 訂單結算匯入日 
        /// </summary> 
        [Column("LastImportDate")] 
        public DateTime? @LastImportDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
}
}
