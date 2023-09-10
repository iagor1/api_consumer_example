using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_request.Models
{
    internal class Music
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("duration_ms")]
        public int? Duration { get; set; }

        [JsonPropertyName("gender")]
        public string? Gender { get; set; }

        public void ShowMusicDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Artist);
            Console.WriteLine(Duration);
            Console.WriteLine(Gender);

        }
    }
}
