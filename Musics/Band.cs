using ScreenSound.Musics.Interface;

namespace ScreenSound.Musics
{
    public class Band : IEvaluation
    {
        private List<Album> albums = new List<Album>();
        private List<Evaluation> Grades = new List<Evaluation>();
        public string Name { get; }
        public double Average
        {
            get 
            { 
                if(Grades.Count == 0) return 0;
                else return Grades.Average(a => a.Grade);
            }
        }

        public Band(string name)
        {
            Name = name;
        }

        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        public void AddGrade(Evaluation grade)
        {
            Grades.Add(grade);
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
