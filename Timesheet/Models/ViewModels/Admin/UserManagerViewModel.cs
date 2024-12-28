namespace Timesheet.Models.ViewModels.Admin
{
    public class UserManagerViewModel
    {
        public string? Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string PersonelCode { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
