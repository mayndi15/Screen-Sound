using ScreenSound.Musics;
using ScreenSound.Musics.Service;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;

        MusicService.AllGenre(musics);
        MusicService.AllArtist(musics);
        MusicService.ArtistByGenre(musics, "rock");
        MusicService.MusicByArtist(musics, "Michel Teló");
        MusicService.MusicByKey(musics, "C#");

        var favorites = new Favorites("People");
        favorites.AddFavorites(musics[10]);
        favorites.AddFavorites(musics[100]);
        favorites.AddFavorites(musics[1000]);
        favorites.AddFavorites(musics[0]);

        favorites.ShowFavorites();  
        favorites.GenerateJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception message " + ex.Message);
    }
}
