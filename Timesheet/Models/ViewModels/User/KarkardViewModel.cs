namespace Timesheet.Models.ViewModels.User
{
    public class KarkardViewModel
    {
        public int PersonelCode { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int? EntryExitWork { get; set; }
        public int? TMwork { get; set; }
        public int? TimesheetWork { get; set; }
        public int? Delay { get; set; }
        public int? Absence { get; set; }
        public int? ExtraWork { get; set; }
        public int? NotAllowedExit { get; set; }
        public int? WorkAtHome { get; set; }
         public int? PaidLeave { get; set; }
        public int? NotFilledTimeSheet { get; set; }
        public string? Department { get; set; }

    }
}
