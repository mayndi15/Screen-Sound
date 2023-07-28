namespace ScreenSound.Musics.Service
{
    public class MusicService
    {
        public static void AllGenre(List<Music> musics)
        {
            var filterGenres = musics.Select(x => x.Genre).Distinct().ToList();

            foreach (var genre in filterGenres)
            {
                Console.WriteLine($"Genre: {genre}");
            }
        }

        public static void AllArtist(List<Music> musics)
        {
            var filterArtists = musics.OrderBy(x => x.Artist).Select(x => x.Artist).Distinct().ToList();

            foreach (var artist in filterArtists)
            {
                Console.WriteLine($"Artist: {artist}");
            }
        }

        public static void ArtistByGenre(List<Music> musics, string genre)
        {
            var filterArtists = musics.Where(x => x.Genre!.Contains(genre)).Select(x => x.Artist).Distinct().ToList();

            foreach (var artist in filterArtists)
            {
                Console.WriteLine($"Artist: {artist}");
            }
        }

        public static void MusicByArtist(List<Music> musics, string artist)
        {
            var filterMusics = musics.Where(x => x.Artist!.Contains(artist)).Select(x => x.Name).Distinct().ToList();

            foreach (var music in filterMusics)
            {
                Console.WriteLine($"Music: {music}");
            }
        }

        public static void MusicByKey(List<Music> musics, string key)
        {
            var filterMusics = musics.Where(x => x.Shade.Equals(key)).Select(x => x.Name).ToList();

            foreach (var music in filterMusics)
            {
                Console.WriteLine($"Music: {music}");
            }
        }
    }
}
