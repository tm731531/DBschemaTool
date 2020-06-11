using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class APIList
{
        ///<summary> 
        /// PK，流水編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// Api 的 URL 
        /// </summary> 
        [Column("ApiUrl")] 
        [MaxLength(500)] 
        public string @ApiUrl   { get; set; }
        ///<summary> 
        /// Api 的名稱 
        /// </summary> 
        [Column("ApiName")] 
        [MaxLength(50)] 
        public string @ApiName   { get; set; }
        ///<summary> 
        /// 群組 id 
        /// </summary> 
        [Column("Groupid")] 
        public short @Groupid   { get; set; }
        ///<summary> 
        /// 群組名稱 
        /// </summary> 
        [Column("GroupName")] 
        [MaxLength(50)] 
        public string @GroupName   { get; set; }
        ///<summary> 
        /// 是否禁用  0:False  1:True 
        /// </summary> 
        [Column("IsDisabled")] 
        public bool @IsDisabled   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime @CreateOn   { get; set; }
        ///<summary> 
        /// 建立人員 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 修改人員 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
}
}
