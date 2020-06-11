using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BlockSetupForProductVideo
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 移除類型 :  1-黑名單；2-手動移除 
        /// </summary> 
        [Column("BlockType")] 
        public short @BlockType   { get; set; }
        ///<summary> 
        /// 富購銷編 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(12)] 
        public string @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 刪除註記 
        /// </summary> 
        [Column("IsDelete")] 
        public bool @IsDelete   { get; set; }
        ///<summary> 
        /// 新增日期 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
        ///<summary> 
        /// 新增人員 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(200)] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
        ///<summary> 
        /// 修改人員 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(200)] 
        public string? @ModifyUser   { get; set; }
}
}
