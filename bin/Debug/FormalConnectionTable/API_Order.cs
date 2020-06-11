using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class API_Order
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 用戶訂單編號 
        /// </summary> 
        [Column("buyer_order_id")] 
        [MaxLength(30)] 
        public string @buyer_order_id   { get; set; }
        ///<summary> 
        /// 買家編號 
        /// </summary> 
        [Column("buyer_id")] 
        public long? @buyer_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("seller_channel")] 
        [MaxLength(20)] 
        public string? @seller_channel   { get; set; }
        ///<summary> 
        /// 付款方式(1: 信用卡, 2: 現金) 
        /// </summary> 
        [Column("pay_type")] 
        public byte? @pay_type   { get; set; }
        ///<summary> 
        /// 付款狀態(0: 未付款, 1: 巳付款) 
        /// </summary> 
        [Column("pay_status")] 
        public byte? @pay_status   { get; set; }
        ///<summary> 
        /// 訂單狀態(order_accept: 訂單受理, order_cancel: 訂單取消) 
        /// </summary> 
        [Column("order_status")] 
        [MaxLength(20)] 
        public string? @order_status   { get; set; }
        ///<summary> 
        /// 付款日期 
        /// </summary> 
        [Column("order_paid_time")] 
        public DateTime? @order_paid_time   { get; set; }
        ///<summary> 
        /// 買家姓名 
        /// </summary> 
        [Column("buyer_name")] 
        [MaxLength(20)] 
        public string? @buyer_name   { get; set; }
        ///<summary> 
        /// 買家匿名 
        /// </summary> 
        [Column("buyer_nick")] 
        [MaxLength(20)] 
        public string? @buyer_nick   { get; set; }
        ///<summary> 
        /// 買家郵遞區號 
        /// </summary> 
        [Column("buyer_zipcode")] 
        [MaxLength(10)] 
        public string? @buyer_zipcode   { get; set; }
        ///<summary> 
        /// 買家地址 
        /// </summary> 
        [Column("buyer_street")] 
        [MaxLength(100)] 
        public string? @buyer_street   { get; set; }
        ///<summary> 
        /// 買家手機號碼 
        /// </summary> 
        [Column("buyer_mobile")] 
        [MaxLength(15)] 
        public string? @buyer_mobile   { get; set; }
        ///<summary> 
        /// 買家家用電話號碼 
        /// </summary> 
        [Column("buyer_tel")] 
        [MaxLength(20)] 
        public string? @buyer_tel   { get; set; }
        ///<summary> 
        /// 買家電子郵件 
        /// </summary> 
        [Column("buyer_email")] 
        [MaxLength(100)] 
        public string? @buyer_email   { get; set; }
        ///<summary> 
        /// 收件人姓名 
        /// </summary> 
        [Column("receiver_name")] 
        [MaxLength(10)] 
        public string? @receiver_name   { get; set; }
        ///<summary> 
        /// 收件人郵遞區號 
        /// </summary> 
        [Column("receiver_zipcode")] 
        [MaxLength(10)] 
        public string? @receiver_zipcode   { get; set; }
        ///<summary> 
        /// 收件人地址 
        /// </summary> 
        [Column("receiver_street")] 
        [MaxLength(100)] 
        public string? @receiver_street   { get; set; }
        ///<summary> 
        /// 收件人手機號碼 
        /// </summary> 
        [Column("receiver_mobile")] 
        [MaxLength(15)] 
        public string? @receiver_mobile   { get; set; }
        ///<summary> 
        /// 收件人家用電話號碼 
        /// </summary> 
        [Column("receiver_tel")] 
        [MaxLength(20)] 
        public string? @receiver_tel   { get; set; }
        ///<summary> 
        /// 發票種類(二聯為 [D]、三聯為 [T]) 
        /// </summary> 
        [Column("invoice_type")] 
        [MaxLength(1)] 
        public string? @invoice_type   { get; set; }
        ///<summary> 
        /// 發票抬頭 
        /// </summary> 
        [Column("invoice_title")] 
        [MaxLength(50)] 
        public string? @invoice_title   { get; set; }
        ///<summary> 
        /// 發票地址 
        /// </summary> 
        [Column("invoice_street")] 
        [MaxLength(100)] 
        public string? @invoice_street   { get; set; }
        ///<summary> 
        /// 富購發票捐贈單位代碼(不捐贈：NULL , 東森慈善基金會：1002) 
        /// </summary> 
        [Column("invoice_donated_target")] 
        public int? @invoice_donated_target   { get; set; }
        ///<summary> 
        /// 發票統一編號 
        /// </summary> 
        [Column("invoice_uniform_no")] 
        [MaxLength(8)] 
        public string? @invoice_uniform_no   { get; set; }
        ///<summary> 
        /// 訂單金額 
        /// </summary> 
        [Column("total_fee")] 
        public decimal? @total_fee   { get; set; }
        ///<summary> 
        /// 運費 
        /// </summary> 
        [Column("post_fee")] 
        public decimal? @post_fee   { get; set; }
        ///<summary> 
        /// 付款金額(含運費) 
        /// </summary> 
        [Column("pay_fee")] 
        public decimal? @pay_fee   { get; set; }
        ///<summary> 
        /// 使用紅利點數 
        /// </summary> 
        [Column("point_fee")] 
        public decimal? @point_fee   { get; set; }
        ///<summary> 
        /// 是否富購巳建立 
        /// </summary> 
        [Column("is_fugo_created")] 
        public bool? @is_fugo_created   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugo_order_id")] 
        public long? @fugo_order_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugo_customer_id")] 
        public long? @fugo_customer_id   { get; set; }
        ///<summary> 
        /// 備註(英數上限60個字,中文30個字) 
        /// </summary> 
        [Column("memo")] 
        [MaxLength(60)] 
        public string? @memo   { get; set; }
        ///<summary> 
        /// 更新日期 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
}
}
