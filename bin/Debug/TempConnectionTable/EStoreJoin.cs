using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreJoin
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public int @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CustomerID")] 
        public int @CustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CustomerName")] 
        [MaxLength(50)] 
        public string @CustomerName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CustomerMobile")] 
        [MaxLength(15)] 
        public string @CustomerMobile   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderNo")] 
        public int @OrderNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreNo")] 
        [MaxLength(15)] 
        public string @EStoreNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreName")] 
        [MaxLength(50)] 
        public string @EStoreName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("EStoreNumber")] 
        [MaxLength(12)] 
        public string? @EStoreNumber   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OrderDate")] 
        public DateTime @OrderDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Status")] 
        public bool @Status   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProcessMemo")] 
        [MaxLength(2000)] 
        public string? @ProcessMemo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public int @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("LastModifyUser")] 
        public int @LastModifyUser   { get; set; }
}
}
