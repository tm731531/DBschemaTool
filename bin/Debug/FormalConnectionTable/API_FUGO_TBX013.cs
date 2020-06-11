using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_FUGO_TBX013
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
        [Column("SEQ")] 
        public int @SEQ   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SUPPLIERID")] 
        public int @SUPPLIERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PRODUCTID")] 
        public int @PRODUCTID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("COLORID")] 
        public int @COLORID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("STYLEID")] 
        public int @STYLEID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("QTY")] 
        public int @QTY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("COST")] 
        public decimal @COST   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PRICE")] 
        public decimal @PRICE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DELIVERYTYPE")] 
        public int @DELIVERYTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CODPAYMENT")] 
        [MaxLength(1)] 
        public string @CODPAYMENT   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RETURNORDERID")] 
        public int? @RETURNORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PICKUPORDERID")] 
        public int? @PICKUPORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DELIVERYADDRESSID")] 
        public int @DELIVERYADDRESSID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CONSIGNEE")] 
        [MaxLength(50)] 
        public string @CONSIGNEE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CONTACTNUMBER")] 
        [MaxLength(16)] 
        public string? @CONTACTNUMBER   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("REMARK")] 
        [MaxLength(100)] 
        public string? @REMARK   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EXPRESSYN")] 
        [MaxLength(1)] 
        public string? @EXPRESSYN   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ASKDELIVERYDATE")] 
        public DateTime? @ASKDELIVERYDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ASKDELIVERYTIME")] 
        public int? @ASKDELIVERYTIME   { get; set; }
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
        [Column("SHIPORDERID")] 
        public int? @SHIPORDERID   { get; set; }
}
}
