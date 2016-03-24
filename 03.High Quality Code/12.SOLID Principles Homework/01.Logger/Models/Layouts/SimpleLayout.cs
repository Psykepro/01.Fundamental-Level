namespace _01.Logger.Models.Layouts
{
    using System;

    using _01.Logger.Interfaces;

    public class SimpleLayout : ILayout
    {
        private const string MessageFormat = "{0} - {1} - {2}";

        public string Format(DateTime date, ReportLevel reportLevel, string message)
        {
            string returnFormat = string.Format(MessageFormat + Environment.NewLine, date, reportLevel, message);

            return returnFormat;
        }
    }
}
