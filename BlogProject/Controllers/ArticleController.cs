using BlogProject.BAL;
using BlogProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers;

[ApiController]
[Route("[controller]")]
public class ArticleController : Controller
{
    private IArticleServis _articleServis;
    
    public ArticleController(IArticleServis article)
    {
        _articleServis = article;
    }

    [HttpPost( "PostPost")]
    public IEnumerable<Article> PostPost([FromBody]Article article)
    {
        return _articleServis.PostPost(article);
    }

    [HttpGet("GetPost")]
    public IEnumerable<Article> GetPost()
    {
        return _articleServis.GetPost();
    }

    [HttpDelete("DeletePost")]
    public IEnumerable<Article> DeletePost(int id)
    {
        return _articleServis.DeletePost(id);
    }

    [HttpPut("PutPost")]
    public IEnumerable<Article> PutPost(Article id)
    {
        return _articleServis.PutPost(id);
    }
}