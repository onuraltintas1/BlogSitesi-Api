using BlogProject.DAL;

namespace BlogProject.BAL;

public class ArticleServis: IArticleServis
{
    
    private IArticleRepository _articleRepository;

    public ArticleServis(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }
    public IList<Article> PostPost(Article article)
    {
        _articleRepository.Articles ??= new List<Article>();
        _articleRepository.Articles.Add(article);
        return _articleRepository.Articles;
    }

    public IList<Article> GetPost()
    {
        return _articleRepository.Articles;
    }

    public IList<Article> DeletePost(int Did)
    {
        Article art = _articleRepository.Articles.Where(x => x.Id == Did).Single<Article>();
        _articleRepository.Articles.Remove(art);
        return _articleRepository.Articles;
    }

    public IList<Article> PutPost(Article modi)
    {
        Article arts = _articleRepository.Articles.Where(c => c.Id == modi.Id).Single<Article>();
        arts.Content = modi.Content;
        arts.Title = modi.Title;
        arts.ModifiedAt = modi.ModifiedAt;
        return _articleRepository.Articles;
    }
}