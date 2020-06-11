using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Draft
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 1.範本 2.新品草稿 3.修改商品草稿 5.大量上傳的暫存資料 7.駁回再提報草稿 8.修改駁回再提報草稿 9.競網小幫手(新品) 
        /// </summary> 
        [Column("draftType")] 
        public byte @draftType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createOn")] 
        public DateTime? @createOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createBy")] 
        [MaxLength(20)] 
        public string? @createBy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("updateOn")] 
        public DateTime? @updateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("updateBy")] 
        [MaxLength(20)] 
        public string? @updateBy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("agentBy")] 
        [MaxLength(20)] 
        public string? @agentBy   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TempProductApplicationID")] 
        [MaxLength(36)] 
        public string? @TempProductApplicationID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_product")] 
        public int? @id_product   { get; set; }
}
}
