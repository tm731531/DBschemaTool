using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreBillingSetup
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
        [Column("BillingNo")] 
        public DateTime @BillingNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BillingDateStart")] 
        public DateTime @BillingDateStart   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BillingDateEnd")] 
        public DateTime @BillingDateEnd   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BillingDateExport")] 
        public DateTime @BillingDateExport   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BillingShowDate")] 
        public DateTime @BillingShowDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BillingCheckoutDate")] 
        public DateTime? @BillingCheckoutDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BillingFile")] 
        [MaxLength(200)] 
        public string? @BillingFile   { get; set; }
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
        [Column("DividendRate")] 
        [MaxLength(1024)] 
        public string? @DividendRate   { get; set; }
}
}
