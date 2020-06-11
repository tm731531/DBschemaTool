using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class Log_TicketRecycling
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Id")] 
        public long? @Id   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("TokenNo")] 
        public string? @TokenNo   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("Money")] 
        public int? @Money   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RecyclingJson")] 
        public string? @RecyclingJson   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ETMallCustomerID")] 
        public int? @ETMallCustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoCustomerID")] 
        public int? @FugoCustomerID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ETMallResponsJson")] 
        public string? @ETMallResponsJson   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoRequestJson")] 
        public string? @FugoRequestJson   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("FugoResponseJson")] 
        public string? @FugoResponseJson   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("IsRecycling")] 
        public bool? @IsRecycling   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("RecyclingMessage")] 
        public string? @RecyclingMessage   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("id_MemberTransEHSD")] 
        public long? @id_MemberTransEHSD   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateOn")] 
        public DateTime? @CreateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateUser")] 
        public string? @CreateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("CreateIP")] 
        public string? @CreateIP   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateOn")] 
        public DateTime? @UpdateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateUser")] 
        public string? @UpdateUser   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("UpdateIP")] 
        public string? @UpdateIP   { get; set; }
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
