using api_request.Models;
using System.Text.Json;

namespace api_request
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                HttpClient client = new HttpClient();
                
                string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                var deserializedMusic = JsonSerializer.Deserialize<List<Music>>(response)!;

                // Filters.FilterByGenders(deserializedMusic);
                // Filters.FilterByArtistNames(deserializedMusic);
                // string c = "rock";
                // Filters.FilterArtistByGender(deserializedMusic,c);
                // string name = "Green Day";
                // Filters.FilterMusicsFromArtist(deserializedMusic,name);
                
                var prefmusics = new FavMusics("pedro");
                prefmusics.AddFavMusics(deserializedMusic[2]);
                prefmusics.ShowFavMusics();
                prefmusics.GenerateJson();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}