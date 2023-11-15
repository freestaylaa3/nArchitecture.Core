using Core.Persistence.Paging;

namespace Core.Application.Responses;

public class GetListResponse<T> : BasePageableModel
{
    public IList<T> Items
    {
        get => _items ??= new List<T>();
        set => _items = value;
    }
    public IList<object> Extras { get; set; } = new List<object>();

    private IList<T>? _items;
}
