namespace _01.Logger
{
    using System;

    using _01.Logger.Models;
    using _01.Logger.Models.Layouts;

    public class LoggerTest
    {
        public static void Main()
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            var logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warn - missing files.");

            consoleAppender.ReportLevel = ReportLevel.Error;

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("After setting console appender's report level to Error :");
            Console.ResetColor();
            Console.WriteLine();

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warn - missing files.");

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("After changing console appender's layout to xml :");
            Console.ResetColor();
            Console.WriteLine();

            var xmlLayout = new XmlLayout();
            consoleAppender.Layout = xmlLayout;
            consoleAppender.ReportLevel = ReportLevel.Info;

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warn - missing files.");
        }
    }
}
