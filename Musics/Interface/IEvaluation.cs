namespace ScreenSound.Musics.Interface
{
    public interface IEvaluation
    {
        public double Average { get; }

        void AddGrade(Evaluation grade);
    }
}
