namespace Web.Models;

public class PeriodEntry
{
    public PeriodEntry(string title, string subtitle, DateOnly startDate, DateOnly? endDate = null, IEnumerable<string>? details = null)
    {
        Title = title;
        Subtitle = subtitle;
        StartDate = startDate;
        EndDate = endDate;
        Details = details ?? Enumerable.Empty<string>();
    }

    public string Title { get; } = string.Empty;
    public string Subtitle { get; } = string.Empty;
    public IEnumerable<string> Details { get; } = Enumerable.Empty<string>();
    public DateOnly StartDate { get; }
    public DateOnly? EndDate { get; }

    public string Period => $"{StartDate.Year} - {EndDate?.Year}";
}
