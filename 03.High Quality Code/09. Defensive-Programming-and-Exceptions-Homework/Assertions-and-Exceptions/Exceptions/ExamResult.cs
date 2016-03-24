using System;


public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {                            
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get { return this.grade; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade cannot be negative.");
            }
            if (value < MinGrade || value > MaxGrade)
            {
                throw new ArgumentException("Invalid grade.");
            }
            this.grade = value;
        }
    }

    public int MinGrade
    {
        get { return this.minGrade; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Minimum grade cannot be negative.");
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get { return this.maxGrade; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Maximum grade cannot be negative.");
            }
            if (value <= minGrade)
            {
                throw new ArgumentOutOfRangeException("maxGrade","Maximum grade cannot be smaller or equal to the minimum grade.");
            }
            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get { return this.comments; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("comments","Comments cannot be null or empty or whitespaces.");
            }
            this.comments = value;
        }
    }
}
