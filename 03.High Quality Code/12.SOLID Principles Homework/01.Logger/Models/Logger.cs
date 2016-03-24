namespace _01.Logger.Models
{
    using System;

    using _01.Logger.Interfaces;

    public class Logger : ILogger
    {

        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public IAppender Appender { get; set; }

        public void Info(string message)
        {
            this.LogMessage(ReportLevel.Info, message);
        }

        public void Warn(string message)
        {
            this.LogMessage(ReportLevel.Warning, message);
        }

        public void Error(string message)
        {
            this.LogMessage(ReportLevel.Error, message);
        }

        public void Critical(string message)
        {
            this.LogMessage(ReportLevel.Critical, message);
        }

        public void Fatal(string message)
        {
            this.LogMessage(ReportLevel.Fatal, message);
        }

        private void LogMessage(ReportLevel reportLevel, string message)
        {
            DateTime dateTime = DateTime.Now;

            this.Appender.AppendFormatedMessage(dateTime,reportLevel,message);
        }
    }
}
