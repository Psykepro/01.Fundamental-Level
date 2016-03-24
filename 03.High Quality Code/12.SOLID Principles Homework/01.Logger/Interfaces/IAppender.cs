namespace _01.Logger.Interfaces
{
    using System;

    public interface IAppender
    {
        ILayout Layout { get; set; }

        ReportLevel ReportLevel { get; set; }

        void AppendFormatedMessage(DateTime date,ReportLevel reportLevel,string message);
    }
}
