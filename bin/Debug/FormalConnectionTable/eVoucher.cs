using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class eVoucher
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 訂單編號 
        /// </summary> 
        [Column("OrderID")] 
        public long? @OrderID   { get; set; }
        ///<summary> 
        /// 訂單項次 
        /// </summary> 
        [Column("ItemID")] 
        public long? @ItemID   { get; set; }
        ///<summary> 
        /// 銷售名稱 
        /// </summary> 
        [Column("SaleName")] 
        [MaxLength(200)] 
        public string? @SaleName   { get; set; }
        ///<summary> 
        /// 核銷編號 
        /// </summary> 
        [Column("VoucherNumber")] 
        [MaxLength(100)] 
        public string? @VoucherNumber   { get; set; }
        ///<summary> 
        /// 票券編號 
        /// </summary> 
        [Column("VoucherPath")] 
        [MaxLength(100)] 
        public string? @VoucherPath   { get; set; }
        ///<summary> 
        /// 短網址驗証碼 
        /// </summary> 
        [Column("UrlValidCode")] 
        public long? @UrlValidCode   { get; set; }
        ///<summary> 
        /// 1001	新品類 1002	新品 1003	舊品重組 1004	關渡商品 1005	ECTV 1006	包檔商品 1007	珠寶專案商品 1008	墨攻商品 1009	年菜親取 1010	分次配送 1011	東源宅配 1012	東森超值券 1013	聯強 1014	醫美電子票券 
        /// </summary> 
        [Column("ProductType")] 
        public int? @ProductType   { get; set; }
        ///<summary> 
        /// 顯示QRCode(0/1) 
        /// </summary> 
        [Column("IsShowQRCode")] 
        public bool @IsShowQRCode   { get; set; }
        ///<summary> 
        /// 簡訊發送(0: 未發送, 1:巳發送) 
        /// </summary> 
        [Column("IsSendSMS")] 
        public bool @IsSendSMS   { get; set; }
        ///<summary> 
        /// 優惠期間 
        /// </summary> 
        [Column("ShortDescription")] 
        [MaxLength(300)] 
        public string? @ShortDescription   { get; set; }
        ///<summary> 
        /// 發送簡訊失敗次數，最大上限為3 
        /// </summary> 
        [Column("FailRetry")] 
        public byte @FailRetry   { get; set; }
        ///<summary> 
        /// 修改人員姓名 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(50)] 
        public string? @ModifyUser   { get; set; }
        ///<summary> 
        /// 修改時間 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime? @ModifyDate   { get; set; }
        ///<summary> 
        /// 新增人員姓名 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 新增時間 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 子帳號的流水號 
        /// </summary> 
        [Column("RedeemUserId")] 
        public int? @RedeemUserId   { get; set; }
        ///<summary> 
        /// 子帳號的姓名 
        /// </summary> 
        [Column("RedeemUserName")] 
        [MaxLength(100)] 
        public string? @RedeemUserName   { get; set; }
        ///<summary> 
        /// 子帳號的流水號 
        /// </summary> 
        [Column("BookingUserId")] 
        public int? @BookingUserId   { get; set; }
        ///<summary> 
        /// 子帳號的姓名 
        /// </summary> 
        [Column("BookingUserName")] 
        [MaxLength(100)] 
        public string? @BookingUserName   { get; set; }
}
}
