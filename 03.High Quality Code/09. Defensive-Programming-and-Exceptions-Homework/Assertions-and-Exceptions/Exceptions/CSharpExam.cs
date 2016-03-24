using System;

public class CSharpExam : Exam
{
    private int score;

    private const int MinScore = 0;
    private const int MaxScore = 100;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get { return this.score; }
        private set
        {
            if (value < MinScore || value > MaxScore)
            {
                throw new ArgumentException("Score must be in range from 0 to 100.");
            }
            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        var examResult = new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
        return examResult;
    }
}
