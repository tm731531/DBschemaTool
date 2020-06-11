using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MC_PANExclude
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 系統平台(1: U , 2: E) 
        /// </summary> 
        [Column("platform")] 
        public byte @platform   { get; set; }
        ///<summary> 
        /// FRI_FORMAL.ProductAccessedNum.id 
        /// </summary> 
        [Column("formal_pan_id")] 
        public long @formal_pan_id   { get; set; }
        ///<summary> 
        /// 處理結果(0: 失敗, 1: 成功, 2: 因規格停用, 不處理) 
        /// </summary> 
        [Column("status")] 
        public byte? @status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createDate")] 
        public DateTime @createDate   { get; set; }
}
}
