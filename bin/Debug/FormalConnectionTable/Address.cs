using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Address
{
        ///<summary> 
        /// 地址編號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 城市編號，FK，參照City表 
        /// </summary> 
        [Column("cityId_City")] 
        [MaxLength(12)] 
        public string @cityId_City   { get; set; }
        ///<summary> 
        /// 區域編號,FK,參照District表的districtId列 
        /// </summary> 
        [Column("districtId_District")] 
        [MaxLength(12)] 
        public string @districtId_District   { get; set; }
        ///<summary> 
        /// 街道 
        /// </summary> 
        [Column("street")] 
        [MaxLength(200)] 
        public string @street   { get; set; }
        ///<summary> 
        /// 最後更新時間標誌 
        /// </summary> 
        [Column("lastUpdated")] 
        public long @lastUpdated   { get; set; }
        ///<summary> 
        /// FK:關聯到Province表的id 
        /// </summary> 
        [Column("provinceId_Province")] 
        [MaxLength(12)] 
        public string @provinceId_Province   { get; set; }
        ///<summary> 
        /// 郵編 
        /// </summary> 
        [Column("zipCode")] 
        [MaxLength(12)] 
        public string? @zipCode   { get; set; }
        ///<summary> 
        /// 樓 
        /// </summary> 
        [Column("floor")] 
        [MaxLength(60)] 
        public string? @floor   { get; set; }
        ///<summary> 
        /// 室 
        /// </summary> 
        [Column("room")] 
        [MaxLength(60)] 
        public string? @room   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoAddressID")] 
        [MaxLength(60)] 
        public string? @fugoAddressID   { get; set; }
}
}
