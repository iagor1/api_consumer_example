using System.Text.Json;
using System.Text.Json.Serialization;

namespace api_request.Models
{
    public class FavMusics 
    {
        public string? Name {get;set;} // prop nome para podermos manipular depois
        public List<Music> MusicsList;
    
    public FavMusics(string name)
    {
        Name=name;
        MusicsList = new List<Music>();
        //qd usarmos essa classe (instanciar) vai ser criado uma lista do tipo music
    }
    public void AddFavMusics(Music music)
    {
        MusicsList.Add(music);
    }
    
    public void ShowFavMusics()
    {
        Console.WriteLine($"Favorites musics {Name}");
        foreach (var fav_musics in MusicsList)
        {
            Console.WriteLine($"Favorites musics {fav_musics.Song}");
        
        }
    }
    public void GenerateJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Name,
            musics = MusicsList
        });//função anônima
        //string json = JsonSerializer.Serialize(MusicsList);
        string file_name = $"fav_musics-{Name}.json";
        File.WriteAllText(file_name,json);
        Console.WriteLine("arquivo json criado");
    }
    
    }


}