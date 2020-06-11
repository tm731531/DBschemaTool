using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class FugoCarrier
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 貨運公司名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(20)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 貨運公司ID 
        /// </summary> 
        [Column("carrierId")] 
        public int @carrierId   { get; set; }
        ///<summary> 
        /// 是否顯示在SPM出貨管理頁 1:顯示, 0:不顯示 
        /// </summary> 
        [Column("isShow")] 
        public byte @isShow   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
