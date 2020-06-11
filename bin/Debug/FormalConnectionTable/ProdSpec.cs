using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class ProdSpec
{
        ///<summary> 
        /// 規格 ID 
        /// </summary> 
        [Column("SpecID")] 
        [Key] 
        public int @SpecID   { get; set; }
        ///<summary> 
        /// 規格名稱 
        /// </summary> 
        [Column("Name")] 
        [MaxLength(200)] 
        public string @Name   { get; set; }
        ///<summary> 
        /// 屬性類別ID，當 ChoiceType != 4 為必填 
        /// </summary> 
        [Column("AttrTypeID")] 
        public int? @AttrTypeID   { get; set; }
        ///<summary> 
        /// 這個規格使用的類別清單，使用,分隔 
        /// </summary> 
        [Column("AttrIDList")] 
        public string? @AttrIDList   { get; set; }
        ///<summary> 
        /// 是否以圖片呈現，0:文字、1:圖片，當ChoiceType != 4  為必填 
        /// </summary> 
        [Column("DisplayImg")] 
        public bool? @DisplayImg   { get; set; }
        ///<summary> 
        /// 是否必填，0:不是必填、1:必填 
        /// </summary> 
        [Column("Required")] 
        public bool @Required   { get; set; }
        ///<summary> 
        /// 1: 單選 2: 單選下拉 3: 複選  4:文字 
        /// </summary> 
        [Column("ChoiceType")] 
        [MaxLength(1)] 
        public string @ChoiceType   { get; set; }
        ///<summary> 
        /// 最多選擇數量，ChoiceType=3 時所使用 
        /// </summary> 
        [Column("MaxChoices")] 
        public byte? @MaxChoices   { get; set; }
        ///<summary> 
        /// ChoiceType=4 時使用    最少幾個字 
        /// </summary> 
        [Column("MinLength")] 
        public short? @MinLength   { get; set; }
        ///<summary> 
        /// 規格是否給PAN(提報時)表使用 0:False 1:True 
        /// </summary> 
        [Column("PANEnable")] 
        public bool @PANEnable   { get; set; }
        ///<summary> 
        /// 是否啟用，0:不啟用、1:啟用。若設定為 0 時，不在 mongoDb 顯示 
        /// </summary> 
        [Column("Active")] 
        public bool @Active   { get; set; }
        ///<summary> 
        /// 建立日期 
        /// </summary> 
        [Column("CreatedDate")] 
        public DateTime @CreatedDate   { get; set; }
        ///<summary> 
        /// 建立人 ID 
        /// </summary> 
        [Column("CreatedUser")] 
        public int @CreatedUser   { get; set; }
        ///<summary> 
        /// 最後修改時間 
        /// </summary> 
        [Column("LastModifyDate")] 
        public DateTime @LastModifyDate   { get; set; }
        ///<summary> 
        /// 最後修改人 ID 
        /// </summary> 
        [Column("LastModifyUser")] 
        public int @LastModifyUser   { get; set; }
}
}
