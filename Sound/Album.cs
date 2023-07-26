namespace ScreenSound.Sound
{
    public class Album
    {
        private List<Music> musics = new List<Music>();
        public string Name { get; }
        public int TotalDuration => musics.Sum(m => m.Duration);

        public Album(string name)
        {
            Name = name;
        }

        public void AddMusic(Music music)
        {
            musics.Add(music);
        }

        public void ShowAlbum()
        {
            Console.WriteLine($"Album: {Name}");
            Console.WriteLine($"Total duration: {TotalDuration}");

            foreach (var music in musics)
            {
                Console.WriteLine($"Music: {music.Name}");
            }
        }
    }
}
