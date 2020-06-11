using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEngine.Temp.Model.Tools
{
public class eJob
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
        [Column("saleNo_U")] 
        [MaxLength(60)] 
        public string? @saleNo_U   { get; set; }
        ///<summary> 
        /// 
        /// </summary> 
        [Column("saleNo_E")] 
        [MaxLength(60)] 
        public string? @saleNo_E   { get; set; }
        ///<summary> 
        /// 資料來源 1為U-mall, 2為Etmall 
        /// </summary> 
        [Column("datafrom")] 
        public byte @datafrom   { get; set; }
        ///<summary> 
        /// 複製完是否要壓二邊的fugoSaleNo2 
        /// </summary> 
        [Column("isAddSaleNo2")] 
        public bool @isAddSaleNo2   { get; set; }
        ///<summary> 
        /// 商品文件申請類別， 0: 新商品提報,1:修改商品 (不含:成本及分期設定)**停用**, 2:修改商品 (含: 成本及分期設定)**停用**,3:B2E主管修改商品(無變價功能), 4:B2E營業主管商品變價, 5:B2B修改商品(無變價功能), 6:B2B商品變價,7:B2B商品變量,8:營業主管變量,9:B2B修改商品銷售狀態,10:帶狀變價(JOB自動產生) 
        /// 11:B2E維護商品,12:B2E維護大批商品(修改銷售狀態),13:是否採購,14:B2E維護大批商品(修改其他),15:抓回失落的顏色款式,16:E複製到U要用的(ETMALL有很多商品是直接從FUGO拉回來) 
        ///  
        /// </summary> 
        [Column("salesMixType")] 
        public byte @salesMixType   { get; set; }
        ///<summary> 
        /// 狀態：未完成0 ;同步FUGO 1 ;壓fugoSaleNo2 2 ;同步完成 3 ; 同步失敗 4; 駁回 5;沒有顏色款式 6;純E或純U商品 7;SalesMix.productDevelopmentStaff,EU帳號是否啟用不一致 8;SalesMix已存在 9;EU同步失敗,再試一次 10 
        /// </summary> 
        [Column("status")] 
        public byte @status   { get; set; }
        ///<summary> 
        /// 建立者 
        /// </summary> 
        [Column("create_by")] 
        public long @create_by   { get; set; }
        ///<summary> 
        /// 通路建立日期 
        /// </summary> 
        [Column("create_on")] 
        public DateTime @create_on   { get; set; }
        ///<summary> 
        /// 通路最近一次異動日期 
        /// </summary> 
        [Column("update_on")] 
        public DateTime? @update_on   { get; set; }
        ///<summary> 
        /// 是否手動複製(JOB7-11手動複製專用欄位) 
        /// </summary> 
        [Column("isCopy")] 
        public bool @isCopy   { get; set; }
        ///<summary> 
        /// 是否手動綁定(JOB7-11手動複製專用欄位) 
        /// </summary> 
        [Column("isSync")] 
        public bool @isSync   { get; set; }
        ///<summary> 
        /// 記錄該job是誰跑的 
        /// </summary> 
        [Column("little_e")] 
        public byte? @little_e   { get; set; }
        ///<summary> 
        /// 註解 
        /// </summary> 
        [Column("notes")] 
        [MaxLength(250)] 
        public string? @notes   { get; set; }
}
}
