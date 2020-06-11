using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class SubTitleEventSetupDetail
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 對應SubTitleEventSetup的ID 
        /// </summary> 
        [Column("id_SubTitleEventSetup")] 
        public long? @id_SubTitleEventSetup   { get; set; }
        ///<summary> 
        /// 分類ID或富購銷編(依活動設定所輸入的資料填入E前台分類seq/id或同富購銷編) 
        /// </summary> 
        [Column("SetupKey")] 
        public long? @SetupKey   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateDate")] 
        public DateTime @CreateDate   { get; set; }
}
}
