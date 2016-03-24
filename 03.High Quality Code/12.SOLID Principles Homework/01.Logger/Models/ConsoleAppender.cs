namespace _01.Logger.Models
{
    using System;

    using _01.Logger.Interfaces;

    public class ConsoleAppender : Appender
    {
         public ConsoleAppender(ILayout layout) : base(layout)
         {
         }

         public override void AppendFormatedMessage(DateTime date, ReportLevel reportLevel, string message)
         {
             if (reportLevel >= this.ReportLevel)
             {
                 string formatedMessageByLayout = this.Layout.Format(date, reportLevel, message);

                 Console.Write(formatedMessageByLayout);
             }
         }
    }
}
