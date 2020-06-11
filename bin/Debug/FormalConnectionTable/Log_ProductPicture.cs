using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_ProductPicture
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("picturePath")] 
        public string? @picturePath   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("pictureSort")] 
        public int? @pictureSort   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("pictureCategory")] 
        public byte? @pictureCategory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("pictureOwnerId")] 
        public long? @pictureOwnerId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("uploadFileType")] 
        public bool? @uploadFileType   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fileName")] 
        public string? @fileName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isMiniatureImage")] 
        public int? @isMiniatureImage   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("lastModifiedTime")] 
        public DateTime? @lastModifiedTime   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_action")] 
        [MaxLength(1)] 
        public string? @trg_action   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("trg_create_on")] 
        public DateTime @trg_create_on   { get; set; }
}
}
