using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SMA_ProdSpecValues
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// SMAID 
        /// </summary> 
        [Column("id_SMA")] 
        public long? @id_SMA   { get; set; }
        ///<summary> 
        /// FormID 
        /// </summary> 
        [Column("FormID")] 
        public int? @FormID   { get; set; }
        ///<summary> 
        /// 規格ID 
        /// </summary> 
        [Column("SpecID")] 
        public int? @SpecID   { get; set; }
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
