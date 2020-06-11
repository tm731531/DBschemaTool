using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwVendorUser
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorUserId")] 
        [MaxLength(100)] 
        public string @VendorUserId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UserName")] 
        [MaxLength(200)] 
        public string @UserName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("email")] 
        [MaxLength(256)] 
        public string @email   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Password")] 
        [MaxLength(256)] 
        public string @Password   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isLock")] 
        public bool? @isLock   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("VendorId")] 
        [MaxLength(100)] 
        public string @VendorId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UserId")] 
        public long @UserId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ShortName")] 
        [MaxLength(100)] 
        public string? @ShortName   { get; set; }
}
}
