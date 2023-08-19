using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using nTier_RepositoryPattern.BussinessLayer.Abstract;

namespace nTier_ReositoryPattern.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorController : ControllerBase
	{
		private readonly IAuthorService _authorService;

		public AuthorController(IAuthorService authorService)
		{
			_authorService = authorService;
		}

		[HttpGet("AuthorGetAll")]
		public async Task<IActionResult> GetAll()
		{
			return Ok(_authorService.TGetList());
		}

		[HttpGet("AuthorGet")]
		public async Task<IActionResult> Get(int? id)
		{
			if (id == null || id == 0)
			{
				return BadRequest();
			}
			var author = _authorService.TGetById(id.Value);
			if (id == null)
			{
				return BadRequest();
			}
			return Ok(author);
		}

	


	}
}
