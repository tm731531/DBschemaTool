using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class SocialMember
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 社交電商種類(1: 網連通 2:購享賺) 
        /// </summary> 
        [Column("SocialType")] 
        public byte? @SocialType   { get; set; }
        ///<summary> 
        /// 對應的前台客代 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public int? @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 對應的富購客代 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public int? @FugoCustomerID   { get; set; }
        ///<summary> 
        /// 社交電商會員狀態(0:停權 1:正常 2:凍結) 
        /// </summary> 
        [Column("SocialStatus")] 
        public byte? @SocialStatus   { get; set; }
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
