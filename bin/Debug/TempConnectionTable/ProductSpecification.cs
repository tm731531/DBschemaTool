using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class ProductSpecification
{
        ///<summary> 
        /// 規格編號ID 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 規格名稱 
        /// </summary> 
        [Column("specificationsName")] 
        [MaxLength(200)] 
        public string? @specificationsName   { get; set; }
        ///<summary> 
        /// 外鍵 關聯到本表中的主鍵specificationId 
        /// </summary> 
        [Column("specificationsFather_ProductSpecification")] 
        public int? @specificationsFather_ProductSpecification   { get; set; }
        ///<summary> 
        /// 規格的擁有者 0：系統常用規格 
        /// 其他編號:供應商外鍵 關聯到商品表vendorId 
        /// </summary> 
        [Column("specificationOwner_Vendor")] 
        public long @specificationOwner_Vendor   { get; set; }
        ///<summary> 
        /// 規格描述 
        /// </summary> 
        [Column("specificationDescription")] 
        [MaxLength(400)] 
        public string? @specificationDescription   { get; set; }
        ///<summary> 
        /// 原規格說明 關聯到ProductSpecification表中的Id 
        /// </summary> 
        [Column("originalSpecification_ProductSpecification")] 
        public long? @originalSpecification_ProductSpecification   { get; set; }
        ///<summary> 
        /// 原始規格名稱 
        /// </summary> 
        [Column("originalSpecificationName")] 
        [MaxLength(200)] 
        public string? @originalSpecificationName   { get; set; }
        ///<summary> 
        /// 常用規格ID 
        /// </summary> 
        [Column("commonSpecID")] 
        public int? @commonSpecID   { get; set; }
        ///<summary> 
        /// 0停用 1可用 
        /// </summary> 
        [Column("fugoUsable")] 
        public bool? @fugoUsable   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sort")] 
        public int? @sort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
}
}
