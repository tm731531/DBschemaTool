using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreMarketingData
{
        ///<summary> 
        /// 貼文流水號 
        /// </summary> 
        [Column("MsgID")] 
        [Key] 
        public long @MsgID   { get; set; }
        ///<summary> 
        /// 貼文種類-1-東森專屬優惠, 2-網連通獨家促銷 
        /// </summary> 
        [Column("Category")] 
        public byte @Category   { get; set; }
        ///<summary> 
        /// 推播平台流水號 
        /// </summary> 
        [Column("Serno")] 
        public long? @Serno   { get; set; }
        ///<summary> 
        /// 推播平台文章流水號 
        /// </summary> 
        [Column("PushID")] 
        public long? @PushID   { get; set; }
        ///<summary> 
        /// 推播時間 
        /// </summary> 
        [Column("PushDate")] 
        public DateTime? @PushDate   { get; set; }
        ///<summary> 
        /// 推播Title 
        /// </summary> 
        [Column("PushTitle")] 
        [MaxLength(250)] 
        public string? @PushTitle   { get; set; }
        ///<summary> 
        /// 推播Content 
        /// </summary> 
        [Column("PushContent")] 
        [MaxLength(250)] 
        public string? @PushContent   { get; set; }
        ///<summary> 
        /// 推播平台推播連結 
        /// </summary> 
        [Column("PushLink")] 
        public string? @PushLink   { get; set; }
        ///<summary> 
        /// 推播圖片連結 
        /// </summary> 
        [Column("PushImage")] 
        public string? @PushImage   { get; set; }
        ///<summary> 
        /// 推播種類(行銷) 
        /// </summary> 
        [Column("PushKind")] 
        public int? @PushKind   { get; set; }
        ///<summary> 
        /// 推播APP(Android) 
        /// </summary> 
        [Column("AppID")] 
        public int? @AppID   { get; set; }
        ///<summary> 
        /// 推播對象(全推) 
        /// </summary> 
        [Column("SendList")] 
        public string? @SendList   { get; set; }
        ///<summary> 
        /// 推播平台建檔日期 
        /// </summary> 
        [Column("SourceCreateDate")] 
        public DateTime? @SourceCreateDate   { get; set; }
        ///<summary> 
        /// 推薦的商品銷編 
        /// </summary> 
        [Column("FugoSaleNo")] 
        [MaxLength(12)] 
        public string? @FugoSaleNo   { get; set; }
        ///<summary> 
        /// 刪除日期 
        /// </summary> 
        [Column("DeleteDate")] 
        public DateTime? @DeleteDate   { get; set; }
        ///<summary> 
        /// 建檔日期 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 建檔人員 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(100)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 修改日期 
        /// </summary> 
        [Column("ModifyDate")] 
        public DateTime @ModifyDate   { get; set; }
        ///<summary> 
        /// 修改人員 
        /// </summary> 
        [Column("ModifyUser")] 
        [MaxLength(100)] 
        public string @ModifyUser   { get; set; }
}
}
