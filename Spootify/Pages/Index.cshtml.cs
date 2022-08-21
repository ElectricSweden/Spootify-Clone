using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spootify.Models;
using Spootify.Services;

namespace Spootify.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileSongService SongService;
        public IEnumerable<Song> Songs { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileSongService songService)
        {
            _logger = logger;
            SongService = songService;
        }

        public void OnGet()
        {
            Songs = SongService.GetSongs();
        }

    }
}