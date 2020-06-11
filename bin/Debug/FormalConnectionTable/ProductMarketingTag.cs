using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductMarketingTag
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 富購銷編 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(60)] 
        public string @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 1=優選, 2=未來擴充使用 
        /// </summary> 
        [Column("TagID")] 
        public int @TagID   { get; set; }
        ///<summary> 
        /// 上架時間 
        /// </summary> 
        [Column("StartTime")] 
        public DateTime @StartTime   { get; set; }
        ///<summary> 
        /// 下架時間 
        /// </summary> 
        [Column("EndTime")] 
        public DateTime @EndTime   { get; set; }
        ///<summary> 
        /// 標籤狀態 0無效 1有效 
        /// </summary> 
        [Column("Status")] 
        public bool @Status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string @ModifyUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime @ModifyDate   { get; set; }
        ///<summary> 
        /// 主管同意 
        /// </summary> 
        [Column("IsManageAgree")] 
        public bool? @IsManageAgree   { get; set; }
}
}
