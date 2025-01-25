using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Timesheet.Data;
using Timesheet.Models.ViewModels.User;
namespace Timesheet.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [Authorize]
    public class KarkardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public KarkardController(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return Unauthorized("User is not logged in.");
            }
            var userposition = _context.Position.FirstOrDefault(p => p.UserId == userId && p.PositionCode == GetCounter());
            if (userposition == null)
            {
                return NotFound("Position is not found for this user");
            }
            var filteringFormula = userposition.Filtering;
            filteringFormula = filteringFormula?.Replace("\\\"", "\"");
            List<Models.Entities.User.Timesheet> filteredTimesheet = [];

            if (filteringFormula == null)
            {
                filteredTimesheet = _context.Timesheet.ToList();
            }
            else
            {
                filteredTimesheet= _context.Timesheet.Where(filteringFormula).ToList();
            }
            var reportData = filteredTimesheet
        .GroupBy(k => new { k.persCode, k.fNamePersian, k.lNamePersian })
        .Select(group => new KarkardViewModel
        {
            PersonelCode = group.Key.persCode,
         
            Name = group.Key.fNamePersian,
            Family = group.Key.lNamePersian,
            Department = group.Select(g=> g.personnelDepartment).FirstOrDefault(),
            EntryExitWork = group.Sum(g => g.tMWork + g.extraWork),
            TimesheetWork = group.Sum(g => g.timeSheetMWork),
            TMwork = group.Sum(g => g.tMWork),
            Delay = group.Sum(g => g.delayPercM),
            Absence = group.Sum(g => g.absenceM),
            ExtraWork = group.Sum(g => g.extraWork),
            PaidLeave = group.Sum(g => g.vacationPayM),
            NotAllowedExit = group.Sum(g => g.inMissionM),
            WorkAtHome = group.Sum(g => g.extraMissionM + g.homeWorkM),
            NotFilledTimeSheet = group.Sum(g => g.tMWork + g.extraWork - g.timeSheetMWork)

        })
        .ToList();

            return View(reportData);
        }
        public int GetCounter()
        {
            var countertable = _context.Counter_Table.ToList();
            var counter = countertable[0].Counter;
            return counter;
        }
    }
}
