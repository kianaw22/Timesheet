using System.ComponentModel.DataAnnotations;

namespace Timesheet.Models.ViewModels.Admin
{
    public class PositionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "یوزر")]
        public string UserId { get; set; }

        [Display(Name = "یوزرنیم")]
        public string UserName { get; set; }

        [Display(Name = "نوع سمت")]
        public string PositionType { get; set; }

        [Display(Name = "نام سمت")]
        public string PositionName { get; set; }
        [Display(Name = "کد سمت")]
        public string PositionCode { get; set; }


        [Display(Name = "فرمول فیلتر")]
        public string? Filtering { get; set; }

        [Display(Name = "فرمول گروه")]
        public string? Grouping { get; set; }


        [Display(Name = "امضا شده")]
        public bool? Signed { get; set; }
    }
}
