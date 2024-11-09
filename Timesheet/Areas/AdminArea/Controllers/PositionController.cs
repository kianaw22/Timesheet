using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Pkcs;
using Timesheet.Data;
using Timesheet.Models.Entities;
using Timesheet.Models.Entities.Admin;
using Timesheet.Models.ViewModels.Admin;

namespace Timesheet.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class PositionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PositionController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var positions = _context.Posiiton.ToList();
            return View(positions);
        }
        public IActionResult AddPosition()
        {
           ViewBag.user = _context.Users
                 .Select(u => new
                 {
                     u.Id,
                     u.UserName,
                     FullName = u.Name + " " + u.Family
                 }).ToList();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPosition(PositionViewModel position)
        {
            ViewBag.user = _context.Users
               .Select(u => new
               {
                   u.Id,
                   u.UserName,
                   FullName = u.Name + " " + u.Family
               }).ToList();
            if (ModelState.IsValid)
            {
                var positionEntity = new Position
                {
                    UserId = position.UserId,
                    UserName = position.UserName,
                    PositionType = position.PositionType,
                    PostionName = position.PostionName,
                    Formula = position.Formula
                };
                _context.Add(positionEntity);
               _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(position);
        }

      

    }
}
