using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nTier_RepositoryPattern.DtoLayer.AppUserDto;
using nTier_RepositoryPattern.Entity.Concrete;

namespace nTier_RepositoryPattern.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            AppUser appUser = new AppUser
            {
                UserName = appUserRegisterDto.Name,
                Name = appUserRegisterDto.Name,
                Surname = appUserRegisterDto.Surname,
                Email = appUserRegisterDto.Email
            };

            var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);

            return RedirectToAction("Index","Login");
        }
    }
}
