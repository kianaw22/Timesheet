using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Timesheet.Data;

namespace Timesheet.Area.UserArea.Controllers
{
    [Area("UserArea")]
    [Authorize]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var param1 = string.Join(", ", _context.Date.Select(x => x.StartDate));
            var param2 = string.Join(", ", _context.Date.Select(x => x.EndDate));

            ViewData["Param1"] = !string.IsNullOrEmpty(param1) ? param1 : "Default Value 1";
            ViewData["Param2"] = !string.IsNullOrEmpty(param2) ? param2 : "Default Value 2";
            return View();
        }
    }
}
