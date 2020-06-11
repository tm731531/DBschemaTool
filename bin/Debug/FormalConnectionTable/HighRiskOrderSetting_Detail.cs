using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class HighRiskOrderSetting_Detail
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MasterID")] 
        public long? @MasterID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RegistType")] 
        [MaxLength(1)] 
        public string? @RegistType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BeforeRegisterDay")] 
        public int? @BeforeRegisterDay   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AfterRegistDate")] 
        public DateTime? @AfterRegistDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Pay")] 
        public int? @Pay   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BuyBeforeHours")] 
        public int? @BuyBeforeHours   { get; set; }
}
}
