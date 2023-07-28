using ScreenSound.Musics.Interface;

namespace ScreenSound.Musics
{
    public class Album : IEvaluation
    {
        private List<Music> musics = new List<Music>();
        private List<Evaluation> Grades = new List<Evaluation>();
        public string Name { get; }
        public int TotalDuration => musics.Sum(m => m.Duration);
        public double Average
        {
            get
            {
                if (Grades.Count == 0) return 0;
                else return Grades.Average(a => a.Grade);
            }
        }

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

        public void AddGrade(Evaluation grade)
        {
            Grades.Add(grade);
        }
    }
}
