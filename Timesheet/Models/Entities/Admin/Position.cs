using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.Pkcs;

namespace Timesheet.Models.Entities.Admin
{
    public class Position
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PositionType { get; set; }
        public string PositionName { get; set; }

        public string? Filtering { get; set; }
        public string? Grouping { get; set; }
        public int? Order { get; set; }
        public int? Counter { get;set;}
        public bool? Signed { get; set; }

    }
}
