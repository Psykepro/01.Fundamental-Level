using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{

    private string firstName;
    private string lastName;
    private List<Exam> exams; 

    public Student(string firstName, string lastName, List<Exam> exams)
    {
        
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("firstName","First name cannot be null, empty or whitespaces.");
            }
            this.firstName = value;
        } 
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("lastName", "Last name cannot be null, empty or whitespaces.");
            }
            this.lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get
        {
            return this.exams;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("exams","Exams cannot be null.");
            }
            if (value.Count == 0)
            {
                throw new ArgumentException("Exams count must be positive.");
            }
            this.exams = (List<Exam>) value;
        }
    }

    public IList<ExamResult> CheckExams()
    {      
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
