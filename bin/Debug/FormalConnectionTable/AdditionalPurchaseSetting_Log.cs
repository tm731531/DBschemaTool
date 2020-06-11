using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class AdditionalPurchaseSetting_Log
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
        [Column("logType")] 
        [MaxLength(10)] 
        public string @logType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("additionalPurchaseSettingId")] 
        public int @additionalPurchaseSettingId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(50)] 
        public string @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("activityStartTime")] 
        public DateTime @activityStartTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("activityEndTime")] 
        public DateTime @activityEndTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("purchaseType")] 
        public int @purchaseType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fullCount")] 
        public int @fullCount   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("settingUserID")] 
        public long @settingUserID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("createdTime")] 
        public DateTime @createdTime   { get; set; }
}
}
