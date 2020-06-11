using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class MemberTransEHSD
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// =EHSDMaster.id 
        /// </summary> 
        [Column("id_EHSDMaster")] 
        public long? @id_EHSDMaster   { get; set; }
        ///<summary> 
        /// =SocialMember.id 
        /// </summary> 
        [Column("id_SocialMember")] 
        public long? @id_SocialMember   { get; set; }
        ///<summary> 
        /// 對應的前台客代 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public int? @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 對應的富購客代 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public int? @FugoCustomerID   { get; set; }
        ///<summary> 
        /// 借貸方式(C:加給, D: 扣除) 
        /// </summary> 
        [Column("DebitCredit")] 
        [MaxLength(2)] 
        public string? @DebitCredit   { get; set; }
        ///<summary> 
        /// 借貸類別(C =>1007:促銷給付, 1091:儲值-增加 ; D => 1092: 儲值-減少) 
        /// </summary> 
        [Column("ReferenceType")] 
        public short? @ReferenceType   { get; set; }
        ///<summary> 
        /// 東森幣 
        /// </summary> 
        [Column("TransactionValue")] 
        public decimal? @TransactionValue   { get; set; }
        ///<summary> 
        /// 有效日期(日期+235959) 
        /// </summary> 
        [Column("EndDate")] 
        public DateTime? @EndDate   { get; set; }
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
}
}
