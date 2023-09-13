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
                var deserializedMusic = JsonSerializer.Deserialize<List<Music>>(response);
                deserializedMusic[0].ShowMusicDetails();
                foreach(Music lista in deserializedMusic)
                {
                    var musics = lista;
                    Console.WriteLine(musics.Gender);
                    Console.WriteLine(musics.ShowMusicDetails());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}