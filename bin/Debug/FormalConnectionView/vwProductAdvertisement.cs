using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class vwProductAdvertisement
{
        ///<summary> 
        /// 
        /// </summary> 
        [Column("ProAd_ID")] 
        public long @ProAd_ID   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(40)] 
        public string? @saleCode   { get; set; }
}
}
