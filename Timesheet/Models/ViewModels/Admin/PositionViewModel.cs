using System.ComponentModel.DataAnnotations;

namespace Timesheet.Models.ViewModels.Admin
{
    public class PositionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "یوزر")]
        public int UserId { get; set; }

        [Display(Name = "یوزرنیم")]
        public string UserName { get; set; }

        [Display(Name = "نوع سمت")]
        public string PositionType { get; set; }

        [Display(Name = "نام سمت")]
        public string PostionName { get; set; }

        [Display(Name = "فرمول")]
        public string Formula { get; set; }
    }
}
