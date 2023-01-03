namespace BlogProject.DAL;

public interface ICommentRepository
{
    public IList<Comment>? Comments { get; set; }
}