using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesSettingCategoryRelation
{
        ///<summary> 
        /// 主鍵id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 業績分類_中分類 
        /// </summary> 
        [Column("salesSettingCategoryId")] 
        public long @salesSettingCategoryId   { get; set; }
        ///<summary> 
        /// 富購後台分類_小分類 
        /// </summary> 
        [Column("backendCategoryId")] 
        public long @backendCategoryId   { get; set; }
        ///<summary> 
        /// 前台分類_館分類 
        /// </summary> 
        [Column("frontendProductCategoryId")] 
        public long @frontendProductCategoryId   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("remark")] 
        [MaxLength(256)] 
        public string? @remark   { get; set; }
        ///<summary> 
        /// 建立者:FK:User表id 
        /// </summary> 
        [Column("createUser")] 
        public long? @createUser   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("createTime")] 
        public DateTime @createTime   { get; set; }
        ///<summary> 
        /// 修改者:FK:User表id 
        /// </summary> 
        [Column("modifyUser")] 
        public long? @modifyUser   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("modifyTime")] 
        public DateTime? @modifyTime   { get; set; }
}
}
