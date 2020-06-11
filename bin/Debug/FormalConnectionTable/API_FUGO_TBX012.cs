using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_FUGO_TBX012
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
        [Column("ORDERTYPE")] 
        public int @ORDERTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERSTATUS")] 
        public int @ORDERSTATUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("COMPANYID")] 
        public int @COMPANYID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SALENO")] 
        public int @SALENO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MULTISALENO")] 
        public int? @MULTISALENO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERQTY")] 
        public int @ORDERQTY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PRICE")] 
        public decimal @PRICE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CARRIAGE")] 
        public decimal @CARRIAGE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AMOUNT")] 
        public decimal @AMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SALEPRICE")] 
        public decimal @SALEPRICE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SALEAMOUNT")] 
        public decimal @SALEAMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DISCOUNTAMOUNT")] 
        public decimal @DISCOUNTAMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MANUALDISCOUNT")] 
        public decimal @MANUALDISCOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("APPROVEDBY")] 
        public int @APPROVEDBY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERAMOUNT")] 
        public decimal @ORDERAMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VERIFICATIONSTATUS")] 
        public int @VERIFICATIONSTATUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INVOICETYPE")] 
        [MaxLength(1)] 
        public string? @INVOICETYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INVOICETITLE")] 
        [MaxLength(60)] 
        public string? @INVOICETITLE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INVOICEADDRESSID")] 
        public int? @INVOICEADDRESSID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INVOICEAMOUNT")] 
        public decimal? @INVOICEAMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TAXAMOUNT")] 
        public decimal @TAXAMOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TAXRATE")] 
        public decimal @TAXRATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERNO")] 
        [MaxLength(20)] 
        public string @ORDERNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ITEMNO")] 
        [MaxLength(20)] 
        public string @ITEMNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DONATEDTARGET")] 
        public int? @DONATEDTARGET   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UNIFYNO")] 
        [MaxLength(20)] 
        public string? @UNIFYNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("WEBORDERTYPE")] 
        public int @WEBORDERTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BONUS")] 
        public decimal @BONUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("WEBDISCOUNT")] 
        public decimal @WEBDISCOUNT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("COUPONGROUPID")] 
        public int? @COUPONGROUPID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("COUPONNUMBER")] 
        [MaxLength(12)] 
        public string? @COUPONNUMBER   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CAMPAIGNNO")] 
        public int? @CAMPAIGNNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CAMPAIGNNAME")] 
        [MaxLength(50)] 
        public string? @CAMPAIGNNAME   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EINVOICE")] 
        [MaxLength(1)] 
        public string @EINVOICE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DDORDERID")] 
        [MaxLength(40)] 
        public string? @DDORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DDORDERSTATUS")] 
        public int? @DDORDERSTATUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DDORDERYN")] 
        [MaxLength(1)] 
        public string? @DDORDERYN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VDN")] 
        [MaxLength(6)] 
        public string? @VDN   { get; set; }
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
        [Column("CURRENCYAMT")] 
        public decimal? @CURRENCYAMT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CHAINSTOREID")] 
        public int? @CHAINSTOREID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SHOPPRICE")] 
        public decimal? @SHOPPRICE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SUBCHANNELID")] 
        public decimal? @SUBCHANNELID   { get; set; }
}
}
