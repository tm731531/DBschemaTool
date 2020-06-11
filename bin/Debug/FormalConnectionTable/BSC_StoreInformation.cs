using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class BSC_StoreInformation
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PortalId")] 
        public int @PortalId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(100)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BusinessType")] 
        public int @BusinessType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("BusinessName")] 
        [MaxLength(50)] 
        public string? @BusinessName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Phone")] 
        [MaxLength(50)] 
        public string @Phone   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Remark")] 
        [MaxLength(500)] 
        public string? @Remark   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("City")] 
        [MaxLength(1)] 
        public string @City   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("District")] 
        [MaxLength(6)] 
        public string @District   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Addr")] 
        [MaxLength(200)] 
        public string @Addr   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Sort")] 
        public int @Sort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AdminEMail")] 
        [MaxLength(100)] 
        public string? @AdminEMail   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UseEHSD")] 
        public bool @UseEHSD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateEHSD")] 
        public bool @CreateEHSD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("StoreCode")] 
        [MaxLength(50)] 
        public string? @StoreCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TradeCode")] 
        [MaxLength(50)] 
        public string? @TradeCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Enabled")] 
        public bool @Enabled   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Creater")] 
        [MaxLength(50)] 
        public string @Creater   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateTime")] 
        public DateTime @CreateTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EHSDRecord")] 
        public bool @EHSDRecord   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LogoURI")] 
        [MaxLength(500)] 
        public string? @LogoURI   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Editer")] 
        [MaxLength(50)] 
        public string? @Editer   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EditTime")] 
        public DateTime? @EditTime   { get; set; }
}
}
