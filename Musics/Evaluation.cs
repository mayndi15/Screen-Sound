namespace ScreenSound.Musics
{
    public class Evaluation
    {
        public int Grade { get; }

        public Evaluation(int grade) { 
            Grade = grade;
        }

        public Evaluation Parse(string text) { 
            int grade = int.Parse(text);
            return new Evaluation(grade);
        }
    }
}
