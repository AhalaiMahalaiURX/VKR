using Microsoft.AspNetCore.Mvc;
using BL.Interfaces;
using BL;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var authorDto = await _authorService.GetAuthorWithDetails(id);
            if (authorDto == null)
            {
                return NotFound();
            }
            return Ok(authorDto);
        }
    }

}
