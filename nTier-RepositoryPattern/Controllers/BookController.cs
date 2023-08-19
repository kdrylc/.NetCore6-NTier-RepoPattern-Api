using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using nTier_RepositoryPattern.BussinessLayer.Abstract;
using nTier_RepositoryPattern.DataAccesLayer.Concrete;
using nTier_RepositoryPattern.Entity;

namespace nTier_RepositoryPattern.Controllers
{
	[Authorize]
	public class BookController : Controller
    {
        private readonly IBookService _bookService;
        Context db = new Context();

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public IActionResult Index()
        {      
            return View(_bookService.TGetList());
        }

        public IActionResult Create()
        {
            List<SelectListItem> val = (from i in db.Authors.ToList()
                                        select new SelectListItem
                                        {
                                            Text = i.Name,
                                            Value = i.Id.ToString()
                                        }).ToList();
            ViewBag.vls = val;
            return View();
        }


        [HttpPost]
        public IActionResult Create(Book p)
        {
            Book f = new Book();
            f.Name = p.Name;
            f.AuthorId = p.AuthorId;
            _bookService.TInsert(f);

            return RedirectToAction("Index");
        }

    }
}
