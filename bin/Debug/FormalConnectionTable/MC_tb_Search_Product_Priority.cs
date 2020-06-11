using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class MC_tb_Search_Product_Priority
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CAMP_ID")] 
        public int? @CAMP_ID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GOOD_ID")] 
        public int? @GOOD_ID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("GOOD_NM")] 
        [MaxLength(800)] 
        public string? @GOOD_NM   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Priority")] 
        public int? @Priority   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("STARTDATE")] 
        public DateTime? @STARTDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ENDDATE")] 
        public DateTime? @ENDDATE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREATEDATETIME")] 
        public DateTime? @CREATEDATETIME   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MODIFYDATETIME")] 
        public DateTime? @MODIFYDATETIME   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CREATEBY")] 
        [MaxLength(50)] 
        public string? @CREATEBY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MODIFYBY")] 
        [MaxLength(50)] 
        public string? @MODIFYBY   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ISENABLED")] 
        [MaxLength(1)] 
        public string? @ISENABLED   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("NOTE")] 
        [MaxLength(100)] 
        public string? @NOTE   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Boost_term")] 
        [MaxLength(200)] 
        public string? @Boost_term   { get; set; }
}
}
