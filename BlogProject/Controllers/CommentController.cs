using BlogProject.BAL;
using BlogProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController : Controller
{
    private ICommentServis _commentServis;
    
    public CommentController(ICommentServis commentServis)
    {
        _commentServis = commentServis;
    }
    
    [HttpGet("GetUsers")]
    public IEnumerable<Comment> GetComments()
    {
        return _commentServis.GetComment();
    }

    [HttpPost("AddUser")]
    public IEnumerable<Comment> PostComments([FromBody] Comment comment)
    {
        return _commentServis.PostComment(comment);
    }
    [HttpDelete("DeletePost")]
    public IEnumerable<Comment> DeleteComment(int id)
    {
        return _commentServis.DeleteComment(id);
    }

    [HttpPut("PutComment")]
    public IEnumerable<Comment> PutComment(Comment id)
    {
        return _commentServis.PutComment(id);
    }
}