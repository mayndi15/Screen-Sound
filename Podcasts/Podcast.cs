namespace ScreenSound.Podcasts
{
    public class Podcast
    {
        private List<Episode> Episodes = new List<Episode>();
        public string Name { get; }
        public string Host { get; }
        public int TotalEpisodes => Episodes.Count;

        public Podcast(string name, string host)
        {
            Name = name;
            Host = host;
        }

        public void AddEpisode(Episode episode)
        {
            Episodes.Add(episode);
        }

        public void ShowPodcast()
        {
            Console.WriteLine($"Podcast: {Name} hosted by {Host}");

            foreach (var episode in Episodes.OrderBy(e => e.Order))
            {
                Console.WriteLine($"This podcast has {TotalEpisodes} episodes");
            }
        }
    }
}
