using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesMix_subChannel
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 富購銷售編號 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 子通路別代碼, ex: EU的網路都是999900 (FUGO型態是NUMBER 4) 
        /// </summary> 
        [Column("subChannel")] 
        public int @subChannel   { get; set; }
        ///<summary> 
        /// 1為U-mall, 2為Etmall 
        /// </summary> 
        [Column("platform")] 
        public byte @platform   { get; set; }
        ///<summary> 
        /// 1 未處理,2 銷售不可,3 已下市,4 可銷售,5 待同步 
        /// </summary> 
        [Column("status")] 
        public byte @status   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 通路最近一次異動日期 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
}
}
