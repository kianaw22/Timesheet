using AutoMapper;
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
        private readonly IMapper _mapper;
        public PositionController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var positions = _context.Position.ToList();
            return View(positions);
        }
        public IActionResult AddPosition()
        {

            FillDropDown();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPosition(PositionViewModel position)
        {

            FillDropDown();
            if (ModelState.IsValid)
            {
                var positionEntity = _mapper.Map<Position>(position);
                _context.Add(positionEntity);
               _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(position);
        }
        public IActionResult EditPosition(int id)
        {
            var position = _context.Position.Find(id);
            if (position == null)
            {
                return NotFound();
            }

            var positionViewModel = _mapper.Map<PositionViewModel>(position);
            FillDropDown();
            return View(positionViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPosition(PositionViewModel positionViewModel)
        {
            FillDropDown();
            if (ModelState.IsValid)
            {
                var positionEntity = _mapper.Map<Position>(positionViewModel);
                _context.Update(positionEntity);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(positionViewModel);
        }


        public IActionResult DeletePosition(int id )
        {
            var position = _context.Position.FirstOrDefault(p => p.Id == id);
            if (position == null)
            {
                return NotFound();
            }

            return PartialView("_DeletePosition", position);
        }
        [HttpPost]
        public IActionResult DeletePositionPost(int id)
        {
            var entity = _context.Position.Find(id);
            if (entity != null)
            {
                _context.Position.Remove(entity);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
        public void FillDropDown()
        {
            ViewBag.user = _context.Users
              .Select(u => new
              {
                  u.Id,
                  u.UserName,
                  FullName = u.Name + " " + u.Family
              }).ToList();
        }


    }
}
