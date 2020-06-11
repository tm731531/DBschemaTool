using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class MonitorSalesMixType
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 監控主旨 
        /// </summary> 
        [Column("MonitorSubject")] 
        [MaxLength(1000)] 
        public string? @MonitorSubject   { get; set; }
        ///<summary> 
        /// 監控內容 
        /// </summary> 
        [Column("MonitorContext")] 
        [MaxLength(2000)] 
        public string? @MonitorContext   { get; set; }
        ///<summary> 
        /// 物件類別 
        /// </summary> 
        [Column("prodModel")] 
        [MaxLength(150)] 
        public string? @prodModel   { get; set; }
        ///<summary> 
        /// 提報類別 
        /// </summary> 
        [Column("SalesMixType")] 
        public int? @SalesMixType   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// SMA.id or SM.id 
        /// </summary> 
        [Column("DataModelId")] 
        public long? @DataModelId   { get; set; }
}
}
