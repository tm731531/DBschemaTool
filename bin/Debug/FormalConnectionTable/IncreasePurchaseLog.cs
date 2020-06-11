using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Formal.Model.Tools
{
public class IncreasePurchaseLog
{
        ///<summary> 
        /// id 
        /// </summary> 
        [Column("id")] 
        [Key] 
        public long @id   { get; set; }
        ///<summary> 
        /// 商品代碼 (index) 
        /// </summary> 
        [Column("saleCode")] 
        [MaxLength(20)] 
        public string @saleCode   { get; set; }
        ///<summary> 
        /// 加價購商品代碼 
        /// </summary> 
        [Column("fr_saleCode")] 
        [MaxLength(20)] 
        public string @fr_saleCode   { get; set; }
        ///<summary> 
        /// 動作種類 1:主商品新增加價購 2:主商品刪除加價購 3:變更順序加價購商品順序 4:加價購新增主商品 5:加價購刪除主商品 
        /// </summary> 
        [Column("actionType")] 
        public int @actionType   { get; set; }
        ///<summary> 
        /// 異動值 
        /// </summary> 
        [Column("updateVal")] 
        [MaxLength(10)] 
        public string @updateVal   { get; set; }
        ///<summary> 
        /// 異動人員 (UserId) 
        /// </summary> 
        [Column("updateBy")] 
        [MaxLength(50)] 
        public string @updateBy   { get; set; }
        ///<summary> 
        /// 異動時間 
        /// </summary> 
        [Column("updateOn")] 
        public DateTime @updateOn   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("platform")] 
        public byte? @platform   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("e_id")] 
        public long? @e_id   { get; set; }
}
}
