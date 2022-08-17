using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Spootify.Models;
using Microsoft.AspNetCore.Hosting;

namespace Spootify.Services
{
    public class JsonFileSongService
    {
        public JsonFileSongService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "songs.json"); }
        }

        public IEnumerable<Song>? GetSongs()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Song[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void AddRating(string SongName, int rating)
        {
            var songs = GetSongs();
            var query = songs.First(x => x.Name == SongName);

            if(query.Ratings == null)
            {
                query.Ratings = new int[] { rating };
            }
            else
            {
                var ratings = query.Ratings.ToList();
                ratings.Add(rating);
                query.Ratings = ratings.ToArray();
            }

            using(var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Song>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    songs);
            }
        }
    }
}