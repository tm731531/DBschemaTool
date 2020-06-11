using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SPMSpecialExcelDetail
{
        ///<summary> 
        /// PK流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// MasterID 
        /// </summary> 
        [Column("MasterId")] 
        public int @MasterId   { get; set; }
        ///<summary> 
        /// 配送單號 
        /// </summary> 
        [Column("ShipOrderId")] 
        [MaxLength(50)] 
        public string @ShipOrderId   { get; set; }
        ///<summary> 
        /// 已MasterID為Gropu排序OrderID，順序由富購提供 
        /// </summary> 
        [Column("Sort")] 
        public short @Sort   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
}
}
