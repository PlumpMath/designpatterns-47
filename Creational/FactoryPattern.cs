using System;
using System.Collections.Generic;

public static class ReportFactory
{
    private static readonly Dictionary<string, Report> _reports;

    static ReportFactory()
    {
        _reports = new Dictionary<string, Report>();
        _reports.Add("PDF", new PDFReport());
        _reports.Add("HTML", new HTMLReport());
    }
    public static Report CreateReport(string reportType)
    {
        Report repo;
        _reports.TryGetValue(reportType, out repo);
        return repo;
    }
}

public abstract class Report
{
    public virtual void DisplayReport()
    {
        throw new NotImplementedException();
    }
}

public class PDFReport : Report
{
    public override void DisplayReport()
    {
        Console.WriteLine("Displaying PDF Report");

    }
}

public class HTMLReport : Report
{
    public override void DisplayReport()
    {
        Console.WriteLine("Displaying HTML Report");
    }
}