using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class B2COpenID
{
        ///<summary> 
        /// 識別碼(PK) 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// Umall使用者帳號 (FK: formal.B2CUser.id) 
        /// </summary> 
        [Column("userID")] 
        public long @userID   { get; set; }
        ///<summary> 
        /// OpenID帳號類型： 0=FB 1=Google 2=Yahoo 3=Windows 
        /// </summary> 
        [Column("accType")] 
        public int @accType   { get; set; }
        ///<summary> 
        /// OpenID帳號eMail 
        /// </summary> 
        [Column("OpenIDAccount")] 
        [MaxLength(100)] 
        public string @OpenIDAccount   { get; set; }
        ///<summary> 
        /// 是否已綁定umall會員帳號 1=是 0=否 
        /// </summary> 
        [Column("IsUMallMember")] 
        public bool @IsUMallMember   { get; set; }
        ///<summary> 
        /// open account 的 uid 
        /// </summary> 
        [Column("accUID")] 
        [MaxLength(100)] 
        public string? @accUID   { get; set; }
}
}
