using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_FUGO_VWX_SHIPORDERINFO
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
        [Column("SHIPORDERID")] 
        public long? @SHIPORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CUSTOMERID")] 
        public long? @CUSTOMERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERID")] 
        public long @ORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ITEMID")] 
        public short @ITEMID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERNO")] 
        [MaxLength(20)] 
        public string? @ORDERNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERTYPE")] 
        public short? @ORDERTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERTYPENM")] 
        [MaxLength(4000)] 
        public string? @ORDERTYPENM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DELIVERYDATE")] 
        public DateTime? @DELIVERYDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RECEIVEDDATE")] 
        public DateTime? @RECEIVEDDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SHIPORDERSTATUS")] 
        public short @SHIPORDERSTATUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("STATUSNM")] 
        [MaxLength(4000)] 
        public string? @STATUSNM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TERMINATEDDATE")] 
        public DateTime? @TERMINATEDDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TERMINATEDCODE")] 
        public short? @TERMINATEDCODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TERMINATEDCODENM")] 
        [MaxLength(4000)] 
        public string? @TERMINATEDCODENM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TERMINATEDDESC")] 
        [MaxLength(1000)] 
        public string? @TERMINATEDDESC   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PICKUPCONFIRMDATE")] 
        public DateTime? @PICKUPCONFIRMDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("REASON")] 
        [MaxLength(200)] 
        public string? @REASON   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INVOICECODE")] 
        [MaxLength(20)] 
        public string? @INVOICECODE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INVOICENO")] 
        [MaxLength(20)] 
        public string? @INVOICENO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MODIFIEDDATE")] 
        public DateTime? @MODIFIEDDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CARRIERID")] 
        public long? @CARRIERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CARRIERNM")] 
        [MaxLength(4000)] 
        public string? @CARRIERNM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DELIVERYORDERID")] 
        [MaxLength(40)] 
        public string? @DELIVERYORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INVOICEDATE")] 
        public DateTime? @INVOICEDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERDATE")] 
        public DateTime? @ORDERDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PRINTDATE")] 
        public DateTime? @PRINTDATE   { get; set; }
}
}
