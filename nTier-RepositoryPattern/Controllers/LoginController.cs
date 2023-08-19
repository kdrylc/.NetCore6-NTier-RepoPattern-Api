using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nTier_RepositoryPattern.Entity.Concrete;
using nTier_RepositoryPattern.Models;

namespace nTier_RepositoryPattern.Controllers
{
	public class LoginController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Index(LoginViewModel loginViewModel)
		{
			var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, false, true);
			if (result.Succeeded)
			{
				var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
				
					return RedirectToAction("Index", "Home");
				

			}
			return View();
		}

	}
}
