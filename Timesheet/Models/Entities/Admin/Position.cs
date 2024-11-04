using System.Diagnostics.CodeAnalysis;

namespace Timesheet.Models.Entities.Admin
{
     public class Position
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PositionType { get; set; }
        public string PostionName { get; set; }
        public string Formula { get; set; }
        
    }
}
