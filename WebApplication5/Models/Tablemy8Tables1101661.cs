//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace WebApplication5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tablemy8Tables1101661
    {
        [Display(Name = "編號")]
        public int Id { get; set; }
        [Required(ErrorMessage = "請輸入Song")]
        [Display(Name = "歌曲名稱")]
        public string Song { get; set; }
        [Required(ErrorMessage = "請輸入Singer")]
        [Display(Name = "歌手")]
        public string Singer { get; set; }
        [Required(ErrorMessage = "請輸入Album")]
        [Display(Name = "專輯")]
        public string Album { get; set; }
        [Required(ErrorMessage = "請輸入 Clickthroughrate")]
        [Display(Name = "點閱率")]
        public string Clickthroughrate { get; set; }
        [Required(ErrorMessage = "請輸入Time")]
        [Display(Name = "時間")]
        public string Time { get; set; }
    }
}
