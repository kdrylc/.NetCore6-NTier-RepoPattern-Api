using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using nTier_RepositoryPattern.BussinessLayer.Abstract;
using nTier_RepositoryPattern.DtoLayer.AuthorDTO;
using nTier_RepositoryPattern.Entity;
using nTier_RepositoryPattern.Models;

namespace nTier_RepositoryPattern.Controllers
{
    [Authorize]
    public class AuthorController : Controller
    {
        
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult Index()
        {     
           return View(_authorService.TGetList());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Author p) 
        {
            _authorService.TInsert(p);      
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Author p)
        {
            _authorService.TDelete(p);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var authget = _authorService.TGetById(id);
            Author get = new Author()
            {
                
                Name= authget.Name,
                Surname= authget.Surname,
            };
            return View(get);
        }
        [HttpPost]
        public IActionResult Update(Author p)
        {
            var a = _authorService.TGetById(p.Id);
            a.Name = p.Name;
            a.Surname = p.Surname;
            _authorService.TUpdate(a);
            return RedirectToAction("Index");
        }
    }
}
