namespace ScreenSound.Podcasts
{
    public class Episode
    {
        private List<string> Guests = new List<string>();
        public string Order { get; }
        public string Title { get; }
        public string Duration { get; }
        public string Resume => $"{Order}. {Title}. ({Duration} min) - {string.Join(",", Guests)}";

        public Episode(string order, string title, string duration)
        {
            Order = order;
            Title = title;
            Duration = duration;
        }

        public void AddGuest(string guest)
        {
            Guests.Add(guest);
        }
    }
}
