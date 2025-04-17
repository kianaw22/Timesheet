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
            // Get current user's Id.
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User is not logged in.");
            }

            // Find the user's position using their UserId and a PositionCode from GetCounter().
            var userPosition = _context.Position.FirstOrDefault(p => p.UserId == userId && p.PositionCode == GetCounter());
            if (userPosition == null)
            {
                return NotFound("Position is not found for this user");
            }

            // Retrieve the filtering formula and unescape quotes.
            var filteringFormula = userPosition.Filtering?.Replace("\\\"", "\"");

            // Retrieve the timesheet records based on the filtering formula if provided.
            List<Timesheet.Models.Entities.User.Timesheet> filteredTimesheets;
            if (string.IsNullOrEmpty(filteringFormula))
            {
                filteredTimesheets = _context.Timesheet.ToList();
            }
            else
            {
                // Note: Ensure that filteringFormula is a valid expression for use in Where.
                filteredTimesheets = _context.Timesheet.Where(filteringFormula).ToList();
            }

            // For each unique combination of person and date, select only the first record (ordered by AutoNumber).
            var distinctTimesheets = filteredTimesheets
                .GroupBy(t => new { t.persCode, t.date })
                .Select(g => g.OrderBy(t => t.autoNumber).FirstOrDefault())
                .ToList();

            // Aggregate the distinct records by person.
            var reportData = distinctTimesheets
                .GroupBy(t => new { t.persCode, t.fNamePersian, t.lNamePersian })
                .Select(g => new KarkardViewModel
                {
                    PersonelCode = g.Key.persCode,
                    Name = g.Key.fNamePersian,
                    Family = g.Key.lNamePersian,
                    Department = g.Select(t => t.personnelDepartment).FirstOrDefault(),
                    EntryExitWork = g.Sum(t => t.tMWork + t.inMissionM + t.extraWork),
                    TimesheetWork = g.Sum(t => t.timeSheetMWork),
                   // TMwork = g.Sum(t => t.tMWork +  t.homeWorkM + t.extraWork),
                    Delay = g.Sum(t => t.delayPercM),
                    Absence = g.Sum(t => t.absenceM),
                    ExtraWork = g.Sum(t => t.extraWork),
                    PaidLeave = g.Sum(t => t.vacationPayM),
                    NotAllowedExit = g.Sum(t => t.inMissionM),
                    WorkAtHome = g.Sum(t => t.extraMissionM + t.homeWorkM),
                    NotFilledTimeSheet = g.Sum(t => t.tMWork + t.extraWork+ t.homeWorkM  - t.timeSheetMWork)
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
