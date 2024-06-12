using Microsoft.AspNetCore.Mvc;
using BL.Interfaces;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookInfoController : ControllerBase
    {
        private readonly IBookInfoService _bookInfoService;

        public BookInfoController(IBookInfoService bookInfoService)
        {
            _bookInfoService = bookInfoService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFanficById(int id)
        {
            var bookInfoDto = await _bookInfoService.GetBookWithDetails(id);
            if (bookInfoDto == null)
            {
                return NotFound();
            }
            return Ok(bookInfoDto);
        }
    }
}
