using Microsoft.AspNetCore.Mvc;
using BL.Interfaces;
using BL;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FanficsController : ControllerBase
    {
        private readonly IFanficService _fanficService;

        public FanficsController(IFanficService fanficService)
        {
            _fanficService = fanficService;
        }

        [HttpGet("{authorId}")]
        public async Task<IActionResult> GetFanficsWithChaptersByAuthor(int authorId)
        {
            var fanficsWithChapters = await _fanficService.GetFanficsWithChaptersByAuthor(authorId);
            if (fanficsWithChapters == null || !fanficsWithChapters.Any())
            {
                return NotFound();
            }
            return Ok(fanficsWithChapters);
        }
    }

}
