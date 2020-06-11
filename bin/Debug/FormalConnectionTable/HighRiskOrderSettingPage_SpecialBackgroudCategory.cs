using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class HighRiskOrderSettingPage_SpecialBackgroudCategory
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
        /// 後台大分類代碼(BackendCategory.id) 
        /// </summary> 
        [Column("BackGroundCategoryFirstID")] 
        public long? @BackGroundCategoryFirstID   { get; set; }
        ///<summary> 
        /// 後台中分類代碼(BackendCategory.id) 
        /// </summary> 
        [Column("BackGroundCategorySecondID")] 
        public long? @BackGroundCategorySecondID   { get; set; }
        ///<summary> 
        /// 後台小分類代碼(BackendCategory.id) 
        /// </summary> 
        [Column("BackGroundCategoryThirdID")] 
        public long? @BackGroundCategoryThirdID   { get; set; }
        ///<summary> 
        /// 超過金額 
        /// </summary> 
        [Column("OverMoney")] 
        public int? @OverMoney   { get; set; }
        ///<summary> 
        /// 超過筆數 
        /// </summary> 
        [Column("OverCount")] 
        public int? @OverCount   { get; set; }
}
}
