namespace ScreenSound.Podcast.Podcast
{
    public class Podcast
    {
        private List<Episode> episodes = new List<Episode>();
        public string Name { get; }
        public string Host { get; }
        public int TotalEpisodes => episodes.Count;

        public Podcast(string name, string host)
        {
            Name = name;
            Host = host;
        }

        public void AddEpisode(Episode episode)
        {
            episodes.Add(episode);
        }

        public void ShowPodcast()
        {
            Console.WriteLine($"Podcast: {Name} hosted by {Host}");

            foreach (var episode in episodes.OrderBy(e => e.Order))
            {
                Console.WriteLine($"This podcast has {TotalEpisodes} episodes");
            }
        }
    }
}
