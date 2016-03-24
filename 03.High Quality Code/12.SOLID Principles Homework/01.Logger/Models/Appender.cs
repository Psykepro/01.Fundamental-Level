namespace _01.Logger.Models
{
    using System;

    using _01.Logger.Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ILayout Layout { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void AppendFormatedMessage(DateTime date, ReportLevel reportLevel, string message);
    }
}
