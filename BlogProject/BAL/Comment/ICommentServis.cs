namespace BlogProject.BAL;

public interface ICommentServis
{
    IList<Comment> PostComment(Comment comment);
    IList<Comment> GetComment();
    IList<Comment> DeleteComment(int did);
    IList<Comment> PutComment(Comment modifi);
}