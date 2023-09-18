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
            var genderslist = musicslist.Select(genders => genders.Gender).Distinct().ToList();
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
                Console.WriteLine("artist name :" + artist); //desafio 2 
            }

        }


    }
}
