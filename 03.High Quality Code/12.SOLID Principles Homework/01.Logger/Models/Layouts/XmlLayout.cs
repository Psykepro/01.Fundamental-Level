namespace _01.Logger.Models.Layouts
{
    using System;
    using System.Text;

    using _01.Logger.Interfaces;

    public class XmlLayout : ILayout
    {
        public string Format(DateTime date, ReportLevel reportLevel, string message)
        {
            StringBuilder formatedData=new StringBuilder();

            formatedData.AppendLine("<log>");
            formatedData.AppendLine(string.Format("\t<date>{0}</date>", date));
            formatedData.AppendLine(string.Format("\t<level>{0}</level>", reportLevel));
            formatedData.AppendLine(string.Format("\t<message>{0}</message>", message));
            formatedData.AppendLine("</log>");

            return formatedData.ToString();
        }
    }
}
