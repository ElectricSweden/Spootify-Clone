using System.Text.Json;

namespace Spootify.Models
{
    public class Song
    {
        public string Name { get; set;  }
        public string Songwriter { get; set;  }
        public int Length { get; set; }

        public int[] Ratings { get; set; }

        //public Song()
        //{
        //    Name = "undefined";
        //    Songwriter = "undefined";
        //    Length = 0;
        //}

        //public Song(string name, string songwriter, int length)
        //{
        //    Name = name;
        //    Songwriter = songwriter;
        //    Length = length;
        //}

        public override string ToString() => JsonSerializer.Serialize<Song>(this);
    }
}
