using MongoDB.Driver;

namespace Core.Application.Requests;

public class PageRequest
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public bool? isFirstLoad { get; set; }
    public string? OrderBy { get; set; }
    public string? SortDirection { get; set; }
    public string? SearchTerms { get; set; }
}
