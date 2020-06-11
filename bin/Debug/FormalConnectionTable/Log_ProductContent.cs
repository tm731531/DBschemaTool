using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_ProductContent
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public int? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SalesCode")] 
        public string? @SalesCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_SalesMix")] 
        public int? @id_SalesMix   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ContentType")] 
        public int? @ContentType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ContentData")] 
        public string? @ContentData   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ContentClass")] 
        public int? @ContentClass   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsDelete")] 
        public bool? @IsDelete   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsUpdate")] 
        public bool? @IsUpdate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsEnabled")] 
        public bool? @IsEnabled   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ContentOrder")] 
        public int? @ContentOrder   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyUser")] 
        public string? @ModifyUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Guid")] 
        public string? @Guid   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CssClass")] 
        public string? @CssClass   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime? @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_action")] 
        [MaxLength(1)] 
        public string? @trg_action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_create_on")] 
        public DateTime @trg_create_on   { get; set; }
}
}
