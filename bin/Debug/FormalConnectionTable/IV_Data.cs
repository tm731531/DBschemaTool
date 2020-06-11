using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class IV_Data
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 作業狀態 
        /// </summary> 
        [Column("status")] 
        [MaxLength(10)] 
        public string? @status   { get; set; }
        ///<summary> 
        /// 資料型態 
        /// </summary> 
        [Column("type")] 
        public int? @type   { get; set; }
        ///<summary> 
        /// 上傳方式 
        /// </summary> 
        [Column("way")] 
        public int? @way   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(100)] 
        public string? @saleCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fugoSaleNo")] 
        [MaxLength(60)] 
        public string? @fugoSaleNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sourceFrom")] 
        [MaxLength(500)] 
        public string? @sourceFrom   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("sourceUrl")] 
        public string? @sourceUrl   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("name")] 
        [MaxLength(500)] 
        public string? @name   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("cover")] 
        [MaxLength(500)] 
        public string? @cover   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("brandName")] 
        [MaxLength(100)] 
        public string? @brandName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("endorser")] 
        [MaxLength(500)] 
        public string? @endorser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("model")] 
        [MaxLength(500)] 
        public string? @model   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("termOn")] 
        public DateTime? @termOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("videoLength")] 
        [MaxLength(100)] 
        public string? @videoLength   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("fileSize")] 
        [MaxLength(100)] 
        public string? @fileSize   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("proofAuthforVideo")] 
        [MaxLength(500)] 
        public string? @proofAuthforVideo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("proofAuthforMusic")] 
        [MaxLength(500)] 
        public string? @proofAuthforMusic   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("musicMute")] 
        public bool? @musicMute   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("limited")] 
        [MaxLength(50)] 
        public string? @limited   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isMainVideo")] 
        public bool? @isMainVideo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Tags")] 
        [MaxLength(500)] 
        public string? @Tags   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("url")] 
        [MaxLength(1000)] 
        public string? @url   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("remark")] 
        public string? @remark   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("groupId")] 
        [MaxLength(100)] 
        public string? @groupId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_on")] 
        public DateTime? @create_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("create_by")] 
        public long? @create_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("update_by")] 
        public long? @update_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("stop_on")] 
        public DateTime? @stop_on   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("stop_by")] 
        public long? @stop_by   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isImageGo")] 
        public bool? @isImageGo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("imageGoDate")] 
        public DateTime? @imageGoDate   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("imageGoId")] 
        [MaxLength(200)] 
        public string? @imageGoId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("salesMixApplicationId")] 
        public long? @salesMixApplicationId   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("WidthPx")] 
        [MaxLength(200)] 
        public string? @WidthPx   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("HeightPx")] 
        [MaxLength(200)] 
        public string? @HeightPx   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("transferToNas")] 
        public int? @transferToNas   { get; set; }
        ///<summary> 
        /// Job執行失敗 
        /// </summary> 
        [Column("isFail")] 
        public bool? @isFail   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("beforeUrl")] 
        [MaxLength(1000)] 
        public string? @beforeUrl   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("beforeCover")] 
        [MaxLength(1000)] 
        public string? @beforeCover   { get; set; }
}
}
