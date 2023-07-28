using System.Text.Json;

namespace ScreenSound.Musics
{
    public class Favorites
    {
        public string? Name { get; set; }
        public List<Music> Musics;

        public Favorites(string name)
        {
            Name = name;
            Musics = new List<Music>();
        }

        public void AddFavorites(Music music)
        {
            Musics.Add(music);
        }

        public void ShowFavorites()
        {
            foreach (var music in Musics)
            {
                Console.WriteLine($"Music: {music.Name}");
            }
        }

        public void GenerateJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                name = Name,
                musics = Musics
            });

            string file = $"Favorites-{Name}.json";

            File.WriteAllText(file, json);

            Console.WriteLine($"Success - {Path.GetFullPath(file)}");
        }
    }
}
