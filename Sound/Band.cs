namespace ScreenSound.Sound
{
    public class Band
    {
        private List<Album> albums = new List<Album>();
        public string Name { get; }

        public Band(string name)
        {
            Name = name;
        }

        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ShowBand()
        {
            Console.WriteLine($"Band: {Name}");

            foreach (var album in albums)
            {
                Console.WriteLine($"Album: {album.Name} ({album.TotalDuration})");
            }
        }
    }
}
