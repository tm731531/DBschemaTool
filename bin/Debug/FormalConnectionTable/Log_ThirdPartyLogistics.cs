using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_ThirdPartyLogistics
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public int? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("API_ThirdParty")] 
        [MaxLength(50)] 
        public string? @API_ThirdParty   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderID")] 
        public int? @OrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ItemID")] 
        public int? @ItemID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CombinedOrderID")] 
        public int? @CombinedOrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SaleNO")] 
        [MaxLength(40)] 
        public string? @SaleNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductID")] 
        [MaxLength(40)] 
        public string? @ProductID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Consignee")] 
        [MaxLength(50)] 
        public string? @Consignee   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Contactnumber")] 
        [MaxLength(50)] 
        public string? @Contactnumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DelveryAddressnm")] 
        [MaxLength(400)] 
        public string? @DelveryAddressnm   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DeliveryType")] 
        public int? @DeliveryType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorWarehouse")] 
        public int? @VendorWarehouse   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DeliveryMemo")] 
        public string? @DeliveryMemo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Weight")] 
        [MaxLength(20)] 
        public string? @Weight   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Safety")] 
        public decimal? @Safety   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DeliveryOrderId")] 
        [MaxLength(50)] 
        public string? @DeliveryOrderId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DownloadNO")] 
        [MaxLength(50)] 
        public string? @DownloadNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorID")] 
        [MaxLength(20)] 
        public string? @VendorID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Update_By")] 
        [MaxLength(10)] 
        public string? @Update_By   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Update_on")] 
        public DateTime? @Update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SetNo")] 
        [MaxLength(20)] 
        public string? @SetNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderProduct")] 
        [MaxLength(100)] 
        public string? @OrderProduct   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("NotifyType")] 
        public int? @NotifyType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ShipStatus")] 
        public int? @ShipStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SetVat")] 
        [MaxLength(30)] 
        public string? @SetVat   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Verified")] 
        public int? @Verified   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CDisType")] 
        public bool? @CDisType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoVendorId")] 
        public int? @FugoVendorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Platform")] 
        public int? @Platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FreightCompany")] 
        public int? @FreightCompany   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FailTimes")] 
        public int? @FailTimes   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_action")] 
        [MaxLength(1)] 
        public string? @trg_action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_create_on")] 
        public DateTime @trg_create_on   { get; set; }
}
}
