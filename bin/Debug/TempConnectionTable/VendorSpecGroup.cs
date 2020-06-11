using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class VendorSpecGroup
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 廠商流水號(對應FORMAL.Vedor.id) 
        /// </summary> 
        [Column("id_Vendor")] 
        [MaxLength(100)] 
        public string @id_Vendor   { get; set; }
        ///<summary> 
        /// 款式群組名稱(Ex: 內衣、呎吋、電視系列) 
        /// </summary> 
        [Column("groupName")] 
        [MaxLength(100)] 
        public string @groupName   { get; set; }
        ///<summary> 
        /// 顏色或款式的群組(1-color, 2-style) 
        /// </summary> 
        [Column("groupType")] 
        public byte @groupType   { get; set; }
        ///<summary> 
        /// 排序(呈現時要依sort升冪排序) 
        /// </summary> 
        [Column("sort")] 
        public short @sort   { get; set; }
        ///<summary> 
        /// 建檔日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// 建檔人員(對應user.id) 
        /// </summary> 
        [Column("create_by")] 
        public int? @create_by   { get; set; }
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 修改人員(對應user.id) 
        /// </summary> 
        [Column("update_by")] 
        public int? @update_by   { get; set; }
}
}
