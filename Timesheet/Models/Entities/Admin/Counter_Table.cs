using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace Timesheet.Models.Entities.Admin
{
    public class Counter_Table
    {
        [Key]
        public int id { get; set; }
        public int Counter { get; set; }
    }
}
