using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_FUGO_TBX011
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
        [Column("spx_order_return_code")] 
        public long? @spx_order_return_code   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERID")] 
        public long @ORDERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERSOURCE")] 
        public long @ORDERSOURCE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CUSTOMERID")] 
        public long @CUSTOMERID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERDATE")] 
        public DateTime @ORDERDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERTYPE")] 
        [MaxLength(50)] 
        public string @ORDERTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERFROM")] 
        [MaxLength(20)] 
        public string? @ORDERFROM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ORDERNO")] 
        [MaxLength(20)] 
        public string? @ORDERNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREATEDBY")] 
        public long @CREATEDBY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREATEDDATE")] 
        public DateTime @CREATEDDATE   { get; set; }
}
}
