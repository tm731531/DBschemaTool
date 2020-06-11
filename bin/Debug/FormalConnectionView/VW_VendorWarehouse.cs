using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class VW_VendorWarehouse
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MerchantID")] 
        [MaxLength(30)] 
        public string @MerchantID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SetVat")] 
        [MaxLength(30)] 
        public string @SetVat   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SetClass")] 
        public int @SetClass   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CompanyName")] 
        [MaxLength(50)] 
        public string @CompanyName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SerialNumber")] 
        [MaxLength(8)] 
        public string @SerialNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("WarehouseName")] 
        [MaxLength(50)] 
        public string @WarehouseName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("API_ThirdParty")] 
        [MaxLength(30)] 
        public string @API_ThirdParty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("WareHouseStatus")] 
        public int @WareHouseStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorID")] 
        [MaxLength(10)] 
        public string @VendorID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Update_on")] 
        public DateTime @Update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Verified")] 
        public int? @Verified   { get; set; }
}
}
