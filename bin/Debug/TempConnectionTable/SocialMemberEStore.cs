using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SocialMemberEStore
{
        ///<summary> 
        /// 流水號 
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
        /// 店主代碼(不可重複不可修改) 
        /// </summary> 
        [Column("SocialID")] 
        [MaxLength(50)] 
        public string @SocialID   { get; set; }
        ///<summary> 
        /// 會員姓名 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(50)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 電話(手機) 
        /// </summary> 
        [Column("Mobile")] 
        [MaxLength(15)] 
        public string @Mobile   { get; set; }
        ///<summary> 
        /// 電子信箱 
        /// </summary> 
        [Column("Email")] 
        [MaxLength(100)] 
        public string? @Email   { get; set; }
        ///<summary> 
        /// 推薦或導購碼(單一社交電商代碼不可重複) 
        /// </summary> 
        [Column("SocialCode")] 
        [MaxLength(50)] 
        public string? @SocialCode   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 最後修改者 
        /// </summary> 
        [Column("UpdateUser")] 
        [MaxLength(50)] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 建立時間 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 建立者 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(50)] 
        public string? @CreateUser   { get; set; }
}
}
