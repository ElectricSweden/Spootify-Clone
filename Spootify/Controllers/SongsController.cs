using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spootify.Models;
using Spootify.Services;

namespace Spootify.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        public SongsController(JsonFileSongService songService)
        {
            this.SongService = songService;
        }

        public JsonFileSongService SongService { get; }

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return SongService.GetSongs();
        }

        //[HttpPatch] "[FromBody]"
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string SongName,
            [FromQuery] int Rating)
        {
            SongService.AddRating(SongName, Rating);
            return Ok();
        }
    }
}
