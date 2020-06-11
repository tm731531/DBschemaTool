using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_FUGO_VWX_RETURNINFO
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
        [Column("RETURNID")] 
        public long @RETURNID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RETURNORDERID")] 
        public long @RETURNORDERID   { get; set; }
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
        [Column("RETURNTYPE")] 
        public short? @RETURNTYPE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RETURNTYPENM")] 
        [MaxLength(4000)] 
        public string? @RETURNTYPENM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RETURNDATE")] 
        public DateTime? @RETURNDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RETURNWAREHOUSEDATE")] 
        public DateTime? @RETURNWAREHOUSEDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RETURNSTATUS")] 
        public short? @RETURNSTATUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RETURNSTATUSNM")] 
        [MaxLength(4000)] 
        public string? @RETURNSTATUSNM   { get; set; }
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
        [Column("INVOICESTATUS")] 
        public short? @INVOICESTATUS   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("INVOICESTATUSNM")] 
        [MaxLength(4000)] 
        public string? @INVOICESTATUSNM   { get; set; }
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
        [Column("INVOICERETURNDATE")] 
        public DateTime? @INVOICERETURNDATE   { get; set; }
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
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
}
}
