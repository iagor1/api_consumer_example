using api_request.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_request
{
    public class Filters
    {
        public static void FilterByGenders(List<Music> musicslist)
        {
            var genderslist = musicslist.Select(genders => genders.Gender) .Distinct().ToList();
            foreach (var allgenders in genderslist)
            {
                Console.WriteLine("genders are : "+allgenders);
            }
        }
        public static void FilterByArtistNames(List<Music> musicslist)
        {
            var namesArtists = musicslist.OrderBy(names => names.Artist).Select(names => names.Artist).Distinct().ToList();
            //filter by name and select by 
            foreach (var artist in namesArtists)
            {
                Console.WriteLine("artist name :" + artist); 
            }

        }
        public static void FilterArtistByGender(List<Music> musicslist, string gender)
        {
            var ArtistsByGender = musicslist.Where(musics=> musics.Gender.Contains(gender)).Select(musics=> musics.Artist).Distinct().ToList();
 
            Console.WriteLine($"Exibindo artistas pelo gênero musical {gender}:");
            foreach (var artist in ArtistsByGender)
            {
                Console.WriteLine($"Artistas:{artist}"); 
            }

        }
        public static void FilterMusicsFromArtist(List<Music> musicslist, string artist_name)
        {
            var MusicsFromArtist = musicslist.Where(artists=> artists.Artist!.Equals(artist_name)).Select(artists=> artists.Song).Distinct().ToList();
 
            Console.WriteLine($"Exibindo musicas do artistas/banda {artist_name} ");
            foreach (var songs in MusicsFromArtist)
            {
                Console.WriteLine($"Musicas :{songs}"); 
            }

        }

    }
}
