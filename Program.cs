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
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}