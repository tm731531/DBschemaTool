using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class tmp_prodspec_L
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("SpecID")] 
        [Key] 
        public int @SpecID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(200)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AttrTypeID")] 
        public int? @AttrTypeID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("AttrIDList")] 
        public string? @AttrIDList   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("DisplayImg")] 
        public bool? @DisplayImg   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Required")] 
        public bool @Required   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ChoiceType")] 
        [MaxLength(1)] 
        public string @ChoiceType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MaxChoices")] 
        public byte? @MaxChoices   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("MinLength")] 
        public short? @MinLength   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("PANEnable")] 
        public bool @PANEnable   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Active")] 
        public bool @Active   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreatedDate")] 
        public DateTime @CreatedDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreatedUser")] 
        public int @CreatedUser   { get; set; }
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
