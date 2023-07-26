namespace ScreenSound.Podcast.Podcast
{
    public class Episode
    {
        private List<string> guests = new List<string>();
        public string Order { get; }
        public string Title { get; }
        public string Duration { get; }
        public string Resume => $"{Order}. {Title}. ({Duration} min) - {string.Join(",", guests)}";

        public Episode(string order, string title, string duration)
        {
            Order = order;
            Title = title;
            Duration = duration;
        }

        public void AddGuest(string guest)
        {
            guests.Add(guest);
        }
    }
}
