using BlogProject.DAL;

namespace BlogProject.BAL;

public class CommentServis:ICommentServis
{

    private ICommentRepository _commentRepository;
    private ICommentServis _commentServisImplementation;

    public CommentServis(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }
    
    public IList<Comment> PostComment(Comment comment)
    {
        _commentRepository.Comments ??= new List<Comment>();
        _commentRepository.Comments.Add(comment);
        return _commentRepository.Comments;

    }
    
    public IList<Comment> GetComment()
    {
        return _commentRepository.Comments;
        
    }
    
    public IList<Comment> DeleteComment(int Did)
    {
        Comment comdel = _commentRepository.Comments.Where(x => x.Id == Did).Single<Comment>();
        _commentRepository.Comments.Remove(comdel);
        return _commentRepository.Comments;
    }

    public IList<Comment> PutComment(Comment modifi)
    {
        if (_commentRepository.Comments != null)
        {
            Comment comput = _commentRepository.Comments.Single(c => c.Id == modifi.Id);
            comput.Content = modifi.Content;
            comput.ModiefiedAt = modifi.ModiefiedAt;
        }

        return _commentRepository.Comments;
    }
}