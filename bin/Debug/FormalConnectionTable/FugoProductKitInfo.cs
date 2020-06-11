using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FugoProductKitInfo
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// KIT主商品 
        /// </summary> 
        [Column("SALENO")] 
        [MaxLength(60)] 
        public string @SALENO   { get; set; }
        ///<summary> 
        /// KIT所包含的商品FUGO PRODUCTID 
        /// </summary> 
        [Column("KIT_PRODUCTID")] 
        [MaxLength(60)] 
        public string @KIT_PRODUCTID   { get; set; }
        ///<summary> 
        /// KIT所包含的商品FUGO SALENO 
        /// </summary> 
        [Column("KIT_SALENO")] 
        [MaxLength(60)] 
        public string? @KIT_SALENO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SHORTNAME")] 
        [MaxLength(510)] 
        public string? @SHORTNAME   { get; set; }
        ///<summary> 
        /// 這個商品在KIT包裡的件數 
        /// </summary> 
        [Column("QTY")] 
        public int @QTY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("notes")] 
        [MaxLength(200)] 
        public string? @notes   { get; set; }
        ///<summary> 
        /// 1:UMALL, 2:ETMALL 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
