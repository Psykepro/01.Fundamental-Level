using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;
    private const int MinProblemsCount = 0;
    private const int MaxProblemsCount = 10;
    private const int MinGrade = 2;
    private const int MaxGrade = 6;
    public SimpleMathExam(int problemsSolved)
    {
        

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get { return this.problemsSolved; }
        private set
        {
            if (value < MinProblemsCount || value > MaxProblemsCount)
            {
                throw new ArgumentException("Problems count have invalid value.");
            }
            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        switch (this.ProblemsSolved)
        {
            case 0: return new ExamResult(2, MinGrade, MaxGrade, "Bad result: nothing done.");
            case 1: return new ExamResult(4, MinGrade, MaxGrade, "Average result: something done.");
            case 2: return new ExamResult(6, MinGrade, MaxGrade, "Exellent result: everything done.");
            default: return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }            
    }
}
