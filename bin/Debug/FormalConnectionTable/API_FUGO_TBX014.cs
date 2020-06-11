using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_FUGO_TBX014
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
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("api_order_id")] 
        public long? @api_order_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERID")] 
        public long @ORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ITEMID")] 
        public long @ITEMID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PAYMENTTYPE")] 
        public int @PAYMENTTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PAYDATE")] 
        public DateTime? @PAYDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PAYAMOUNT")] 
        public decimal @PAYAMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BANKID")] 
        public int? @BANKID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BANKCODE")] 
        [MaxLength(28)] 
        public string? @BANKCODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ACCOUNTNO")] 
        [MaxLength(20)] 
        public string? @ACCOUNTNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREDITCARDNO")] 
        [MaxLength(100)] 
        public string? @CREDITCARDNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INSTALLMENTNO")] 
        public int? @INSTALLMENTNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LAST3DIGITAL")] 
        [MaxLength(4)] 
        public string? @LAST3DIGITAL   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VALIDTHROUGH")] 
        [MaxLength(4)] 
        public string? @VALIDTHROUGH   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AUTHSTOREID")] 
        [MaxLength(20)] 
        public string? @AUTHSTOREID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AUTHBANK")] 
        public int? @AUTHBANK   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AUTHTERMINALNO")] 
        [MaxLength(20)] 
        public string? @AUTHTERMINALNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AUTHCODE")] 
        [MaxLength(20)] 
        public string? @AUTHCODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TRANSACTIONORDER")] 
        [MaxLength(20)] 
        public string? @TRANSACTIONORDER   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INSTALLMENTTYPE")] 
        [MaxLength(1)] 
        public string? @INSTALLMENTTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FIRSTPERIODAMOUNT")] 
        public decimal? @FIRSTPERIODAMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EACHPERIODAMOUNT")] 
        public decimal? @EACHPERIODAMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INSTALLMENTFEE")] 
        public decimal? @INSTALLMENTFEE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AUTHDATE")] 
        public DateTime? @AUTHDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ISCONTRACT")] 
        [MaxLength(1)] 
        public string? @ISCONTRACT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREDITPAYID")] 
        public int? @CREDITPAYID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SETTLEBANK")] 
        public int? @SETTLEBANK   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SETTLETERMINALNO")] 
        [MaxLength(20)] 
        public string? @SETTLETERMINALNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AUTHBANKTYPE")] 
        [MaxLength(20)] 
        public string? @AUTHBANKTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CARRIAGE")] 
        public decimal @CARRIAGE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BONUSPOINTUSE")] 
        public int? @BONUSPOINTUSE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BONUSPOINTAMT")] 
        public decimal? @BONUSPOINTAMT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BONUSBALANCE")] 
        public int? @BONUSBALANCE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("XID")] 
        [MaxLength(40)] 
        public string? @XID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RRPID")] 
        [MaxLength(40)] 
        public string? @RRPID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CURRENCY")] 
        public int? @CURRENCY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EXCHANGERATE")] 
        public decimal? @EXCHANGERATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DDPAYMENTTYPE")] 
        [MaxLength(30)] 
        public string? @DDPAYMENTTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DDPAYMENTDATE")] 
        public DateTime? @DDPAYMENTDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CURRENCYAMT")] 
        public decimal? @CURRENCYAMT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERNO")] 
        [MaxLength(20)] 
        public string? @ORDERNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ITEMNO")] 
        [MaxLength(20)] 
        public string? @ITEMNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PAYMENTID")] 
        public int? @PAYMENTID   { get; set; }
}
}
