using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Timesheet.Area.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")] // Optional: restrict access to authorized users only
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
