using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EStoreEHSDRecord
{
        ///<summary> 
        /// 東森幣發送記錄流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public int @Id   { get; set; }
        ///<summary> 
        /// 店主Table流水號 
        /// </summary> 
        [Column("Id_EStoreMember")] 
        public int @Id_EStoreMember   { get; set; }
        ///<summary> 
        /// 店主代碼 
        /// </summary> 
        [Column("EStoreNumber")] 
        [MaxLength(12)] 
        public string @EStoreNumber   { get; set; }
        ///<summary> 
        /// 富購客代 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public int @FugoCustomerID   { get; set; }
        ///<summary> 
        /// 東森幣活動代碼 
        /// </summary> 
        [Column("EHSDItemName")] 
        [MaxLength(100)] 
        public string? @EHSDItemName   { get; set; }
        ///<summary> 
        /// 東森幣贈幣數量 
        /// </summary> 
        [Column("EHSDItemValue")] 
        public int? @EHSDItemValue   { get; set; }
        ///<summary> 
        /// 東森幣給幣日期(時分秒) 
        /// </summary> 
        [Column("EHSDImportDate")] 
        public DateTime? @EHSDImportDate   { get; set; }
        ///<summary> 
        /// 建檔時間 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime? @CreateDate   { get; set; }
        ///<summary> 
        /// 建檔人員 
        /// </summary> 
        [Column("CreateUser")] 
        [MaxLength(100)] 
        public string? @CreateUser   { get; set; }
}
}
