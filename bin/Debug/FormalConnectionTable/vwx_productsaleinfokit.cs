using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwx_productsaleinfokit
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PRODUCTID")] 
        public double? @PRODUCTID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SUPPLIERID")] 
        public double? @SUPPLIERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SALENO")] 
        public double? @SALENO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MULTISALENO")] 
        public double? @MULTISALENO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SCLASSCODE")] 
        public double? @SCLASSCODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MCLASSCODE")] 
        public double? @MCLASSCODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LCLASSCODE")] 
        public double? @LCLASSCODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PRODUCTNM")] 
        [MaxLength(255)] 
        public string? @PRODUCTNM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SHORTNAME")] 
        [MaxLength(255)] 
        public string? @SHORTNAME   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ITEMTYPE")] 
        public double? @ITEMTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SELLINGSTARTDATE")] 
        public DateTime? @SELLINGSTARTDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SELLINGENDDATE")] 
        public DateTime? @SELLINGENDDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MARKETPRICE")] 
        public double? @MARKETPRICE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PRICE")] 
        public double? @PRICE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("COST")] 
        public double? @COST   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GROSSMARGIN")] 
        public double? @GROSSMARGIN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GROSSPROFIT")] 
        public double? @GROSSPROFIT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GIFT")] 
        [MaxLength(255)] 
        public string? @GIFT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RETURNYN")] 
        [MaxLength(255)] 
        public string? @RETURNYN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SETTLEMENTTYPE")] 
        public double? @SETTLEMENTTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREDITPAYMENT")] 
        public double? @CREDITPAYMENT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INSTALLMENTNO")] 
        [MaxLength(255)] 
        public string? @INSTALLMENTNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EMPLOYEEPRICE")] 
        public double? @EMPLOYEEPRICE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BONUSPAYMENT")] 
        [MaxLength(255)] 
        public string? @BONUSPAYMENT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DELIVERYTYPE")] 
        public double? @DELIVERYTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SUBDELIVERYTYPE")] 
        public double? @SUBDELIVERYTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("NAKEDLENGTH")] 
        public double? @NAKEDLENGTH   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("NAKEDWIDTH")] 
        public double? @NAKEDWIDTH   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("NAKEDHEIGHT")] 
        public double? @NAKEDHEIGHT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CARRIAGE")] 
        public double? @CARRIAGE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ATTENTION")] 
        [MaxLength(255)] 
        public string? @ATTENTION   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("STATUS")] 
        public double? @STATUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("NAKEDWEIGHT")] 
        public double? @NAKEDWEIGHT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RATETYPE")] 
        [MaxLength(255)] 
        public string? @RATETYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RATE")] 
        public double? @RATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INCOMERATETYPE")] 
        [MaxLength(255)] 
        public string? @INCOMERATETYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INCOMERATE")] 
        public double? @INCOMERATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GROSSPROFITNOTAX")] 
        public double? @GROSSPROFITNOTAX   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GROSSMARGINNOTAX")] 
        public double? @GROSSMARGINNOTAX   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("REWARDBONUS")] 
        [MaxLength(255)] 
        public string? @REWARDBONUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("APPRECIATIONDAY")] 
        public double? @APPRECIATIONDAY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SALENAME")] 
        [MaxLength(255)] 
        public string? @SALENAME   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PURPOSE")] 
        public string? @PURPOSE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TAKEORDERTYPE")] 
        public double? @TAKEORDERTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CHARACTER")] 
        [MaxLength(255)] 
        public string? @CHARACTER   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PRODUCTSPECMODE")] 
        public double? @PRODUCTSPECMODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MD")] 
        public double? @MD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MA")] 
        public double? @MA   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("USE")] 
        [MaxLength(255)] 
        public string? @USE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ACCESSORY")] 
        [MaxLength(255)] 
        public string? @ACCESSORY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREATEDDATE")] 
        public DateTime? @CREATEDDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MODIFIEDDATE")] 
        public DateTime? @MODIFIEDDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("COMPANYID")] 
        public double? @COMPANYID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CONTRACTNO")] 
        [MaxLength(255)] 
        public string? @CONTRACTNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EXPRESSQTY")] 
        public double? @EXPRESSQTY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREDITBONUSUSEYN")] 
        [MaxLength(255)] 
        public string? @CREDITBONUSUSEYN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CODPAYMENT")] 
        [MaxLength(255)] 
        public string? @CODPAYMENT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PREORDER")] 
        [MaxLength(255)] 
        public string? @PREORDER   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CWPRODUCT")] 
        [MaxLength(255)] 
        public string? @CWPRODUCT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DISCOUNTABLE")] 
        [MaxLength(255)] 
        public string? @DISCOUNTABLE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IVRORDER")] 
        [MaxLength(255)] 
        public string? @IVRORDER   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AGENTORDER")] 
        [MaxLength(255)] 
        public string? @AGENTORDER   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SALENO2")] 
        public double? @SALENO2   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MULTISALESTATUS")] 
        public double? @MULTISALESTATUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MULTISALASTATUSNM")] 
        [MaxLength(255)] 
        public string? @MULTISALASTATUSNM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MULTISALEMODIFIEDDATE")] 
        public DateTime? @MULTISALEMODIFIEDDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CHAINSTOREYN")] 
        [MaxLength(255)] 
        public string? @CHAINSTOREYN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ISLANDSDELIVERY")] 
        [MaxLength(255)] 
        public string? @ISLANDSDELIVERY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ARRIVALDATE")] 
        public DateTime? @ARRIVALDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EXPRESSYN")] 
        [MaxLength(255)] 
        public string? @EXPRESSYN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AIRLIMIT")] 
        [MaxLength(255)] 
        public string? @AIRLIMIT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PACKTYPE")] 
        public double? @PACKTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BOXNO")] 
        public double? @BOXNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PACKTYPENM")] 
        [MaxLength(255)] 
        public string? @PACKTYPENM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("WEBPRODUCTDESC")] 
        [MaxLength(255)] 
        public string? @WEBPRODUCTDESC   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MANUALFILE")] 
        [MaxLength(255)] 
        public string? @MANUALFILE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GETPOINTRATE")] 
        public double? @GETPOINTRATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GETPOINT")] 
        public double? @GETPOINT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("USEPOINTRATE")] 
        public double? @USEPOINTRATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("USEPOINT")] 
        public double? @USEPOINT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ISPOINTAREA")] 
        [MaxLength(255)] 
        public string? @ISPOINTAREA   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MERCHID")] 
        [MaxLength(255)] 
        public string? @MERCHID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TERMID")] 
        [MaxLength(255)] 
        public string? @TERMID   { get; set; }
}
}
