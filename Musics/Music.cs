using System.Text.Json.Serialization;
using ScreenSound.Musics.Interface;

namespace ScreenSound.Musics
{
    public class Music : IEvaluation
    {
        private List<Evaluation> Grades = new List<Evaluation>();

        private string[] shades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("song")]
        public string? Name { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duration { get; set; }

        [JsonPropertyName("genre")]
        public string? Genre { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Shade
        {
            get
            {
                return shades[Key];
            }
        }

        public Band Band { get; }

        private bool Available { get; set; }

        public string Description => $"The song {Name} belongs to the band {Band}";

        public double Average
        {
            get
            {
                if (Grades.Count == 0) return 0;
                else return Grades.Average(a => a.Grade);
            }
        }

        public Music(Band band, string name)
        {
            Band = band;
            Name = name;
        }

        public void ShowJson()
        {
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Duration: {Duration / 1000}");
            Console.WriteLine($"Genre: {Genre}");
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

        public void AddGrade(Evaluation grade)
        {
            Grades.Add(grade);
        }
    }
}
