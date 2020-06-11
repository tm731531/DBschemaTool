using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class EHSDMaster
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 東森幣錢包ID 
        /// </summary> 
        [Column("EHSDID")] 
        public int? @EHSDID   { get; set; }
        ///<summary> 
        /// 活動ID 
        /// </summary> 
        [Column("OfferNO")] 
        public long? @OfferNO   { get; set; }
        ///<summary> 
        /// 認列單位 
        /// </summary> 
        [Column("ChannelID")] 
        public int? @ChannelID   { get; set; }
        ///<summary> 
        /// 備註 
        /// </summary> 
        [Column("Memo")] 
        [MaxLength(100)] 
        public string? @Memo   { get; set; }
        ///<summary> 
        /// 參數設定(請存Json格式) 
        /// </summary> 
        [Column("Parameters")] 
        public string? @Parameters   { get; set; }
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
