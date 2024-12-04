using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Timesheet.Data;
using System.Linq.Dynamic.Core;

namespace Timesheet.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [Authorize]
    public class TimesheetController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public TimesheetController(ApplicationDbContext context , IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public IActionResult Index()
        {
            /*
            var currentUserId = User.Identity.Name;
            if (string.IsNullOrEmpty(currentUserId))
            {
                return BadRequest("user id fetch failed");
            }
            var filteringFormula = _context.Position
                .Where(p => p.UserName == currentUserId)
                .Select(p => p.Filtering)
                .FirstOrDefault();
            if (string.IsNullOrEmpty(filteringFormula))
            {
                return BadRequest("No filtering formula defined for the user.");
            }


            //personnelDepartment desc, prjCode asc
               var groupingFields = position.Grouping
            .Split(',')
        .Select(g =>
        {
            var parts = g.Trim().Split(' ');
            return new
            {
                field = parts[0],               // Field name
                dir = parts.Length > 1 ? parts[1].ToLower() : "asc" // Direction: asc or desc
            };
        })
        .ToList();
            */
            var filteringFormula = @"prjCode == ""7297"" OR prjCode == ""7289""";
            var groupingFormula = @"personnelDepartment desc, prjCode asc";
            try
            {
                var groupingFields = groupingFormula.Split(',').Select(g =>
                {
                    var parts = g.Trim().Split(' ');
                    return new
                    {
                        field = parts[0],               
                        dir = parts.Length > 1 ? parts[1].ToLower() : "asc" ,
                        aggregates = new List<object> // Add desired aggregations here
                        {
                            new { field ="extraWork", aggregate = "sum" }, // Example aggregation
                       
                        }
                      };
                }).ToList();

                var filteredTimesheet = _context.Timesheet.Where(filteringFormula).ToList();

                var jsonGrouping = JsonConvert.SerializeObject(groupingFields).Replace("\\", "\\\\");

                var jsonData = JsonConvert.SerializeObject(filteredTimesheet).Replace("'", "") .Replace("\\", "\\\\");
                ViewBag.JsonData = jsonData;
                ViewBag.GroupingData = jsonGrouping;

                return View();
            }
            catch (Exception ex)
            {
              
                return BadRequest($"Error applying filter: {ex.Message}");
            }
            
        }
    }
}
