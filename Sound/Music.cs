namespace ScreenSound.Sound
{
    public class Music
    {
        public string Name { get; }
        public Band Band { get; }
        public int Duration { get; set; }
        private bool Available { get; set; }
        public string Description => $"The song {Name} belongs to the band {Band}";

        public Music(Band band, string name)
        {
            Band = band;
            Name = name;
        }

        public void Datasheet()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Singer: {Band.Name}");
            Console.WriteLine($"Duration: {Duration}");

            if (Available)
            {
                Console.WriteLine($"Available in plan");
            }
            else
            {
                Console.WriteLine($"Buy the premium plan");
            }
        }
    }
}
