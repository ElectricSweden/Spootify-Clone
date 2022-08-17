using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Spootify.Pages
{
    public class PlaylistModel : PageModel
    {
        private readonly ILogger<PlaylistModel> _logger;

        public PlaylistModel(ILogger<PlaylistModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}