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
                
                foreach(Music lista in deserializedMusic)
                {
                    //desafio 1 
                    lista.ShowMusicDetails();
                    
                }
                var namesArtists = deserializedMusic.OrderBy(names => names.Artist).ToList();
                foreach(Music artist in namesArtists)
                {
                    Console.WriteLine("artist name :"+artist.Artist); //desafio 2 
                }
                var genderMusics = deserializedMusic.OrderBy(gender_names => gender_names.Gender).ToList();
                foreach (Music genders in genderMusics)
                {
                    Console.WriteLine("nome do artista :" + genders.Artist); //desafio 3
                    Console.WriteLine("Gênero :" + genders.Gender);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}