using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SalesSettingCategory
{
        ///<summary> 
        /// 主鍵id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 1:處, 2:館, 3:中分類 
        /// </summary> 
        [Column("type")] 
        public int @type   { get; set; }
        ///<summary> 
        /// 業績分類名稱 
        /// </summary> 
        [Column("name")] 
        [MaxLength(256)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("remark")] 
        [MaxLength(256)] 
        public string? @remark   { get; set; }
        ///<summary> 
        /// 父類別Id 
        /// </summary> 
        [Column("parentCategoryId")] 
        public long @parentCategoryId   { get; set; }
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
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
}
}
