using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProductMarketingTagLog
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seq")] 
        [Key] 
        public long @seq   { get; set; }
        ///<summary> 
        /// 1=頁面刪除, 2= Job 刪除 
        /// </summary> 
        [Column("Type")] 
        public int @Type   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
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
        /// 
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
        ///<summary> 
        /// Log建立時間 
        /// </summary> 
        [Column("CreateTime")] 
        public DateTime @CreateTime   { get; set; }
}
}
