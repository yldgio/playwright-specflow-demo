namespace BlazorApp;
public class TodoItem
{
    public Guid Id { get; } = Guid.NewGuid();
    public string? Title { get; set; }
    public bool IsDone { get; private set; } = false;
    public void Complete()
    {
        IsDone = true;
    }
}
public class TodoItems
{
    private static readonly List<TodoItem> _todoItems = new();
    public void Add(TodoItem item)
    {
        _todoItems.Add(item);
    }
    public void Remove(TodoItem item)
    {
        //_todoItems.Remove(item);
    }
    public void MarkAsDone(TodoItem item)
    {
        item?.Complete();
    }
    public void MarkAsDone(Guid id)
    {
        MarkAsDone(_todoItems.FirstOrDefault(item => item.Id == id));
    }
    public int Count => _todoItems.Count;
}