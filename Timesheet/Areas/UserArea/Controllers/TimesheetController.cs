using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Timesheet.Data;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using Newtonsoft.Json.Serialization;

namespace Timesheet.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [Authorize]
    public class TimesheetController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public TimesheetController(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public IActionResult Index()
        {
            //var filteringFormula = @"prjCode == ""7297"" OR prjCode == ""7289""";
            // var groupingFormula = @"personnelDepartment desc, prjCode asc";
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (userId == null )
            {
                return Unauthorized("User is not logged in.");
            }
            var userposition = _context.Position.FirstOrDefault(p => p.UserId == userId && p.PositionCode == GetCounter());
            if (userposition == null )
            {
                var maxCounter = _context.Position.Where(p => p.UserId == userId).Max(p => (int?)p.PositionCode) ?? 0;
                if (maxCounter == 0){
                    return NotFound("No position found for this user");
                }
                userposition = _context.Position.FirstOrDefault(p => p.UserId == userId && p.PositionCode == maxCounter);

            }

            var filteringFormula = userposition.Filtering;
            var groupingFormula = userposition.Grouping;
            var signed = userposition.Signed;
            try
            {
                var groupingFields = groupingFormula?.Split(',').Select(g =>
                {
                    var parts = g.Trim().Split(' ');
                    return new
                    {
                        field = parts[0],
                        dir = parts.Length > 1 ? parts[1].ToLower() : "asc",
                        aggregates = new List<object> 
                        {
                            new { field ="dMWork", aggregate = "sum" }, 
                       
                        }
                    };
                }).ToList();

                filteringFormula = filteringFormula?.Replace("\\\"", "\"");
                List<Models.Entities.User.Timesheet> filteredTimesheet = [];
                var position = GetField();

                if ( position=="Ceo")
                {
                    filteredTimesheet = _context.Timesheet.Where(x => x.fName != "خالی").ToList();
                }
                else
                {
                    IQueryable<Models.Entities.User.Timesheet> filter;
                    if ( string.IsNullOrEmpty(filteringFormula))
                    {
                        filter = _context.Timesheet.Where(x => x.fName != "خالی");
                    }
                    else
                    {
                         filter = _context.Timesheet.Where(x => x.fName != "خالی").Where(filteringFormula);

                    }
                    
                    if (position=="PrjHead" || position == "WtrDpt" || position == "GasDpt" ||position == "BusDpt"|| position == "SupDpt")
                    {
                        filter = filter.Where(a => a.NotAccept == null);
                        
                    }
                    filteredTimesheet = filter.ToList();

                }

                var jsonGrouping = JsonConvert.SerializeObject(groupingFields).Replace("\\", "\\\\");

                var jsonData = JsonConvert.SerializeObject(filteredTimesheet).Replace("'", "").Replace("\\", "\\\\");
          
                ViewBag.JsonData = jsonData;
                ViewBag.GroupingData = jsonGrouping;

                ViewBag.Signed = signed;
                ViewData["FieldToUse"] = GetField();
                return View();
            }
            catch (Exception ex)
            {

                return BadRequest($"Error applying filter: {ex.Message}");
            }
            
        }


        [HttpPost]
        public IActionResult UpdateNotAccept([FromBody]  List<int> uncheckedRecords)
        {
            if (uncheckedRecords == null || uncheckedRecords.Count == 0)
            {
                return BadRequest(new { success = false, message = "No records received." });
            }

            try
            {
                var recordsToUpdate = _context.Timesheet
                        .Where(t => uncheckedRecords.Contains((int)t.autoNumber))
                        .ToList();

                foreach (var record in recordsToUpdate)
                {
                    if (record.DepHead == false)
                    {
                        record.NotAccept += " and EngHead";
                    }
                    else
                    {
                        record.NotAccept = "not accept by EngHead"; // Update field
                    }
                 }

                    _context.SaveChanges();
                

                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = "Server error.", error = ex.Message });
            }
        }
        [HttpPost]
        public JsonResult Sign()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (userId == null)
                {
                    return Json(new { success = false, message = "User is not logged in." });
                }

                var position = _context.Position.FirstOrDefault(t => t.UserId == userId && t.PositionCode == GetCounter());
                

                if (position == null)
                {
                    return Json(new { success = false, message = "No position found for the user." });
                }

                position.Signed = true;
                _context.SaveChanges();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"An error occurred: {ex.Message}" });
            }
        }
        [HttpGet]
        public JsonResult GetSignedStatus()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var userposition = _context.Position.FirstOrDefault(p => p.UserId == userId && p.PositionCode == GetCounter());
                bool signed = userposition?.Signed ?? false;
                return Json(new { signed = signed });
            }
            catch (Exception ex)
            {
                return Json(new { error = true, message = ex.Message });
            }
        }
        public string? GetCurrentPosition()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return null;

            var position = _context.Position.FirstOrDefault(x => x.UserId == userId && x.PositionCode == GetCounter());
            if (position == null) return null;
            return position.PositionType;

        }
        public string? GetMaxCounterPosition()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return null;
            var maxCounter = _context.Position.Where(p => p.UserId == userId).Max(p => (int?)p.PositionCode) ?? 0;
            var position = _context.Position.FirstOrDefault(p => p.UserId == userId && p.PositionCode == maxCounter);
            if (position == null)
            {
                return null;
            }
            return position.PositionType ;
        }
        [HttpGet]
        public JsonResult GetUserPosition()
        {
            try
            {
                var position = GetCurrentPosition(); 
                if (position == null){
                    position = GetMaxCounterPosition();
                }
                return Json(new { position = position ?? "No Position" });
            }
            catch (Exception ex)
            {
                return Json(new { error = true, message = ex.Message });
            }
        }

        public int GetCounter()
        {
            var countertable = _context.Counter_Table.ToList();
            var counter = countertable[0].Counter;
            return counter;
        }
        [HttpGet]
        public string GetField()
        {
            var counter = GetCounter();
            string field="";
            if (counter == 1) 
            {
                var position = GetCurrentPosition();
                if (position=="مدیر بخش") field = "DepHead";
                else if (position == "امور حقوقی و قراردادها") { field = "Contract"; }
                else if (position == "کنترل پروژه") { field = "PrjControl"; }
            }
            else if (counter == 2) { field = "EngHead"; }
            else if (counter == 3) { field = "PrjHead"; }
            else if (counter == 4)
            {
                var position = GetCurrentPosition();
                if (position == "معاونت نفت و گاز") { field = "GasDpt";  }
                else if (position == "معاونت آب و انرژی") { field = "WtrDpt"; }
                else if (position == "معاونت پشتیبانی") { field = "SupDpt";  }
                else if (position == "معاونت توسعه کسب و کار") { field = "BusDpt";  }
                else if (position == "امور حقوقی و قراردادها") { field = "Contract"; }
                else if (position == "کنترل پروژه") { field = "PrjControl"; }


            }
            else if (counter == 5) { field = "Ceo"; }
            return field;

        }
        
    
        [HttpPost]
        public IActionResult UpdateField(int recordId, bool newValue)
        {

            var timesheetrow = _context.Timesheet.FirstOrDefault(t => t.autoNumber == recordId);
            if (timesheetrow != null)
            {
               
                var field = GetField(); 
                var property = timesheetrow.GetType().GetProperty(field);

                if (property != null)
                { 
                    property.SetValue(timesheetrow, newValue);
                    if (field == "DepHead" )
                    {
                        if (newValue == false)
                        {
                            timesheetrow.EngHead = false;
                            timesheetrow.NotAccept = $"not accept by {field}";
                        }
                        else
                        {
                            timesheetrow.EngHead = true;
                            timesheetrow.NotAccept =null;
                        }
                      
                    }
                    else if  (field == "EngHead" || field == "PrjControl" || field == "Contract")
                    {
                        if (newValue == false)
                        {
                            if (timesheetrow.DepHead == false )
                            {
                                timesheetrow.NotAccept = $"not accept by {field} and DepHead";
                            }
                            else
                            {
                                timesheetrow.NotAccept = $"not accept by {field}";
                            }
                            
                        }
                        else
                        {
                           
                            timesheetrow.NotAccept = null;
                        }

                    }
                    else
                    {
                        if (newValue == false)
                        {
                            timesheetrow.NotAccept = $"not accept by {field}";
                        }
                        else
                        {
                            timesheetrow.NotAccept = null;
                        }
                    }
                    _context.SaveChanges();
                    return Ok();
                }
                return BadRequest("property row isnt found");

            }
            return BadRequest("timesheet row isnt found");
        }

    }
}
