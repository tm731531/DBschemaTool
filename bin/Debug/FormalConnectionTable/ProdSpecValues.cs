using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProdSpecValues
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 銷售編號 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(20)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 使用的規格表內容 (mongo:FormalPordSpecFormInfo 欄位 ID) 
        /// </summary> 
        [Column("ProductSpecID")] 
        public int? @ProductSpecID   { get; set; }
        ///<summary> 
        /// 規格ID 
        /// </summary> 
        [Column("SpecID")] 
        public int? @SpecID   { get; set; }
        ///<summary> 
        /// 規格名稱 
        /// </summary> 
        [Column("SpecName")] 
        [MaxLength(200)] 
        public string? @SpecName   { get; set; }
        ///<summary> 
        /// 規格屬性 ID 
        /// </summary> 
        [Column("ValueID")] 
        public int? @ValueID   { get; set; }
        ///<summary> 
        /// 規格屬性名稱或値 
        /// </summary> 
        [Column("ValueName")] 
        public string? @ValueName   { get; set; }
        ///<summary> 
        /// 是否選用 
        /// </summary> 
        [Column("IsEnabled")] 
        public bool? @IsEnabled   { get; set; }
        ///<summary> 
        /// 建立人 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 最後修改人 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
}
}
