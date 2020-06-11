using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProdSpecFormNew
{
        ///<summary> 
        /// PK (自動增加) 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 規格表ID 
        /// </summary> 
        [Column("FormID")] 
        public int @FormID   { get; set; }
        ///<summary> 
        /// 規格表名稱 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(200)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 規格ID 
        /// </summary> 
        [Column("SpecID")] 
        public int @SpecID   { get; set; }
        ///<summary> 
        /// 顯示名稱 
        /// </summary> 
        [Column("DisplayName")] 
        [MaxLength(200)] 
        public string @DisplayName   { get; set; }
        ///<summary> 
        /// 顯示排序 
        /// </summary> 
        [Column("DisplayOrder")] 
        public int @DisplayOrder   { get; set; }
        ///<summary> 
        /// 0:不篩選 1:篩選 
        /// </summary> 
        [Column("FilterEnable")] 
        public bool @FilterEnable   { get; set; }
        ///<summary> 
        /// 0:不啟用 1:啟用 
        /// </summary> 
        [Column("Active")] 
        public bool @Active   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("CreatedDate")] 
        public DateTime @CreatedDate   { get; set; }
        ///<summary> 
        /// 建立UserID 
        /// </summary> 
        [Column("CreatedUser")] 
        public int @CreatedUser   { get; set; }
        ///<summary> 
        /// 最後修改日期 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 最後修改UserID 
        /// </summary> 
        [Column("LastModifyUser")] 
        public int @LastModifyUser   { get; set; }
}
}
