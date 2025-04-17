using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Timesheet.Data;

namespace Timesheet.Area.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")] // Optional: restrict access to authorized users only
    public class AdminController(ApplicationDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var param1 = string.Join(", ", context.Date.Select(x => x.StartDate));
            var param2 = string.Join(", ", context.Date.Select(x => x.EndDate));

            ViewData["Param1"] = !string.IsNullOrEmpty(param1) ? param1 : "Default Value 1";
            ViewData["Param2"] = !string.IsNullOrEmpty(param2) ? param2 : "Default Value 2";
            return View();
          
        }
    }
}
