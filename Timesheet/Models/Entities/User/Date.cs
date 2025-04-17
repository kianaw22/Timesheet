using System.ComponentModel.DataAnnotations;

namespace Timesheet.Models.Entities.User
{
    public class Date
    {
        [Key]
        public int Id { get; set; }
        public string? StartDate { get; set; }

        public string? EndDate { get; set; }
    }
}
