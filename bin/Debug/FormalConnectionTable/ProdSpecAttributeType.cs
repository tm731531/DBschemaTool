using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProdSpecAttributeType
{
        ///<summary> 
        /// 屬性類別 ID 
        /// </summary> 
        [Column("AttrTypeID")] 
        [Key] 
        public int @AttrTypeID   { get; set; }
        ///<summary> 
        /// 屬性類別名稱 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(100)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 啟用類別(0:不啟用, 1:啟用) 
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
