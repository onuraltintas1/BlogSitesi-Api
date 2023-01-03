namespace BlogProject;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTimeOffset ModiefiedAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}