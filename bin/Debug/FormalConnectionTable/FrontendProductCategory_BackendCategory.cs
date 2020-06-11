using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class FrontendProductCategory_BackendCategory
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 前台分類 seq 
        /// </summary> 
        [Column("id_FrontendProductCategory")] 
        public long @id_FrontendProductCategory   { get; set; }
        ///<summary> 
        /// 後台(fugo)分類 id 
        /// </summary> 
        [Column("id_BackendCategory")] 
        public long @id_BackendCategory   { get; set; }
        ///<summary> 
        /// 狀態: 0:等待設定, 1:設定完成, 9:刪除 
        /// </summary> 
        [Column("status")] 
        public int @status   { get; set; }
        ///<summary> 
        /// 申請人 
        /// </summary> 
        [Column("createUser")] 
        [MaxLength(50)] 
        public string? @createUser   { get; set; }
        ///<summary> 
        /// 申請時間 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 修改人(審核人) 
        /// </summary> 
        [Column("modifyUser")] 
        [MaxLength(50)] 
        public string? @modifyUser   { get; set; }
        ///<summary> 
        /// 修改時間(審核時間) 
        /// </summary> 
        [Column("modifyTime")] 
        public DateTime? @modifyTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
}
}
