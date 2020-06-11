using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SocialMemberCashare
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// =SocialMember.id 
        /// </summary> 
        [Column("id_SocialMember")] 
        public long? @id_SocialMember   { get; set; }
        ///<summary> 
        /// 合作的廠商代碼(若有串OAUTH則以OAUTH產出寫入 若無則填統編，若未串接則NULL) 
        /// </summary> 
        [Column("ClientID")] 
        public int? @ClientID   { get; set; }
        ///<summary> 
        /// 社交電商串接的會員代碼;是由禾力(外部)給的 
        /// </summary> 
        [Column("SocialID")] 
        [MaxLength(50)] 
        public string? @SocialID   { get; set; }
        ///<summary> 
        /// 東購會員OAUTH代碼;從OAUTH呼叫後成功後取得，若未串接則NULL(=tb_CUSTOMER_OAUTH.CUST_ACCT_ID_ENCODE) 
        /// </summary> 
        [Column("EncodeID")] 
        public decimal? @EncodeID   { get; set; }
        ///<summary> 
        /// 推薦或導購碼(單一社交電商代碼不可重複) 
        /// </summary> 
        [Column("SocialCode")] 
        [MaxLength(50)] 
        public string? @SocialCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
}
}
