using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class HighRiskOrderSettingPage_FrontCategoryGroup_keyWord
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        [Key] 
        public long @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Detail_Id")] 
        public long? @Detail_Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("KeyWord")] 
        [MaxLength(50)] 
        public string? @KeyWord   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsBought")] 
        public bool? @IsBought   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OverMoney")] 
        public int? @OverMoney   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("OverCount")] 
        public int? @OverCount   { get; set; }
}
}
