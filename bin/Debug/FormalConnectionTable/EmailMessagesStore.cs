using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class EmailMessagesStore
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MailId")] 
        [Key] 
        public long @MailId   { get; set; }
        ///<summary> 
        /// 信件主旨 
        /// </summary> 
        [Column("Subject")] 
        [MaxLength(100)] 
        public string? @Subject   { get; set; }
        ///<summary> 
        /// 信件內文 
        /// </summary> 
        [Column("BodyContent")] 
        public string @BodyContent   { get; set; }
        ///<summary> 
        /// 寄件者 
        /// </summary> 
        [Column("FromAddress")] 
        [MaxLength(50)] 
        public string? @FromAddress   { get; set; }
        ///<summary> 
        /// 收件者 
        /// </summary> 
        [Column("ToAddress")] 
        [MaxLength(300)] 
        public string? @ToAddress   { get; set; }
        ///<summary> 
        /// 寄送優先順序, 規範寄送的優先順序，目前從 1~5, 1 的優先度為最高. 
        /// </summary> 
        [Column("SendPriority")] 
        public int? @SendPriority   { get; set; }
        ///<summary> 
        /// 是否已寄送, 0:未寄送,1:已寄送. 
        /// </summary> 
        [Column("IsSent")] 
        public bool @IsSent   { get; set; }
        ///<summary> 
        /// 重複寄送次數, 當寄送失敗 (發生 Exception)，此計數值會加 1. 
        /// </summary> 
        [Column("ResendCount")] 
        public int @ResendCount   { get; set; }
        ///<summary> 
        /// 預計發送日期, null為即時發送，如果不會 null，則成為系統要寄發此 Mail 的設定時間. 
        /// </summary> 
        [Column("ScheduledSendDateTime")] 
        public DateTime? @ScheduledSendDateTime   { get; set; }
        ///<summary> 
        /// 發送信件類型. 
        /// </summary> 
        [Column("FunctionKey")] 
        public int @FunctionKey   { get; set; }
        ///<summary> 
        /// Email Template file Name, EX:AlertAvailableOrderQuantity.htm, SendRegisterReviterEmail.htm… 
        /// </summary> 
        [Column("FunctionName")] 
        [MaxLength(50)] 
        public string @FunctionName   { get; set; }
        ///<summary> 
        /// 信件建立者, 預設為 SystemAdmin. 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string @CreateUser   { get; set; }
        ///<summary> 
        /// 信件建立日期. 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 實際寄送日期, 可以用來檢視刪除順序. 
        /// </summary> 
        [Column("SendDateTime")] 
        public DateTime? @SendDateTime   { get; set; }
        ///<summary> 
        /// 附件路徑, 用以夾帶附件，目前尚未使用. 
        /// </summary> 
        [Column("AttachmentFilePath")] 
        [MaxLength(50)] 
        public string? @AttachmentFilePath   { get; set; }
        ///<summary> 
        /// 註記. 
        /// </summary> 
        [Column("Comment")] 
        public string? @Comment   { get; set; }
}
}
