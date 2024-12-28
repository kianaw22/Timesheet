using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Timesheet.Data;
using Timesheet.Models.Entities;
using Timesheet.Models.ViewModels.Admin;

namespace Timesheet.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class UserManagerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserManagerController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var UserManagers = _context.Users.ToList();
            return View(UserManagers);
        }
        public IActionResult AddUserManager()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUserManager(UserManagerViewModel UserManagerViewModel)
        {

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = UserManagerViewModel.UserName,
                    Name= UserManagerViewModel.Name,
                    Family = UserManagerViewModel.Family,
                    PersonelCode = UserManagerViewModel.PersonelCode,
                    IsAdmin = UserManagerViewModel.IsAdmin,
                    Password = UserManagerViewModel.Password
                };
               // _userManager.PasswordValidators.Clear();
                var result = _userManager.CreateAsync(user, UserManagerViewModel.Password).Result;
                if (result.Succeeded)
                {
                    string role = UserManagerViewModel.IsAdmin ? "Admin" : "User";
                    var addToRoleResult = _userManager.AddToRoleAsync(user, role).Result;

                    if (addToRoleResult.Succeeded)
                    {
                        _context.SaveChanges();
                        return RedirectToAction("Index"); // Redirect to Index after success
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Failed add role to user.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Failed to Create user.");
                }

            }
            return View(UserManagerViewModel);
        }
        public IActionResult EditUserManager(string id)
        {
            var UserManager = _context.Users.Find(id);
            if (UserManager == null)
            {
                return NotFound();
            }

            var UserManagerViewModel = _mapper.Map<UserManagerViewModel>(UserManager);
            return View(UserManagerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUserManager(UserManagerViewModel UserManagerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.FindByIdAsync(UserManagerViewModel.Id).Result;
                if (user == null)
                {
                    return RedirectToAction("Error", "Shared", new { errorMessage = "User not found." });
                }
                user.Name = UserManagerViewModel.Name;
                user.Family = UserManagerViewModel.Family;
                user.PersonelCode = UserManagerViewModel.PersonelCode;
                user.UserName = UserManagerViewModel.UserName;
                user.IsAdmin = UserManagerViewModel.IsAdmin;
                user.Password = UserManagerViewModel.Password;

                var currentRole = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
                var newRole = UserManagerViewModel.IsAdmin ? "Admin" : "User";

                if (currentRole != newRole)
                {
                    _userManager.RemoveFromRoleAsync(user, currentRole).Wait();
                    _userManager.AddToRoleAsync(user, newRole).Wait();
                }
                if (!string.IsNullOrEmpty(UserManagerViewModel.Password))
                {
                    var passwordResult = _userManager.RemovePasswordAsync(user).Result;
                    if (passwordResult.Succeeded)
                    {
                        var addPasswordResult = _userManager.AddPasswordAsync(user, UserManagerViewModel.Password).Result;
                        if (!addPasswordResult.Succeeded)
                        {
                            ModelState.AddModelError(string.Empty, "Password change failed: " + string.Join(", ", addPasswordResult.Errors.Select(e => e.Description)));
                            return View(UserManagerViewModel);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Failed to remove old password.");
                        return View(UserManagerViewModel);
                    }
                }
                var updateResult = _userManager.UpdateAsync(user).Result;
                if (updateResult.Succeeded)
                {
                    return RedirectToAction("Index"); // Redirect after successful update
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "User update failed: " + string.Join(", ", updateResult.Errors.Select(e => e.Description)));
                }
            }

            return View(UserManagerViewModel);
        }
        [HttpGet]
        public IActionResult DeleteUserManager(string id)
        {
            var userm = _context.Users.FirstOrDefault(p => p.Id == id);
            if (userm == null)
            {
                return NotFound();
            }

            return PartialView("_deleteUserManager", userm);
        }
        [HttpPost]
        public IActionResult DeleteUserManagerPost(string id)
        {
            var entity = _context.Users.Find(id);
            if (entity != null)
            {
                _context.Users.Remove(entity);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
