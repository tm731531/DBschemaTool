using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class Log_Product
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("pk")] 
        [Key] 
        public long @pk   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id")] 
        public long? @id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productCode")] 
        public string? @productCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productName")] 
        public string? @productName   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productCharacteristics")] 
        public string? @productCharacteristics   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productSpec")] 
        public string? @productSpec   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productNotes")] 
        public string? @productNotes   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("versionCode")] 
        public double? @versionCode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productStatus")] 
        public int? @productStatus   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("proposedCost")] 
        public double? @proposedCost   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("orderMode")] 
        public string? @orderMode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productCharacteristicsOutPlanner")] 
        public string? @productCharacteristicsOutPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productSpecMode")] 
        public string? @productSpecMode   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("useMethod")] 
        public string? @useMethod   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accessory")] 
        public string? @accessory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productSpecPlanner")] 
        public string? @productSpecPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productCharacteristicsPlanner")] 
        public string? @productCharacteristicsPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("productNotesPlanner")] 
        public string? @productNotesPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("useMethodPlanner")] 
        public string? @useMethodPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("accessoryPlanner")] 
        public string? @accessoryPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isChangePrdDesPlanner")] 
        public bool? @isChangePrdDesPlanner   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isChangeProductCharacteristics")] 
        public bool? @isChangeProductCharacteristics   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isChangeProductSpec")] 
        public bool? @isChangeProductSpec   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isChangeProductNotes")] 
        public bool? @isChangeProductNotes   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isChangeUseMethod")] 
        public bool? @isChangeUseMethod   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isChangeAccessory")] 
        public bool? @isChangeAccessory   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("isChangePresentDescription")] 
        public bool? @isChangePresentDescription   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FormID")] 
        public int? @FormID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductSpecOld")] 
        public string? @ProductSpecOld   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductSpecID")] 
        public int? @ProductSpecID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProductSpecJson")] 
        public string? @ProductSpecJson   { get; set; }
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
