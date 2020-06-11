using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class HighRiskOrderSettingPage_SpecialMemberGroup
{
        ///<summary> 
        /// 流水號 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 設定版次流水號(HighRiskOrderSetting_SpecialMaster.id) 
        /// </summary> 
        [Column("SpecialMasterID")] 
        public long @SpecialMasterID   { get; set; }
        ///<summary> 
        /// 會員等級代碼 
        /// </summary> 
        [Column("Level")] 
        [MaxLength(10)] 
        public string? @Level   { get; set; }
}
}
