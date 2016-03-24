// Making abstract class Layout only for 1 method is useless. \\
namespace _01.Logger.Interfaces
{
    using System;

    public interface ILayout
    {
        string Format(DateTime date, ReportLevel reportLevel, string message);
    }
}