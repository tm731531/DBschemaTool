using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class OrderPostponed
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderID")] 
        [MaxLength(10)] 
        public string @orderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("itemID")] 
        [MaxLength(4)] 
        public string @itemID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleNO")] 
        [MaxLength(7)] 
        public string @saleNO   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productID")] 
        [MaxLength(7)] 
        public string @productID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productName")] 
        [MaxLength(4000)] 
        public string @productName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MA")] 
        [MaxLength(6)] 
        public string? @MA   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MAName")] 
        [MaxLength(4000)] 
        public string? @MAName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MD")] 
        [MaxLength(6)] 
        public string @MD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MDName")] 
        [MaxLength(4000)] 
        public string @MDName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("supplierID")] 
        [MaxLength(6)] 
        public string @supplierID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("supplierName")] 
        [MaxLength(4000)] 
        public string @supplierName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("readyShipDate")] 
        [MaxLength(10)] 
        public string @readyShipDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shipDays")] 
        public byte @shipDays   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("delayDays")] 
        public int @delayDays   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderStatusName")] 
        [MaxLength(4000)] 
        public string @orderStatusName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("remark")] 
        [MaxLength(100)] 
        public string? @remark   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("shippingInfo")] 
        [MaxLength(1000)] 
        public string? @shippingInfo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("askDeliveryDate")] 
        [MaxLength(10)] 
        public string? @askDeliveryDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("largeClassName")] 
        [MaxLength(4000)] 
        public string? @largeClassName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("mediumClassName")] 
        [MaxLength(4000)] 
        public string? @mediumClassName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deliveryWay")] 
        [MaxLength(10)] 
        public string? @deliveryWay   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderMode")] 
        [MaxLength(10)] 
        public string? @orderMode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salePrice")] 
        public decimal? @salePrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("costPrice")] 
        public decimal @costPrice   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderDate")] 
        [MaxLength(10)] 
        public string @orderDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("expectWarehouseDate")] 
        [MaxLength(10)] 
        public string? @expectWarehouseDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("actuallyCaeeierID")] 
        [MaxLength(6)] 
        public string? @actuallyCaeeierID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("actuallyCaeeierName")] 
        [MaxLength(4000)] 
        public string? @actuallyCaeeierName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deliveryOrderID")] 
        [MaxLength(40)] 
        public string? @deliveryOrderID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("eType")] 
        public byte? @eType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("souldShipDate")] 
        [MaxLength(10)] 
        public string @souldShipDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("unifiedSerialNumber")] 
        [MaxLength(100)] 
        public string @unifiedSerialNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("delayStatus")] 
        [MaxLength(10)] 
        public string @delayStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("deliveryDate")] 
        [MaxLength(10)] 
        public string? @deliveryDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("categoryID")] 
        [MaxLength(8)] 
        public string @categoryID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("preorderShipDate")] 
        [MaxLength(10)] 
        public string? @preorderShipDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("preorderShipDays")] 
        public byte? @preorderShipDays   { get; set; }
}
}
