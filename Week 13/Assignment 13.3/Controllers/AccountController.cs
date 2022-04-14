using Microsoft.AspNetCore.Mvc;
//step 9.6
using Microsoft.AspNetCore.Identity;
using Assignment12._1.Models;
using System.Threading.Tasks;
//step 18.6
using Assignment12._1.ViewModels;

namespace Assignment12._1.Controllers
{
    public class AccountController : Controller
    {
        //step 10.6
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        //step 11.6
        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        //step 19.6
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginView)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginView.UserName, loginView.Password, loginView.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Failed to login");
            return View();
        }

        //step 20.6
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User newuser = new User()
                {
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    UserName = registerViewModel.UserName,
                    PhoneNumber = registerViewModel.PhoneNumber.ToString(),
                    Email = registerViewModel.Email
                };
                var result = await _userManager.CreateAsync(newuser, registerViewModel.Password);
                if (result.Succeeded)
                {
                    //step 39.6
                    var addedUser = await _userManager.FindByNameAsync(newuser.UserName);
                    if (addedUser.UserName == "Admin")
                    {
                        await _userManager.AddToRoleAsync(addedUser, "Admin");
                        await _userManager.AddToRoleAsync(addedUser, "Customer");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(addedUser, "Customer");
                    }

                    //step 20.6
                    return RedirectToAction("Login", "Account");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        //step 12.6
        //this method can also be synchronous
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //step 13.6
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
